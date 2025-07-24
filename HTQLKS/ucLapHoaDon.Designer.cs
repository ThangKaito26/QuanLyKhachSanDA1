namespace HTQLKS
{
    partial class ucLapHoaDon
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnExportPDF;
        private System.Windows.Forms.Panel pnlBookingInfo;
        private System.Windows.Forms.Label lblBookingId;
        private System.Windows.Forms.TextBox txtBookingId;
        private System.Windows.Forms.Label lblCustomer;
        private System.Windows.Forms.TextBox txtCustomer;
        private System.Windows.Forms.Label lblRoom;
        private System.Windows.Forms.TextBox txtRoom;
        private System.Windows.Forms.Label lblCheckIn;
        private System.Windows.Forms.TextBox txtCheckIn;
        private System.Windows.Forms.Label lblCheckOut;
        private System.Windows.Forms.TextBox txtCheckOut;
        private System.Windows.Forms.Panel pnlPaymentDetails;
        private System.Windows.Forms.Label lblRoomCharge;
        private System.Windows.Forms.TextBox txtRoomCharge;
        private System.Windows.Forms.Label lblSurcharge;
        private System.Windows.Forms.TextBox txtSurcharge;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Panel pnlServices;
        private System.Windows.Forms.DataGridView dgvServices;
        private System.Windows.Forms.Panel pnlPaymentMethod;
        private System.Windows.Forms.Button btnCash;
        private System.Windows.Forms.Button btnCard;
        private System.Windows.Forms.Button btnTransfer;
        private System.Windows.Forms.Button btnConfirmPayment;

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
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnExportPDF = new System.Windows.Forms.Button();
            this.pnlBookingInfo = new System.Windows.Forms.Panel();
            this.lblBookingId = new System.Windows.Forms.Label();
            this.txtBookingId = new System.Windows.Forms.TextBox();
            this.lblCustomer = new System.Windows.Forms.Label();
            this.txtCustomer = new System.Windows.Forms.TextBox();
            this.lblRoom = new System.Windows.Forms.Label();
            this.txtRoom = new System.Windows.Forms.TextBox();
            this.lblCheckIn = new System.Windows.Forms.Label();
            this.txtCheckIn = new System.Windows.Forms.TextBox();
            this.lblCheckOut = new System.Windows.Forms.Label();
            this.txtCheckOut = new System.Windows.Forms.TextBox();
            this.pnlPaymentDetails = new System.Windows.Forms.Panel();
            this.lblRoomCharge = new System.Windows.Forms.Label();
            this.txtRoomCharge = new System.Windows.Forms.TextBox();
            this.lblSurcharge = new System.Windows.Forms.Label();
            this.txtSurcharge = new System.Windows.Forms.TextBox();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.pnlServices = new System.Windows.Forms.Panel();
            this.dgvServices = new System.Windows.Forms.DataGridView();
            this.pnlPaymentMethod = new System.Windows.Forms.Panel();
            this.btnCash = new System.Windows.Forms.Button();
            this.btnCard = new System.Windows.Forms.Button();
            this.btnTransfer = new System.Windows.Forms.Button();
            this.btnConfirmPayment = new System.Windows.Forms.Button();
            this.pnlMain.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.pnlBookingInfo.SuspendLayout();
            this.pnlPaymentDetails.SuspendLayout();
            this.pnlServices.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServices)).BeginInit();
            this.pnlPaymentMethod.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.FromArgb(45, 55, 72);
            this.pnlMain.Controls.Add(this.pnlHeader);
            this.pnlMain.Controls.Add(this.pnlBookingInfo);
            this.pnlMain.Controls.Add(this.pnlPaymentDetails);
            this.pnlMain.Controls.Add(this.pnlServices);
            this.pnlMain.Controls.Add(this.pnlPaymentMethod);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Padding = new System.Windows.Forms.Padding(30);
            this.pnlMain.Size = new System.Drawing.Size(1352, 897);
            this.pnlMain.TabIndex = 0;
            // 
            // pnlHeader
            // 
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Controls.Add(this.btnExportPDF);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Height = 60;
            this.pnlHeader.BackColor = System.Drawing.Color.Transparent;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(10, 10);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(200, 36);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Lập Hóa Đơn";
            // 
            // btnExportPDF
            // 
            this.btnExportPDF.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnExportPDF.BackColor = System.Drawing.Color.FromArgb(49, 130, 206);
            this.btnExportPDF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportPDF.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnExportPDF.ForeColor = System.Drawing.Color.White;
            this.btnExportPDF.Location = new System.Drawing.Point(1150, 10);
            this.btnExportPDF.Name = "btnExportPDF";
            this.btnExportPDF.Size = new System.Drawing.Size(180, 40);
            this.btnExportPDF.TabIndex = 1;
            this.btnExportPDF.Text = "Xuất PDF";
            this.btnExportPDF.UseVisualStyleBackColor = false;
            // 
            // pnlBookingInfo
            // 
            this.pnlBookingInfo.BackColor = System.Drawing.Color.FromArgb(42, 50, 66);
            this.pnlBookingInfo.Controls.Add(this.lblBookingId);
            this.pnlBookingInfo.Controls.Add(this.txtBookingId);
            this.pnlBookingInfo.Controls.Add(this.lblCustomer);
            this.pnlBookingInfo.Controls.Add(this.txtCustomer);
            this.pnlBookingInfo.Controls.Add(this.lblRoom);
            this.pnlBookingInfo.Controls.Add(this.txtRoom);
            this.pnlBookingInfo.Controls.Add(this.lblCheckIn);
            this.pnlBookingInfo.Controls.Add(this.txtCheckIn);
            this.pnlBookingInfo.Controls.Add(this.lblCheckOut);
            this.pnlBookingInfo.Controls.Add(this.txtCheckOut);
            this.pnlBookingInfo.Location = new System.Drawing.Point(30, 80);
            this.pnlBookingInfo.Name = "pnlBookingInfo";
            this.pnlBookingInfo.Size = new System.Drawing.Size(600, 180);
            this.pnlBookingInfo.TabIndex = 2;
            // 
            // lblBookingId
            // 
            this.lblBookingId.AutoSize = true;
            this.lblBookingId.ForeColor = System.Drawing.Color.White;
            this.lblBookingId.Location = new System.Drawing.Point(20, 20);
            this.lblBookingId.Name = "lblBookingId";
            this.lblBookingId.Size = new System.Drawing.Size(100, 20);
            this.lblBookingId.TabIndex = 0;
            this.lblBookingId.Text = "Mã đặt phòng";
            // 
            // txtBookingId
            // 
            this.txtBookingId.Location = new System.Drawing.Point(140, 17);
            this.txtBookingId.Name = "txtBookingId";
            this.txtBookingId.ReadOnly = true;
            this.txtBookingId.Size = new System.Drawing.Size(180, 26);
            this.txtBookingId.TabIndex = 1;
            // 
            // lblCustomer
            // 
            this.lblCustomer.AutoSize = true;
            this.lblCustomer.ForeColor = System.Drawing.Color.White;
            this.lblCustomer.Location = new System.Drawing.Point(20, 55);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(90, 20);
            this.lblCustomer.TabIndex = 2;
            this.lblCustomer.Text = "Khách hàng";
            // 
            // txtCustomer
            // 
            this.txtCustomer.Location = new System.Drawing.Point(140, 52);
            this.txtCustomer.Name = "txtCustomer";
            this.txtCustomer.ReadOnly = true;
            this.txtCustomer.Size = new System.Drawing.Size(180, 26);
            this.txtCustomer.TabIndex = 3;
            // 
            // lblRoom
            // 
            this.lblRoom.AutoSize = true;
            this.lblRoom.ForeColor = System.Drawing.Color.White;
            this.lblRoom.Location = new System.Drawing.Point(20, 90);
            this.lblRoom.Name = "lblRoom";
            this.lblRoom.Size = new System.Drawing.Size(50, 20);
            this.lblRoom.TabIndex = 4;
            this.lblRoom.Text = "Phòng";
            // 
            // txtRoom
            // 
            this.txtRoom.Location = new System.Drawing.Point(140, 87);
            this.txtRoom.Name = "txtRoom";
            this.txtRoom.ReadOnly = true;
            this.txtRoom.Size = new System.Drawing.Size(180, 26);
            this.txtRoom.TabIndex = 5;
            // 
            // lblCheckIn
            // 
            this.lblCheckIn.AutoSize = true;
            this.lblCheckIn.ForeColor = System.Drawing.Color.White;
            this.lblCheckIn.Location = new System.Drawing.Point(20, 125);
            this.lblCheckIn.Name = "lblCheckIn";
            this.lblCheckIn.Size = new System.Drawing.Size(70, 20);
            this.lblCheckIn.TabIndex = 6;
            this.lblCheckIn.Text = "Check-in";
            // 
            // txtCheckIn
            // 
            this.txtCheckIn.Location = new System.Drawing.Point(140, 122);
            this.txtCheckIn.Name = "txtCheckIn";
            this.txtCheckIn.ReadOnly = true;
            this.txtCheckIn.Size = new System.Drawing.Size(180, 26);
            this.txtCheckIn.TabIndex = 7;
            // 
            // lblCheckOut
            // 
            this.lblCheckOut.AutoSize = true;
            this.lblCheckOut.ForeColor = System.Drawing.Color.White;
            this.lblCheckOut.Location = new System.Drawing.Point(20, 160);
            this.lblCheckOut.Name = "lblCheckOut";
            this.lblCheckOut.Size = new System.Drawing.Size(80, 20);
            this.lblCheckOut.TabIndex = 8;
            this.lblCheckOut.Text = "Check-out";
            // 
            // txtCheckOut
            // 
            this.txtCheckOut.Location = new System.Drawing.Point(140, 157);
            this.txtCheckOut.Name = "txtCheckOut";
            this.txtCheckOut.ReadOnly = true;
            this.txtCheckOut.Size = new System.Drawing.Size(180, 26);
            this.txtCheckOut.TabIndex = 9;
            // 
            // pnlPaymentDetails
            // 
            this.pnlPaymentDetails.BackColor = System.Drawing.Color.FromArgb(42, 50, 66);
            this.pnlPaymentDetails.Controls.Add(this.lblRoomCharge);
            this.pnlPaymentDetails.Controls.Add(this.txtRoomCharge);
            this.pnlPaymentDetails.Controls.Add(this.lblSurcharge);
            this.pnlPaymentDetails.Controls.Add(this.txtSurcharge);
            this.pnlPaymentDetails.Controls.Add(this.lblDiscount);
            this.pnlPaymentDetails.Controls.Add(this.txtDiscount);
            this.pnlPaymentDetails.Controls.Add(this.lblTotal);
            this.pnlPaymentDetails.Controls.Add(this.txtTotal);
            this.pnlPaymentDetails.Location = new System.Drawing.Point(650, 80);
            this.pnlPaymentDetails.Name = "pnlPaymentDetails";
            this.pnlPaymentDetails.Size = new System.Drawing.Size(600, 180);
            this.pnlPaymentDetails.TabIndex = 3;
            // 
            // lblRoomCharge
            // 
            this.lblRoomCharge.AutoSize = true;
            this.lblRoomCharge.ForeColor = System.Drawing.Color.White;
            this.lblRoomCharge.Location = new System.Drawing.Point(20, 20);
            this.lblRoomCharge.Name = "lblRoomCharge";
            this.lblRoomCharge.Size = new System.Drawing.Size(80, 20);
            this.lblRoomCharge.TabIndex = 0;
            this.lblRoomCharge.Text = "Tiền phòng";
            // 
            // txtRoomCharge
            // 
            this.txtRoomCharge.Location = new System.Drawing.Point(140, 17);
            this.txtRoomCharge.Name = "txtRoomCharge";
            this.txtRoomCharge.ReadOnly = true;
            this.txtRoomCharge.Size = new System.Drawing.Size(180, 26);
            this.txtRoomCharge.TabIndex = 1;
            // 
            // lblSurcharge
            // 
            this.lblSurcharge.AutoSize = true;
            this.lblSurcharge.ForeColor = System.Drawing.Color.White;
            this.lblSurcharge.Location = new System.Drawing.Point(20, 55);
            this.lblSurcharge.Name = "lblSurcharge";
            this.lblSurcharge.Size = new System.Drawing.Size(60, 20);
            this.lblSurcharge.TabIndex = 2;
            this.lblSurcharge.Text = "Phụ thu";
            // 
            // txtSurcharge
            // 
            this.txtSurcharge.Location = new System.Drawing.Point(140, 52);
            this.txtSurcharge.Name = "txtSurcharge";
            this.txtSurcharge.Size = new System.Drawing.Size(180, 26);
            this.txtSurcharge.TabIndex = 3;
            // 
            // lblDiscount
            // 
            this.lblDiscount.AutoSize = true;
            this.lblDiscount.ForeColor = System.Drawing.Color.White;
            this.lblDiscount.Location = new System.Drawing.Point(20, 90);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(70, 20);
            this.lblDiscount.TabIndex = 4;
            this.lblDiscount.Text = "Giảm giá";
            // 
            // txtDiscount
            // 
            this.txtDiscount.Location = new System.Drawing.Point(140, 87);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(180, 26);
            this.txtDiscount.TabIndex = 5;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.ForeColor = System.Drawing.Color.White;
            this.lblTotal.Location = new System.Drawing.Point(20, 125);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(80, 20);
            this.lblTotal.TabIndex = 6;
            this.lblTotal.Text = "Tổng cộng";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(140, 122);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(180, 26);
            this.txtTotal.TabIndex = 7;
            // 
            // pnlServices
            // 
            this.pnlServices.BackColor = System.Drawing.Color.FromArgb(42, 50, 66);
            this.pnlServices.Controls.Add(this.dgvServices);
            this.pnlServices.Location = new System.Drawing.Point(30, 280);
            this.pnlServices.Name = "pnlServices";
            this.pnlServices.Size = new System.Drawing.Size(1220, 200);
            this.pnlServices.TabIndex = 4;
            // 
            // dgvServices
            // 
            this.dgvServices.BackgroundColor = System.Drawing.Color.FromArgb(42, 50, 66);
            this.dgvServices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvServices.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvServices.Location = new System.Drawing.Point(0, 0);
            this.dgvServices.Name = "dgvServices";
            this.dgvServices.Size = new System.Drawing.Size(1220, 200);
            this.dgvServices.TabIndex = 0;
            // 
            // pnlPaymentMethod
            // 
            this.pnlPaymentMethod.BackColor = System.Drawing.Color.FromArgb(42, 50, 66);
            this.pnlPaymentMethod.Controls.Add(this.btnCash);
            this.pnlPaymentMethod.Controls.Add(this.btnCard);
            this.pnlPaymentMethod.Controls.Add(this.btnTransfer);
            this.pnlPaymentMethod.Controls.Add(this.btnConfirmPayment);
            this.pnlPaymentMethod.Location = new System.Drawing.Point(30, 500);
            this.pnlPaymentMethod.Name = "pnlPaymentMethod";
            this.pnlPaymentMethod.Size = new System.Drawing.Size(1220, 100);
            this.pnlPaymentMethod.TabIndex = 5;
            // 
            // btnCash
            // 
            this.btnCash.BackColor = System.Drawing.Color.FromArgb(49, 130, 206);
            this.btnCash.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCash.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnCash.ForeColor = System.Drawing.Color.White;
            this.btnCash.Location = new System.Drawing.Point(40, 20);
            this.btnCash.Name = "btnCash";
            this.btnCash.Size = new System.Drawing.Size(180, 40);
            this.btnCash.TabIndex = 0;
            this.btnCash.Text = "Tiền mặt";
            this.btnCash.UseVisualStyleBackColor = false;
            // 
            // btnCard
            // 
            this.btnCard.BackColor = System.Drawing.Color.FromArgb(49, 130, 206);
            this.btnCard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnCard.ForeColor = System.Drawing.Color.White;
            this.btnCard.Location = new System.Drawing.Point(250, 20);
            this.btnCard.Name = "btnCard";
            this.btnCard.Size = new System.Drawing.Size(180, 40);
            this.btnCard.TabIndex = 1;
            this.btnCard.Text = "Thẻ";
            this.btnCard.UseVisualStyleBackColor = false;
            // 
            // btnTransfer
            // 
            this.btnTransfer.BackColor = System.Drawing.Color.FromArgb(49, 130, 206);
            this.btnTransfer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTransfer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnTransfer.ForeColor = System.Drawing.Color.White;
            this.btnTransfer.Location = new System.Drawing.Point(460, 20);
            this.btnTransfer.Name = "btnTransfer";
            this.btnTransfer.Size = new System.Drawing.Size(180, 40);
            this.btnTransfer.TabIndex = 2;
            this.btnTransfer.Text = "Chuyển khoản";
            this.btnTransfer.UseVisualStyleBackColor = false;
            // 
            // btnConfirmPayment
            // 
            this.btnConfirmPayment.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnConfirmPayment.BackColor = System.Drawing.Color.FromArgb(49, 130, 206);
            this.btnConfirmPayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnConfirmPayment.ForeColor = System.Drawing.Color.White;
            this.btnConfirmPayment.Location = new System.Drawing.Point(1000, 20);
            this.btnConfirmPayment.Name = "btnConfirmPayment";
            this.btnConfirmPayment.Size = new System.Drawing.Size(180, 40);
            this.btnConfirmPayment.TabIndex = 3;
            this.btnConfirmPayment.Text = "Xác nhận thanh toán";
            this.btnConfirmPayment.UseVisualStyleBackColor = false;
            // 
            // ucLapHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlMain);
            this.Name = "ucLapHoaDon";
            this.Size = new System.Drawing.Size(1352, 897);
            this.pnlMain.ResumeLayout(false);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlBookingInfo.ResumeLayout(false);
            this.pnlBookingInfo.PerformLayout();
            this.pnlPaymentDetails.ResumeLayout(false);
            this.pnlPaymentDetails.PerformLayout();
            this.pnlServices.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvServices)).EndInit();
            this.pnlPaymentMethod.ResumeLayout(false);
            this.ResumeLayout(false);
        }
    }
} 