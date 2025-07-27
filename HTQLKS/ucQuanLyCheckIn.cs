using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
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

        // Helper method để đảm bảo độ dài mã không vượt quá giới hạn
        private string EnsureMaxLength(string value, int maxLength)
        {
            if (string.IsNullOrEmpty(value)) return value;
            return value.Length > maxLength ? value.Substring(0, maxLength) : value;
        }

        // Helper method để reload dữ liệu từ database
        private void ReloadAllData()
        {
            try
            {
                // Clear existing data first
                qlksDataSet.Clear();
                
                // Reload data without transaction scope
                datPhongAdapter.Fill(qlksDataSet.DATPHONG);
                phongAdapter.Fill(qlksDataSet.PHONG);
                khachHangAdapter.Fill(qlksDataSet.KHACHHANG);
                loaiPhongAdapter.Fill(qlksDataSet.LOAIPHONG);
                
                Console.WriteLine("Data reloaded successfully");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error reloading data: {ex.Message}");
                Console.WriteLine($"Stack trace: {ex.StackTrace}");
                // Don't show message box here to avoid blocking the UI
                // Instead, throw the exception to be handled by caller
                throw new Exception($"Lỗi khi tải lại dữ liệu: {ex.Message}");
            }
        }

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
            
            // Test connection
            try
            {
                connection.Open();
                connection.Close();
                Console.WriteLine("Database connection successful");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Database connection failed: {ex.Message}");
                MessageBox.Show($"Lỗi kết nối database: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
                              where dp.RowState != DataRowState.Deleted && dp.RowState != DataRowState.Detached
                              join kh_join in qlksDataSet.KHACHHANG.Where(k => k.RowState != DataRowState.Deleted && k.RowState != DataRowState.Detached)
                                  on dp.MaKH equals kh_join.MaKH into kh_group
                              from kh in kh_group.DefaultIfEmpty()
                              join p_join in qlksDataSet.PHONG.Where(p => p.RowState != DataRowState.Deleted && p.RowState != DataRowState.Detached)
                                  on dp.MaPhong equals p_join.MaPhong into p_group
                              from p in p_group.DefaultIfEmpty()
                              join lp_join in qlksDataSet.LOAIPHONG.Where(l => l.RowState != DataRowState.Deleted && l.RowState != DataRowState.Detached)
                                  on (p == null ? "" : p.MaLoaiPhong) equals lp_join.MaLoaiPhong into lp_group
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

            // --- Input Form ComboBoxes ---
            // Customer ComboBox (for edit mode only)
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
            if (cmbLoaiPhong.SelectedValue != null && cmbLoaiPhong.SelectedValue != DBNull.Value)
            {
                string maLoaiPhong = cmbLoaiPhong.SelectedValue.ToString();
                // Always get fresh available rooms
                var availableRooms = qlksDataSet.PHONG
                    .Where(p => p.RowState != DataRowState.Deleted 
                            && p.RowState != DataRowState.Detached
                            && p.MaLoaiPhong == maLoaiPhong 
                            && p.TrangThai == "Trống")
                    .ToList();
                cmbSoPhong.DataSource = availableRooms;
                cmbSoPhong.DisplayMember = "SoPhong";
                cmbSoPhong.ValueMember = "MaPhong";
                cmbSoPhong.SelectedIndex = availableRooms.Any() ? 0 : -1;
            }
            else
            {
                cmbSoPhong.DataSource = null;
                cmbSoPhong.Items.Clear();
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

                // Luôn ẩn ComboBox, chỉ dùng TextBox cho khách hàng
                cmbTenKhach.Visible = false;
                txtTenKhach.Visible = true;

                var datPhongRow = qlksDataSet.DATPHONG.FindByMaDatPhong(maDatPhong);
                if (datPhongRow != null && datPhongRow.RowState != DataRowState.Deleted && datPhongRow.RowState != DataRowState.Detached)
                {
                    txtMaDatPhong.Text = datPhongRow.MaDatPhong;
                    
                    // Cải thiện xử lý DateTime để tránh lỗi precision
                    try
                    {
                        dtpNgayCheckIn.Value = datPhongRow.NgayCheckIn;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Error setting DateTimePicker value: {ex.Message}");
                        // Fallback to current date if there's an issue
                        dtpNgayCheckIn.Value = DateTime.Now;
                    }

                    // Load customer info
                    if (!datPhongRow.IsNull("MaKH"))
                    {
                        var khachHangRow = qlksDataSet.KHACHHANG.FindByMaKH(datPhongRow.MaKH);
                        if (khachHangRow != null)
                        {
                            txtTenKhach.Text = khachHangRow.HoTen;
                            txtCCCD.Text = khachHangRow.CCCD;
                            txtSDT.Text = khachHangRow.SDT;
                        }
                    }

                    // Load room info
                    if (!datPhongRow.IsNull("MaPhong"))
                    {
                        var phongRow = qlksDataSet.PHONG.FindByMaPhong(datPhongRow.MaPhong);
                        if (phongRow != null && phongRow.RowState != DataRowState.Deleted && phongRow.RowState != DataRowState.Detached)
                        {
                            cmbLoaiPhong.SelectedValue = phongRow.MaLoaiPhong;
                            // Hiển thị cả phòng đang sử dụng (của khách) và các phòng trống cùng loại
                            var soPhongList = qlksDataSet.PHONG
                                .Where(p =>
                                    p.MaLoaiPhong == phongRow.MaLoaiPhong &&
                                    (p.TrangThai == "Trống" || p.MaPhong == phongRow.MaPhong) &&
                                    p.RowState != DataRowState.Deleted && p.RowState != DataRowState.Detached)
                                .ToList();
                            cmbSoPhong.DataSource = soPhongList;
                            cmbSoPhong.DisplayMember = "SoPhong";
                            cmbSoPhong.ValueMember = "MaPhong";
                            cmbSoPhong.SelectedValue = phongRow.MaPhong;
                        }
                        else
                        {
                            cmbLoaiPhong.SelectedIndex = -1;
                            cmbSoPhong.DataSource = null;
                            cmbSoPhong.Items.Clear();
                        }
                    }
                }
            }
            // Handle Delete button click
            else if (e.ColumnIndex == dgvCheckIn.Columns["Delete"].Index)
            {
                if (MessageBox.Show($"Bạn có chắc muốn xóa check-in có mã {maDatPhong}?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    // Xóa trực tiếp bằng SQL
                    using (var connection = new SqlConnection(Properties.Settings.Default.QLKSConnectionString))
                    {
                        connection.Open();
                        using (var cmd = new SqlCommand("DELETE FROM DATPHONG WHERE MaDatPhong = @MaDatPhong", connection))
                        {
                            cmd.Parameters.AddWithValue("@MaDatPhong", maDatPhong);
                            int rows = cmd.ExecuteNonQuery();
                            if (rows > 0)
                            {
                                ReloadAllData();
                                MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                DisplayCheckInData();
                            }
                            else
                            {
                                MessageBox.Show("Không tìm thấy dòng để xóa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
        }

        private void Filters_Changed(object sender, EventArgs e)
        {
            var query = from dp in qlksDataSet.DATPHONG
                        where (dp.TrangThai == "Đã xác nhận" || dp.TrangThai == "Đã check-in")
                            && dp.RowState != DataRowState.Deleted 
                            && dp.RowState != DataRowState.Detached
                        join kh in qlksDataSet.KHACHHANG.Where(k => k.RowState != DataRowState.Deleted && k.RowState != DataRowState.Detached)
                            on dp.MaKH equals kh.MaKH
                        join p in qlksDataSet.PHONG.Where(p => p.RowState != DataRowState.Deleted && p.RowState != DataRowState.Detached)
                            on dp.MaPhong equals p.MaPhong
                        join lp in qlksDataSet.LOAIPHONG.Where(l => l.RowState != DataRowState.Deleted && l.RowState != DataRowState.Detached)
                            on p.MaLoaiPhong equals lp.MaLoaiPhong
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

            // Remove customer name filter (txtFilterTenKhach)

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
            if (string.IsNullOrWhiteSpace(txtTenKhach.Text))
            {
                MessageBox.Show("Vui lòng nhập tên khách hàng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            
            // Validation cho ngày check-in
            if (dtpNgayCheckIn.Value < DateTime.Today)
            {
                MessageBox.Show("Ngày check-in không thể là ngày trong quá khứ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            
            // Validation cho ngày check-out (đảm bảo >= ngày check-in)
            DateTime ngayCheckOut = dtpNgayCheckIn.Value.AddDays(1);
            if (ngayCheckOut <= dtpNgayCheckIn.Value)
            {
                MessageBox.Show("Ngày check-out phải lớn hơn ngày check-in.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cmbLoaiPhong.SelectedIndex == -1 || cmbLoaiPhong.SelectedValue == null || cmbLoaiPhong.SelectedValue == DBNull.Value)
            {
                MessageBox.Show("Vui lòng chọn loại phòng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cmbSoPhong.SelectedIndex == -1 || cmbSoPhong.Items.Count == 0 || cmbSoPhong.SelectedValue == null || cmbSoPhong.SelectedValue == DBNull.Value)
            {
                MessageBox.Show("Không có phòng trống cho loại phòng đã chọn hoặc bạn chưa chọn phòng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                if (isEditing)
                {
                    // Sử dụng direct SQL update để tránh lỗi concurrency
                    UpdateExistingRecord();
                }
                else
                {
                    // Add new customer
                    var rand = new Random();
                    string newMaKH;
                    do {
                        newMaKH = EnsureMaxLength($"KH{DateTime.Now:HHmmss}{rand.Next(10,99)}", 10);
                    } while (qlksDataSet.KHACHHANG.Any(kh => kh.MaKH == newMaKH));

                    var newKhachHangRow = qlksDataSet.KHACHHANG.NewKHACHHANGRow();
                    newKhachHangRow.MaKH = newMaKH;
                    newKhachHangRow.HoTen = txtTenKhach.Text;
                    newKhachHangRow.CCCD = txtCCCD.Text;
                    newKhachHangRow.SDT = txtSDT.Text;
                    qlksDataSet.KHACHHANG.AddKHACHHANGRow(newKhachHangRow);

                    // Cập nhật KHACHHANG xuống DB trước để tránh lỗi khóa ngoại
                    khachHangAdapter.Update(qlksDataSet.KHACHHANG.Select(null, null, DataViewRowState.Added));
                    qlksDataSet.KHACHHANG.AcceptChanges();

                    // Ensure selected room is still available
                    var selectedMaPhong = cmbSoPhong.SelectedValue?.ToString();
                    if (string.IsNullOrEmpty(selectedMaPhong))
                    {
                        MessageBox.Show("Vui lòng chọn phòng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    
                    // Đảm bảo MaPhong không vượt quá 10 ký tự
                    selectedMaPhong = EnsureMaxLength(selectedMaPhong, 10);
                    
                    var phongRow = qlksDataSet.PHONG.FirstOrDefault(p => p.MaPhong == selectedMaPhong && p.TrangThai == "Trống" && p.RowState != DataRowState.Deleted && p.RowState != DataRowState.Detached);
                    if (phongRow == null)
                    {
                        MessageBox.Show("Phòng đã được đặt hoặc không còn phòng trống. Vui lòng chọn lại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Thêm mới booking bằng direct SQL
                    AddNewBooking(newMaKH, selectedMaPhong);
                    ReloadAllData();
                    MessageBox.Show("Thêm mới thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DisplayCheckInData();
                    ResetForm();
                    return;
                }

                // Debug: Check what rows are ready for update
                var modifiedKhachHang = qlksDataSet.KHACHHANG.Select(null, null, DataViewRowState.ModifiedCurrent);
                var addedDatPhong = qlksDataSet.DATPHONG.Select(null, null, DataViewRowState.Added);
                var modifiedDatPhong = qlksDataSet.DATPHONG.Select(null, null, DataViewRowState.ModifiedCurrent);
                var modifiedPhong = qlksDataSet.PHONG.Select(null, null, DataViewRowState.ModifiedCurrent);

                Console.WriteLine($"Modified KHACHHANG: {modifiedKhachHang.Length}");
                Console.WriteLine($"Added DATPHONG: {addedDatPhong.Length}");
                Console.WriteLine($"Modified DATPHONG: {modifiedDatPhong.Length}");
                Console.WriteLine($"Modified PHONG: {modifiedPhong.Length}");

                // Debug: Check if there are any changes at all
                bool hasAnyChanges = modifiedKhachHang.Length > 0 || addedDatPhong.Length > 0 || 
                                   modifiedDatPhong.Length > 0 || modifiedPhong.Length > 0;
                
                if (!hasAnyChanges && !isEditing)
                {
                    Console.WriteLine("No changes detected in DataSet");
                    MessageBox.Show("Không có thay đổi nào được phát hiện trong dữ liệu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // Sử dụng transaction scope đơn giản hơn
                using (var transaction = new TransactionScope())
                {
                    try
                    {
                        // Save all changes in correct order with proper error handling
                        int khachHangUpdated = 0;
                        int datPhongUpdated = 0;
                        int phongUpdated = 0;

                        // Update KHACHHANG
                        var khachHangRows = qlksDataSet.KHACHHANG.Select(null, null, DataViewRowState.ModifiedCurrent);
                        if (khachHangRows.Length > 0)
                        {
                            khachHangUpdated = khachHangAdapter.Update(khachHangRows);
                            Console.WriteLine($"KHACHHANG updated: {khachHangUpdated} rows");
                        }

                        // Update DATPHONG (chỉ cho edit mode, thêm mới đã dùng direct SQL)
                        if (isEditing)
                        {
                            var datPhongRows = qlksDataSet.DATPHONG.Select(null, null, DataViewRowState.Added | DataViewRowState.ModifiedCurrent);
                            if (datPhongRows.Length > 0)
                            {
                                datPhongUpdated = datPhongAdapter.Update(datPhongRows.Cast<QLKSDataSet.DATPHONGRow>().ToArray());
                                Console.WriteLine($"DATPHONG updated: {datPhongUpdated} rows");
                            }
                        }

                        // Update PHONG (chỉ cho edit mode, thêm mới đã dùng direct SQL)
                        if (isEditing)
                        {
                            var phongRows = qlksDataSet.PHONG.Select(null, null, DataViewRowState.Added | DataViewRowState.ModifiedCurrent);
                            if (phongRows.Length > 0)
                            {
                                phongUpdated = phongAdapter.Update(phongRows.Cast<QLKSDataSet.PHONGRow>().ToArray());
                                Console.WriteLine($"PHONG updated: {phongUpdated} rows");
                            }
                        }

                        // Check if any update failed
                        if (khachHangUpdated < 0 || datPhongUpdated < 0 || phongUpdated < 0)
                        {
                            throw new Exception($"Lỗi cập nhật: KHACHHANG={khachHangUpdated}, DATPHONG={datPhongUpdated}, PHONG={phongUpdated}");
                        }

                        // Verify that at least one table was updated
                        if (khachHangUpdated == 0 && datPhongUpdated == 0 && phongUpdated == 0 && !isEditing)
                        {
                            throw new Exception("Không có bản ghi nào được cập nhật. Vui lòng kiểm tra lại dữ liệu.");
                        }

                        transaction.Complete();
                        qlksDataSet.AcceptChanges();
                    }
                    catch (Exception ex)
                    {
                        qlksDataSet.RejectChanges();
                        throw new Exception($"Lỗi cập nhật dữ liệu: {ex.Message}. Vui lòng thử lại.");
                    }
                }

                // Force refresh data after successful update (outside transaction scope)
                try
                {
                    ReloadAllData();
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Warning: Could not reload data after update: {ex.Message}");
                }

                // Làm mới lại dữ liệu phòng và combobox sau khi cập nhật/thêm mới
                phongAdapter.Fill(qlksDataSet.PHONG);
                LoadComboBoxData();

                MessageBox.Show(isEditing ? "Cập nhật thành công!" : "Thêm mới thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DisplayCheckInData();
                ResetForm();
            }
            catch (Exception ex)
            {
                // Log chi tiết lỗi để debug
                Console.WriteLine($"Error in BtnConfirm_Click: {ex.Message}");
                Console.WriteLine($"Stack trace: {ex.StackTrace}");
                
                // Kiểm tra nếu là lỗi concurrency violation
                if (ex.Message.Contains("Concurrency violation") || 
                    ex.Message.Contains("affected 0 of the expected 1 records") ||
                    ex.Message.Contains("Row not found") ||
                    ex.Message.Contains("Update requires a valid UpdateCommand"))
                {
                    // Reload dữ liệu và thử lại
                    try
                    {
                        ReloadAllData();
                        Console.WriteLine("Data reloaded successfully after concurrency error");
                    }
                    catch (Exception reloadEx)
                    {
                        Console.WriteLine($"Warning: Could not reload data: {reloadEx.Message}");
                    }
                    MessageBox.Show("Dữ liệu đã được cập nhật bởi người khác. Vui lòng thử lại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (ex.Message.Contains("Không thể cập nhật") || ex.Message.Contains("Không tìm thấy"))
                {
                    // Lỗi cụ thể từ direct SQL update
                    MessageBox.Show(ex.Message, "Lỗi cập nhật", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (ex.Message.Contains("Phòng đã được đặt") || ex.Message.Contains("Phòng không tồn tại"))
                {
                    // Lỗi liên quan đến phòng
                    MessageBox.Show(ex.Message, "Lỗi phòng", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                qlksDataSet.RejectChanges();
            }
        }

        // Phương thức mới để cập nhật record hiện có bằng direct SQL
        private void UpdateExistingRecord()
        {
            using (var connection = new SqlConnection(Properties.Settings.Default.QLKSConnectionString))
            {
                connection.Open();
                using (var transaction = connection.BeginTransaction())
                {
                    try
                    {
                        // 1. Cập nhật thông tin khách hàng
                        var datPhongRow = qlksDataSet.DATPHONG.FindByMaDatPhong(currentMaDatPhong);
                        if (datPhongRow != null)
                        {
                            string maKH = datPhongRow.MaKH;
                            string currentMaPhong = datPhongRow.MaPhong; // Phòng hiện tại của booking
                            
                            Console.WriteLine($"Updating booking: {currentMaDatPhong}");
                            Console.WriteLine($"Current room: {currentMaPhong}");
                            Console.WriteLine($"Selected room: {cmbSoPhong.SelectedValue}");
                            Console.WriteLine($"Customer: {txtTenKhach.Text}");
                            Console.WriteLine($"Check-in date: {dtpNgayCheckIn.Value}");
                            
                            // Cập nhật KHACHHANG
                            string updateKhachHangSql = @"
                                UPDATE KHACHHANG 
                                SET HoTen = @HoTen, CCCD = @CCCD, SDT = @SDT 
                                WHERE MaKH = @MaKH";
                            
                            using (var cmd = new SqlCommand(updateKhachHangSql, connection, transaction))
                            {
                                cmd.Parameters.AddWithValue("@HoTen", txtTenKhach.Text);
                                cmd.Parameters.AddWithValue("@CCCD", txtCCCD.Text);
                                cmd.Parameters.AddWithValue("@SDT", txtSDT.Text);
                                cmd.Parameters.AddWithValue("@MaKH", maKH);
                                
                                int khachHangUpdated = cmd.ExecuteNonQuery();
                                Console.WriteLine($"KHACHHANG updated: {khachHangUpdated} rows");
                                
                                if (khachHangUpdated == 0)
                                {
                                    throw new Exception("Không thể cập nhật thông tin khách hàng.");
                                }
                            }

                            // 2. Cập nhật DATPHONG
                            string selectedMaPhong = cmbSoPhong.SelectedValue?.ToString();
                            if (!string.IsNullOrEmpty(selectedMaPhong))
                            {
                                selectedMaPhong = EnsureMaxLength(selectedMaPhong, 10);
                                
                                // Kiểm tra xem phòng có tồn tại và trống không
                                // Cho phép phòng hiện tại đang được sử dụng bởi booking này
                                string checkRoomSql = @"
                                    SELECT COUNT(*) FROM PHONG 
                                    WHERE MaPhong = @MaPhong";
                                
                                using (var checkCmd = new SqlCommand(checkRoomSql, connection, transaction))
                                {
                                    checkCmd.Parameters.AddWithValue("@MaPhong", selectedMaPhong);
                                    int roomExists = (int)checkCmd.ExecuteScalar();
                                    
                                    if (roomExists == 0)
                                    {
                                        throw new Exception("Phòng không tồn tại trong hệ thống.");
                                    }
                                }
                                
                                // Kiểm tra xem phòng có bị đặt bởi booking khác không
                                if (selectedMaPhong != currentMaPhong)
                                {
                                    string checkRoomOccupiedSql = @"
                                        SELECT COUNT(*) FROM DATPHONG 
                                        WHERE MaPhong = @MaPhong AND MaDatPhong != @CurrentMaDatPhong 
                                        AND TrangThai IN ('Đã đặt', 'Đã check-in')";
                                    
                                    using (var checkCmd = new SqlCommand(checkRoomOccupiedSql, connection, transaction))
                                    {
                                        checkCmd.Parameters.AddWithValue("@MaPhong", selectedMaPhong);
                                        checkCmd.Parameters.AddWithValue("@CurrentMaDatPhong", currentMaDatPhong);
                                        int roomOccupied = (int)checkCmd.ExecuteScalar();
                                        
                                        if (roomOccupied > 0)
                                        {
                                            throw new Exception("Phòng đã được đặt bởi khách hàng khác.");
                                        }
                                    }
                                }
                                
                                string updateDatPhongSql = @"
                                    UPDATE DATPHONG 
                                    SET MaPhong = @MaPhong, NgayCheckIn = @NgayCheckIn, NgayCheckOut = @NgayCheckOut 
                                    WHERE MaDatPhong = @MaDatPhong";
                                
                                using (var cmd = new SqlCommand(updateDatPhongSql, connection, transaction))
                                {
                                    cmd.Parameters.AddWithValue("@MaPhong", selectedMaPhong);
                                    cmd.Parameters.AddWithValue("@NgayCheckIn", dtpNgayCheckIn.Value);
                                    // Đảm bảo NgayCheckOut luôn >= NgayCheckIn
                                    DateTime ngayCheckOut = dtpNgayCheckIn.Value.AddDays(1);
                                    cmd.Parameters.AddWithValue("@NgayCheckOut", ngayCheckOut);
                                    cmd.Parameters.AddWithValue("@MaDatPhong", currentMaDatPhong);
                                    
                                    int datPhongUpdated = cmd.ExecuteNonQuery();
                                    Console.WriteLine($"DATPHONG updated: {datPhongUpdated} rows");
                                    
                                    if (datPhongUpdated == 0)
                                    {
                                        throw new Exception("Không thể cập nhật thông tin đặt phòng.");
                                    }
                                }
                                
                                // 3. Cập nhật trạng thái phòng
                                // Nếu chuyển sang phòng khác, cập nhật trạng thái cả 2 phòng
                                if (selectedMaPhong != currentMaPhong)
                                {
                                    // Đặt phòng cũ về trạng thái trống
                                    string updateOldRoomSql = @"
                                        UPDATE PHONG 
                                        SET TrangThai = N'Trống' 
                                        WHERE MaPhong = @MaPhong";
                                    
                                    using (var cmd = new SqlCommand(updateOldRoomSql, connection, transaction))
                                    {
                                        cmd.Parameters.AddWithValue("@MaPhong", currentMaPhong);
                                        int oldRoomUpdated = cmd.ExecuteNonQuery();
                                        Console.WriteLine($"Old PHONG updated: {oldRoomUpdated} rows");
                                    }
                                    
                                    // Đặt phòng mới về trạng thái đang sử dụng
                                    string updateNewRoomSql = @"
                                        UPDATE PHONG 
                                        SET TrangThai = N'Đang sử dụng' 
                                        WHERE MaPhong = @MaPhong";
                                    
                                    using (var cmd = new SqlCommand(updateNewRoomSql, connection, transaction))
                                    {
                                        cmd.Parameters.AddWithValue("@MaPhong", selectedMaPhong);
                                        int newRoomUpdated = cmd.ExecuteNonQuery();
                                        Console.WriteLine($"New PHONG updated: {newRoomUpdated} rows");
                                    }
                                }
                                else
                                {
                                    // Nếu vẫn giữ nguyên phòng, chỉ cập nhật ngày check-in
                                    Console.WriteLine("Same room selected, no room status update needed");
                                }
                            }

                            transaction.Commit();
                            Console.WriteLine("Update completed successfully");
                        }
                        else
                        {
                            throw new Exception("Không tìm thấy thông tin đặt phòng.");
                        }
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        throw new Exception($"Lỗi cập nhật: {ex.Message}");
                    }
                }
            }
        }

        // Phương thức mới để thêm booking bằng direct SQL
        private void AddNewBooking(string maKH, string selectedMaPhong)
        {
            using (var connection = new SqlConnection(Properties.Settings.Default.QLKSConnectionString))
            {
                connection.Open();
                using (var transaction = connection.BeginTransaction())
                {
                    try
                    {
                        var rand = new Random();
                        string maDatPhong;
                        do {
                            maDatPhong = EnsureMaxLength($"DP{rand.Next(1000, 9999)}", 10);
                        } while (qlksDataSet.DATPHONG.Any(dp => dp.MaDatPhong == maDatPhong));

                        // Thêm mới DATPHONG bằng direct SQL
                        string insertDatPhongSql = @"
                            INSERT INTO DATPHONG (MaDatPhong, MaKH, MaPhong, NgayDat, NgayCheckIn, NgayCheckOut, SoNguoi, TrangThai, GhiChu)
                            VALUES (@MaDatPhong, @MaKH, @MaPhong, @NgayDat, @NgayCheckIn, @NgayCheckOut, @SoNguoi, N'Đã check-in', @GhiChu)";
                        
                        using (var cmd = new SqlCommand(insertDatPhongSql, connection, transaction))
                        {
                            cmd.Parameters.AddWithValue("@MaDatPhong", maDatPhong);
                            cmd.Parameters.AddWithValue("@MaKH", maKH);
                            cmd.Parameters.AddWithValue("@MaPhong", selectedMaPhong);
                            cmd.Parameters.AddWithValue("@NgayDat", DateTime.Now);
                            cmd.Parameters.AddWithValue("@NgayCheckIn", dtpNgayCheckIn.Value);
                            cmd.Parameters.AddWithValue("@NgayCheckOut", dtpNgayCheckIn.Value.AddDays(1));
                            cmd.Parameters.AddWithValue("@SoNguoi", 1);
                            cmd.Parameters.AddWithValue("@GhiChu", DBNull.Value);
                            
                            int datPhongInserted = cmd.ExecuteNonQuery();
                            Console.WriteLine($"DATPHONG inserted: {datPhongInserted} rows");
                        }

                        // Cập nhật trạng thái phòng
                        string updateRoomSql = @"
                            UPDATE PHONG 
                            SET TrangThai = N'Đang sử dụng' 
                            WHERE MaPhong = @MaPhong";
                        
                        using (var cmd = new SqlCommand(updateRoomSql, connection, transaction))
                        {
                            cmd.Parameters.AddWithValue("@MaPhong", selectedMaPhong);
                            int roomUpdated = cmd.ExecuteNonQuery();
                            Console.WriteLine($"PHONG updated: {roomUpdated} rows");
                        }

                        transaction.Commit();
                        Console.WriteLine("Add new booking completed successfully");
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        throw new Exception($"Lỗi thêm mới booking: {ex.Message}");
                    }
                }
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

            var rand = new Random();
            string maDatPhong = EnsureMaxLength($"DP{rand.Next(1000, 9999)}", 10);
            txtMaDatPhong.Text = maDatPhong;
            
            // Show TextBox, hide ComboBox for add new
            txtTenKhach.Visible = true;
            cmbTenKhach.Visible = false;

            // Clear selections and text fields
            txtTenKhach.Clear();
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