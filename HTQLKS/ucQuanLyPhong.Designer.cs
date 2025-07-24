namespace HTQLKS
{
    partial class ucQuanLyPhong
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.displayPanel = new System.Windows.Forms.Panel();
            this.flowLayoutPanelRooms = new System.Windows.Forms.FlowLayoutPanel();
            this.dataGridViewRooms = new System.Windows.Forms.DataGridView();
            this.filterPanel = new System.Windows.Forms.Panel();
            this.btnViewList = new System.Windows.Forms.Button();
            this.btnViewGrid = new System.Windows.Forms.Button();
            this.btnAddRoom = new System.Windows.Forms.Button();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.cmbFloor = new System.Windows.Forms.ComboBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.statsPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.qLKSDataSet = new HTQLKS.QLKSDataSet();
            this.panelTotal = new System.Windows.Forms.Panel();
            this.lblTotalRooms = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panelAvailable = new System.Windows.Forms.Panel();
            this.lblAvailableRooms = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panelOccupied = new System.Windows.Forms.Panel();
            this.lblOccupiedRooms = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panelCleaning = new System.Windows.Forms.Panel();
            this.lblCleaning = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panelMaintenance = new System.Windows.Forms.Panel();
            this.lblMaintenance = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.displayPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRooms)).BeginInit();
            this.filterPanel.SuspendLayout();
            this.statsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qLKSDataSet)).BeginInit();
            this.panelTotal.SuspendLayout();
            this.panelAvailable.SuspendLayout();
            this.panelOccupied.SuspendLayout();
            this.panelCleaning.SuspendLayout();
            this.panelMaintenance.SuspendLayout();
            this.SuspendLayout();
            // 
            // displayPanel
            // 
            this.displayPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.displayPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(50)))), ((int)(((byte)(66)))));
            this.displayPanel.Controls.Add(this.flowLayoutPanelRooms);
            this.displayPanel.Controls.Add(this.dataGridViewRooms);
            this.displayPanel.Location = new System.Drawing.Point(23, 185);
            this.displayPanel.Name = "displayPanel";
            this.displayPanel.Size = new System.Drawing.Size(968, 521);
            this.displayPanel.TabIndex = 2;
            // 
            // flowLayoutPanelRooms
            // 
            this.flowLayoutPanelRooms.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanelRooms.AutoScroll = true;
            this.flowLayoutPanelRooms.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanelRooms.Name = "flowLayoutPanelRooms";
            this.flowLayoutPanelRooms.Size = new System.Drawing.Size(1200, 521);
            this.flowLayoutPanelRooms.TabIndex = 0;
            this.flowLayoutPanelRooms.WrapContents = true;
            // 
            // dataGridViewRooms
            // 
            this.dataGridViewRooms.AllowUserToAddRows = false;
            this.dataGridViewRooms.AllowUserToDeleteRows = false;
            this.dataGridViewRooms.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewRooms.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(50)))), ((int)(((byte)(66)))));
            this.dataGridViewRooms.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewRooms.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(50)))), ((int)(((byte)(66)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewRooms.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewRooms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(50)))), ((int)(((byte)(66)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(130)))), ((int)(((byte)(206)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewRooms.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewRooms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewRooms.EnableHeadersVisualStyles = false;
            this.dataGridViewRooms.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.dataGridViewRooms.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewRooms.Name = "dataGridViewRooms";
            this.dataGridViewRooms.ReadOnly = true;
            this.dataGridViewRooms.RowHeadersVisible = false;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(2);
            this.dataGridViewRooms.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewRooms.RowTemplate.Height = 40;
            this.dataGridViewRooms.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewRooms.Size = new System.Drawing.Size(968, 521);
            this.dataGridViewRooms.TabIndex = 1;
            this.dataGridViewRooms.Visible = false;
            // 
            // filterPanel
            // 
            this.filterPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.filterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(50)))), ((int)(((byte)(66)))));
            this.filterPanel.Controls.Add(this.btnViewList);
            this.filterPanel.Controls.Add(this.btnViewGrid);
            this.filterPanel.Controls.Add(this.btnAddRoom);
            this.filterPanel.Controls.Add(this.cmbStatus);
            this.filterPanel.Controls.Add(this.cmbType);
            this.filterPanel.Controls.Add(this.cmbFloor);
            this.filterPanel.Controls.Add(this.txtSearch);
            this.filterPanel.Location = new System.Drawing.Point(23, 102);
            this.filterPanel.Name = "filterPanel";
            this.filterPanel.Size = new System.Drawing.Size(968, 64);
            this.filterPanel.TabIndex = 1;
            // 
            // btnViewList
            // 
            this.btnViewList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnViewList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.btnViewList.FlatAppearance.BorderSize = 0;
            this.btnViewList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewList.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewList.ForeColor = System.Drawing.Color.White;
            this.btnViewList.Location = new System.Drawing.Point(756, 17);
            this.btnViewList.Name = "btnViewList";
            this.btnViewList.Size = new System.Drawing.Size(80, 30);
            this.btnViewList.TabIndex = 6;
            this.btnViewList.Text = "List";
            this.btnViewList.UseVisualStyleBackColor = false;
            // 
            // btnViewGrid
            // 
            this.btnViewGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnViewGrid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(130)))), ((int)(((byte)(206)))));
            this.btnViewGrid.FlatAppearance.BorderSize = 0;
            this.btnViewGrid.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewGrid.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewGrid.ForeColor = System.Drawing.Color.White;
            this.btnViewGrid.Location = new System.Drawing.Point(670, 17);
            this.btnViewGrid.Name = "btnViewGrid";
            this.btnViewGrid.Size = new System.Drawing.Size(80, 30);
            this.btnViewGrid.TabIndex = 5;
            this.btnViewGrid.Text = "Grid";
            this.btnViewGrid.UseVisualStyleBackColor = false;
            // 
            // btnAddRoom
            // 
            this.btnAddRoom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddRoom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(161)))), ((int)(((byte)(105)))));
            this.btnAddRoom.FlatAppearance.BorderSize = 0;
            this.btnAddRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddRoom.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddRoom.ForeColor = System.Drawing.Color.White;
            this.btnAddRoom.Location = new System.Drawing.Point(853, 17);
            this.btnAddRoom.Name = "btnAddRoom";
            this.btnAddRoom.Size = new System.Drawing.Size(100, 30);
            this.btnAddRoom.TabIndex = 4;
            this.btnAddRoom.Text = "+ Thêm Phòng";
            this.btnAddRoom.UseVisualStyleBackColor = false;
            // 
            // cmbStatus
            // 
            this.cmbStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.cmbStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbStatus.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbStatus.ForeColor = System.Drawing.Color.White;
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Location = new System.Drawing.Point(525, 17);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(121, 30);
            this.cmbStatus.TabIndex = 3;
            this.cmbStatus.Text = "Trạng thái";
            // 
            // cmbType
            // 
            this.cmbType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.cmbType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbType.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbType.ForeColor = System.Drawing.Color.White;
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Location = new System.Drawing.Point(398, 17);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(121, 30);
            this.cmbType.TabIndex = 2;
            this.cmbType.Text = "Loại phòng";
            // 
            // cmbFloor
            // 
            this.cmbFloor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.cmbFloor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbFloor.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFloor.ForeColor = System.Drawing.Color.White;
            this.cmbFloor.FormattingEnabled = true;
            this.cmbFloor.Location = new System.Drawing.Point(271, 17);
            this.cmbFloor.Name = "cmbFloor";
            this.cmbFloor.Size = new System.Drawing.Size(121, 30);
            this.cmbFloor.TabIndex = 1;
            this.cmbFloor.Text = "Tầng";
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.Color.White;
            this.txtSearch.Location = new System.Drawing.Point(17, 19);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(232, 27);
            this.txtSearch.TabIndex = 0;
            // 
            // statsPanel
            // 
            this.statsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.statsPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(72)))));
            this.statsPanel.Controls.Add(this.panelTotal);
            this.statsPanel.Controls.Add(this.panelAvailable);
            this.statsPanel.Controls.Add(this.panelOccupied);
            this.statsPanel.Controls.Add(this.panelCleaning);
            this.statsPanel.Controls.Add(this.panelMaintenance);
            this.statsPanel.Location = new System.Drawing.Point(20, 0);
            this.statsPanel.Name = "statsPanel";
            this.statsPanel.Size = new System.Drawing.Size(971, 85);
            this.statsPanel.TabIndex = 0;
            // 
            // qLKSDataSet
            // 
            this.qLKSDataSet.DataSetName = "QLKSDataSet";
            this.qLKSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panelTotal
            // 
            this.panelTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(130)))), ((int)(((byte)(206)))));
            this.panelTotal.Controls.Add(this.lblTotalRooms);
            this.panelTotal.Controls.Add(this.label2);
            this.panelTotal.Location = new System.Drawing.Point(3, 3);
            this.panelTotal.Name = "panelTotal";
            this.panelTotal.Size = new System.Drawing.Size(180, 75);
            this.panelTotal.TabIndex = 0;
            // 
            // lblTotalRooms
            // 
            this.lblTotalRooms.AutoSize = true;
            this.lblTotalRooms.Font = new System.Drawing.Font("Poppins", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalRooms.ForeColor = System.Drawing.Color.White;
            this.lblTotalRooms.Location = new System.Drawing.Point(13, 30);
            this.lblTotalRooms.Name = "lblTotalRooms";
            this.lblTotalRooms.Size = new System.Drawing.Size(32, 37);
            this.lblTotalRooms.TabIndex = 1;
            this.lblTotalRooms.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(16, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tổng số phòng";
            // 
            // panelAvailable
            // 
            this.panelAvailable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(161)))), ((int)(((byte)(105)))));
            this.panelAvailable.Controls.Add(this.lblAvailableRooms);
            this.panelAvailable.Controls.Add(this.label4);
            this.panelAvailable.Location = new System.Drawing.Point(189, 3);
            this.panelAvailable.Name = "panelAvailable";
            this.panelAvailable.Size = new System.Drawing.Size(180, 75);
            this.panelAvailable.TabIndex = 1;
            // 
            // lblAvailableRooms
            // 
            this.lblAvailableRooms.AutoSize = true;
            this.lblAvailableRooms.Font = new System.Drawing.Font("Poppins", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvailableRooms.ForeColor = System.Drawing.Color.White;
            this.lblAvailableRooms.Location = new System.Drawing.Point(13, 30);
            this.lblAvailableRooms.Name = "lblAvailableRooms";
            this.lblAvailableRooms.Size = new System.Drawing.Size(32, 37);
            this.lblAvailableRooms.TabIndex = 1;
            this.lblAvailableRooms.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(16, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 22);
            this.label4.TabIndex = 0;
            this.label4.Text = "Phòng trống";
            // 
            // panelOccupied
            // 
            this.panelOccupied.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(79)))), ((int)(((byte)(95)))));
            this.panelOccupied.Controls.Add(this.lblOccupiedRooms);
            this.panelOccupied.Controls.Add(this.label6);
            this.panelOccupied.Location = new System.Drawing.Point(375, 3);
            this.panelOccupied.Name = "panelOccupied";
            this.panelOccupied.Size = new System.Drawing.Size(180, 75);
            this.panelOccupied.TabIndex = 2;
            // 
            // lblOccupiedRooms
            // 
            this.lblOccupiedRooms.AutoSize = true;
            this.lblOccupiedRooms.Font = new System.Drawing.Font("Poppins", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOccupiedRooms.ForeColor = System.Drawing.Color.White;
            this.lblOccupiedRooms.Location = new System.Drawing.Point(13, 30);
            this.lblOccupiedRooms.Name = "lblOccupiedRooms";
            this.lblOccupiedRooms.Size = new System.Drawing.Size(32, 37);
            this.lblOccupiedRooms.TabIndex = 1;
            this.lblOccupiedRooms.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(16, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 22);
            this.label6.TabIndex = 0;
            this.label6.Text = "Đang sử dụng";
            // 
            // panelCleaning
            // 
            this.panelCleaning.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(162)))), ((int)(((byte)(81)))));
            this.panelCleaning.Controls.Add(this.lblCleaning);
            this.panelCleaning.Controls.Add(this.label8);
            this.panelCleaning.Location = new System.Drawing.Point(561, 3);
            this.panelCleaning.Name = "panelCleaning";
            this.panelCleaning.Size = new System.Drawing.Size(180, 75);
            this.panelCleaning.TabIndex = 3;
            // 
            // lblCleaning
            // 
            this.lblCleaning.AutoSize = true;
            this.lblCleaning.Font = new System.Drawing.Font("Poppins", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCleaning.ForeColor = System.Drawing.Color.White;
            this.lblCleaning.Location = new System.Drawing.Point(13, 30);
            this.lblCleaning.Name = "lblCleaning";
            this.lblCleaning.Size = new System.Drawing.Size(32, 37);
            this.lblCleaning.TabIndex = 1;
            this.lblCleaning.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(16, 11);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 22);
            this.label8.TabIndex = 0;
            this.label8.Text = "Cần dọn dẹp";
            // 
            // panelMaintenance
            // 
            this.panelMaintenance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(128)))), ((int)(((byte)(150)))));
            this.panelMaintenance.Controls.Add(this.lblMaintenance);
            this.panelMaintenance.Controls.Add(this.label10);
            this.panelMaintenance.Location = new System.Drawing.Point(747, 3);
            this.panelMaintenance.Name = "panelMaintenance";
            this.panelMaintenance.Size = new System.Drawing.Size(180, 75);
            this.panelMaintenance.TabIndex = 4;
            // 
            // lblMaintenance
            // 
            this.lblMaintenance.AutoSize = true;
            this.lblMaintenance.Font = new System.Drawing.Font("Poppins", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaintenance.ForeColor = System.Drawing.Color.White;
            this.lblMaintenance.Location = new System.Drawing.Point(13, 30);
            this.lblMaintenance.Name = "lblMaintenance";
            this.lblMaintenance.Size = new System.Drawing.Size(32, 37);
            this.lblMaintenance.TabIndex = 1;
            this.lblMaintenance.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(16, 11);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(84, 22);
            this.label10.TabIndex = 0;
            this.label10.Text = "Đang bảo trì";
            // 
            // ucQuanLyPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(72)))));
            this.Controls.Add(this.displayPanel);
            this.Controls.Add(this.filterPanel);
            this.Controls.Add(this.statsPanel);
            this.Name = "ucQuanLyPhong";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.Size = new System.Drawing.Size(1014, 729);
            this.Load += new System.EventHandler(this.ucQuanLyPhong_Load);
            this.displayPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRooms)).EndInit();
            this.filterPanel.ResumeLayout(false);
            this.filterPanel.PerformLayout();
            this.statsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.qLKSDataSet)).EndInit();
            this.panelTotal.ResumeLayout(false);
            this.panelTotal.PerformLayout();
            this.panelAvailable.ResumeLayout(false);
            this.panelAvailable.PerformLayout();
            this.panelOccupied.ResumeLayout(false);
            this.panelOccupied.PerformLayout();
            this.panelCleaning.ResumeLayout(false);
            this.panelCleaning.PerformLayout();
            this.panelMaintenance.ResumeLayout(false);
            this.panelMaintenance.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel displayPanel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelRooms;
        private System.Windows.Forms.DataGridView dataGridViewRooms;
        private System.Windows.Forms.Panel filterPanel;
        private System.Windows.Forms.Button btnViewList;
        private System.Windows.Forms.Button btnViewGrid;
        private System.Windows.Forms.Button btnAddRoom;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.ComboBox cmbFloor;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.FlowLayoutPanel statsPanel;
        private QLKSDataSet qLKSDataSet;
        private System.Windows.Forms.Panel panelTotal;
        private System.Windows.Forms.Label lblTotalRooms;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelAvailable;
        private System.Windows.Forms.Label lblAvailableRooms;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panelOccupied;
        private System.Windows.Forms.Label lblOccupiedRooms;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panelCleaning;
        private System.Windows.Forms.Label lblCleaning;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panelMaintenance;
        private System.Windows.Forms.Label lblMaintenance;
        private System.Windows.Forms.Label label10;
    }
} 