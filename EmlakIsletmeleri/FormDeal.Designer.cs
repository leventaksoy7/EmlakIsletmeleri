namespace EmlakIsletmeleri
{
    partial class FormDeal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDeal));
            btnDeal = new Button();
            btnExit = new Button();
            cbCustomers = new ComboBox();
            label14 = new Label();
            lblPropertyType = new Label();
            lblAreaSquareMeters = new Label();
            lblNumberOfRooms = new Label();
            lblFloor = new Label();
            lblBuildingFloors = new Label();
            lblHeatingType = new Label();
            lblPrice = new Label();
            lblCity = new Label();
            lblDistrict = new Label();
            lblNeighborhood = new Label();
            lblStreetAddress = new Label();
            lblDate = new Label();
            lblOwner = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label10 = new Label();
            label12 = new Label();
            label13 = new Label();
            label15 = new Label();
            label9 = new Label();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            fontDialog1 = new FontDialog();
            btnRapor = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // btnDeal
            // 
            btnDeal.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnDeal.BackColor = Color.FromArgb(19, 93, 102);
            btnDeal.FlatAppearance.BorderSize = 0;
            btnDeal.FlatStyle = FlatStyle.Flat;
            btnDeal.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            btnDeal.ForeColor = Color.White;
            btnDeal.ImageAlign = ContentAlignment.MiddleLeft;
            btnDeal.Location = new Point(12, 763);
            btnDeal.Name = "btnDeal";
            btnDeal.Size = new Size(244, 50);
            btnDeal.TabIndex = 63;
            btnDeal.Text = "ANLAŞMA";
            btnDeal.UseVisualStyleBackColor = false;
            btnDeal.Click += btnDeal_Click;
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
            btnExit.Location = new Point(512, 763);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(244, 50);
            btnExit.TabIndex = 62;
            btnExit.Text = "ÇIKIŞ";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // cbCustomers
            // 
            cbCustomers.FlatStyle = FlatStyle.Flat;
            cbCustomers.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            cbCustomers.FormattingEnabled = true;
            cbCustomers.Location = new Point(260, 53);
            cbCustomers.Name = "cbCustomers";
            cbCustomers.Size = new Size(410, 38);
            cbCustomers.TabIndex = 65;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label14.Location = new Point(119, 54);
            label14.Name = "label14";
            label14.Size = new Size(125, 32);
            label14.TabIndex = 64;
            label14.Text = "MÜŞTERİ:";
            // 
            // lblPropertyType
            // 
            lblPropertyType.AutoSize = true;
            lblPropertyType.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblPropertyType.Location = new Point(250, 35);
            lblPropertyType.Name = "lblPropertyType";
            lblPropertyType.Size = new Size(198, 32);
            lblPropertyType.TabIndex = 66;
            lblPropertyType.Text = "lblPropertyType";
            // 
            // lblAreaSquareMeters
            // 
            lblAreaSquareMeters.AutoSize = true;
            lblAreaSquareMeters.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblAreaSquareMeters.Location = new Point(250, 75);
            lblAreaSquareMeters.Name = "lblAreaSquareMeters";
            lblAreaSquareMeters.Size = new Size(254, 32);
            lblAreaSquareMeters.TabIndex = 67;
            lblAreaSquareMeters.Text = "lblAreaSquareMeters";
            // 
            // lblNumberOfRooms
            // 
            lblNumberOfRooms.AutoSize = true;
            lblNumberOfRooms.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblNumberOfRooms.Location = new Point(250, 115);
            lblNumberOfRooms.Name = "lblNumberOfRooms";
            lblNumberOfRooms.Size = new Size(242, 32);
            lblNumberOfRooms.TabIndex = 68;
            lblNumberOfRooms.Text = "lblNumberOfRooms";
            // 
            // lblFloor
            // 
            lblFloor.AutoSize = true;
            lblFloor.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblFloor.Location = new Point(250, 155);
            lblFloor.Name = "lblFloor";
            lblFloor.Size = new Size(102, 32);
            lblFloor.TabIndex = 69;
            lblFloor.Text = "lblFloor";
            // 
            // lblBuildingFloors
            // 
            lblBuildingFloors.AutoSize = true;
            lblBuildingFloors.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblBuildingFloors.Location = new Point(250, 195);
            lblBuildingFloors.Name = "lblBuildingFloors";
            lblBuildingFloors.Size = new Size(209, 32);
            lblBuildingFloors.TabIndex = 70;
            lblBuildingFloors.Text = "lblBuildingFloors";
            // 
            // lblHeatingType
            // 
            lblHeatingType.AutoSize = true;
            lblHeatingType.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblHeatingType.Location = new Point(250, 235);
            lblHeatingType.Name = "lblHeatingType";
            lblHeatingType.Size = new Size(187, 32);
            lblHeatingType.TabIndex = 71;
            lblHeatingType.Text = "lblHeatingType";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblPrice.Location = new Point(250, 275);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(100, 32);
            lblPrice.TabIndex = 72;
            lblPrice.Text = "lblPrice";
            // 
            // lblCity
            // 
            lblCity.AutoSize = true;
            lblCity.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblCity.Location = new Point(250, 315);
            lblCity.Name = "lblCity";
            lblCity.Size = new Size(87, 32);
            lblCity.TabIndex = 73;
            lblCity.Text = "lblCity";
            // 
            // lblDistrict
            // 
            lblDistrict.AutoSize = true;
            lblDistrict.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblDistrict.Location = new Point(250, 355);
            lblDistrict.Name = "lblDistrict";
            lblDistrict.Size = new Size(126, 32);
            lblDistrict.TabIndex = 74;
            lblDistrict.Text = "lblDistrict";
            // 
            // lblNeighborhood
            // 
            lblNeighborhood.AutoSize = true;
            lblNeighborhood.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblNeighborhood.Location = new Point(250, 395);
            lblNeighborhood.Name = "lblNeighborhood";
            lblNeighborhood.Size = new Size(210, 32);
            lblNeighborhood.TabIndex = 75;
            lblNeighborhood.Text = "lblNeighborhood";
            // 
            // lblStreetAddress
            // 
            lblStreetAddress.AutoSize = true;
            lblStreetAddress.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblStreetAddress.Location = new Point(250, 435);
            lblStreetAddress.Name = "lblStreetAddress";
            lblStreetAddress.Size = new Size(201, 32);
            lblStreetAddress.TabIndex = 76;
            lblStreetAddress.Text = "lblStreetAddress";
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblDate.Location = new Point(250, 475);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(96, 32);
            lblDate.TabIndex = 77;
            lblDate.Text = "lblDate";
            // 
            // lblOwner
            // 
            lblOwner.AutoSize = true;
            lblOwner.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblOwner.Location = new Point(250, 515);
            lblOwner.Name = "lblOwner";
            lblOwner.Size = new Size(118, 32);
            lblOwner.TabIndex = 78;
            lblOwner.Text = "lblOwner";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(155, 35);
            label1.Name = "label1";
            label1.Size = new Size(89, 32);
            label1.TabIndex = 80;
            label1.Text = "MÜLK:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.Location = new Point(99, 75);
            label2.Name = "label2";
            label2.Size = new Size(145, 32);
            label2.TabIndex = 81;
            label2.Text = "ALAN (M²):";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label3.Location = new Point(22, 155);
            label3.Name = "label3";
            label3.Size = new Size(222, 32);
            label3.TabIndex = 82;
            label3.Text = "BULUNDUĞU KAT:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label4.Location = new Point(99, 195);
            label4.Name = "label4";
            label4.Size = new Size(145, 32);
            label4.TabIndex = 83;
            label4.Text = "KAT SAYISI:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label5.Location = new Point(140, 235);
            label5.Name = "label5";
            label5.Size = new Size(104, 32);
            label5.TabIndex = 84;
            label5.Text = "ISITMA:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label6.Location = new Point(161, 275);
            label6.Name = "label6";
            label6.Size = new Size(83, 32);
            label6.TabIndex = 85;
            label6.Text = "FİYAT:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label7.Location = new Point(203, 315);
            label7.Name = "label7";
            label7.Size = new Size(41, 32);
            label7.TabIndex = 86;
            label7.Text = "İL:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label8.Location = new Point(176, 355);
            label8.Name = "label8";
            label8.Size = new Size(68, 32);
            label8.TabIndex = 87;
            label8.Text = "İLÇE:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label10.Location = new Point(111, 395);
            label10.Name = "label10";
            label10.Size = new Size(133, 32);
            label10.TabIndex = 88;
            label10.Text = "MAHALLE:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label12.Location = new Point(142, 435);
            label12.Name = "label12";
            label12.Size = new Size(102, 32);
            label12.TabIndex = 89;
            label12.Text = "CADDE:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label13.Location = new Point(152, 475);
            label13.Name = "label13";
            label13.Size = new Size(92, 32);
            label13.TabIndex = 90;
            label13.Text = "TARİH:";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label15.Location = new Point(69, 515);
            label15.Name = "label15";
            label15.Size = new Size(175, 32);
            label15.TabIndex = 91;
            label15.Text = "MÜLK SAHİBİ:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label9.Location = new Point(91, 115);
            label9.Name = "label9";
            label9.Size = new Size(153, 32);
            label9.TabIndex = 92;
            label9.Text = "ODA SAYISI:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(lblPropertyType);
            groupBox1.Controls.Add(label15);
            groupBox1.Controls.Add(lblAreaSquareMeters);
            groupBox1.Controls.Add(label13);
            groupBox1.Controls.Add(lblNumberOfRooms);
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(lblFloor);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(lblBuildingFloors);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(lblHeatingType);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(lblPrice);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(lblCity);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(lblDistrict);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(lblNeighborhood);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(lblStreetAddress);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(lblDate);
            groupBox1.Controls.Add(lblOwner);
            groupBox1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            groupBox1.Location = new Point(50, 150);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(676, 553);
            groupBox1.TabIndex = 93;
            groupBox1.TabStop = false;
            groupBox1.Text = "MÜLK BİLGİLERİ";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label14);
            groupBox2.Controls.Add(cbCustomers);
            groupBox2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            groupBox2.Location = new Point(50, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(676, 132);
            groupBox2.TabIndex = 94;
            groupBox2.TabStop = false;
            groupBox2.Text = "MÜŞTERİ BİLGİLERİ";
            // 
            // btnRapor
            // 
            btnRapor.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnRapor.BackColor = Color.FromArgb(19, 93, 102);
            btnRapor.FlatAppearance.BorderSize = 0;
            btnRapor.FlatStyle = FlatStyle.Flat;
            btnRapor.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            btnRapor.ForeColor = Color.White;
            btnRapor.ImageAlign = ContentAlignment.MiddleLeft;
            btnRapor.Location = new Point(262, 763);
            btnRapor.Name = "btnRapor";
            btnRapor.Size = new Size(244, 50);
            btnRapor.TabIndex = 95;
            btnRapor.Text = "RAPOR";
            btnRapor.UseVisualStyleBackColor = false;
            btnRapor.Click += btnRapor_Click;
            // 
            // FormDeal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(119, 176, 170);
            ClientSize = new Size(768, 825);
            Controls.Add(btnRapor);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(btnDeal);
            Controls.Add(btnExit);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormDeal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormDeal";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnDeal;
        private Button btnExit;
        private ComboBox cbCustomers;
        private Label label14;
        private Label lblPropertyType;
        private Label lblAreaSquareMeters;
        private Label lblNumberOfRooms;
        private Label lblFloor;
        private Label lblBuildingFloors;
        private Label lblHeatingType;
        private Label lblPrice;
        private Label lblCity;
        private Label lblDistrict;
        private Label lblNeighborhood;
        private Label lblStreetAddress;
        private Label lblDate;
        private Label lblOwner;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label10;
        private Label label12;
        private Label label13;
        private Label label15;
        private Label label9;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private FontDialog fontDialog1;
        private Button btnRapor;
    }
}