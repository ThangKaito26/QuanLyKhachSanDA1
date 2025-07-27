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
    public partial class ucQuanLyCheckOut : UserControl
    {
        private QLKSDataSet qlksDataSet;
        private QLKSDataSetTableAdapters.DATPHONGTableAdapter datPhongAdapter;
        private QLKSDataSetTableAdapters.KHACHHANGTableAdapter khachHangAdapter;
        private QLKSDataSetTableAdapters.PHONGTableAdapter phongAdapter;
        private QLKSDataSetTableAdapters.LOAIPHONGTableAdapter loaiPhongAdapter;
        private BindingSource bindingSource = new BindingSource();
        // Xóa biến không dùng nữa
        // private string currentMaDatPhong = null;

        public ucQuanLyCheckOut()
        {
            InitializeComponent();
            this.Load += ucQuanLyCheckOut_Load;
        }

        private void ucQuanLyCheckOut_Load(object sender, EventArgs e)
        {
            InitializeDataAccess();
            LoadData();
            ConfigureGridView();
            LoadComboBoxData();
            SetupEventHandlers();
            dtpCheckOut.Format = DateTimePickerFormat.Custom;
            dtpCheckOut.CustomFormat = "dd/MM/yyyy";
            dtpCheckOut.Value = DateTime.Now;
            Filters_Changed(null, null); // Gọi hàm lọc khi load xong
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
                DisplayCheckOutData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load data from the database. Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DisplayCheckOutData()
        {
            // Chỉ hiển thị các phòng đã check-in, chưa check-out
            var checkOutData = from dp in qlksDataSet.DATPHONG
                               join kh in qlksDataSet.KHACHHANG on dp.MaKH equals kh.MaKH
                               join p in qlksDataSet.PHONG on dp.MaPhong equals p.MaPhong
                               join lp in qlksDataSet.LOAIPHONG on p.MaLoaiPhong equals lp.MaLoaiPhong
                               where dp.TrangThai == "Đã check-in"
                               select new
                               {
                                   MaDatPhong = dp.MaDatPhong,
                                   TenKhachHang = kh.HoTen,
                                   SoPhong = p.SoPhong,
                                   LoaiPhong = lp.TenLoaiPhong,
                                   NgayCheckIn = dp.NgayCheckIn,
                                   NgayCheckOut = dp.NgayCheckOut
                               };
            bindingSource.DataSource = checkOutData.ToList();
            dgvCheckOut.DataSource = bindingSource;
        }

        private void ConfigureGridView()
        {
            dgvCheckOut.Columns["MaDatPhong"].HeaderText = "Mã đặt phòng";
            dgvCheckOut.Columns["TenKhachHang"].HeaderText = "Tên khách hàng";
            dgvCheckOut.Columns["SoPhong"].HeaderText = "Số phòng";
            dgvCheckOut.Columns["LoaiPhong"].HeaderText = "Loại phòng";
            dgvCheckOut.Columns["NgayCheckIn"].HeaderText = "Ngày check-in";
            dgvCheckOut.Columns["NgayCheckOut"].HeaderText = "Ngày check-out";

            DataGridViewButtonColumn checkOutButton = new DataGridViewButtonColumn
            {
                Name = "CheckOut",
                Text = "Check-out",
                UseColumnTextForButtonValue = true,
                HeaderText = "Thao tác",
                FlatStyle = FlatStyle.Flat,
                DefaultCellStyle = { BackColor = Color.FromArgb(49, 130, 206), ForeColor = Color.White }
            };
            dgvCheckOut.Columns.Add(checkOutButton);
        }

        private void LoadComboBoxData()
        {
            // Lọc loại phòng (join sang LOAIPHONG để lấy tên)
            var roomTypesFilter = qlksDataSet.LOAIPHONG
                .Select(lp => lp.TenLoaiPhong)
                .Distinct()
                .ToList();
            roomTypesFilter.Insert(0, "Tất cả loại phòng");
            cmbFilterLoaiPhong.DataSource = roomTypesFilter;
            cmbFilterLoaiPhong.SelectedIndex = 0;

            // Lọc số phòng
            var roomNumbersFilter = qlksDataSet.PHONG
                .Select(p => p.SoPhong)
                .Distinct()
                .ToList();
            roomNumbersFilter.Insert(0, "Tất cả số phòng");
            cmbFilterSoPhong.DataSource = roomNumbersFilter;
            cmbFilterSoPhong.SelectedIndex = 0;
        }

        private void SetupEventHandlers()
        {
            dgvCheckOut.CellContentClick += DgvCheckOut_CellContentClick;
            btnXacNhan.Click += BtnXacNhan_Click;
            btnHuy.Click += BtnHuy_Click;
            cmbFilterLoaiPhong.SelectedIndexChanged += Filters_Changed;
            cmbFilterSoPhong.SelectedIndexChanged += Filters_Changed;
        }

        private void Filters_Changed(object sender, EventArgs e)
        {
            var query = from dp in qlksDataSet.DATPHONG
                        join kh in qlksDataSet.KHACHHANG on dp.MaKH equals kh.MaKH
                        join p in qlksDataSet.PHONG on dp.MaPhong equals p.MaPhong
                        join lp in qlksDataSet.LOAIPHONG on p.MaLoaiPhong equals lp.MaLoaiPhong
                        where dp.TrangThai == "Đã check-in"
                        select new
                        {
                            MaDatPhong = dp.MaDatPhong,
                            TenKhachHang = kh.HoTen,
                            SoPhong = p.SoPhong,
                            LoaiPhong = lp.TenLoaiPhong,
                            NgayCheckIn = dp.NgayCheckIn,
                            NgayCheckOut = dp.NgayCheckOut
                        };

            // Lọc loại phòng
            if (cmbFilterLoaiPhong.SelectedIndex > 0)
            {
                string selectedType = cmbFilterLoaiPhong.SelectedItem.ToString();
                query = query.Where(r => r.LoaiPhong == selectedType);
            }

            // Lọc số phòng
            if (cmbFilterSoPhong.SelectedIndex > 0)
            {
                string selectedRoom = cmbFilterSoPhong.SelectedItem.ToString();
                query = query.Where(r => r.SoPhong == selectedRoom);
            }

            bindingSource.DataSource = query.ToList();
            dgvCheckOut.DataSource = bindingSource;
        }

        private void DgvCheckOut_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            // Khi click vào dòng, hiển thị thông tin lên form
            string maDatPhong = dgvCheckOut.Rows[e.RowIndex].Cells["MaDatPhong"].Value.ToString();
            txtMaDatPhong.Text = maDatPhong;
            var datPhongRow = qlksDataSet.DATPHONG.FindByMaDatPhong(maDatPhong);
            if (datPhongRow != null)
            {
                dtpCheckOut.Value = datPhongRow.NgayCheckOut;
                txtGhiChuHuHong.Text = datPhongRow.IsGhiChuNull() ? "" : datPhongRow.GhiChu;
                txtGhiChuKhac.Text = datPhongRow.IsGhiChuNull() ? "" : datPhongRow.GhiChu;
            }
        }

        private void BtnXacNhan_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaDatPhong.Text))
            {
                MessageBox.Show("Vui lòng chọn mã đặt phòng từ danh sách.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string maDatPhong = txtMaDatPhong.Text;
            datPhongAdapter.Fill(qlksDataSet.DATPHONG); // Thêm dòng này để reload lại dữ liệu mới nhất, tránh lỗi concurrency
            var datPhongRow = qlksDataSet.DATPHONG.FindByMaDatPhong(maDatPhong);
            if (datPhongRow != null)
            {
                datPhongRow.NgayCheckOut = dtpCheckOut.Value;
                // Gộp ghi chú hư hỏng và ghi chú khác vào GhiChu
                string ghiChu = txtGhiChuHuHong.Text;
                if (!string.IsNullOrWhiteSpace(txtGhiChuKhac.Text))
                {
                    ghiChu += (string.IsNullOrWhiteSpace(ghiChu) ? "" : "\n") + txtGhiChuKhac.Text;
                }
                datPhongRow.GhiChu = ghiChu;
                datPhongRow.TrangThai = "Đã check-out";
                // Cập nhật trạng thái phòng về Trống
                var phongRow = qlksDataSet.PHONG.FindByMaPhong(datPhongRow.MaPhong);
                if (phongRow != null)
                {
                    phongRow.TrangThai = "Trống";
                }
                try
                {
                    datPhongAdapter.Update(qlksDataSet.DATPHONG);
                    phongAdapter.Update(qlksDataSet.PHONG);
                    qlksDataSet.AcceptChanges();
                    MessageBox.Show("Check-out thành công và đã lập hóa đơn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Hiển thị trang lập hóa đơn
                    var parent = this.Parent;
                    if (parent != null)
                    {
                        parent.Controls.Clear();
                        var uc = new ucLapHoaDon(maDatPhong);
                        uc.Dock = DockStyle.Fill;
                        parent.Controls.Add(uc);
                    }
                    //DisplayCheckOutData();
                    //ResetForm();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi check-out: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    qlksDataSet.RejectChanges();
                }
            }
        }

        private void BtnHuy_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void ResetForm()
        {
            txtMaDatPhong.Clear();
            dtpCheckOut.Value = DateTime.Now;
            txtGhiChuHuHong.Clear();
            txtGhiChuKhac.Clear();
        }
    }
} 