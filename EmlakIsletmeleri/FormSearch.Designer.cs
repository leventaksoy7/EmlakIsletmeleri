namespace EmlakIsletmeleri
{
    partial class FormSearch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSearch));
            btnFilter = new Button();
            btnExit = new Button();
            btnDeal = new Button();
            dgSearch = new DataGridView();
            cbCity = new ComboBox();
            cbHeatingType = new ComboBox();
            cbPropertyType = new ComboBox();
            rbIsForRent = new RadioButton();
            rbIsForSale = new RadioButton();
            label15 = new Label();
            tbStreetAddress = new TextBox();
            label12 = new Label();
            tbNeighborhood = new TextBox();
            label13 = new Label();
            tbDistrict = new TextBox();
            label11 = new Label();
            tbMaxPrice = new TextBox();
            label7 = new Label();
            tbMinPrice = new TextBox();
            label6 = new Label();
            label5 = new Label();
            tbBuildingFloors = new TextBox();
            label4 = new Label();
            tbMinFloor = new TextBox();
            label3 = new Label();
            label2 = new Label();
            tbMinArea = new TextBox();
            label1 = new Label();
            tbMaxArea = new TextBox();
            tbMaxRoom = new TextBox();
            tbMinRoom = new TextBox();
            tbMaxFloor = new TextBox();
            btnClean = new Button();
            btnUpdate = new Button();
            ((System.ComponentModel.ISupportInitialize)dgSearch).BeginInit();
            SuspendLayout();
            // 
            // btnFilter
            // 
            btnFilter.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnFilter.BackColor = Color.FromArgb(19, 93, 102);
            btnFilter.FlatAppearance.BorderSize = 0;
            btnFilter.FlatStyle = FlatStyle.Flat;
            btnFilter.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            btnFilter.ForeColor = Color.White;
            btnFilter.Image = (Image)resources.GetObject("btnFilter.Image");
            btnFilter.ImageAlign = ContentAlignment.MiddleLeft;
            btnFilter.Location = new Point(12, 648);
            btnFilter.Name = "btnFilter";
            btnFilter.Size = new Size(244, 50);
            btnFilter.TabIndex = 63;
            btnFilter.Text = "FİLTRELE";
            btnFilter.UseVisualStyleBackColor = false;
            btnFilter.Click += btnFilter_Click;
            // 
            // btnExit
            // 
            btnExit.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnExit.BackColor = Color.FromArgb(19, 93, 102);
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            btnExit.ForeColor = Color.White;
            btnExit.Image = (Image)resources.GetObject("btnExit.Image");
            btnExit.ImageAlign = ContentAlignment.MiddleLeft;
            btnExit.Location = new Point(1148, 648);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(244, 50);
            btnExit.TabIndex = 62;
            btnExit.Text = "ÇIKIŞ";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // btnDeal
            // 
            btnDeal.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnDeal.BackColor = Color.FromArgb(19, 93, 102);
            btnDeal.FlatAppearance.BorderSize = 0;
            btnDeal.FlatStyle = FlatStyle.Flat;
            btnDeal.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            btnDeal.ForeColor = Color.White;
            btnDeal.Image = (Image)resources.GetObject("btnDeal.Image");
            btnDeal.ImageAlign = ContentAlignment.MiddleLeft;
            btnDeal.Location = new Point(512, 648);
            btnDeal.Name = "btnDeal";
            btnDeal.Size = new Size(244, 50);
            btnDeal.TabIndex = 64;
            btnDeal.Text = "KİRALA/SAT";
            btnDeal.UseVisualStyleBackColor = false;
            btnDeal.Click += btnDeal_Click;
            // 
            // dgSearch
            // 
            dgSearch.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgSearch.Location = new Point(615, 12);
            dgSearch.Name = "dgSearch";
            dgSearch.Size = new Size(785, 623);
            dgSearch.TabIndex = 65;
            dgSearch.CellClick += dgSearch_CellClick;
            // 
            // cbCity
            // 
            cbCity.FlatStyle = FlatStyle.Flat;
            cbCity.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            cbCity.FormattingEnabled = true;
            cbCity.Location = new Point(251, 382);
            cbCity.Name = "cbCity";
            cbCity.Size = new Size(358, 38);
            cbCity.TabIndex = 93;
            // 
            // cbHeatingType
            // 
            cbHeatingType.FlatStyle = FlatStyle.Flat;
            cbHeatingType.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            cbHeatingType.FormattingEnabled = true;
            cbHeatingType.Location = new Point(251, 278);
            cbHeatingType.Name = "cbHeatingType";
            cbHeatingType.Size = new Size(358, 38);
            cbHeatingType.TabIndex = 92;
            // 
            // cbPropertyType
            // 
            cbPropertyType.FlatStyle = FlatStyle.Flat;
            cbPropertyType.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            cbPropertyType.FormattingEnabled = true;
            cbPropertyType.Location = new Point(251, 8);
            cbPropertyType.Name = "cbPropertyType";
            cbPropertyType.Size = new Size(358, 38);
            cbPropertyType.TabIndex = 91;
            // 
            // rbIsForRent
            // 
            rbIsForRent.AutoSize = true;
            rbIsForRent.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            rbIsForRent.Location = new Point(421, 603);
            rbIsForRent.Name = "rbIsForRent";
            rbIsForRent.Size = new Size(113, 34);
            rbIsForRent.TabIndex = 89;
            rbIsForRent.TabStop = true;
            rbIsForRent.Text = "KİRALIK";
            rbIsForRent.UseVisualStyleBackColor = true;
            // 
            // rbIsForSale
            // 
            rbIsForSale.AutoSize = true;
            rbIsForSale.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            rbIsForSale.Location = new Point(253, 603);
            rbIsForSale.Name = "rbIsForSale";
            rbIsForSale.Size = new Size(108, 34);
            rbIsForSale.TabIndex = 88;
            rbIsForSale.TabStop = true;
            rbIsForSale.Text = "SATILIK";
            rbIsForSale.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label15.Location = new Point(143, 548);
            label15.Name = "label15";
            label15.Size = new Size(102, 32);
            label15.TabIndex = 86;
            label15.Text = "CADDE:";
            // 
            // tbStreetAddress
            // 
            tbStreetAddress.BorderStyle = BorderStyle.None;
            tbStreetAddress.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 162);
            tbStreetAddress.Location = new Point(253, 545);
            tbStreetAddress.Name = "tbStreetAddress";
            tbStreetAddress.Size = new Size(358, 32);
            tbStreetAddress.TabIndex = 85;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label12.Location = new Point(112, 494);
            label12.Name = "label12";
            label12.Size = new Size(133, 32);
            label12.TabIndex = 84;
            label12.Text = "MAHALLE:";
            // 
            // tbNeighborhood
            // 
            tbNeighborhood.BorderStyle = BorderStyle.None;
            tbNeighborhood.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 162);
            tbNeighborhood.Location = new Point(253, 491);
            tbNeighborhood.Name = "tbNeighborhood";
            tbNeighborhood.Size = new Size(358, 32);
            tbNeighborhood.TabIndex = 83;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label13.Location = new Point(177, 440);
            label13.Name = "label13";
            label13.Size = new Size(68, 32);
            label13.TabIndex = 82;
            label13.Text = "İLÇE:";
            // 
            // tbDistrict
            // 
            tbDistrict.BorderStyle = BorderStyle.None;
            tbDistrict.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 162);
            tbDistrict.Location = new Point(253, 437);
            tbDistrict.Name = "tbDistrict";
            tbDistrict.Size = new Size(358, 32);
            tbDistrict.TabIndex = 81;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label11.Location = new Point(204, 386);
            label11.Name = "label11";
            label11.Size = new Size(41, 32);
            label11.TabIndex = 80;
            label11.Text = "İL:";
            // 
            // tbMaxPrice
            // 
            tbMaxPrice.BorderStyle = BorderStyle.None;
            tbMaxPrice.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 162);
            tbMaxPrice.Location = new Point(436, 333);
            tbMaxPrice.Name = "tbMaxPrice";
            tbMaxPrice.Size = new Size(173, 32);
            tbMaxPrice.TabIndex = 78;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label7.Location = new Point(162, 336);
            label7.Name = "label7";
            label7.Size = new Size(83, 32);
            label7.TabIndex = 77;
            label7.Text = "FİYAT:";
            // 
            // tbMinPrice
            // 
            tbMinPrice.BorderStyle = BorderStyle.None;
            tbMinPrice.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 162);
            tbMinPrice.Location = new Point(251, 333);
            tbMinPrice.Name = "tbMinPrice";
            tbMinPrice.Size = new Size(173, 32);
            tbMinPrice.TabIndex = 76;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label6.Location = new Point(141, 282);
            label6.Name = "label6";
            label6.Size = new Size(104, 32);
            label6.TabIndex = 75;
            label6.Text = "ISITMA:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label5.Location = new Point(100, 228);
            label5.Name = "label5";
            label5.Size = new Size(145, 32);
            label5.TabIndex = 74;
            label5.Text = "KAT SAYISI:";
            // 
            // tbBuildingFloors
            // 
            tbBuildingFloors.BorderStyle = BorderStyle.None;
            tbBuildingFloors.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 162);
            tbBuildingFloors.Location = new Point(251, 225);
            tbBuildingFloors.Name = "tbBuildingFloors";
            tbBuildingFloors.Size = new Size(358, 32);
            tbBuildingFloors.TabIndex = 73;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label4.Location = new Point(23, 174);
            label4.Name = "label4";
            label4.Size = new Size(222, 32);
            label4.TabIndex = 72;
            label4.Text = "BULUNDUĞU KAT:";
            // 
            // tbMinFloor
            // 
            tbMinFloor.BorderStyle = BorderStyle.None;
            tbMinFloor.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 162);
            tbMinFloor.Location = new Point(251, 171);
            tbMinFloor.Name = "tbMinFloor";
            tbMinFloor.Size = new Size(173, 32);
            tbMinFloor.TabIndex = 71;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label3.Location = new Point(92, 120);
            label3.Name = "label3";
            label3.Size = new Size(153, 32);
            label3.TabIndex = 70;
            label3.Text = "ODA SAYISI:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.Location = new Point(100, 66);
            label2.Name = "label2";
            label2.Size = new Size(145, 32);
            label2.TabIndex = 68;
            label2.Text = "ALAN (M²):";
            // 
            // tbMinArea
            // 
            tbMinArea.BorderStyle = BorderStyle.None;
            tbMinArea.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 162);
            tbMinArea.Location = new Point(251, 63);
            tbMinArea.Name = "tbMinArea";
            tbMinArea.Size = new Size(173, 32);
            tbMinArea.TabIndex = 67;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(156, 12);
            label1.Name = "label1";
            label1.Size = new Size(89, 32);
            label1.TabIndex = 66;
            label1.Text = "MÜLK:";
            // 
            // tbMaxArea
            // 
            tbMaxArea.BorderStyle = BorderStyle.None;
            tbMaxArea.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 162);
            tbMaxArea.Location = new Point(436, 63);
            tbMaxArea.Name = "tbMaxArea";
            tbMaxArea.Size = new Size(173, 32);
            tbMaxArea.TabIndex = 94;
            // 
            // tbMaxRoom
            // 
            tbMaxRoom.BorderStyle = BorderStyle.None;
            tbMaxRoom.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 162);
            tbMaxRoom.Location = new Point(436, 117);
            tbMaxRoom.Name = "tbMaxRoom";
            tbMaxRoom.Size = new Size(173, 32);
            tbMaxRoom.TabIndex = 96;
            // 
            // tbMinRoom
            // 
            tbMinRoom.BorderStyle = BorderStyle.None;
            tbMinRoom.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 162);
            tbMinRoom.Location = new Point(251, 117);
            tbMinRoom.Name = "tbMinRoom";
            tbMinRoom.Size = new Size(173, 32);
            tbMinRoom.TabIndex = 95;
            // 
            // tbMaxFloor
            // 
            tbMaxFloor.BorderStyle = BorderStyle.None;
            tbMaxFloor.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 162);
            tbMaxFloor.Location = new Point(436, 171);
            tbMaxFloor.Name = "tbMaxFloor";
            tbMaxFloor.Size = new Size(173, 32);
            tbMaxFloor.TabIndex = 97;
            // 
            // btnClean
            // 
            btnClean.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnClean.BackColor = Color.FromArgb(19, 93, 102);
            btnClean.FlatAppearance.BorderSize = 0;
            btnClean.FlatStyle = FlatStyle.Flat;
            btnClean.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            btnClean.ForeColor = Color.White;
            btnClean.ImageAlign = ContentAlignment.MiddleLeft;
            btnClean.Location = new Point(262, 648);
            btnClean.Name = "btnClean";
            btnClean.Size = new Size(244, 50);
            btnClean.TabIndex = 98;
            btnClean.Text = "TEMİZLE";
            btnClean.UseVisualStyleBackColor = false;
            btnClean.Click += btnClean_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnUpdate.BackColor = Color.FromArgb(19, 93, 102);
            btnUpdate.FlatAppearance.BorderSize = 0;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.ImageAlign = ContentAlignment.MiddleLeft;
            btnUpdate.Location = new Point(762, 648);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(244, 50);
            btnUpdate.TabIndex = 99;
            btnUpdate.Text = "GÜNCELLE";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // FormSearch
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(119, 176, 170);
            ClientSize = new Size(1412, 710);
            Controls.Add(btnUpdate);
            Controls.Add(btnClean);
            Controls.Add(tbMaxFloor);
            Controls.Add(tbMaxRoom);
            Controls.Add(tbMinRoom);
            Controls.Add(tbMaxArea);
            Controls.Add(cbCity);
            Controls.Add(cbHeatingType);
            Controls.Add(cbPropertyType);
            Controls.Add(rbIsForRent);
            Controls.Add(rbIsForSale);
            Controls.Add(label15);
            Controls.Add(tbStreetAddress);
            Controls.Add(label12);
            Controls.Add(tbNeighborhood);
            Controls.Add(label13);
            Controls.Add(tbDistrict);
            Controls.Add(label11);
            Controls.Add(tbMaxPrice);
            Controls.Add(label7);
            Controls.Add(tbMinPrice);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(tbBuildingFloors);
            Controls.Add(label4);
            Controls.Add(tbMinFloor);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(tbMinArea);
            Controls.Add(label1);
            Controls.Add(dgSearch);
            Controls.Add(btnDeal);
            Controls.Add(btnFilter);
            Controls.Add(btnExit);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormSearch";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormSearch";
            Load += FormSearch_Load;
            ((System.ComponentModel.ISupportInitialize)dgSearch).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnFilter;
        private Button btnExit;
        private Button btnDeal;
        private DataGridView dgSearch;
        private ComboBox cbCity;
        private ComboBox cbHeatingType;
        private ComboBox cbPropertyType;
        private RadioButton rbIsForRent;
        private RadioButton rbIsForSale;
        private Label label15;
        private TextBox tbStreetAddress;
        private Label label12;
        private TextBox tbNeighborhood;
        private Label label13;
        private TextBox tbDistrict;
        private Label label11;
        private TextBox tbMaxPrice;
        private Label label7;
        private TextBox tbMinPrice;
        private Label label6;
        private Label label5;
        private TextBox tbBuildingFloors;
        private Label label4;
        private TextBox tbMinFloor;
        private Label label3;
        private Label label2;
        private TextBox tbMinArea;
        private Label label1;
        private TextBox tbMaxArea;
        private TextBox tbMaxRoom;
        private TextBox tbMinRoom;
        private TextBox tbMaxFloor;
        private Button btnClean;
        private Button btnUpdate;
    }
}