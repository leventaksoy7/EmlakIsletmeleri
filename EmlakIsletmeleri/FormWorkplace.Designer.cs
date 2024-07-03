namespace EmlakIsletmeleri
{
    partial class FormWorkplace
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormWorkplace));
            label4 = new Label();
            tbAddress = new TextBox();
            label3 = new Label();
            tbAuthorizedPerson = new TextBox();
            label2 = new Label();
            tbName = new TextBox();
            label1 = new Label();
            tbPassword = new TextBox();
            label15 = new Label();
            tbUserName = new TextBox();
            btnSave = new Button();
            btnExit = new Button();
            label5 = new Label();
            tbPhone = new TextBox();
            label6 = new Label();
            tbFax = new TextBox();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label4.Location = new Point(139, 164);
            label4.Name = "label4";
            label4.Size = new Size(98, 32);
            label4.TabIndex = 71;
            label4.Text = "ADRES:";
            // 
            // tbAddress
            // 
            tbAddress.BorderStyle = BorderStyle.None;
            tbAddress.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 162);
            tbAddress.Location = new Point(243, 164);
            tbAddress.Name = "tbAddress";
            tbAddress.Size = new Size(445, 32);
            tbAddress.TabIndex = 70;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label3.Location = new Point(107, 126);
            label3.Name = "label3";
            label3.Size = new Size(130, 32);
            label3.TabIndex = 69;
            label3.Text = "YÖNETİCİ:";
            // 
            // tbAuthorizedPerson
            // 
            tbAuthorizedPerson.BorderStyle = BorderStyle.None;
            tbAuthorizedPerson.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 162);
            tbAuthorizedPerson.Location = new Point(243, 126);
            tbAuthorizedPerson.Name = "tbAuthorizedPerson";
            tbAuthorizedPerson.Size = new Size(445, 32);
            tbAuthorizedPerson.TabIndex = 68;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.Location = new Point(164, 88);
            label2.Name = "label2";
            label2.Size = new Size(73, 32);
            label2.TabIndex = 67;
            label2.Text = "İSİM:";
            // 
            // tbName
            // 
            tbName.BorderStyle = BorderStyle.None;
            tbName.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 162);
            tbName.Location = new Point(243, 88);
            tbName.Name = "tbName";
            tbName.Size = new Size(445, 32);
            tbName.TabIndex = 66;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(154, 50);
            label1.Name = "label1";
            label1.Size = new Size(83, 32);
            label1.TabIndex = 65;
            label1.Text = "ŞİFRE:";
            // 
            // tbPassword
            // 
            tbPassword.BorderStyle = BorderStyle.None;
            tbPassword.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 162);
            tbPassword.Location = new Point(243, 50);
            tbPassword.Name = "tbPassword";
            tbPassword.PasswordChar = '*';
            tbPassword.Size = new Size(445, 32);
            tbPassword.TabIndex = 64;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label15.Location = new Point(41, 12);
            label15.Name = "label15";
            label15.Size = new Size(196, 32);
            label15.TabIndex = 63;
            label15.Text = "KULLANICI ADI:";
            // 
            // tbUserName
            // 
            tbUserName.BorderStyle = BorderStyle.None;
            tbUserName.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 162);
            tbUserName.Location = new Point(243, 12);
            tbUserName.Name = "tbUserName";
            tbUserName.Size = new Size(445, 32);
            tbUserName.TabIndex = 62;
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
            btnSave.Location = new Point(12, 763);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(244, 50);
            btnSave.TabIndex = 61;
            btnSave.Text = "KAYIT";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
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
            btnExit.Location = new Point(444, 763);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(244, 50);
            btnExit.TabIndex = 60;
            btnExit.Text = "ÇIKIŞ";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label5.Location = new Point(115, 202);
            label5.Name = "label5";
            label5.Size = new Size(122, 32);
            label5.TabIndex = 73;
            label5.Text = "TELEFON:";
            // 
            // tbPhone
            // 
            tbPhone.BorderStyle = BorderStyle.None;
            tbPhone.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 162);
            tbPhone.Location = new Point(243, 202);
            tbPhone.Name = "tbPhone";
            tbPhone.Size = new Size(445, 32);
            tbPhone.TabIndex = 72;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label6.Location = new Point(172, 240);
            label6.Name = "label6";
            label6.Size = new Size(65, 32);
            label6.TabIndex = 75;
            label6.Text = "FAX:";
            // 
            // tbFax
            // 
            tbFax.BorderStyle = BorderStyle.None;
            tbFax.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 162);
            tbFax.Location = new Point(243, 240);
            tbFax.Name = "tbFax";
            tbFax.Size = new Size(445, 32);
            tbFax.TabIndex = 74;
            // 
            // FormWorkplace
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(119, 176, 170);
            ClientSize = new Size(700, 825);
            Controls.Add(label6);
            Controls.Add(tbFax);
            Controls.Add(label5);
            Controls.Add(tbPhone);
            Controls.Add(label4);
            Controls.Add(tbAddress);
            Controls.Add(label3);
            Controls.Add(tbAuthorizedPerson);
            Controls.Add(label2);
            Controls.Add(tbName);
            Controls.Add(label1);
            Controls.Add(tbPassword);
            Controls.Add(label15);
            Controls.Add(tbUserName);
            Controls.Add(btnSave);
            Controls.Add(btnExit);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormWorkplace";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormWorkplace";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private TextBox tbAddress;
        private Label label3;
        private TextBox tbAuthorizedPerson;
        private Label label2;
        private TextBox tbName;
        private Label label1;
        private TextBox tbPassword;
        private Label label15;
        private TextBox tbUserName;
        private Button btnSave;
        private Button btnExit;
        private Label label5;
        private TextBox tbPhone;
        private Label label6;
        private TextBox tbFax;
    }
}