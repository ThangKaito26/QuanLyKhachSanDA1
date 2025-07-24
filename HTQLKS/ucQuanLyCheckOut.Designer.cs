namespace HTQLKS
{
    partial class ucQuanLyCheckOut
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Panel pnlFilters;
        private System.Windows.Forms.TableLayoutPanel tblFilters;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.TextBox txtFilterTenKhach;
        private System.Windows.Forms.ComboBox cmbFilterLoaiPhong;
        private System.Windows.Forms.ComboBox cmbFilterSoPhong;
        private System.Windows.Forms.DateTimePicker dtpFilterNgayCheckOut;
        private System.Windows.Forms.DataGridView dgvCheckOut;
        private System.Windows.Forms.Panel pnlDetails;
        private System.Windows.Forms.Label lblDetailsTitle;
        private System.Windows.Forms.TableLayoutPanel pnlInputFields;
        private System.Windows.Forms.Label lblMaDatPhong;
        private System.Windows.Forms.TextBox txtMaDatPhong;
        private System.Windows.Forms.Label lblCheckOutTime;
        private System.Windows.Forms.DateTimePicker dtpCheckOut;
        private System.Windows.Forms.Label lblGhiChuHuHong;
        private System.Windows.Forms.TextBox txtGhiChuHuHong;
        private System.Windows.Forms.Label lblGhiChuKhac;
        private System.Windows.Forms.TextBox txtGhiChuKhac;
        private System.Windows.Forms.Button btnXacNhan;
        private System.Windows.Forms.Button btnHuy;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.dgvCheckOut = new System.Windows.Forms.DataGridView();
            this.pnlDetails = new System.Windows.Forms.Panel();
            this.btnXacNhan = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.pnlInputFields = new System.Windows.Forms.TableLayoutPanel();
            this.lblMaDatPhong = new System.Windows.Forms.Label();
            this.txtMaDatPhong = new System.Windows.Forms.TextBox();
            this.lblCheckOutTime = new System.Windows.Forms.Label();
            this.dtpCheckOut = new System.Windows.Forms.DateTimePicker();
            this.lblGhiChuHuHong = new System.Windows.Forms.Label();
            this.txtGhiChuHuHong = new System.Windows.Forms.TextBox();
            this.lblGhiChuKhac = new System.Windows.Forms.Label();
            this.txtGhiChuKhac = new System.Windows.Forms.TextBox();
            this.lblDetailsTitle = new System.Windows.Forms.Label();
            this.pnlFilters = new System.Windows.Forms.Panel();
            this.tblFilters = new System.Windows.Forms.TableLayoutPanel();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.txtFilterTenKhach = new System.Windows.Forms.TextBox();
            this.cmbFilterLoaiPhong = new System.Windows.Forms.ComboBox();
            this.cmbFilterSoPhong = new System.Windows.Forms.ComboBox();
            this.dtpFilterNgayCheckOut = new System.Windows.Forms.DateTimePicker();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.btnExport = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCheckOut)).BeginInit();
            this.pnlDetails.SuspendLayout();
            this.pnlInputFields.SuspendLayout();
            this.pnlFilters.SuspendLayout();
            this.tblFilters.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.FromArgb(45, 55, 72);
            this.pnlMain.Controls.Add(this.dgvCheckOut);
            this.pnlMain.Controls.Add(this.pnlDetails);
            this.pnlMain.Controls.Add(this.pnlFilters);
            this.pnlMain.Controls.Add(this.pnlHeader);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Padding = new System.Windows.Forms.Padding(27, 25, 27, 25);
            this.pnlMain.Size = new System.Drawing.Size(1352, 897);
            this.pnlMain.TabIndex = 0;
            // 
            // dgvCheckOut
            // 
            this.dgvCheckOut.AllowUserToAddRows = false;
            this.dgvCheckOut.AllowUserToDeleteRows = false;
            this.dgvCheckOut.AllowUserToResizeRows = false;
            this.dgvCheckOut.BackgroundColor = System.Drawing.Color.FromArgb(26, 32, 44);
            this.dgvCheckOut.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCheckOut.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvCheckOut.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(45, 55, 72);
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(45, 55, 72);
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCheckOut.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCheckOut.ColumnHeadersHeight = 40;
            this.dgvCheckOut.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(26, 32, 44);
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(49, 130, 206);
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCheckOut.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCheckOut.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCheckOut.EnableHeadersVisualStyles = false;
            this.dgvCheckOut.GridColor = System.Drawing.Color.FromArgb(45, 55, 72);
            this.dgvCheckOut.Location = new System.Drawing.Point(27, 167);
            this.dgvCheckOut.Name = "dgvCheckOut";
            this.dgvCheckOut.ReadOnly = true;
            this.dgvCheckOut.RowHeadersVisible = false;
            this.dgvCheckOut.RowHeadersWidth = 51;
            this.dgvCheckOut.RowTemplate.Height = 35;
            this.dgvCheckOut.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCheckOut.Size = new System.Drawing.Size(1298, 386);
            this.dgvCheckOut.TabIndex = 2;
            this.dgvCheckOut.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            // 
            // pnlDetails
            // 
            this.pnlDetails.BackColor = System.Drawing.Color.FromArgb(26, 32, 44);
            this.pnlDetails.Controls.Add(this.btnXacNhan);
            this.pnlDetails.Controls.Add(this.btnHuy);
            this.pnlDetails.Controls.Add(this.pnlInputFields);
            this.pnlDetails.Controls.Add(this.lblDetailsTitle);
            this.pnlDetails.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlDetails.Location = new System.Drawing.Point(27, 553);
            this.pnlDetails.Name = "pnlDetails";
            this.pnlDetails.Padding = new System.Windows.Forms.Padding(27, 25, 27, 25);
            this.pnlDetails.Size = new System.Drawing.Size(1298, 319);
            this.pnlDetails.TabIndex = 3;
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXacNhan.BackColor = System.Drawing.Color.FromArgb(49, 130, 206);
            this.btnXacNhan.FlatAppearance.BorderSize = 0;
            this.btnXacNhan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXacNhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnXacNhan.ForeColor = System.Drawing.Color.White;
            this.btnXacNhan.Location = new System.Drawing.Point(1063, 255);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(200, 43);
            this.btnXacNhan.TabIndex = 3;
            this.btnXacNhan.Text = "Xác nhận Check-out";
            this.btnXacNhan.UseVisualStyleBackColor = false;
            // 
            // btnHuy
            // 
            this.btnHuy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHuy.BackColor = System.Drawing.Color.FromArgb(71, 85, 105);
            this.btnHuy.FlatAppearance.BorderSize = 0;
            this.btnHuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnHuy.ForeColor = System.Drawing.Color.White;
            this.btnHuy.Location = new System.Drawing.Point(908, 255);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(147, 43);
            this.btnHuy.TabIndex = 2;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = false;
            // 
            // pnlInputFields
            // 
            this.pnlInputFields.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlInputFields.ColumnCount = 4;
            this.pnlInputFields.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 160F));
            this.pnlInputFields.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.pnlInputFields.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 160F));
            this.pnlInputFields.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.pnlInputFields.Controls.Add(this.lblMaDatPhong, 0, 0);
            this.pnlInputFields.Controls.Add(this.txtMaDatPhong, 1, 0);
            this.pnlInputFields.Controls.Add(this.lblCheckOutTime, 2, 0);
            this.pnlInputFields.Controls.Add(this.dtpCheckOut, 3, 0);
            this.pnlInputFields.Controls.Add(this.lblGhiChuHuHong, 0, 1);
            this.pnlInputFields.Controls.Add(this.txtGhiChuHuHong, 1, 1);
            this.pnlInputFields.Controls.Add(this.lblGhiChuKhac, 0, 2);
            this.pnlInputFields.Controls.Add(this.txtGhiChuKhac, 1, 2);
            this.pnlInputFields.Controls.Add(new System.Windows.Forms.Label(), 2, 1);
            this.pnlInputFields.Controls.Add(new System.Windows.Forms.Label(), 2, 2);
            this.pnlInputFields.Controls.Add(new System.Windows.Forms.Label(), 3, 1);
            this.pnlInputFields.Controls.Add(new System.Windows.Forms.Label(), 3, 2);
            this.pnlInputFields.Location = new System.Drawing.Point(27, 62);
            this.pnlInputFields.Name = "pnlInputFields";
            this.pnlInputFields.RowCount = 3;
            this.pnlInputFields.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.pnlInputFields.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.pnlInputFields.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34F));
            this.pnlInputFields.Size = new System.Drawing.Size(1244, 150);
            this.pnlInputFields.TabIndex = 1;
            // 
            // lblMaDatPhong
            // 
            this.lblMaDatPhong.AutoSize = true;
            this.lblMaDatPhong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMaDatPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lblMaDatPhong.ForeColor = System.Drawing.Color.White;
            this.lblMaDatPhong.Location = new System.Drawing.Point(4, 0);
            this.lblMaDatPhong.Name = "lblMaDatPhong";
            this.lblMaDatPhong.Size = new System.Drawing.Size(152, 49);
            this.lblMaDatPhong.TabIndex = 0;
            this.lblMaDatPhong.Text = "Mã đặt phòng";
            this.lblMaDatPhong.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtMaDatPhong
            // 
            this.txtMaDatPhong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMaDatPhong.BackColor = System.Drawing.Color.FromArgb(71, 85, 105);
            this.txtMaDatPhong.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMaDatPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtMaDatPhong.ForeColor = System.Drawing.Color.White;
            this.txtMaDatPhong.Location = new System.Drawing.Point(164, 11);
            this.txtMaDatPhong.Name = "txtMaDatPhong";
            this.txtMaDatPhong.ReadOnly = true;
            this.txtMaDatPhong.Size = new System.Drawing.Size(454, 26);
            this.txtMaDatPhong.TabIndex = 1;
            // 
            // lblCheckOutTime
            // 
            this.lblCheckOutTime.AutoSize = true;
            this.lblCheckOutTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCheckOutTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lblCheckOutTime.ForeColor = System.Drawing.Color.White;
            this.lblCheckOutTime.Location = new System.Drawing.Point(626, 0);
            this.lblCheckOutTime.Name = "lblCheckOutTime";
            this.lblCheckOutTime.Size = new System.Drawing.Size(152, 49);
            this.lblCheckOutTime.TabIndex = 2;
            this.lblCheckOutTime.Text = "Thời gian check-out";
            this.lblCheckOutTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dtpCheckOut
            // 
            this.dtpCheckOut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpCheckOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.dtpCheckOut.Location = new System.Drawing.Point(786, 11);
            this.dtpCheckOut.Name = "dtpCheckOut";
            this.dtpCheckOut.Size = new System.Drawing.Size(454, 26);
            this.dtpCheckOut.TabIndex = 3;
            // 
            // lblGhiChuHuHong
            // 
            this.lblGhiChuHuHong.AutoSize = true;
            this.lblGhiChuHuHong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblGhiChuHuHong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lblGhiChuHuHong.ForeColor = System.Drawing.Color.White;
            this.lblGhiChuHuHong.Location = new System.Drawing.Point(4, 49);
            this.lblGhiChuHuHong.Name = "lblGhiChuHuHong";
            this.lblGhiChuHuHong.Size = new System.Drawing.Size(152, 49);
            this.lblGhiChuHuHong.TabIndex = 4;
            this.lblGhiChuHuHong.Text = "Ghi chú hư hỏng";
            this.lblGhiChuHuHong.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtGhiChuHuHong
            // 
            this.txtGhiChuHuHong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtGhiChuHuHong.BackColor = System.Drawing.Color.FromArgb(71, 85, 105);
            this.txtGhiChuHuHong.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtGhiChuHuHong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtGhiChuHuHong.ForeColor = System.Drawing.Color.White;
            this.txtGhiChuHuHong.Location = new System.Drawing.Point(164, 60);
            this.txtGhiChuHuHong.Name = "txtGhiChuHuHong";
            this.txtGhiChuHuHong.Size = new System.Drawing.Size(454, 26);
            this.txtGhiChuHuHong.TabIndex = 5;
            // 
            // lblGhiChuKhac
            // 
            this.lblGhiChuKhac.AutoSize = true;
            this.lblGhiChuKhac.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblGhiChuKhac.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lblGhiChuKhac.ForeColor = System.Drawing.Color.White;
            this.lblGhiChuKhac.Location = new System.Drawing.Point(4, 98);
            this.lblGhiChuKhac.Name = "lblGhiChuKhac";
            this.lblGhiChuKhac.Size = new System.Drawing.Size(152, 52);
            this.lblGhiChuKhac.TabIndex = 6;
            this.lblGhiChuKhac.Text = "Ghi chú khác";
            this.lblGhiChuKhac.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtGhiChuKhac
            // 
            this.txtGhiChuKhac.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtGhiChuKhac.BackColor = System.Drawing.Color.FromArgb(71, 85, 105);
            this.txtGhiChuKhac.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtGhiChuKhac.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtGhiChuKhac.ForeColor = System.Drawing.Color.White;
            this.txtGhiChuKhac.Location = new System.Drawing.Point(164, 109);
            this.txtGhiChuKhac.Name = "txtGhiChuKhac";
            this.txtGhiChuKhac.Size = new System.Drawing.Size(454, 26);
            this.txtGhiChuKhac.TabIndex = 7;
            // 
            // lblDetailsTitle
            // 
            this.lblDetailsTitle.AutoSize = true;
            this.lblDetailsTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblDetailsTitle.ForeColor = System.Drawing.Color.White;
            this.lblDetailsTitle.Location = new System.Drawing.Point(31, 18);
            this.lblDetailsTitle.Name = "lblDetailsTitle";
            this.lblDetailsTitle.Size = new System.Drawing.Size(217, 25);
            this.lblDetailsTitle.TabIndex = 0;
            this.lblDetailsTitle.Text = "Thông tin Check-out";
            // 
            // pnlFilters
            // 
            this.pnlFilters.BackColor = System.Drawing.Color.FromArgb(26, 32, 44);
            this.pnlFilters.Controls.Add(this.tblFilters);
            this.pnlFilters.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFilters.Location = new System.Drawing.Point(27, 87);
            this.pnlFilters.Name = "pnlFilters";
            this.pnlFilters.Padding = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.pnlFilters.Size = new System.Drawing.Size(1298, 80);
            this.pnlFilters.TabIndex = 1;
            // 
            // tblFilters
            // 
            this.tblFilters.ColumnCount = 5;
            this.tblFilters.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblFilters.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblFilters.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tblFilters.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tblFilters.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblFilters.Controls.Add(this.txtSearch, 0, 0);
            this.tblFilters.Controls.Add(this.txtFilterTenKhach, 1, 0);
            this.tblFilters.Controls.Add(this.cmbFilterLoaiPhong, 2, 0);
            this.tblFilters.Controls.Add(this.cmbFilterSoPhong, 3, 0);
            this.tblFilters.Controls.Add(this.dtpFilterNgayCheckOut, 4, 0);
            this.tblFilters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblFilters.Location = new System.Drawing.Point(13, 12);
            this.tblFilters.Name = "tblFilters";
            this.tblFilters.RowCount = 1;
            this.tblFilters.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblFilters.Size = new System.Drawing.Size(1272, 56);
            this.tblFilters.TabIndex = 0;
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.BackColor = System.Drawing.Color.FromArgb(71, 85, 105);
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtSearch.ForeColor = System.Drawing.Color.White;
            this.txtSearch.Location = new System.Drawing.Point(3, 15);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(311, 26);
            this.txtSearch.TabIndex = 0;
            // 
            // txtFilterTenKhach
            // 
            this.txtFilterTenKhach.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFilterTenKhach.BackColor = System.Drawing.Color.FromArgb(71, 85, 105);
            this.txtFilterTenKhach.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFilterTenKhach.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtFilterTenKhach.ForeColor = System.Drawing.Color.White;
            this.txtFilterTenKhach.Location = new System.Drawing.Point(320, 15);
            this.txtFilterTenKhach.Name = "txtFilterTenKhach";
            this.txtFilterTenKhach.Size = new System.Drawing.Size(311, 26);
            this.txtFilterTenKhach.TabIndex = 1;
            // 
            // cmbFilterLoaiPhong
            // 
            this.cmbFilterLoaiPhong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbFilterLoaiPhong.BackColor = System.Drawing.Color.FromArgb(71, 85, 105);
            this.cmbFilterLoaiPhong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbFilterLoaiPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.cmbFilterLoaiPhong.ForeColor = System.Drawing.Color.White;
            this.cmbFilterLoaiPhong.FormattingEnabled = true;
            this.cmbFilterLoaiPhong.Location = new System.Drawing.Point(637, 14);
            this.cmbFilterLoaiPhong.Name = "cmbFilterLoaiPhong";
            this.cmbFilterLoaiPhong.Size = new System.Drawing.Size(184, 28);
            this.cmbFilterLoaiPhong.TabIndex = 2;
            // 
            // cmbFilterSoPhong
            // 
            this.cmbFilterSoPhong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbFilterSoPhong.BackColor = System.Drawing.Color.FromArgb(71, 85, 105);
            this.cmbFilterSoPhong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbFilterSoPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.cmbFilterSoPhong.ForeColor = System.Drawing.Color.White;
            this.cmbFilterSoPhong.FormattingEnabled = true;
            this.cmbFilterSoPhong.Location = new System.Drawing.Point(827, 14);
            this.cmbFilterSoPhong.Name = "cmbFilterSoPhong";
            this.cmbFilterSoPhong.Size = new System.Drawing.Size(184, 28);
            this.cmbFilterSoPhong.TabIndex = 3;
            // 
            // dtpFilterNgayCheckOut
            // 
            this.dtpFilterNgayCheckOut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpFilterNgayCheckOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.dtpFilterNgayCheckOut.Location = new System.Drawing.Point(1017, 15);
            this.dtpFilterNgayCheckOut.Name = "dtpFilterNgayCheckOut";
            this.dtpFilterNgayCheckOut.Size = new System.Drawing.Size(252, 26);
            this.dtpFilterNgayCheckOut.TabIndex = 4;
            // 
            // pnlHeader
            // 
            this.pnlHeader.Controls.Add(this.btnExport);
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(27, 25);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1298, 62);
            this.pnlHeader.TabIndex = 0;
            // 
            // btnExport
            // 
            this.btnExport.BackColor = System.Drawing.Color.FromArgb(49, 130, 206);
            this.btnExport.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnExport.FlatAppearance.BorderSize = 0;
            this.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExport.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnExport.ForeColor = System.Drawing.Color.White;
            this.btnExport.Location = new System.Drawing.Point(1098, 0);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(200, 62);
            this.btnExport.TabIndex = 1;
            this.btnExport.Text = "Xuất báo cáo";
            this.btnExport.UseVisualStyleBackColor = false;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(238, 31);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Quản lý Check-out";
            // 
            // ucQuanLyCheckOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlMain);
            this.Name = "ucQuanLyCheckOut";
            this.Size = new System.Drawing.Size(1352, 897);
            this.pnlMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCheckOut)).EndInit();
            this.pnlDetails.ResumeLayout(false);
            this.pnlDetails.PerformLayout();
            this.pnlInputFields.ResumeLayout(false);
            this.pnlInputFields.PerformLayout();
            this.pnlFilters.ResumeLayout(false);
            this.tblFilters.ResumeLayout(false);
            this.tblFilters.PerformLayout();
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.ResumeLayout(false);
        }
    }
} 