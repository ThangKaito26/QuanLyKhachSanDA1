using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HTQLKS
{
    public partial class ucQuanLyCheckIn : UserControl
    {
        private QLKSDataSet qlksDataSet;
        private QLKSDataSetTableAdapters.DATPHONGTableAdapter datPhongAdapter;
        private QLKSDataSetTableAdapters.KHACHHANGTableAdapter khachHangAdapter;
        private QLKSDataSetTableAdapters.PHONGTableAdapter phongAdapter;
        private QLKSDataSetTableAdapters.LOAIPHONGTableAdapter loaiPhongAdapter;
        private BindingSource bindingSource = new BindingSource();
        private bool isEditing = false;
        private string currentMaDatPhong = null;

        public ucQuanLyCheckIn()
        {
            InitializeComponent();
            this.Load += ucQuanLyCheckIn_Load;
        }

        private void ucQuanLyCheckIn_Load(object sender, EventArgs e)
        {
            InitializeDataAccess();
            LoadData();
            ConfigureGridView();
            LoadComboBoxData();
            SetupEventHandlers();
            SetPlaceholderText();
            // Allow the date time picker to be toggled
            dtpFilterNgayDen.Format = DateTimePickerFormat.Custom;
            dtpFilterNgayDen.CustomFormat = "dd/MM/yyyy";
            dtpFilterNgayDen.ShowCheckBox = true;
            dtpFilterNgayDen.Checked = false;
            // Gọi hàm lọc ngay sau khi mọi thứ đã sẵn sàng
            Filters_Changed(null, null);
        }

        private void InitializeDataAccess()
        {
            string connectionString = Properties.Settings.Default.QLKSConnectionString;
            SqlConnection connection = new SqlConnection(connectionString);

            qlksDataSet = new QLKSDataSet();
            datPhongAdapter = new QLKSDataSetTableAdapters.DATPHONGTableAdapter() { Connection = connection };
            khachHangAdapter = new QLKSDataSetTableAdapters.KHACHHANGTableAdapter() { Connection = connection };
            phongAdapter = new QLKSDataSetTableAdapters.PHONGTableAdapter() { Connection = connection };
            loaiPhongAdapter = new QLKSDataSetTableAdapters.LOAIPHONGTableAdapter() { Connection = connection };
        }

        private void LoadData()
        {
            try
            {
                datPhongAdapter.Fill(qlksDataSet.DATPHONG);
                khachHangAdapter.Fill(qlksDataSet.KHACHHANG);
                phongAdapter.Fill(qlksDataSet.PHONG);
                loaiPhongAdapter.Fill(qlksDataSet.LOAIPHONG);
                DisplayCheckInData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load data from the database. Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DisplayCheckInData()
        {
            // Load all bookings, regardless of status, to ensure data is displayed.
            var checkInData = from dp in qlksDataSet.DATPHONG
                              join kh_join in qlksDataSet.KHACHHANG on dp.MaKH equals kh_join.MaKH into kh_group
                              from kh in kh_group.DefaultIfEmpty()
                              join p_join in qlksDataSet.PHONG on dp.MaPhong equals p_join.MaPhong into p_group
                              from p in p_group.DefaultIfEmpty()
                              join lp_join in qlksDataSet.LOAIPHONG on (p == null ? "" : p.MaLoaiPhong) equals lp_join.MaLoaiPhong into lp_group
                              from lp in lp_group.DefaultIfEmpty()
                              select new
                              {
                                  MaDatPhong = dp.MaDatPhong,
                                  TenKhachHang = (kh == null ? "N/A" : kh.HoTen),
                                  CCCD = (kh == null ? "N/A" : kh.CCCD),
                                  SDT = (kh == null ? "N/A" : kh.SDT),
                                  NgayDen = dp.NgayCheckIn,
                                  LoaiPhong = (lp == null ? "N/A" : lp.TenLoaiPhong),
                                  SoPhong = (p == null ? "N/A" : p.SoPhong)
                              };
            
            var resultList = checkInData.ToList();
            bindingSource.DataSource = resultList;
            dgvCheckIn.DataSource = bindingSource;
        }

        private void ConfigureGridView()
        {
            dgvCheckIn.Columns["MaDatPhong"].HeaderText = "Mã Đặt Phòng";
            dgvCheckIn.Columns["TenKhachHang"].HeaderText = "Tên Khách Hàng";
            dgvCheckIn.Columns["CCCD"].HeaderText = "CCCD/CMND";
            dgvCheckIn.Columns["SDT"].HeaderText = "Số Điện Thoại";
            dgvCheckIn.Columns["NgayDen"].HeaderText = "Ngày Đến";
            dgvCheckIn.Columns["LoaiPhong"].HeaderText = "Loại Phòng";
            dgvCheckIn.Columns["SoPhong"].HeaderText = "Số Phòng";

            dgvCheckIn.Columns["TenKhachHang"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            
            // Add Edit and Delete buttons
            DataGridViewButtonColumn editButton = new DataGridViewButtonColumn
            {
                Name = "Edit",
                Text = "Sửa",
                UseColumnTextForButtonValue = true,
                HeaderText = "Thao tác",
                FlatStyle = FlatStyle.Flat,
                DefaultCellStyle = { BackColor = Color.FromArgb(49, 130, 206), ForeColor = Color.White }
            };
            dgvCheckIn.Columns.Add(editButton);

            DataGridViewButtonColumn deleteButton = new DataGridViewButtonColumn
            {
                Name = "Delete",
                Text = "Xóa",
                UseColumnTextForButtonValue = true,
                FlatStyle = FlatStyle.Flat,
                DefaultCellStyle = { BackColor = Color.FromArgb(224, 79, 95), ForeColor = Color.White }
            };
            dgvCheckIn.Columns.Add(deleteButton);
        }
        
        private void LoadComboBoxData()
        {
            // --- Filter ComboBoxes ---
            var roomTypesFilter = qlksDataSet.LOAIPHONG.Select(lp => lp.TenLoaiPhong).Distinct().ToList();
            roomTypesFilter.Insert(0, "Tất cả loại phòng");
            cmbFilterLoaiPhong.DataSource = roomTypesFilter;
            cmbFilterLoaiPhong.SelectedIndex = 0;
            
            var roomNumbersFilter = qlksDataSet.PHONG.Select(p => p.SoPhong).Distinct().ToList();
            roomNumbersFilter.Insert(0, "Tất cả số phòng");
            cmbFilterSoPhong.DataSource = roomNumbersFilter;
            cmbFilterSoPhong.SelectedIndex = 0;

            // KHÔNG gọi Filters_Changed ở đây nữa

            // --- Input Form ComboBoxes ---
            // Customer ComboBox
            cmbTenKhach.DataSource = qlksDataSet.KHACHHANG;
            cmbTenKhach.DisplayMember = "HoTen";
            cmbTenKhach.ValueMember = "MaKH";
            cmbTenKhach.SelectedIndex = -1;

            // Room Type ComboBox
            cmbLoaiPhong.DataSource = qlksDataSet.LOAIPHONG;
            cmbLoaiPhong.DisplayMember = "TenLoaiPhong";
            cmbLoaiPhong.ValueMember = "MaLoaiPhong";
            cmbLoaiPhong.SelectedIndex = -1;
        }
        
        private void SetPlaceholderText()
        {
            txtSearch.Text = "Tìm kiếm theo mã, tên, cccd, sđt...";
            txtSearch.ForeColor = Color.Gray;
            txtSearch.GotFocus += (s, e) => {
                if (txtSearch.Text == "Tìm kiếm theo mã, tên, cccd, sđt...")
                {
                    txtSearch.Text = "";
                    txtSearch.ForeColor = Color.White;
                }
            };
            txtSearch.LostFocus += (s, e) => {
                if (string.IsNullOrWhiteSpace(txtSearch.Text))
                {
                    txtSearch.Text = "Tìm kiếm theo mã, tên, cccd, sđt...";
                    txtSearch.ForeColor = Color.Gray;
                }
            };
        }

        private void SetupEventHandlers()
        {
            // Filter events
            txtSearch.TextChanged += new EventHandler(Filters_Changed);
            txtFilterTenKhach.TextChanged += new EventHandler(Filters_Changed);
            dtpFilterNgayDen.ValueChanged += new EventHandler(Filters_Changed);
            cmbFilterLoaiPhong.SelectedIndexChanged += new EventHandler(Filters_Changed);
            cmbFilterSoPhong.SelectedIndexChanged += new EventHandler(Filters_Changed);

            // Input form events
            cmbTenKhach.SelectedIndexChanged += CmbTenKhach_SelectedIndexChanged;
            cmbLoaiPhong.SelectedIndexChanged += CmbLoaiPhong_SelectedIndexChanged;

            // Button events
            btnAddNew.Click += BtnAddNew_Click;
            btnConfirm.Click += BtnConfirm_Click;
            btnCancel.Click += BtnCancel_Click;
            dgvCheckIn.CellContentClick += DgvCheckIn_CellContentClick;
        }

        private void CmbLoaiPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbLoaiPhong.SelectedValue != null)
            {
                string maLoaiPhong = cmbLoaiPhong.SelectedValue.ToString();
                var availableRooms = qlksDataSet.PHONG
                    .Where(p => p.MaLoaiPhong == maLoaiPhong && p.TrangThai == "Trống")
                    .ToList();
                
                cmbSoPhong.DataSource = availableRooms;
                cmbSoPhong.DisplayMember = "SoPhong";
                cmbSoPhong.ValueMember = "MaPhong";
                cmbSoPhong.SelectedIndex = availableRooms.Any() ? 0 : -1;
            }
        }

        private void CmbTenKhach_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTenKhach.SelectedValue != null)
            {
                var khachHangRow = qlksDataSet.KHACHHANG.FindByMaKH(cmbTenKhach.SelectedValue.ToString());
                if (khachHangRow != null)
                {
                    txtCCCD.Text = khachHangRow.CCCD;
                    txtSDT.Text = khachHangRow.SDT;
                }
            }
        }

        private void DgvCheckIn_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            string maDatPhong = dgvCheckIn.Rows[e.RowIndex].Cells["MaDatPhong"].Value.ToString();

            // Handle Edit button click
            if (e.ColumnIndex == dgvCheckIn.Columns["Edit"].Index)
            {
                isEditing = true;
                currentMaDatPhong = maDatPhong;
                lblDetailsTitle.Text = "Chỉnh sửa thông tin Check-in";
                btnConfirm.Text = "Cập nhật";

                var datPhongRow = qlksDataSet.DATPHONG.FindByMaDatPhong(maDatPhong);
                if (datPhongRow != null)
                {
                    txtMaDatPhong.Text = datPhongRow.MaDatPhong;
                    dtpNgayCheckIn.Value = datPhongRow.NgayCheckIn;

                    // Load customer info
                    if (!datPhongRow.IsNull("MaKH"))
                    {
                        cmbTenKhach.SelectedValue = datPhongRow.MaKH;
                        var khachHangRow = qlksDataSet.KHACHHANG.FindByMaKH(datPhongRow.MaKH);
                        if (khachHangRow != null)
                        {
                            txtCCCD.Text = khachHangRow.CCCD;
                            txtSDT.Text = khachHangRow.SDT;
                        }
                    }

                    // Load room info
                    if (!datPhongRow.IsNull("MaPhong"))
                    {
                        var phongRow = qlksDataSet.PHONG.FindByMaPhong(datPhongRow.MaPhong);
                        if (phongRow != null)
                        {
                            cmbLoaiPhong.SelectedValue = phongRow.MaLoaiPhong;
                            cmbSoPhong.SelectedValue = phongRow.MaPhong;
                        }
                    }
                }
            }
            // Handle Delete button click
            else if (e.ColumnIndex == dgvCheckIn.Columns["Delete"].Index)
            {
                if (MessageBox.Show($"Bạn có chắc muốn xóa check-in có mã {maDatPhong}?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    var datPhongRow = qlksDataSet.DATPHONG.FindByMaDatPhong(maDatPhong);
                    if (datPhongRow != null)
                    {
                        datPhongRow.Delete();
                        try
                        {
                            datPhongAdapter.Update(qlksDataSet.DATPHONG);
                            qlksDataSet.AcceptChanges();
                            DisplayCheckInData(); // Refresh the grid
                            MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Lỗi khi xóa: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            qlksDataSet.RejectChanges();
                        }
                    }
                }
            }
        }

        private void Filters_Changed(object sender, EventArgs e)
        {
            var query = from dp in qlksDataSet.DATPHONG
                        join kh in qlksDataSet.KHACHHANG on dp.MaKH equals kh.MaKH
                        join p in qlksDataSet.PHONG on dp.MaPhong equals p.MaPhong
                        join lp in qlksDataSet.LOAIPHONG on p.MaLoaiPhong equals lp.MaLoaiPhong
                        where dp.TrangThai == "Đã xác nhận" || dp.TrangThai == "Đã check-in"
                        select new
                        {
                            MaDatPhong = dp.MaDatPhong,
                            TenKhachHang = kh.HoTen,
                            CCCD = kh.CCCD,
                            SDT = kh.SDT,
                            NgayDen = dp.NgayCheckIn,
                            LoaiPhong = lp.TenLoaiPhong,
                            SoPhong = p.SoPhong
                        };

            // Search bar
            if (!string.IsNullOrWhiteSpace(txtSearch.Text) && txtSearch.Text != "Tìm kiếm theo mã, tên, cccd, sđt...")
            {
                string searchText = txtSearch.Text.ToLower();
                query = query.Where(r => r.MaDatPhong.ToLower().Contains(searchText) ||
                                         r.TenKhachHang.ToLower().Contains(searchText) ||
                                         r.CCCD.ToLower().Contains(searchText) ||
                                         r.SDT.ToLower().Contains(searchText));
            }

            // Customer name filter
            if (!string.IsNullOrWhiteSpace(txtFilterTenKhach.Text))
            {
                string filterName = txtFilterTenKhach.Text.ToLower();
                query = query.Where(r => r.TenKhachHang.ToLower().Contains(filterName));
            }

            // Arrival date filter
            if (dtpFilterNgayDen.Checked)
            {
                query = query.Where(r => r.NgayDen.Date == dtpFilterNgayDen.Value.Date);
            }

            // Room type filter
            if (cmbFilterLoaiPhong.SelectedIndex > 0)
            {
                string selectedType = cmbFilterLoaiPhong.SelectedItem.ToString();
                query = query.Where(r => r.LoaiPhong == selectedType);
            }

            // Room number filter
            if (cmbFilterSoPhong.SelectedIndex > 0)
            {
                string selectedRoom = cmbFilterSoPhong.SelectedItem.ToString();
                query = query.Where(r => r.SoPhong == selectedRoom);
            }

            bindingSource.DataSource = query.ToList();
            dgvCheckIn.DataSource = bindingSource;
        }

        private void BtnAddNew_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void BtnConfirm_Click(object sender, EventArgs e)
        {
            // --- Improved Validation ---
            if (cmbTenKhach.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn khách hàng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(txtCCCD.Text) || txtCCCD.Text.Length < 9 || !txtCCCD.Text.All(char.IsDigit))
            {
                MessageBox.Show("CCCD không hợp lệ. Phải có ít nhất 9 chữ số.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(txtSDT.Text) || txtSDT.Text.Length != 10 || !txtSDT.Text.All(char.IsDigit))
            {
                MessageBox.Show("Số điện thoại không hợp lệ. Phải có 10 chữ số.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cmbLoaiPhong.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn loại phòng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cmbSoPhong.SelectedIndex == -1 || cmbSoPhong.Items.Count == 0)
            {
                MessageBox.Show("Không có phòng trống cho loại phòng đã chọn hoặc bạn chưa chọn phòng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                if (isEditing)
                {
                    // Update existing record
                    var datPhongRow = qlksDataSet.DATPHONG.FindByMaDatPhong(currentMaDatPhong);
                    if (datPhongRow != null)
                    {
                        datPhongRow.MaKH = cmbTenKhach.SelectedValue.ToString();
                        datPhongRow.MaPhong = cmbSoPhong.SelectedValue.ToString();
                        datPhongRow.NgayCheckIn = dtpNgayCheckIn.Value;
                        // Update related customer and room if necessary
                    }
                }
                else
                {
                    // Add new record
                    var newDatPhongRow = qlksDataSet.DATPHONG.NewDATPHONGRow();
                    newDatPhongRow.MaDatPhong = txtMaDatPhong.Text;
                    newDatPhongRow.MaKH = cmbTenKhach.SelectedValue.ToString();
                    newDatPhongRow.MaPhong = cmbSoPhong.SelectedValue.ToString();
                    newDatPhongRow.NgayDat = DateTime.Now;
                    newDatPhongRow.NgayCheckIn = dtpNgayCheckIn.Value;
                    newDatPhongRow.NgayCheckOut = dtpNgayCheckIn.Value.AddDays(1); // Default to 1 day
                    newDatPhongRow.SoNguoi = 1; // Default
                    newDatPhongRow.TrangThai = "Đã check-in";
                    qlksDataSet.DATPHONG.AddDATPHONGRow(newDatPhongRow);

                    // Update room status
                    var phongRow = qlksDataSet.PHONG.FindByMaPhong(cmbSoPhong.SelectedValue.ToString());
                    if (phongRow != null)
                    {
                        phongRow.TrangThai = "Đang sử dụng";
                    }
                }

                // Save all changes
                datPhongAdapter.Update(qlksDataSet.DATPHONG);
                phongAdapter.Update(qlksDataSet.PHONG);
                khachHangAdapter.Update(qlksDataSet.KHACHHANG); // In case customer info was changed
                qlksDataSet.AcceptChanges();

                MessageBox.Show(isEditing ? "Cập nhật thành công!" : "Thêm mới thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DisplayCheckInData();
                ResetForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                qlksDataSet.RejectChanges();
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void ResetForm()
        {
            isEditing = false;
            currentMaDatPhong = null;
            lblDetailsTitle.Text = "Thông tin Check-in";
            btnConfirm.Text = "Xác nhận Check-in";

            txtMaDatPhong.Text = "DP" + DateTime.Now.ToString("yyMMddHHmmss");
            
            // Clear selections and text fields
            cmbTenKhach.SelectedIndex = -1;
            txtCCCD.Clear();
            txtSDT.Clear();
            dtpNgayCheckIn.Value = DateTime.Now;
            cmbLoaiPhong.SelectedIndex = -1;
            
            // Clear room ComboBox and its data source
            cmbSoPhong.DataSource = null;
            cmbSoPhong.Items.Clear();
        }
    }
} 