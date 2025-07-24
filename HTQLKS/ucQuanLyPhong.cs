using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HTQLKS
{
    public partial class ucQuanLyPhong : UserControl
    {
        private QLKSDataSet.PHONGDataTable phongTable;
        private QLKSDataSet.LOAIPHONGDataTable loaiPhongTable;
        private QLKSDataSet.HINHANH_PHONGDataTable hinhAnhPhongTable;
        private QLKSDataSetTableAdapters.PHONGTableAdapter phongAdapter;
        private QLKSDataSetTableAdapters.LOAIPHONGTableAdapter loaiPhongAdapter;
        private QLKSDataSetTableAdapters.HINHANH_PHONGTableAdapter hinhAnhPhongAdapter;

        public ucQuanLyPhong()
        {
            InitializeComponent();
        }

        private void ucQuanLyPhong_Load(object sender, EventArgs e)
        {
            InitializeAdapters();
            LoadData();
            UpdateStats();
            SetupFilters();
            DisplayRoomsAsGrid(); // Default view
        }

        private void InitializeAdapters()
        {
            string connectionString = Properties.Settings.Default.QLKSConnectionString;
            SqlConnection connection = new SqlConnection(connectionString);

            phongAdapter = new QLKSDataSetTableAdapters.PHONGTableAdapter { Connection = connection };
            loaiPhongAdapter = new QLKSDataSetTableAdapters.LOAIPHONGTableAdapter { Connection = connection };
            hinhAnhPhongAdapter = new QLKSDataSetTableAdapters.HINHANH_PHONGTableAdapter { Connection = connection };
        }

        private void LoadData()
        {
            phongTable = qLKSDataSet.PHONG;
            loaiPhongTable = qLKSDataSet.LOAIPHONG;
            hinhAnhPhongTable = qLKSDataSet.HINHANH_PHONG;

            try
            {
                phongAdapter.Fill(phongTable);
                loaiPhongAdapter.Fill(loaiPhongTable);
                hinhAnhPhongAdapter.Fill(hinhAnhPhongTable);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load data from the database. Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void UpdateStats()
        {
            lblTotalRooms.Text = phongTable.Count.ToString();
            lblAvailableRooms.Text = phongTable.AsEnumerable().Count(row => row.Field<string>("TrangThai") == "Trống").ToString();
            lblOccupiedRooms.Text = phongTable.AsEnumerable().Count(row => row.Field<string>("TrangThai") == "Đang sử dụng").ToString();
            lblMaintenance.Text = phongTable.AsEnumerable().Count(row => row.Field<string>("TrangThai") == "Bảo trì").ToString();
            lblCleaning.Text = phongTable.AsEnumerable().Count(row => row.Field<string>("TrangThai") == "Đang dọn").ToString();
        }

        private void SetupFilters()
        {
            // Floor Filter
            var floors = phongTable.AsEnumerable().Select(row => row.Field<int>("Tang")).Distinct().OrderBy(f => f).ToList();
            cmbFloor.Items.Add("Tất cả tầng");
            foreach (var floor in floors)
            {
                cmbFloor.Items.Add($"Tầng {floor}");
            }
            cmbFloor.SelectedIndex = 0;

            // Type Filter
            var types = loaiPhongTable.AsEnumerable().Select(row => row.Field<string>("TenLoaiPhong")).Distinct().ToList();
            cmbType.Items.Add("Tất cả loại");
            cmbType.Items.AddRange(types.ToArray());
            cmbType.SelectedIndex = 0;

            // Status Filter
            var statuses = phongTable.AsEnumerable().Select(row => row.Field<string>("TrangThai")).Distinct().ToList();
            cmbStatus.Items.Add("Tất cả trạng thái");
            cmbStatus.Items.AddRange(statuses.ToArray());
            cmbStatus.SelectedIndex = 0;

            // Event Handlers
            txtSearch.TextChanged += (s, e) => FilterAndDisplayRooms();
            cmbFloor.SelectedIndexChanged += (s, e) => FilterAndDisplayRooms();
            cmbType.SelectedIndexChanged += (s, e) => FilterAndDisplayRooms();
            cmbStatus.SelectedIndexChanged += (s, e) => FilterAndDisplayRooms();
            btnAddRoom.Click += BtnAddRoom_Click;
            btnViewGrid.Click += (s, e) => {
                DisplayRoomsAsGrid();
                dataGridViewRooms.Visible = false;
                flowLayoutPanelRooms.Visible = true;
            };
            btnViewList.Click += (s, e) => {
                DisplayRoomsAsList();
                flowLayoutPanelRooms.Visible = false;
                dataGridViewRooms.Visible = true;
            };
        }

        private void FilterAndDisplayRooms()
        {
            var filteredData = GetFilteredRoomData();
            if (dataGridViewRooms.Visible)
            {
                DisplayRoomsAsList(filteredData);
            }
            else
            {
                DisplayRoomsAsGrid(filteredData);
            }
        }

        private EnumerableRowCollection<QLKSDataSet.PHONGRow> GetFilteredRoomData()
        {
            var query = phongTable.AsEnumerable();

            if (!string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                string searchText = txtSearch.Text.ToLower();
                query = query.Where(r => r.Field<string>("SoPhong").ToLower().Contains(searchText));
            }

            if (cmbFloor.SelectedIndex > 0)
            {
                int selectedFloor = int.Parse(cmbFloor.SelectedItem.ToString().Replace("Tầng ", ""));
                query = query.Where(r => r.Field<int>("Tang") == selectedFloor);
            }
            
            if (cmbType.SelectedIndex > 0)
            {
                string selectedType = cmbType.SelectedItem.ToString();
                var maLoaiPhongList = loaiPhongTable.AsEnumerable()
                                      .Where(lp => lp.Field<string>("TenLoaiPhong") == selectedType)
                                      .Select(lp => lp.Field<string>("MaLoaiPhong"));
                query = query.Where(r => maLoaiPhongList.Contains(r.Field<string>("MaLoaiPhong")));
            }

            if (cmbStatus.SelectedIndex > 0)
            {
                string selectedStatus = cmbStatus.SelectedItem.ToString();
                query = query.Where(r => r.Field<string>("TrangThai") == selectedStatus);
            }

            return query;
        }


        private void DisplayRoomsAsGrid(EnumerableRowCollection<QLKSDataSet.PHONGRow> rooms = null)
        {
            flowLayoutPanelRooms.Controls.Clear();
            var roomsToDisplay = rooms ?? GetFilteredRoomData();

            foreach (var roomRow in roomsToDisplay)
            {
                var loaiPhongRow = loaiPhongTable.FindByMaLoaiPhong(roomRow.MaLoaiPhong);
                Panel roomCard = CreateRoomCard(roomRow, loaiPhongRow);
                flowLayoutPanelRooms.Controls.Add(roomCard);
            }
        }
        
        private void DisplayRoomsAsList(EnumerableRowCollection<QLKSDataSet.PHONGRow> rooms = null)
        {
            var roomsToDisplay = rooms ?? GetFilteredRoomData();

            var listData = from phong in roomsToDisplay
                           join loaiPhong in loaiPhongTable.AsEnumerable()
                           on phong.MaLoaiPhong equals loaiPhong.MaLoaiPhong
                           select new
                           {
                               MaPhong = phong.MaPhong,
                               SoPhong = phong.SoPhong,
                               Tang = phong.Tang,
                               LoaiPhong = loaiPhong.TenLoaiPhong,
                               Gia = loaiPhong.GiaPhong,
                               TrangThai = phong.TrangThai
                           };

            dataGridViewRooms.DataSource = listData.ToList();
            dataGridViewRooms.Columns["MaPhong"].HeaderText = "Mã Phòng";
            dataGridViewRooms.Columns["SoPhong"].HeaderText = "Số Phòng";
            dataGridViewRooms.Columns["Tang"].HeaderText = "Tầng";
            dataGridViewRooms.Columns["LoaiPhong"].HeaderText = "Loại Phòng";
            dataGridViewRooms.Columns["Gia"].HeaderText = "Giá (VND)";
            dataGridViewRooms.Columns["Gia"].DefaultCellStyle.Format = "N0";
            dataGridViewRooms.Columns["TrangThai"].HeaderText = "Trạng Thái";
        }


        private void MakeControlCircular(Control control)
        {
            if (control.Width != control.Height)
                control.Height = control.Width;

            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(0, 0, control.Width, control.Height);
            control.Region = new Region(path);
        }

        private Panel CreateRoomCard(QLKSDataSet.PHONGRow room, QLKSDataSet.LOAIPHONGRow roomType)
        {
            // Main card panel
            Panel card = new Panel
            {
                Width = 300,
                Height = 400, // Increased height to accommodate more amenities
                Margin = new Padding(10),
                BackColor = Color.FromArgb(71, 85, 105),
                Tag = room.MaPhong
            };

            // PictureBox for room image
            PictureBox picRoomImage = new PictureBox
            {
                Location = new Point(0, 0),
                Size = new Size(300, 180),
                SizeMode = PictureBoxSizeMode.StretchImage,
                BackColor = Color.FromArgb(42, 50, 66)
            };
            var hinhAnhRow = hinhAnhPhongTable.FirstOrDefault(h => h.MaLoaiPhong == roomType.MaLoaiPhong);
            if (hinhAnhRow != null)
            {
                // Correctly build the image path from the executable's directory
                string relativePath = hinhAnhRow.LinkHinh.TrimStart('/');
                string imagePath = Path.Combine(Application.StartupPath, relativePath.Replace('/', Path.DirectorySeparatorChar));

                if (File.Exists(imagePath))
                {
                    picRoomImage.Image = Image.FromFile(imagePath);
                }
            }
            card.Controls.Add(picRoomImage);

            // Status Badge
            Label lblStatusBadge = new Label
            {
                Text = room.TrangThai,
                Font = new Font("Poppins", 8, FontStyle.Bold),
                ForeColor = Color.White,
                BackColor = GetStatusColor(room.TrangThai),
                Location = new Point(card.Width - 85, 10),
                Padding = new Padding(8, 4, 8, 4),
                AutoSize = true
            };
            card.Controls.Add(lblStatusBadge);
            lblStatusBadge.BringToFront();

            int detailsYStart = 180;

            // Room Info
            card.Controls.Add(new Label { Text = $"Phòng {room.SoPhong}", Font = new Font("Poppins", 16, FontStyle.Bold), ForeColor = Color.White, AutoSize = true, Location = new Point(15, detailsYStart + 10) });
            card.Controls.Add(new Label { Text = $"{roomType?.GiaPhong:N0}đ /đêm", Font = new Font("Poppins", 12, FontStyle.Bold), ForeColor = Color.White, AutoSize = true, Location = new Point(170, detailsYStart + 14), RightToLeft = RightToLeft.Yes });
            card.Controls.Add(new Label { Text = $"Tầng {room.Tang} • {roomType?.TenLoaiPhong ?? "N/A"}", Font = new Font("Poppins", 9), ForeColor = Color.LightGray, AutoSize = true, Location = new Point(15, detailsYStart + 45) });
            card.Controls.Add(new Label { Text = roomType.IsMoTaNull() ? "" : roomType.MoTa, Font = new Font("Poppins", 8), ForeColor = Color.LightGray, AutoSize = true, Location = new Point(15, detailsYStart + 70) });

            // Amenities FlowPanel - Increased height and adjusted location
            FlowLayoutPanel flowAmenities = new FlowLayoutPanel
            {
                Location = new Point(15, detailsYStart + 95),
                Size = new Size(270, 60), // Increased height for wrapping
                BackColor = Color.Transparent
            };
            if (roomType != null && !roomType.IsTienNghiNull())
            {
                var amenities = roomType.TienNghi.Split(',').Select(s => s.Trim());
                foreach (var amenity in amenities)
                {
                    Label lblAmenity = new Label { Text = amenity, Font = new Font("Poppins", 8), BackColor = Color.FromArgb(90, 103, 122), ForeColor = Color.White, Padding = new Padding(8, 4, 8, 4), Margin = new Padding(3), AutoSize = true };
                    flowAmenities.Controls.Add(lblAmenity);
                }
            }
            card.Controls.Add(flowAmenities);

            // Circular Buttons - Adjusted location
            Label btnEdit = new Label { Text = "✎", Font = new Font("Segoe UI Symbol", 12, FontStyle.Bold), BackColor = Color.FromArgb(49, 130, 206), ForeColor = Color.White, Size = new Size(30, 30), Location = new Point(220, detailsYStart + 165), TextAlign = ContentAlignment.MiddleCenter, Cursor = Cursors.Hand };
            Label btnDelete = new Label { Text = "🗑", Font = new Font("Segoe UI Symbol", 12, FontStyle.Bold), BackColor = Color.FromArgb(224, 79, 95), ForeColor = Color.White, Size = new Size(30, 30), Location = new Point(255, detailsYStart + 165), TextAlign = ContentAlignment.MiddleCenter, Cursor = Cursors.Hand };
            MakeControlCircular(btnEdit);
            MakeControlCircular(btnDelete);
            card.Controls.Add(btnEdit);
            card.Controls.Add(btnDelete);

            // Attach event handlers
            btnEdit.Click += (s, e) => { EditRoom(card.Tag.ToString()); };
            btnDelete.Click += (s, e) => { DeleteRoom(card.Tag.ToString()); };

            return card;
        }

        private Color GetStatusColor(string status)
        {
            switch (status)
            {
                case "Trống":
                    return Color.FromArgb(56, 161, 105);
                case "Đang sử dụng":
                    return Color.FromArgb(224, 79, 95);
                case "Đang dọn":
                    return Color.FromArgb(235, 162, 81);
                case "Bảo trì":
                    return Color.FromArgb(113, 128, 150);
                default:
                    return Color.Gray;
            }
        }
        
        private void BtnAddRoom_Click(object sender, EventArgs e)
        {
            QLKSDataSet.PHONGRow newRow = phongTable.NewPHONGRow();
            
            using (FormRoomDetails frm = new FormRoomDetails(newRow, loaiPhongTable, hinhAnhPhongTable, hinhAnhPhongAdapter))
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    if (frm.LoaiPhongRow.RowState == DataRowState.Detached)
                    {
                        loaiPhongTable.AddLOAIPHONGRow(frm.LoaiPhongRow);
                    }
                    phongTable.AddPHONGRow(newRow);

                    try
                    {
                        loaiPhongAdapter.Update(qLKSDataSet.LOAIPHONG);
                        phongAdapter.Update(qLKSDataSet.PHONG);
                        hinhAnhPhongAdapter.Update(qLKSDataSet.HINHANH_PHONG);
                        qLKSDataSet.AcceptChanges();
                        FilterAndDisplayRooms();
                        UpdateStats();
                        MessageBox.Show("Thêm phòng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi khi thêm phòng: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        qLKSDataSet.RejectChanges();
                    }
                }
            }
        }

        private void EditRoom(string maPhong)
        {
            QLKSDataSet.PHONGRow row = phongTable.FindByMaPhong(maPhong);
            if (row != null)
            {
                using (FormRoomDetails frm = new FormRoomDetails(row, loaiPhongTable, hinhAnhPhongTable, hinhAnhPhongAdapter))
                {
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        try
                        {
                            loaiPhongAdapter.Update(qLKSDataSet.LOAIPHONG);
                            phongAdapter.Update(qLKSDataSet.PHONG);
                            hinhAnhPhongAdapter.Update(qLKSDataSet.HINHANH_PHONG);
                            qLKSDataSet.AcceptChanges();
                            FilterAndDisplayRooms();
                            UpdateStats();
                            MessageBox.Show("Cập nhật phòng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                             MessageBox.Show("Lỗi khi cập nhật phòng: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                             qLKSDataSet.RejectChanges();
                        }
                    }
                }
            }
        }

        private void DeleteRoom(string maPhong)
        {
            QLKSDataSet.PHONGRow row = phongTable.FindByMaPhong(maPhong);
            if (row != null)
            {
                if (MessageBox.Show($"Bạn có chắc muốn xóa phòng {row.SoPhong}?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    row.Delete();
                    try
                    {
                        phongAdapter.Update(qLKSDataSet.PHONG);
                        qLKSDataSet.PHONG.AcceptChanges();
                        FilterAndDisplayRooms();
                        UpdateStats();
                        MessageBox.Show("Xóa phòng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi khi xóa phòng: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        qLKSDataSet.PHONG.RejectChanges();
                    }
                }
            }
        }
    }
} 