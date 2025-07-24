namespace HTQLKS
{
    partial class FormRoomDetails
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblMaPhong = new System.Windows.Forms.Label();
            this.txtMaPhong = new System.Windows.Forms.TextBox();
            this.lblTang = new System.Windows.Forms.Label();
            this.numTang = new System.Windows.Forms.NumericUpDown();
            this.lblLoaiPhong = new System.Windows.Forms.Label();
            this.cmbLoaiPhong = new System.Windows.Forms.ComboBox();
            this.lblTrangThai = new System.Windows.Forms.Label();
            this.cmbTrangThai = new System.Windows.Forms.ComboBox();
            this.lblGiaCoBan = new System.Windows.Forms.Label();
            this.txtGiaCoBan = new System.Windows.Forms.TextBox();
            this.lblGiaCaoDiem = new System.Windows.Forms.Label();
            this.txtGiaCaoDiem = new System.Windows.Forms.TextBox();
            this.lblMoTa = new System.Windows.Forms.Label();
            this.txtMoTa = new System.Windows.Forms.TextBox();
            this.gbTienNghi = new System.Windows.Forms.GroupBox();
            this.flowTienNghi = new System.Windows.Forms.FlowLayoutPanel();
            this.lblHinhAnh = new System.Windows.Forms.Label();
            this.panelHinhAnh = new System.Windows.Forms.Panel();
            this.txtHinhAnh = new System.Windows.Forms.TextBox();
            this.btnChonTep = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numTang)).BeginInit();
            this.gbTienNghi.SuspendLayout();
            this.panelHinhAnh.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("Poppins", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(20, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Padding = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.lblTitle.Size = new System.Drawing.Size(694, 67);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Thêm Phòng Mới";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMaPhong
            // 
            this.lblMaPhong.AutoSize = true;
            this.lblMaPhong.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaPhong.Location = new System.Drawing.Point(30, 90);
            this.lblMaPhong.Name = "lblMaPhong";
            this.lblMaPhong.Size = new System.Drawing.Size(74, 23);
            this.lblMaPhong.TabIndex = 1;
            this.lblMaPhong.Text = "Mã phòng";
            // 
            // txtMaPhong
            // 
            this.txtMaPhong.Font = new System.Drawing.Font("Poppins", 9.75F);
            this.txtMaPhong.Location = new System.Drawing.Point(34, 116);
            this.txtMaPhong.Name = "txtMaPhong";
            this.txtMaPhong.Size = new System.Drawing.Size(320, 27);
            this.txtMaPhong.TabIndex = 2;
            // 
            // lblTang
            // 
            this.lblTang.AutoSize = true;
            this.lblTang.Font = new System.Drawing.Font("Poppins", 9.75F);
            this.lblTang.Location = new System.Drawing.Point(380, 90);
            this.lblTang.Name = "lblTang";
            this.lblTang.Size = new System.Drawing.Size(41, 23);
            this.lblTang.TabIndex = 3;
            this.lblTang.Text = "Tầng";
            // 
            // numTang
            // 
            this.numTang.Font = new System.Drawing.Font("Poppins", 9.75F);
            this.numTang.Location = new System.Drawing.Point(384, 116);
            this.numTang.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numTang.Name = "numTang";
            this.numTang.Size = new System.Drawing.Size(320, 27);
            this.numTang.TabIndex = 4;
            this.numTang.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblLoaiPhong
            // 
            this.lblLoaiPhong.AutoSize = true;
            this.lblLoaiPhong.Font = new System.Drawing.Font("Poppins", 9.75F);
            this.lblLoaiPhong.Location = new System.Drawing.Point(30, 160);
            this.lblLoaiPhong.Name = "lblLoaiPhong";
            this.lblLoaiPhong.Size = new System.Drawing.Size(81, 23);
            this.lblLoaiPhong.TabIndex = 5;
            this.lblLoaiPhong.Text = "Loại phòng";
            // 
            // cmbLoaiPhong
            // 
            this.cmbLoaiPhong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLoaiPhong.Font = new System.Drawing.Font("Poppins", 9.75F);
            this.cmbLoaiPhong.FormattingEnabled = true;
            this.cmbLoaiPhong.Location = new System.Drawing.Point(34, 186);
            this.cmbLoaiPhong.Name = "cmbLoaiPhong";
            this.cmbLoaiPhong.Size = new System.Drawing.Size(320, 31);
            this.cmbLoaiPhong.TabIndex = 6;
            // 
            // lblTrangThai
            // 
            this.lblTrangThai.AutoSize = true;
            this.lblTrangThai.Font = new System.Drawing.Font("Poppins", 9.75F);
            this.lblTrangThai.Location = new System.Drawing.Point(380, 160);
            this.lblTrangThai.Name = "lblTrangThai";
            this.lblTrangThai.Size = new System.Drawing.Size(76, 23);
            this.lblTrangThai.TabIndex = 7;
            this.lblTrangThai.Text = "Trạng thái";
            // 
            // cmbTrangThai
            // 
            this.cmbTrangThai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTrangThai.Font = new System.Drawing.Font("Poppins", 9.75F);
            this.cmbTrangThai.FormattingEnabled = true;
            this.cmbTrangThai.Location = new System.Drawing.Point(384, 186);
            this.cmbTrangThai.Name = "cmbTrangThai";
            this.cmbTrangThai.Size = new System.Drawing.Size(320, 31);
            this.cmbTrangThai.TabIndex = 8;
            // 
            // lblGiaCoBan
            // 
            this.lblGiaCoBan.AutoSize = true;
            this.lblGiaCoBan.Font = new System.Drawing.Font("Poppins", 9.75F);
            this.lblGiaCoBan.Location = new System.Drawing.Point(30, 230);
            this.lblGiaCoBan.Name = "lblGiaCoBan";
            this.lblGiaCoBan.Size = new System.Drawing.Size(84, 23);
            this.lblGiaCoBan.TabIndex = 9;
            this.lblGiaCoBan.Text = "Giá cơ bản";
            // 
            // txtGiaCoBan
            // 
            this.txtGiaCoBan.Font = new System.Drawing.Font("Poppins", 9.75F);
            this.txtGiaCoBan.Location = new System.Drawing.Point(34, 256);
            this.txtGiaCoBan.Name = "txtGiaCoBan";
            this.txtGiaCoBan.Size = new System.Drawing.Size(320, 27);
            this.txtGiaCoBan.TabIndex = 10;
            // 
            // lblGiaCaoDiem
            // 
            this.lblGiaCaoDiem.AutoSize = true;
            this.lblGiaCaoDiem.Font = new System.Drawing.Font("Poppins", 9.75F);
            this.lblGiaCaoDiem.Location = new System.Drawing.Point(380, 230);
            this.lblGiaCaoDiem.Name = "lblGiaCaoDiem";
            this.lblGiaCaoDiem.Size = new System.Drawing.Size(109, 23);
            this.lblGiaCaoDiem.TabIndex = 11;
            this.lblGiaCaoDiem.Text = "Giá mùa cao điểm";
            // 
            // txtGiaCaoDiem
            // 
            this.txtGiaCaoDiem.Font = new System.Drawing.Font("Poppins", 9.75F);
            this.txtGiaCaoDiem.Location = new System.Drawing.Point(384, 256);
            this.txtGiaCaoDiem.Name = "txtGiaCaoDiem";
            this.txtGiaCaoDiem.Size = new System.Drawing.Size(320, 27);
            this.txtGiaCaoDiem.TabIndex = 12;
            // 
            // lblMoTa
            // 
            this.lblMoTa.AutoSize = true;
            this.lblMoTa.Font = new System.Drawing.Font("Poppins", 9.75F);
            this.lblMoTa.Location = new System.Drawing.Point(30, 300);
            this.lblMoTa.Name = "lblMoTa";
            this.lblMoTa.Size = new System.Drawing.Size(46, 23);
            this.lblMoTa.TabIndex = 13;
            this.lblMoTa.Text = "Mô tả";
            // 
            // txtMoTa
            // 
            this.txtMoTa.Font = new System.Drawing.Font("Poppins", 9.75F);
            this.txtMoTa.Location = new System.Drawing.Point(34, 326);
            this.txtMoTa.Multiline = true;
            this.txtMoTa.Name = "txtMoTa";
            this.txtMoTa.Size = new System.Drawing.Size(670, 70);
            this.txtMoTa.TabIndex = 14;
            // 
            // gbTienNghi
            // 
            this.gbTienNghi.Controls.Add(this.flowTienNghi);
            this.gbTienNghi.Font = new System.Drawing.Font("Poppins", 9.75F);
            this.gbTienNghi.ForeColor = System.Drawing.Color.White;
            this.gbTienNghi.Location = new System.Drawing.Point(34, 410);
            this.gbTienNghi.Name = "gbTienNghi";
            this.gbTienNghi.Size = new System.Drawing.Size(670, 150);
            this.gbTienNghi.TabIndex = 15;
            this.gbTienNghi.TabStop = false;
            this.gbTienNghi.Text = "Tiện nghi";
            // 
            // flowTienNghi
            // 
            this.flowTienNghi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowTienNghi.Location = new System.Drawing.Point(3, 23);
            this.flowTienNghi.Name = "flowTienNghi";
            this.flowTienNghi.Size = new System.Drawing.Size(664, 124);
            this.flowTienNghi.TabIndex = 0;
            // 
            // lblHinhAnh
            // 
            this.lblHinhAnh.AutoSize = true;
            this.lblHinhAnh.Font = new System.Drawing.Font("Poppins", 9.75F);
            this.lblHinhAnh.Location = new System.Drawing.Point(30, 570);
            this.lblHinhAnh.Name = "lblHinhAnh";
            this.lblHinhAnh.Size = new System.Drawing.Size(65, 23);
            this.lblHinhAnh.TabIndex = 16;
            this.lblHinhAnh.Text = "Hình ảnh";
            // 
            // panelHinhAnh
            // 
            this.panelHinhAnh.Controls.Add(this.txtHinhAnh);
            this.panelHinhAnh.Controls.Add(this.btnChonTep);
            this.panelHinhAnh.Location = new System.Drawing.Point(34, 596);
            this.panelHinhAnh.Name = "panelHinhAnh";
            this.panelHinhAnh.Size = new System.Drawing.Size(670, 31);
            this.panelHinhAnh.TabIndex = 17;
            // 
            // txtHinhAnh
            // 
            this.txtHinhAnh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtHinhAnh.Font = new System.Drawing.Font("Poppins", 9.75F);
            this.txtHinhAnh.Location = new System.Drawing.Point(100, 0);
            this.txtHinhAnh.Name = "txtHinhAnh";
            this.txtHinhAnh.ReadOnly = true;
            this.txtHinhAnh.Size = new System.Drawing.Size(570, 27);
            this.txtHinhAnh.TabIndex = 1;
            // 
            // btnChonTep
            // 
            this.btnChonTep.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnChonTep.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChonTep.ForeColor = System.Drawing.Color.Black;
            this.btnChonTep.Location = new System.Drawing.Point(0, 0);
            this.btnChonTep.Name = "btnChonTep";
            this.btnChonTep.Size = new System.Drawing.Size(100, 31);
            this.btnChonTep.TabIndex = 0;
            this.btnChonTep.Text = "Chọn tệp";
            this.btnChonTep.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(128)))), ((int)(((byte)(150)))));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Poppins", 10F);
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(484, 660);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 40);
            this.btnCancel.TabIndex = 18;
            this.btnCancel.Text = "Đóng";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(130)))), ((int)(((byte)(206)))));
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Poppins", 10F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(590, 660);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(114, 40);
            this.btnSave.TabIndex = 19;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // FormRoomDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(50)))), ((int)(((byte)(66)))));
            this.ClientSize = new System.Drawing.Size(734, 721);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.panelHinhAnh);
            this.Controls.Add(this.lblHinhAnh);
            this.Controls.Add(this.gbTienNghi);
            this.Controls.Add(this.txtMoTa);
            this.Controls.Add(this.lblMoTa);
            this.Controls.Add(this.txtGiaCaoDiem);
            this.Controls.Add(this.lblGiaCaoDiem);
            this.Controls.Add(this.txtGiaCoBan);
            this.Controls.Add(this.lblGiaCoBan);
            this.Controls.Add(this.cmbTrangThai);
            this.Controls.Add(this.lblTrangThai);
            this.Controls.Add(this.cmbLoaiPhong);
            this.Controls.Add(this.lblLoaiPhong);
            this.Controls.Add(this.numTang);
            this.Controls.Add(this.lblTang);
            this.Controls.Add(this.txtMaPhong);
            this.Controls.Add(this.lblMaPhong);
            this.Controls.Add(this.lblTitle);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormRoomDetails";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Chi tiết Phòng";
            ((System.ComponentModel.ISupportInitialize)(this.numTang)).EndInit();
            this.gbTienNghi.ResumeLayout(false);
            this.panelHinhAnh.ResumeLayout(false);
            this.panelHinhAnh.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblMaPhong;
        private System.Windows.Forms.TextBox txtMaPhong;
        private System.Windows.Forms.Label lblTang;
        private System.Windows.Forms.NumericUpDown numTang;
        private System.Windows.Forms.Label lblLoaiPhong;
        private System.Windows.Forms.ComboBox cmbLoaiPhong;
        private System.Windows.Forms.Label lblTrangThai;
        private System.Windows.Forms.ComboBox cmbTrangThai;
        private System.Windows.Forms.Label lblGiaCoBan;
        private System.Windows.Forms.TextBox txtGiaCoBan;
        private System.Windows.Forms.Label lblGiaCaoDiem;
        private System.Windows.Forms.TextBox txtGiaCaoDiem;
        private System.Windows.Forms.Label lblMoTa;
        private System.Windows.Forms.TextBox txtMoTa;
        private System.Windows.Forms.GroupBox gbTienNghi;
        private System.Windows.Forms.Label lblHinhAnh;
        private System.Windows.Forms.Panel panelHinhAnh;
        private System.Windows.Forms.TextBox txtHinhAnh;
        private System.Windows.Forms.Button btnChonTep;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.FlowLayoutPanel flowTienNghi;
    }
} 