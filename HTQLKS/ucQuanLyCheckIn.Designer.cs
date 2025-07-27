namespace HTQLKS
{
    partial class ucQuanLyCheckIn
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.dgvCheckIn = new System.Windows.Forms.DataGridView();
            this.pnlDetails = new System.Windows.Forms.Panel();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.pnlInputFields = new System.Windows.Forms.TableLayoutPanel();
            this.lblMaDatPhong = new System.Windows.Forms.Label();
            this.txtMaDatPhong = new System.Windows.Forms.TextBox();
            this.lblTenKhach = new System.Windows.Forms.Label();
            this.txtTenKhach = new System.Windows.Forms.TextBox();
            this.cmbTenKhach = new System.Windows.Forms.ComboBox();
            this.lblCCCD = new System.Windows.Forms.Label();
            this.txtCCCD = new System.Windows.Forms.TextBox();
            this.lblSDT = new System.Windows.Forms.Label();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.lblNgayCheckIn = new System.Windows.Forms.Label();
            this.dtpNgayCheckIn = new System.Windows.Forms.DateTimePicker();
            this.lblLoaiPhong = new System.Windows.Forms.Label();
            this.cmbLoaiPhong = new System.Windows.Forms.ComboBox();
            this.lblSoPhong = new System.Windows.Forms.Label();
            this.cmbSoPhong = new System.Windows.Forms.ComboBox();
            this.lblDetailsTitle = new System.Windows.Forms.Label();
            this.pnlFilters = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.cmbFilterSoPhong = new System.Windows.Forms.ComboBox();
            this.cmbFilterLoaiPhong = new System.Windows.Forms.ComboBox();
            this.dtpFilterNgayDen = new System.Windows.Forms.DateTimePicker();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCheckIn)).BeginInit();
            this.pnlDetails.SuspendLayout();
            this.pnlInputFields.SuspendLayout();
            this.pnlFilters.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(72)))));
            this.pnlMain.Controls.Add(this.dgvCheckIn);
            this.pnlMain.Controls.Add(this.pnlDetails);
            this.pnlMain.Controls.Add(this.pnlFilters);
            this.pnlMain.Controls.Add(this.pnlHeader);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Margin = new System.Windows.Forms.Padding(4);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Padding = new System.Windows.Forms.Padding(27, 25, 27, 25);
            this.pnlMain.Size = new System.Drawing.Size(1352, 897);
            this.pnlMain.TabIndex = 0;
            // 
            // dgvCheckIn
            // 
            this.dgvCheckIn.AllowUserToAddRows = false;
            this.dgvCheckIn.AllowUserToDeleteRows = false;
            this.dgvCheckIn.AllowUserToResizeRows = false;
            this.dgvCheckIn.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(44)))));
            this.dgvCheckIn.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCheckIn.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvCheckIn.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCheckIn.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCheckIn.ColumnHeadersHeight = 40;
            this.dgvCheckIn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(44)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(130)))), ((int)(((byte)(206)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCheckIn.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCheckIn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCheckIn.EnableHeadersVisualStyles = false;
            this.dgvCheckIn.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(72)))));
            this.dgvCheckIn.Location = new System.Drawing.Point(27, 167);
            this.dgvCheckIn.Margin = new System.Windows.Forms.Padding(4);
            this.dgvCheckIn.Name = "dgvCheckIn";
            this.dgvCheckIn.ReadOnly = true;
            this.dgvCheckIn.RowHeadersVisible = false;
            this.dgvCheckIn.RowHeadersWidth = 51;
            this.dgvCheckIn.RowTemplate.Height = 35;
            this.dgvCheckIn.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCheckIn.Size = new System.Drawing.Size(1298, 386);
            this.dgvCheckIn.TabIndex = 2;
            // 
            // pnlDetails
            // 
            this.pnlDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(44)))));
            this.pnlDetails.Controls.Add(this.btnConfirm);
            this.pnlDetails.Controls.Add(this.btnCancel);
            this.pnlDetails.Controls.Add(this.pnlInputFields);
            this.pnlDetails.Controls.Add(this.lblDetailsTitle);
            this.pnlDetails.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlDetails.Location = new System.Drawing.Point(27, 553);
            this.pnlDetails.Margin = new System.Windows.Forms.Padding(4);
            this.pnlDetails.Name = "pnlDetails";
            this.pnlDetails.Padding = new System.Windows.Forms.Padding(27, 25, 27, 25);
            this.pnlDetails.Size = new System.Drawing.Size(1298, 319);
            this.pnlDetails.TabIndex = 3;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConfirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(130)))), ((int)(((byte)(206)))));
            this.btnConfirm.FlatAppearance.BorderSize = 0;
            this.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.ForeColor = System.Drawing.Color.White;
            this.btnConfirm.Location = new System.Drawing.Point(1063, 255);
            this.btnConfirm.Margin = new System.Windows.Forms.Padding(4);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(200, 43);
            this.btnConfirm.TabIndex = 3;
            this.btnConfirm.Text = "Xác nhận Check-in";
            this.btnConfirm.UseVisualStyleBackColor = false;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(908, 255);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(147, 43);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.UseVisualStyleBackColor = false;
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
            this.pnlInputFields.Controls.Add(this.lblTenKhach, 2, 0);
            this.pnlInputFields.Controls.Add(this.txtTenKhach, 3, 0);
            this.pnlInputFields.Controls.Add(this.cmbTenKhach, 3, 0);
            this.pnlInputFields.Controls.Add(this.lblCCCD, 0, 1);
            this.pnlInputFields.Controls.Add(this.txtCCCD, 1, 1);
            this.pnlInputFields.Controls.Add(this.lblSDT, 2, 1);
            this.pnlInputFields.Controls.Add(this.txtSDT, 3, 1);
            this.pnlInputFields.Controls.Add(this.lblNgayCheckIn, 0, 2);
            this.pnlInputFields.Controls.Add(this.dtpNgayCheckIn, 1, 2);
            this.pnlInputFields.Controls.Add(this.lblLoaiPhong, 2, 2);
            this.pnlInputFields.Controls.Add(this.cmbLoaiPhong, 3, 2);
            this.pnlInputFields.Controls.Add(this.lblSoPhong, 0, 3);
            this.pnlInputFields.Controls.Add(this.cmbSoPhong, 1, 3);
            this.pnlInputFields.Location = new System.Drawing.Point(27, 62);
            this.pnlInputFields.Margin = new System.Windows.Forms.Padding(4);
            this.pnlInputFields.Name = "pnlInputFields";
            this.pnlInputFields.RowCount = 4;
            this.pnlInputFields.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.pnlInputFields.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.pnlInputFields.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.pnlInputFields.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.pnlInputFields.Size = new System.Drawing.Size(1244, 185);
            this.pnlInputFields.TabIndex = 1;
            // 
            // lblMaDatPhong
            // 
            this.lblMaDatPhong.AutoSize = true;
            this.lblMaDatPhong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMaDatPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lblMaDatPhong.ForeColor = System.Drawing.Color.White;
            this.lblMaDatPhong.Location = new System.Drawing.Point(4, 0);
            this.lblMaDatPhong.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMaDatPhong.Name = "lblMaDatPhong";
            this.lblMaDatPhong.Size = new System.Drawing.Size(152, 46);
            this.lblMaDatPhong.TabIndex = 0;
            this.lblMaDatPhong.Text = "Mã đặt phòng";
            this.lblMaDatPhong.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtMaDatPhong
            // 
            this.txtMaDatPhong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMaDatPhong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.txtMaDatPhong.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMaDatPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtMaDatPhong.ForeColor = System.Drawing.Color.White;
            this.txtMaDatPhong.Location = new System.Drawing.Point(164, 10);
            this.txtMaDatPhong.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaDatPhong.Name = "txtMaDatPhong";
            this.txtMaDatPhong.ReadOnly = true;
            this.txtMaDatPhong.Size = new System.Drawing.Size(454, 26);
            this.txtMaDatPhong.TabIndex = 1;
            // 
            // lblTenKhach
            // 
            this.lblTenKhach.AutoSize = true;
            this.lblTenKhach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTenKhach.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lblTenKhach.ForeColor = System.Drawing.Color.White;
            this.lblTenKhach.Location = new System.Drawing.Point(626, 0);
            this.lblTenKhach.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTenKhach.Name = "lblTenKhach";
            this.lblTenKhach.Size = new System.Drawing.Size(152, 46);
            this.lblTenKhach.TabIndex = 2;
            this.lblTenKhach.Text = "Tên khách hàng";
            this.lblTenKhach.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtTenKhach
            // 
            this.txtTenKhach.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTenKhach.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.txtTenKhach.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTenKhach.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtTenKhach.ForeColor = System.Drawing.Color.White;
            this.txtTenKhach.Location = new System.Drawing.Point(4, 56);
            this.txtTenKhach.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenKhach.Name = "txtTenKhach";
            this.txtTenKhach.Size = new System.Drawing.Size(152, 26);
            this.txtTenKhach.TabIndex = 3;
            // 
            // cmbTenKhach
            // 
            this.cmbTenKhach.Location = new System.Drawing.Point(785, 3);
            this.cmbTenKhach.Name = "cmbTenKhach";
            this.cmbTenKhach.Size = new System.Drawing.Size(121, 24);
            this.cmbTenKhach.TabIndex = 4;
            this.cmbTenKhach.Visible = false;
            // 
            // lblCCCD
            // 
            this.lblCCCD.AutoSize = true;
            this.lblCCCD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCCCD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lblCCCD.ForeColor = System.Drawing.Color.White;
            this.lblCCCD.Location = new System.Drawing.Point(164, 46);
            this.lblCCCD.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCCCD.Name = "lblCCCD";
            this.lblCCCD.Size = new System.Drawing.Size(454, 46);
            this.lblCCCD.TabIndex = 4;
            this.lblCCCD.Text = "CCCD";
            this.lblCCCD.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtCCCD
            // 
            this.txtCCCD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCCCD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.txtCCCD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCCCD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtCCCD.ForeColor = System.Drawing.Color.White;
            this.txtCCCD.Location = new System.Drawing.Point(626, 56);
            this.txtCCCD.Margin = new System.Windows.Forms.Padding(4);
            this.txtCCCD.Name = "txtCCCD";
            this.txtCCCD.Size = new System.Drawing.Size(152, 26);
            this.txtCCCD.TabIndex = 5;
            // 
            // lblSDT
            // 
            this.lblSDT.AutoSize = true;
            this.lblSDT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lblSDT.ForeColor = System.Drawing.Color.White;
            this.lblSDT.Location = new System.Drawing.Point(786, 46);
            this.lblSDT.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSDT.Name = "lblSDT";
            this.lblSDT.Size = new System.Drawing.Size(454, 46);
            this.lblSDT.TabIndex = 6;
            this.lblSDT.Text = "Số điện thoại";
            this.lblSDT.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtSDT
            // 
            this.txtSDT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSDT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.txtSDT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtSDT.ForeColor = System.Drawing.Color.White;
            this.txtSDT.Location = new System.Drawing.Point(4, 102);
            this.txtSDT.Margin = new System.Windows.Forms.Padding(4);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(152, 26);
            this.txtSDT.TabIndex = 7;
            // 
            // lblNgayCheckIn
            // 
            this.lblNgayCheckIn.AutoSize = true;
            this.lblNgayCheckIn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNgayCheckIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lblNgayCheckIn.ForeColor = System.Drawing.Color.White;
            this.lblNgayCheckIn.Location = new System.Drawing.Point(164, 92);
            this.lblNgayCheckIn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNgayCheckIn.Name = "lblNgayCheckIn";
            this.lblNgayCheckIn.Size = new System.Drawing.Size(454, 46);
            this.lblNgayCheckIn.TabIndex = 8;
            this.lblNgayCheckIn.Text = "Ngày check-in";
            this.lblNgayCheckIn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dtpNgayCheckIn
            // 
            this.dtpNgayCheckIn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpNgayCheckIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.dtpNgayCheckIn.Location = new System.Drawing.Point(626, 102);
            this.dtpNgayCheckIn.Margin = new System.Windows.Forms.Padding(4);
            this.dtpNgayCheckIn.Name = "dtpNgayCheckIn";
            this.dtpNgayCheckIn.Size = new System.Drawing.Size(152, 26);
            this.dtpNgayCheckIn.TabIndex = 9;
            // 
            // lblLoaiPhong
            // 
            this.lblLoaiPhong.AutoSize = true;
            this.lblLoaiPhong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblLoaiPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lblLoaiPhong.ForeColor = System.Drawing.Color.White;
            this.lblLoaiPhong.Location = new System.Drawing.Point(786, 92);
            this.lblLoaiPhong.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLoaiPhong.Name = "lblLoaiPhong";
            this.lblLoaiPhong.Size = new System.Drawing.Size(454, 46);
            this.lblLoaiPhong.TabIndex = 10;
            this.lblLoaiPhong.Text = "Loại phòng";
            this.lblLoaiPhong.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbLoaiPhong
            // 
            this.cmbLoaiPhong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbLoaiPhong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.cmbLoaiPhong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbLoaiPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.cmbLoaiPhong.ForeColor = System.Drawing.Color.White;
            this.cmbLoaiPhong.FormattingEnabled = true;
            this.cmbLoaiPhong.Location = new System.Drawing.Point(4, 147);
            this.cmbLoaiPhong.Margin = new System.Windows.Forms.Padding(4);
            this.cmbLoaiPhong.Name = "cmbLoaiPhong";
            this.cmbLoaiPhong.Size = new System.Drawing.Size(152, 28);
            this.cmbLoaiPhong.TabIndex = 11;
            // 
            // lblSoPhong
            // 
            this.lblSoPhong.AutoSize = true;
            this.lblSoPhong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSoPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lblSoPhong.ForeColor = System.Drawing.Color.White;
            this.lblSoPhong.Location = new System.Drawing.Point(164, 138);
            this.lblSoPhong.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSoPhong.Name = "lblSoPhong";
            this.lblSoPhong.Size = new System.Drawing.Size(454, 47);
            this.lblSoPhong.TabIndex = 12;
            this.lblSoPhong.Text = "Số phòng";
            this.lblSoPhong.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbSoPhong
            // 
            this.cmbSoPhong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbSoPhong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.cmbSoPhong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbSoPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.cmbSoPhong.ForeColor = System.Drawing.Color.White;
            this.cmbSoPhong.FormattingEnabled = true;
            this.cmbSoPhong.Location = new System.Drawing.Point(626, 147);
            this.cmbSoPhong.Margin = new System.Windows.Forms.Padding(4);
            this.cmbSoPhong.Name = "cmbSoPhong";
            this.cmbSoPhong.Size = new System.Drawing.Size(152, 28);
            this.cmbSoPhong.TabIndex = 13;
            // 
            // lblDetailsTitle
            // 
            this.lblDetailsTitle.AutoSize = true;
            this.lblDetailsTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetailsTitle.ForeColor = System.Drawing.Color.White;
            this.lblDetailsTitle.Location = new System.Drawing.Point(31, 18);
            this.lblDetailsTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDetailsTitle.Name = "lblDetailsTitle";
            this.lblDetailsTitle.Size = new System.Drawing.Size(196, 25);
            this.lblDetailsTitle.TabIndex = 0;
            this.lblDetailsTitle.Text = "Thông tin Check-in";
            // 
            // pnlFilters
            // 
            this.pnlFilters.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(44)))));
            this.pnlFilters.Controls.Add(this.tableLayoutPanel1);
            this.pnlFilters.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFilters.Location = new System.Drawing.Point(27, 87);
            this.pnlFilters.Margin = new System.Windows.Forms.Padding(4);
            this.pnlFilters.Name = "pnlFilters";
            this.pnlFilters.Padding = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.pnlFilters.Size = new System.Drawing.Size(1298, 80);
            this.pnlFilters.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.txtSearch, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.cmbFilterSoPhong, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.cmbFilterLoaiPhong, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.dtpFilterNgayDen, 3, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(13, 12);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1272, 56);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.Color.White;
            this.txtSearch.Location = new System.Drawing.Point(4, 15);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(416, 26);
            this.txtSearch.TabIndex = 4;
            // 
            // cmbFilterSoPhong
            // 
            this.cmbFilterSoPhong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbFilterSoPhong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.cmbFilterSoPhong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbFilterSoPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.cmbFilterSoPhong.ForeColor = System.Drawing.Color.White;
            this.cmbFilterSoPhong.FormattingEnabled = true;
            this.cmbFilterSoPhong.Location = new System.Drawing.Point(682, 14);
            this.cmbFilterSoPhong.Margin = new System.Windows.Forms.Padding(4);
            this.cmbFilterSoPhong.Name = "cmbFilterSoPhong";
            this.cmbFilterSoPhong.Size = new System.Drawing.Size(246, 28);
            this.cmbFilterSoPhong.TabIndex = 3;
            // 
            // cmbFilterLoaiPhong
            // 
            this.cmbFilterLoaiPhong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbFilterLoaiPhong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.cmbFilterLoaiPhong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbFilterLoaiPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.cmbFilterLoaiPhong.ForeColor = System.Drawing.Color.White;
            this.cmbFilterLoaiPhong.FormattingEnabled = true;
            this.cmbFilterLoaiPhong.Location = new System.Drawing.Point(428, 14);
            this.cmbFilterLoaiPhong.Margin = new System.Windows.Forms.Padding(4);
            this.cmbFilterLoaiPhong.Name = "cmbFilterLoaiPhong";
            this.cmbFilterLoaiPhong.Size = new System.Drawing.Size(246, 28);
            this.cmbFilterLoaiPhong.TabIndex = 2;
            // 
            // dtpFilterNgayDen
            // 
            this.dtpFilterNgayDen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpFilterNgayDen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.dtpFilterNgayDen.Location = new System.Drawing.Point(936, 15);
            this.dtpFilterNgayDen.Margin = new System.Windows.Forms.Padding(4);
            this.dtpFilterNgayDen.Name = "dtpFilterNgayDen";
            this.dtpFilterNgayDen.Size = new System.Drawing.Size(332, 26);
            this.dtpFilterNgayDen.TabIndex = 0;
            // 
            // pnlHeader
            // 
            this.pnlHeader.Controls.Add(this.btnAddNew);
            this.pnlHeader.Controls.Add(this.btnExport);
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(27, 25);
            this.pnlHeader.Margin = new System.Windows.Forms.Padding(4);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1298, 62);
            this.pnlHeader.TabIndex = 0;
            // 
            // btnAddNew
            // 
            this.btnAddNew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(161)))), ((int)(((byte)(105)))));
            this.btnAddNew.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnAddNew.FlatAppearance.BorderSize = 0;
            this.btnAddNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNew.ForeColor = System.Drawing.Color.White;
            this.btnAddNew.Location = new System.Drawing.Point(898, 0);
            this.btnAddNew.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(200, 62);
            this.btnAddNew.TabIndex = 1;
            this.btnAddNew.Text = "+ Thêm mới";
            this.btnAddNew.UseVisualStyleBackColor = false;
            // 
            // btnExport
            // 
            this.btnExport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(130)))), ((int)(((byte)(206)))));
            this.btnExport.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnExport.FlatAppearance.BorderSize = 0;
            this.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExport.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExport.ForeColor = System.Drawing.Color.White;
            this.btnExport.Location = new System.Drawing.Point(1098, 0);
            this.btnExport.Margin = new System.Windows.Forms.Padding(4);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(200, 62);
            this.btnExport.TabIndex = 2;
            this.btnExport.Text = "Xuất báo cáo";
            this.btnExport.UseVisualStyleBackColor = false;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(238, 31);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Quản lý Check-in";
            // 
            // ucQuanLyCheckIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlMain);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ucQuanLyCheckIn";
            this.Size = new System.Drawing.Size(1352, 897);
            this.pnlMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCheckIn)).EndInit();
            this.pnlDetails.ResumeLayout(false);
            this.pnlDetails.PerformLayout();
            this.pnlInputFields.ResumeLayout(false);
            this.pnlInputFields.PerformLayout();
            this.pnlFilters.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.Panel pnlFilters;
        private System.Windows.Forms.DateTimePicker dtpFilterNgayDen;
        private System.Windows.Forms.ComboBox cmbFilterLoaiPhong;
        private System.Windows.Forms.ComboBox cmbFilterSoPhong;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView dgvCheckIn;
        private System.Windows.Forms.Panel pnlDetails;
        private System.Windows.Forms.Label lblDetailsTitle;
        private System.Windows.Forms.TableLayoutPanel pnlInputFields;
        private System.Windows.Forms.Label lblMaDatPhong;
        private System.Windows.Forms.TextBox txtMaDatPhong;
        private System.Windows.Forms.Label lblTenKhach;
        private System.Windows.Forms.TextBox txtTenKhach;
        private System.Windows.Forms.ComboBox cmbTenKhach;
        private System.Windows.Forms.Label lblCCCD;
        private System.Windows.Forms.TextBox txtCCCD;
        private System.Windows.Forms.Label lblSDT;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.Label lblNgayCheckIn;
        private System.Windows.Forms.DateTimePicker dtpNgayCheckIn;
        private System.Windows.Forms.Label lblLoaiPhong;
        private System.Windows.Forms.ComboBox cmbLoaiPhong;
        private System.Windows.Forms.Label lblSoPhong;
        private System.Windows.Forms.ComboBox cmbSoPhong;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
} 