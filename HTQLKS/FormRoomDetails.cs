using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace HTQLKS
{
    public partial class FormRoomDetails : Form
    {
        public QLKSDataSet.PHONGRow PhongRow { get; private set; }
        public QLKSDataSet.LOAIPHONGRow LoaiPhongRow { get; private set; }
        private QLKSDataSet.LOAIPHONGDataTable loaiPhongTable;
        private bool isEditMode;

        private List<string> allAmenities = new List<string> { "Wi-Fi", "TV", "Điều hòa", "Minibar", "Bồn tắm", "Ban công", "Tủ lạnh", "Két sắt", "Bàn làm việc", "Máy pha cà phê" };
        private QLKSDataSet.HINHANH_PHONGDataTable hinhAnhPhongTable;
        private QLKSDataSetTableAdapters.HINHANH_PHONGTableAdapter hinhAnhPhongAdapter;
        private string selectedImagePath = null;

        public FormRoomDetails(QLKSDataSet.PHONGRow phongRow, QLKSDataSet.LOAIPHONGDataTable loaiPhongTable, QLKSDataSet.HINHANH_PHONGDataTable hinhAnhPhongTable = null, QLKSDataSetTableAdapters.HINHANH_PHONGTableAdapter hinhAnhPhongAdapter = null)
        {
            InitializeComponent();
            this.PhongRow = phongRow;
            this.loaiPhongTable = loaiPhongTable;
            this.hinhAnhPhongTable = hinhAnhPhongTable;
            this.hinhAnhPhongAdapter = hinhAnhPhongAdapter;
            this.isEditMode = (phongRow.RowState != DataRowState.Detached);
            SetupControls();
            if (isEditMode)
            {
                this.LoaiPhongRow = this.loaiPhongTable.FindByMaLoaiPhong(phongRow.MaLoaiPhong);
                LoadRoomData();
            }
            else
            {
                lblTitle.Text = "Thêm Phòng Mới";
            }
        }

        private void SetupControls()
        {
            // Populate LoaiPhong ComboBox
            cmbLoaiPhong.DataSource = loaiPhongTable;
            cmbLoaiPhong.DisplayMember = "TenLoaiPhong";
            cmbLoaiPhong.ValueMember = "MaLoaiPhong";
            cmbLoaiPhong.SelectedIndexChanged += CmbLoaiPhong_SelectedIndexChanged;

            // Populate TrangThai ComboBox
            cmbTrangThai.Items.AddRange(new string[] { "Trống", "Đang sử dụng", "Đang dọn", "Bảo trì" });

            // Populate Amenities
            foreach (var amenity in allAmenities)
            {
                CheckBox chk = new CheckBox
                {
                    Text = amenity,
                    Font = new Font("Poppins", 9),
                    ForeColor = Color.White,
                    Width = 150
                };
                flowTienNghi.Controls.Add(chk);
            }

            btnChonTep.Click += BtnChonTep_Click;

            // Trigger the selection change to load data for the initially selected room type
            if (cmbLoaiPhong.Items.Count > 0)
            {
                CmbLoaiPhong_SelectedIndexChanged(this, EventArgs.Empty);
            }
        }

        private void CmbLoaiPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbLoaiPhong.SelectedValue != null)
            {
                string selectedMaLoaiPhong = cmbLoaiPhong.SelectedValue.ToString();
                this.LoaiPhongRow = loaiPhongTable.FindByMaLoaiPhong(selectedMaLoaiPhong);
                LoadRoomTypeData(); // Always load data for the selected room type
            }
        }

        private void LoadRoomData()
        {
            lblTitle.Text = "Sửa thông tin phòng";
            txtMaPhong.Text = PhongRow.MaPhong;
            txtMaPhong.ReadOnly = true;
            cmbLoaiPhong.SelectedValue = PhongRow.MaLoaiPhong;
            cmbTrangThai.SelectedItem = PhongRow.TrangThai;
            numTang.Value = PhongRow.Tang;

            // The room type data is also loaded by the SelectedIndexChanged event, but we call it here again
            // to ensure it's loaded correctly when the form opens in edit mode.
            LoadRoomTypeData();
        }

        private void LoadRoomTypeData()
        {
            if (LoaiPhongRow == null) return;

            // FIX: The Is...Null() methods are not generated for non-nullable columns.
            // Access properties directly.
            txtGiaCoBan.Text = LoaiPhongRow.GiaPhong.ToString("N0");
            txtGiaCaoDiem.Text = LoaiPhongRow.GiaCaoDiem.ToString("N0");

            // These columns can be null, so we must check.
            txtMoTa.Text = LoaiPhongRow.IsMoTaNull() ? "" : LoaiPhongRow.MoTa;

            var amenities = LoaiPhongRow.IsTienNghiNull() ? new List<string>() : LoaiPhongRow.TienNghi.Split(',').Select(s => s.Trim()).ToList();
            foreach (CheckBox chk in flowTienNghi.Controls)
            {
                chk.Checked = amenities.Contains(chk.Text);
            }
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                try
                {
                    // Save PHONG data
                    PhongRow.BeginEdit();
                    if (!isEditMode)
                    {
                        PhongRow.MaPhong = txtMaPhong.Text.Trim();
                    }
                    PhongRow.SoPhong = txtMaPhong.Text.Trim();
                    PhongRow.MaLoaiPhong = cmbLoaiPhong.SelectedValue.ToString();
                    PhongRow.TrangThai = cmbTrangThai.SelectedItem.ToString();
                    PhongRow.Tang = (int)numTang.Value;
                    PhongRow.EndEdit();

                    // Save LOAIPHONG data
                    LoaiPhongRow.BeginEdit();
                    // We don't change MaLoaiPhong or TenLoaiPhong from this form, only its details.
                    LoaiPhongRow.GiaPhong = decimal.Parse(txtGiaCoBan.Text.Replace(",", ""));
                    LoaiPhongRow.GiaCaoDiem = decimal.Parse(txtGiaCaoDiem.Text.Replace(",", ""));
                    LoaiPhongRow.MoTa = txtMoTa.Text;
                    LoaiPhongRow.TienNghi = string.Join(", ", flowTienNghi.Controls.OfType<CheckBox>().Where(c => c.Checked).Select(c => c.Text));
                    LoaiPhongRow.EndEdit();

                    // Xử lý ảnh phòng
                    if (!string.IsNullOrWhiteSpace(selectedImagePath) && File.Exists(selectedImagePath))
                    {
                        string roomType = cmbLoaiPhong.Text.Replace(" ", "").ToLower();
                        string imagesDir = Path.Combine(Application.StartupPath, "images", "rooms", roomType);
                        if (!Directory.Exists(imagesDir))
                            Directory.CreateDirectory(imagesDir);
                        string fileName = Path.GetFileName(selectedImagePath);
                        string destPath = Path.Combine(imagesDir, fileName);
                        if (!File.Exists(destPath) || !File.ReadAllBytes(destPath).SequenceEqual(File.ReadAllBytes(selectedImagePath)))
                            File.Copy(selectedImagePath, destPath, true);
                        string dbPath = $"/images/rooms/{roomType}/{fileName}";
                        // Cập nhật vào bảng HINHANH_PHONG
                        if (hinhAnhPhongTable != null)
                        {
                            var hinhAnhRow = hinhAnhPhongTable.FirstOrDefault(h => h.MaLoaiPhong == cmbLoaiPhong.SelectedValue.ToString());
                            if (hinhAnhRow != null)
                            {
                                hinhAnhRow.LinkHinh = dbPath;
                            }
                            else
                            {
                                var newRow = hinhAnhPhongTable.NewHINHANH_PHONGRow();
                                newRow.MaLoaiPhong = cmbLoaiPhong.SelectedValue.ToString();
                                newRow.LinkHinh = dbPath;
                                newRow.GhiChu = "Ảnh phòng";
                                hinhAnhPhongTable.AddHINHANH_PHONGRow(newRow);
                            }
                            hinhAnhPhongAdapter?.Update(hinhAnhPhongTable);
                        }
                    }

                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                catch (Exception ex)
                {
                    if(PhongRow.HasErrors) PhongRow.CancelEdit();
                    if(LoaiPhongRow.HasErrors) LoaiPhongRow.CancelEdit();
                    MessageBox.Show("Lỗi khi lưu dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(txtMaPhong.Text))
            {
                MessageBox.Show("Mã phòng không được để trống.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (cmbLoaiPhong.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn loại phòng.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (cmbTrangThai.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn trạng thái.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!decimal.TryParse(txtGiaCoBan.Text, out _))
            {
                MessageBox.Show("Giá cơ bản không hợp lệ.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!decimal.TryParse(txtGiaCaoDiem.Text, out _))
            {
                MessageBox.Show("Giá cao điểm không hợp lệ.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void BtnChonTep_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    txtHinhAnh.Text = ofd.FileName;
                    selectedImagePath = ofd.FileName;
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
} 