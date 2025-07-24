namespace HTQLKS
{
    partial class Form1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.sidebarPanel = new System.Windows.Forms.Panel();
            this.lblAppName = new System.Windows.Forms.Label();
            this.appIcon = new System.Windows.Forms.PictureBox();
            this.btnDangXuat = new System.Windows.Forms.Button();
            this.btnLapHoaDon = new System.Windows.Forms.Button();
            this.btnQLDichVu = new System.Windows.Forms.Button();
            this.btnQLCheckOut = new System.Windows.Forms.Button();
            this.btnQLCheckIn = new System.Windows.Forms.Button();
            this.btnQLKhachHang = new System.Windows.Forms.Button();
            this.btnQLPhong = new System.Windows.Forms.Button();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.displayPanel = new System.Windows.Forms.Panel();
            this.sidebarPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.appIcon)).BeginInit();
            this.mainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // sidebarPanel
            // 
            this.sidebarPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(44)))));
            this.sidebarPanel.Controls.Add(this.lblAppName);
            this.sidebarPanel.Controls.Add(this.appIcon);
            this.sidebarPanel.Controls.Add(this.btnDangXuat);
            this.sidebarPanel.Controls.Add(this.btnLapHoaDon);
            this.sidebarPanel.Controls.Add(this.btnQLDichVu);
            this.sidebarPanel.Controls.Add(this.btnQLCheckOut);
            this.sidebarPanel.Controls.Add(this.btnQLCheckIn);
            this.sidebarPanel.Controls.Add(this.btnQLKhachHang);
            this.sidebarPanel.Controls.Add(this.btnQLPhong);
            this.sidebarPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebarPanel.Location = new System.Drawing.Point(0, 0);
            this.sidebarPanel.Name = "sidebarPanel";
            this.sidebarPanel.Size = new System.Drawing.Size(250, 729);
            this.sidebarPanel.TabIndex = 0;
            // 
            // lblAppName
            // 
            this.lblAppName.AutoSize = true;
            this.lblAppName.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppName.ForeColor = System.Drawing.Color.White;
            this.lblAppName.Location = new System.Drawing.Point(68, 26);
            this.lblAppName.Name = "lblAppName";
            this.lblAppName.Size = new System.Drawing.Size(133, 28);
            this.lblAppName.TabIndex = 8;
            this.lblAppName.Text = "Hotel Manager";
            // 
            // appIcon
            // 
            this.appIcon.Location = new System.Drawing.Point(22, 21);
            this.appIcon.Name = "appIcon";
            this.appIcon.Size = new System.Drawing.Size(40, 40);
            this.appIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.appIcon.TabIndex = 7;
            this.appIcon.TabStop = false;
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.FlatAppearance.BorderSize = 0;
            this.btnDangXuat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDangXuat.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangXuat.ForeColor = System.Drawing.Color.White;
            this.btnDangXuat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDangXuat.Location = new System.Drawing.Point(0, 420);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnDangXuat.Size = new System.Drawing.Size(250, 45);
            this.btnDangXuat.TabIndex = 6;
            this.btnDangXuat.Text = "          Đăng xuất";
            this.btnDangXuat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDangXuat.UseVisualStyleBackColor = true;
            // 
            // btnLapHoaDon
            // 
            this.btnLapHoaDon.FlatAppearance.BorderSize = 0;
            this.btnLapHoaDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLapHoaDon.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLapHoaDon.ForeColor = System.Drawing.Color.White;
            this.btnLapHoaDon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLapHoaDon.Location = new System.Drawing.Point(0, 355);
            this.btnLapHoaDon.Name = "btnLapHoaDon";
            this.btnLapHoaDon.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnLapHoaDon.Size = new System.Drawing.Size(250, 45);
            this.btnLapHoaDon.TabIndex = 5;
            this.btnLapHoaDon.Text = "          Lập Hóa Đơn";
            this.btnLapHoaDon.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLapHoaDon.UseVisualStyleBackColor = true;
            // 
            // btnQLDichVu
            // 
            this.btnQLDichVu.FlatAppearance.BorderSize = 0;
            this.btnQLDichVu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQLDichVu.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLDichVu.ForeColor = System.Drawing.Color.White;
            this.btnQLDichVu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQLDichVu.Location = new System.Drawing.Point(0, 305);
            this.btnQLDichVu.Name = "btnQLDichVu";
            this.btnQLDichVu.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnQLDichVu.Size = new System.Drawing.Size(250, 45);
            this.btnQLDichVu.TabIndex = 4;
            this.btnQLDichVu.Text = "          Quản lý Dịch vụ";
            this.btnQLDichVu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQLDichVu.UseVisualStyleBackColor = true;
            // 
            // btnQLCheckOut
            // 
            this.btnQLCheckOut.FlatAppearance.BorderSize = 0;
            this.btnQLCheckOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQLCheckOut.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLCheckOut.ForeColor = System.Drawing.Color.White;
            this.btnQLCheckOut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQLCheckOut.Location = new System.Drawing.Point(0, 255);
            this.btnQLCheckOut.Name = "btnQLCheckOut";
            this.btnQLCheckOut.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnQLCheckOut.Size = new System.Drawing.Size(250, 45);
            this.btnQLCheckOut.TabIndex = 3;
            this.btnQLCheckOut.Text = "          Quản lý Check-out";
            this.btnQLCheckOut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQLCheckOut.UseVisualStyleBackColor = true;
            this.btnQLCheckOut.Click += new System.EventHandler(this.btnQLCheckOut_Click);
            // 
            // btnQLCheckIn
            // 
            this.btnQLCheckIn.FlatAppearance.BorderSize = 0;
            this.btnQLCheckIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQLCheckIn.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLCheckIn.ForeColor = System.Drawing.Color.White;
            this.btnQLCheckIn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQLCheckIn.Location = new System.Drawing.Point(0, 205);
            this.btnQLCheckIn.Name = "btnQLCheckIn";
            this.btnQLCheckIn.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnQLCheckIn.Size = new System.Drawing.Size(250, 45);
            this.btnQLCheckIn.TabIndex = 2;
            this.btnQLCheckIn.Text = "          Quản lý Check-in";
            this.btnQLCheckIn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQLCheckIn.UseVisualStyleBackColor = true;
            this.btnQLCheckIn.Click += new System.EventHandler(this.btnQLCheckIn_Click);
            // 
            // btnQLKhachHang
            // 
            this.btnQLKhachHang.FlatAppearance.BorderSize = 0;
            this.btnQLKhachHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQLKhachHang.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLKhachHang.ForeColor = System.Drawing.Color.White;
            this.btnQLKhachHang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQLKhachHang.Location = new System.Drawing.Point(0, 155);
            this.btnQLKhachHang.Name = "btnQLKhachHang";
            this.btnQLKhachHang.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnQLKhachHang.Size = new System.Drawing.Size(250, 45);
            this.btnQLKhachHang.TabIndex = 1;
            this.btnQLKhachHang.Text = "          Quản lý Khách hàng";
            this.btnQLKhachHang.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQLKhachHang.UseVisualStyleBackColor = true;
            // 
            // btnQLPhong
            // 
            this.btnQLPhong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(130)))), ((int)(((byte)(206)))));
            this.btnQLPhong.FlatAppearance.BorderSize = 0;
            this.btnQLPhong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQLPhong.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLPhong.ForeColor = System.Drawing.Color.White;
            this.btnQLPhong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQLPhong.Location = new System.Drawing.Point(0, 105);
            this.btnQLPhong.Name = "btnQLPhong";
            this.btnQLPhong.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnQLPhong.Size = new System.Drawing.Size(250, 45);
            this.btnQLPhong.TabIndex = 0;
            this.btnQLPhong.Text = "          Quản lý Phòng";
            this.btnQLPhong.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQLPhong.UseVisualStyleBackColor = false;
            this.btnQLPhong.Click += new System.EventHandler(this.btnQLPhong_Click);
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(72)))));
            this.mainPanel.Controls.Add(this.displayPanel);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(250, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1172, 753);
            this.mainPanel.TabIndex = 1;
            // 
            // displayPanel
            // 
            this.displayPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.displayPanel.Location = new System.Drawing.Point(0, 0);
            this.displayPanel.Name = "displayPanel";
            this.displayPanel.Size = new System.Drawing.Size(1172, 753);
            this.displayPanel.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 729);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.sidebarPanel);
            this.Name = "Form1";
            this.Text = "Hệ thống Quản lý Khách sạn";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.sidebarPanel.ResumeLayout(false);
            this.sidebarPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.appIcon)).EndInit();
            this.mainPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel sidebarPanel;
        private System.Windows.Forms.Button btnQLPhong;
        private System.Windows.Forms.Button btnDangXuat;
        private System.Windows.Forms.Button btnLapHoaDon;
        private System.Windows.Forms.Button btnQLDichVu;
        private System.Windows.Forms.Button btnQLCheckOut;
        private System.Windows.Forms.Button btnQLCheckIn;
        private System.Windows.Forms.Button btnQLKhachHang;
        private System.Windows.Forms.Label lblAppName;
        private System.Windows.Forms.PictureBox appIcon;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Panel displayPanel;
    }
}

