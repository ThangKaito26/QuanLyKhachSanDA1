using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace HTQLKS
{
    public partial class ucLapHoaDon : UserControl
    {
        private QLKSDataSet qlksDataSet;
        private QLKSDataSetTableAdapters.DATPHONGTableAdapter datPhongAdapter;
        private QLKSDataSetTableAdapters.KHACHHANGTableAdapter khachHangAdapter;
        private QLKSDataSetTableAdapters.PHONGTableAdapter phongAdapter;
        private QLKSDataSetTableAdapters.SUDUNGDICHVUTableAdapter sudungDichVuAdapter;
        private QLKSDataSetTableAdapters.DICHVUTableAdapter dichVuAdapter;
        private string maDatPhong;
        private string paymentMethod = "cash";

        public ucLapHoaDon(string maDatPhong)
        {
            InitializeComponent();
            this.maDatPhong = maDatPhong;
            this.Load += ucLapHoaDon_Load;
        }

        private void ucLapHoaDon_Load(object sender, EventArgs e)
        {
            InitializeDataAccess();
            LoadInvoiceData();
            SetupPaymentMethodButtons();
            btnConfirmPayment.Click += BtnConfirmPayment_Click;
            btnExportPDF.Click += BtnExportPDF_Click;
        }

        private void InitializeDataAccess()
        {
            string connectionString = Properties.Settings.Default.QLKSConnectionString;
            qlksDataSet = new QLKSDataSet();
            datPhongAdapter = new QLKSDataSetTableAdapters.DATPHONGTableAdapter();
            khachHangAdapter = new QLKSDataSetTableAdapters.KHACHHANGTableAdapter();
            phongAdapter = new QLKSDataSetTableAdapters.PHONGTableAdapter();
            sudungDichVuAdapter = new QLKSDataSetTableAdapters.SUDUNGDICHVUTableAdapter();
            dichVuAdapter = new QLKSDataSetTableAdapters.DICHVUTableAdapter();
            datPhongAdapter.Fill(qlksDataSet.DATPHONG);
            khachHangAdapter.Fill(qlksDataSet.KHACHHANG);
            phongAdapter.Fill(qlksDataSet.PHONG);
            sudungDichVuAdapter.Fill(qlksDataSet.SUDUNGDICHVU);
            dichVuAdapter.Fill(qlksDataSet.DICHVU);
        }

        private void LoadInvoiceData()
        {
            var datPhongRow = qlksDataSet.DATPHONG.FindByMaDatPhong(maDatPhong);
            if (datPhongRow == null) return;
            var khachHangRow = qlksDataSet.KHACHHANG.FindByMaKH(datPhongRow.MaKH);
            var phongRow = qlksDataSet.PHONG.FindByMaPhong(datPhongRow.MaPhong);

            txtBookingId.Text = datPhongRow.MaDatPhong;
            txtCustomer.Text = khachHangRow?.HoTen ?? "";
            txtRoom.Text = phongRow?.SoPhong ?? "";
            txtCheckIn.Text = datPhongRow.NgayCheckIn.ToString("yyyy-MM-dd");
            txtCheckOut.Text = datPhongRow.NgayCheckOut.ToString("yyyy-MM-dd");

            // Tiền phòng
            decimal roomCharge = 0;
            if (phongRow != null)
            {
                var loaiPhongRow = qlksDataSet.LOAIPHONG.FindByMaLoaiPhong(phongRow.MaLoaiPhong);
                if (loaiPhongRow != null)
                    roomCharge = loaiPhongRow.GiaPhong;
            }
            txtRoomCharge.Text = roomCharge.ToString("N0");
            txtSurcharge.Text = "0";
            txtDiscount.Text = "0";

            // Dịch vụ đã sử dụng
            var dvQuery = from sdv in qlksDataSet.SUDUNGDICHVU
                          join dv in qlksDataSet.DICHVU on sdv.MaDV equals dv.MaDV
                          where sdv.MaDatPhong == maDatPhong
                          select new
                          {
                              TenDV = dv.TenDV,
                              SoLuong = sdv.SoLuong,
                              DonGia = dv.GiaDV,
                              ThanhTien = dv.GiaDV * sdv.SoLuong
                          };
            DataTable dt = new DataTable();
            dt.Columns.Add("DichVu");
            dt.Columns.Add("SoLuong");
            dt.Columns.Add("DonGia");
            dt.Columns.Add("ThanhTien");
            decimal totalService = 0;
            foreach (var item in dvQuery)
            {
                dt.Rows.Add(item.TenDV, item.SoLuong, item.DonGia.ToString("N0"), item.ThanhTien.ToString("N0"));
                totalService += item.ThanhTien;
            }
            dgvServices.DataSource = dt;

            // Tổng cộng
            decimal surcharge = 0, discount = 0;
            decimal.TryParse(txtSurcharge.Text, out surcharge);
            decimal.TryParse(txtDiscount.Text, out discount);
            decimal total = roomCharge + totalService + surcharge - discount;
            txtTotal.Text = total.ToString("N0");

            txtDiscount.TextChanged += (s, e) => UpdateTotal();
            txtSurcharge.TextChanged += (s, e) => UpdateTotal();
        }

        private void UpdateTotal()
        {
            decimal roomCharge = 0, surcharge = 0, discount = 0, totalService = 0;
            decimal.TryParse(txtRoomCharge.Text.Replace(",", ""), out roomCharge);
            decimal.TryParse(txtSurcharge.Text.Replace(",", ""), out surcharge);
            decimal.TryParse(txtDiscount.Text.Replace(",", ""), out discount);
            foreach (DataGridViewRow row in dgvServices.Rows)
            {
                decimal val = 0;
                decimal.TryParse(row.Cells["ThanhTien"].Value?.ToString().Replace(",", ""), out val);
                totalService += val;
            }
            decimal total = roomCharge + totalService + surcharge - discount;
            txtTotal.Text = total.ToString("N0");
        }

        private void SetupPaymentMethodButtons()
        {
            btnCash.Click += (s, e) => SelectPaymentMethod("cash");
            btnCard.Click += (s, e) => SelectPaymentMethod("card");
            btnTransfer.Click += (s, e) => SelectPaymentMethod("transfer");
        }

        private void SelectPaymentMethod(string method)
        {
            paymentMethod = method;
            btnCash.BackColor = method == "cash" ? Color.FromArgb(49, 130, 206) : Color.FromArgb(71, 85, 105);
            btnCard.BackColor = method == "card" ? Color.FromArgb(49, 130, 206) : Color.FromArgb(71, 85, 105);
            btnTransfer.BackColor = method == "transfer" ? Color.FromArgb(49, 130, 206) : Color.FromArgb(71, 85, 105);
        }

        private void BtnConfirmPayment_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thanh toán thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            // TODO: Lưu trạng thái hóa đơn, cập nhật DB nếu cần
        }

        private void BtnExportPDF_Click(object sender, EventArgs e)
        {
            // TODO: Thêm logic xuất PDF hóa đơn
            MessageBox.Show("Chức năng xuất PDF sẽ được bổ sung sau.", "Thông báo");
        }
    }
} 