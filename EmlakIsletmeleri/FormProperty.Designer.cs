namespace EmlakIsletmeleri
{
    partial class FormProperty
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProperty));
            btnExit = new Button();
            btnSave = new Button();
            label1 = new Label();
            label2 = new Label();
            tbAreaSquareMeters = new TextBox();
            label3 = new Label();
            tbNumberOfRooms = new TextBox();
            label4 = new Label();
            tbFloor = new TextBox();
            label5 = new Label();
            tbBuildingFloors = new TextBox();
            label6 = new Label();
            label7 = new Label();
            tbSalePrice = new TextBox();
            label10 = new Label();
            tbRentPrice = new TextBox();
            label11 = new Label();
            label12 = new Label();
            tbNeighborhood = new TextBox();
            label13 = new Label();
            tbDistrict = new TextBox();
            label14 = new Label();
            label15 = new Label();
            tbStreetAddress = new TextBox();
            rbIsForSale = new RadioButton();
            rbIsForRent = new RadioButton();
            cbOwner = new ComboBox();
            cbPropertyType = new ComboBox();
            cbHeatingType = new ComboBox();
            cbCity = new ComboBox();
            rbNull = new RadioButton();
            SuspendLayout();
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
            btnExit.Location = new Point(444, 764);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(244, 50);
            btnExit.TabIndex = 20;
            btnExit.Text = "ÇIKIŞ";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnSave.BackColor = Color.FromArgb(19, 93, 102);
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            btnSave.ForeColor = Color.White;
            btnSave.Image = (Image)resources.GetObject("btnSave.Image");
            btnSave.ImageAlign = ContentAlignment.MiddleLeft;
            btnSave.Location = new Point(12, 764);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(244, 50);
            btnSave.TabIndex = 21;
            btnSave.Text = "KAYIT";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(150, 12);
            label1.Name = "label1";
            label1.Size = new Size(89, 32);
            label1.TabIndex = 23;
            label1.Text = "MÜLK:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.Location = new Point(94, 66);
            label2.Name = "label2";
            label2.Size = new Size(145, 32);
            label2.TabIndex = 25;
            label2.Text = "ALAN (M²):";
            // 
            // tbAreaSquareMeters
            // 
            tbAreaSquareMeters.BorderStyle = BorderStyle.None;
            tbAreaSquareMeters.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 162);
            tbAreaSquareMeters.Location = new Point(245, 66);
            tbAreaSquareMeters.Name = "tbAreaSquareMeters";
            tbAreaSquareMeters.Size = new Size(445, 32);
            tbAreaSquareMeters.TabIndex = 24;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label3.Location = new Point(86, 120);
            label3.Name = "label3";
            label3.Size = new Size(153, 32);
            label3.TabIndex = 27;
            label3.Text = "ODA SAYISI:";
            // 
            // tbNumberOfRooms
            // 
            tbNumberOfRooms.BorderStyle = BorderStyle.None;
            tbNumberOfRooms.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 162);
            tbNumberOfRooms.Location = new Point(245, 120);
            tbNumberOfRooms.Name = "tbNumberOfRooms";
            tbNumberOfRooms.Size = new Size(445, 32);
            tbNumberOfRooms.TabIndex = 26;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label4.Location = new Point(17, 174);
            label4.Name = "label4";
            label4.Size = new Size(222, 32);
            label4.TabIndex = 29;
            label4.Text = "BULUNDUĞU KAT:";
            // 
            // tbFloor
            // 
            tbFloor.BorderStyle = BorderStyle.None;
            tbFloor.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 162);
            tbFloor.Location = new Point(245, 174);
            tbFloor.Name = "tbFloor";
            tbFloor.Size = new Size(445, 32);
            tbFloor.TabIndex = 28;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label5.Location = new Point(94, 228);
            label5.Name = "label5";
            label5.Size = new Size(145, 32);
            label5.TabIndex = 31;
            label5.Text = "KAT SAYISI:";
            // 
            // tbBuildingFloors
            // 
            tbBuildingFloors.BorderStyle = BorderStyle.None;
            tbBuildingFloors.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 162);
            tbBuildingFloors.Location = new Point(245, 228);
            tbBuildingFloors.Name = "tbBuildingFloors";
            tbBuildingFloors.Size = new Size(445, 32);
            tbBuildingFloors.TabIndex = 30;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label6.Location = new Point(135, 282);
            label6.Name = "label6";
            label6.Size = new Size(104, 32);
            label6.TabIndex = 33;
            label6.Text = "ISITMA:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label7.Location = new Point(156, 336);
            label7.Name = "label7";
            label7.Size = new Size(83, 32);
            label7.TabIndex = 35;
            label7.Text = "FİYAT:";
            label7.Visible = false;
            // 
            // tbSalePrice
            // 
            tbSalePrice.BorderStyle = BorderStyle.None;
            tbSalePrice.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 162);
            tbSalePrice.Location = new Point(245, 336);
            tbSalePrice.Name = "tbSalePrice";
            tbSalePrice.Size = new Size(445, 32);
            tbSalePrice.TabIndex = 34;
            tbSalePrice.Visible = false;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label10.Location = new Point(161, 390);
            label10.Name = "label10";
            label10.Size = new Size(78, 32);
            label10.TabIndex = 41;
            label10.Text = "KİRA:";
            label10.Visible = false;
            // 
            // tbRentPrice
            // 
            tbRentPrice.BorderStyle = BorderStyle.None;
            tbRentPrice.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 162);
            tbRentPrice.Location = new Point(245, 390);
            tbRentPrice.Name = "tbRentPrice";
            tbRentPrice.Size = new Size(445, 32);
            tbRentPrice.TabIndex = 40;
            tbRentPrice.Visible = false;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label11.Location = new Point(196, 444);
            label11.Name = "label11";
            label11.Size = new Size(41, 32);
            label11.TabIndex = 43;
            label11.Text = "İL:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label12.Location = new Point(106, 552);
            label12.Name = "label12";
            label12.Size = new Size(133, 32);
            label12.TabIndex = 47;
            label12.Text = "MAHALLE:";
            // 
            // tbNeighborhood
            // 
            tbNeighborhood.BorderStyle = BorderStyle.None;
            tbNeighborhood.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 162);
            tbNeighborhood.Location = new Point(245, 552);
            tbNeighborhood.Name = "tbNeighborhood";
            tbNeighborhood.Size = new Size(445, 32);
            tbNeighborhood.TabIndex = 46;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label13.Location = new Point(171, 498);
            label13.Name = "label13";
            label13.Size = new Size(68, 32);
            label13.TabIndex = 45;
            label13.Text = "İLÇE:";
            // 
            // tbDistrict
            // 
            tbDistrict.BorderStyle = BorderStyle.None;
            tbDistrict.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 162);
            tbDistrict.Location = new Point(245, 498);
            tbDistrict.Name = "tbDistrict";
            tbDistrict.Size = new Size(445, 32);
            tbDistrict.TabIndex = 44;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label14.Location = new Point(64, 660);
            label14.Name = "label14";
            label14.Size = new Size(175, 32);
            label14.TabIndex = 51;
            label14.Text = "MÜLK SAHİBİ:";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label15.Location = new Point(137, 606);
            label15.Name = "label15";
            label15.Size = new Size(102, 32);
            label15.TabIndex = 49;
            label15.Text = "CADDE:";
            // 
            // tbStreetAddress
            // 
            tbStreetAddress.BorderStyle = BorderStyle.None;
            tbStreetAddress.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 162);
            tbStreetAddress.Location = new Point(245, 606);
            tbStreetAddress.Name = "tbStreetAddress";
            tbStreetAddress.Size = new Size(445, 32);
            tbStreetAddress.TabIndex = 48;
            // 
            // rbIsForSale
            // 
            rbIsForSale.AutoSize = true;
            rbIsForSale.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            rbIsForSale.Location = new Point(245, 713);
            rbIsForSale.Name = "rbIsForSale";
            rbIsForSale.Size = new Size(108, 34);
            rbIsForSale.TabIndex = 52;
            rbIsForSale.TabStop = true;
            rbIsForSale.Text = "SATILIK";
            rbIsForSale.UseVisualStyleBackColor = true;
            rbIsForSale.CheckedChanged += rbIsForSale_CheckedChanged;
            // 
            // rbIsForRent
            // 
            rbIsForRent.AutoSize = true;
            rbIsForRent.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            rbIsForRent.Location = new Point(405, 713);
            rbIsForRent.Name = "rbIsForRent";
            rbIsForRent.Size = new Size(113, 34);
            rbIsForRent.TabIndex = 53;
            rbIsForRent.TabStop = true;
            rbIsForRent.Text = "KİRALIK";
            rbIsForRent.UseVisualStyleBackColor = true;
            rbIsForRent.CheckedChanged += rbIsForRent_CheckedChanged;
            // 
            // cbOwner
            // 
            cbOwner.FlatStyle = FlatStyle.Flat;
            cbOwner.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            cbOwner.FormattingEnabled = true;
            cbOwner.Location = new Point(245, 660);
            cbOwner.Name = "cbOwner";
            cbOwner.Size = new Size(445, 38);
            cbOwner.TabIndex = 54;
            cbOwner.SelectedIndexChanged += cbOwner_SelectedIndexChanged;
            cbOwner.TextChanged += cbOwner_TextChanged;
            // 
            // cbPropertyType
            // 
            cbPropertyType.FlatStyle = FlatStyle.Flat;
            cbPropertyType.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            cbPropertyType.FormattingEnabled = true;
            cbPropertyType.Location = new Point(245, 11);
            cbPropertyType.Name = "cbPropertyType";
            cbPropertyType.Size = new Size(445, 38);
            cbPropertyType.TabIndex = 55;
            // 
            // cbHeatingType
            // 
            cbHeatingType.FlatStyle = FlatStyle.Flat;
            cbHeatingType.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            cbHeatingType.FormattingEnabled = true;
            cbHeatingType.Location = new Point(245, 281);
            cbHeatingType.Name = "cbHeatingType";
            cbHeatingType.Size = new Size(445, 38);
            cbHeatingType.TabIndex = 56;
            // 
            // cbCity
            // 
            cbCity.FlatStyle = FlatStyle.Flat;
            cbCity.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            cbCity.FormattingEnabled = true;
            cbCity.Location = new Point(243, 443);
            cbCity.Name = "cbCity";
            cbCity.Size = new Size(445, 38);
            cbCity.TabIndex = 57;
            // 
            // rbNull
            // 
            rbNull.AutoSize = true;
            rbNull.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            rbNull.Location = new Point(582, 713);
            rbNull.Name = "rbNull";
            rbNull.Size = new Size(108, 34);
            rbNull.TabIndex = 58;
            rbNull.TabStop = true;
            rbNull.Text = "HİÇBİRİ";
            rbNull.UseVisualStyleBackColor = true;
            rbNull.CheckedChanged += rbNull_CheckedChanged;
            // 
            // FormProperty
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(119, 176, 170);
            ClientSize = new Size(700, 825);
            Controls.Add(rbNull);
            Controls.Add(cbCity);
            Controls.Add(cbHeatingType);
            Controls.Add(cbPropertyType);
            Controls.Add(cbOwner);
            Controls.Add(rbIsForRent);
            Controls.Add(rbIsForSale);
            Controls.Add(label14);
            Controls.Add(label15);
            Controls.Add(tbStreetAddress);
            Controls.Add(label12);
            Controls.Add(tbNeighborhood);
            Controls.Add(label13);
            Controls.Add(tbDistrict);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(tbRentPrice);
            Controls.Add(label7);
            Controls.Add(tbSalePrice);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(tbBuildingFloors);
            Controls.Add(label4);
            Controls.Add(tbFloor);
            Controls.Add(label3);
            Controls.Add(tbNumberOfRooms);
            Controls.Add(label2);
            Controls.Add(tbAreaSquareMeters);
            Controls.Add(label1);
            Controls.Add(btnSave);
            Controls.Add(btnExit);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormProperty";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormProperty";
            Load += FormProperty_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnExit;
        private Button btnSave;
        private Label label1;
        private Label label2;
        private TextBox tbAreaSquareMeters;
        private Label label3;
        private TextBox tbNumberOfRooms;
        private Label label4;
        private TextBox tbFloor;
        private Label label5;
        private TextBox tbBuildingFloors;
        private Label label6;
        private Label label7;
        private TextBox tbSalePrice;
        private Label label10;
        private TextBox tbRentPrice;
        private Label label11;
        private Label label12;
        private TextBox tbNeighborhood;
        private Label label13;
        private TextBox tbDistrict;
        private Label label14;
        private Label label15;
        private TextBox tbStreetAddress;
        private RadioButton rbIsForSale;
        private RadioButton rbIsForRent;
        private ComboBox cbOwner;
        private ComboBox cbPropertyType;
        private ComboBox cbHeatingType;
        private ComboBox cbCity;
        private RadioButton rbNull;
    }
}