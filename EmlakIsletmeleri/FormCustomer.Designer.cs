namespace EmlakIsletmeleri
{
    partial class FormCustomer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCustomer));
            btnSave = new Button();
            btnExit = new Button();
            label15 = new Label();
            tbFirstName = new TextBox();
            label1 = new Label();
            tbLastName = new TextBox();
            label2 = new Label();
            tbHomePhone = new TextBox();
            label3 = new Label();
            tbCellPhone = new TextBox();
            label4 = new Label();
            tbEmail = new TextBox();
            SuspendLayout();
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
            btnSave.TabIndex = 23;
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
            btnExit.TabIndex = 22;
            btnExit.Text = "ÇIKIŞ";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // label15
            // 
            label15.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label15.Location = new Point(181, 12);
            label15.Name = "label15";
            label15.Size = new Size(56, 32);
            label15.TabIndex = 51;
            label15.Text = "AD:";
            // 
            // tbFirstName
            // 
            tbFirstName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbFirstName.BorderStyle = BorderStyle.None;
            tbFirstName.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 162);
            tbFirstName.Location = new Point(243, 12);
            tbFirstName.Name = "tbFirstName";
            tbFirstName.Size = new Size(445, 32);
            tbFirstName.TabIndex = 50;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(137, 50);
            label1.Name = "label1";
            label1.Size = new Size(100, 32);
            label1.TabIndex = 53;
            label1.Text = "SOYAD:";
            // 
            // tbLastName
            // 
            tbLastName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbLastName.BorderStyle = BorderStyle.None;
            tbLastName.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 162);
            tbLastName.Location = new Point(243, 50);
            tbLastName.Name = "tbLastName";
            tbLastName.Size = new Size(445, 32);
            tbLastName.TabIndex = 52;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.Location = new Point(62, 88);
            label2.Name = "label2";
            label2.Size = new Size(175, 32);
            label2.TabIndex = 55;
            label2.Text = "EV TELEFONU:";
            // 
            // tbHomePhone
            // 
            tbHomePhone.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbHomePhone.BorderStyle = BorderStyle.None;
            tbHomePhone.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 162);
            tbHomePhone.Location = new Point(243, 88);
            tbHomePhone.Name = "tbHomePhone";
            tbHomePhone.Size = new Size(445, 32);
            tbHomePhone.TabIndex = 54;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label3.Location = new Point(48, 126);
            label3.Name = "label3";
            label3.Size = new Size(189, 32);
            label3.TabIndex = 57;
            label3.Text = "CEP TELEFONU:";
            // 
            // tbCellPhone
            // 
            tbCellPhone.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbCellPhone.BorderStyle = BorderStyle.None;
            tbCellPhone.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 162);
            tbCellPhone.Location = new Point(243, 126);
            tbCellPhone.Name = "tbCellPhone";
            tbCellPhone.Size = new Size(445, 32);
            tbCellPhone.TabIndex = 56;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label4.Location = new Point(133, 164);
            label4.Name = "label4";
            label4.Size = new Size(104, 32);
            label4.TabIndex = 59;
            label4.Text = "E-MAIL:";
            // 
            // tbEmail
            // 
            tbEmail.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbEmail.BorderStyle = BorderStyle.None;
            tbEmail.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 162);
            tbEmail.Location = new Point(243, 164);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(445, 32);
            tbEmail.TabIndex = 58;
            // 
            // FormCustomer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(119, 176, 170);
            ClientSize = new Size(700, 825);
            Controls.Add(label4);
            Controls.Add(tbEmail);
            Controls.Add(label3);
            Controls.Add(tbCellPhone);
            Controls.Add(label2);
            Controls.Add(tbHomePhone);
            Controls.Add(label1);
            Controls.Add(tbLastName);
            Controls.Add(label15);
            Controls.Add(tbFirstName);
            Controls.Add(btnSave);
            Controls.Add(btnExit);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormCustomer";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormCustomer";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSave;
        private Button btnExit;
        private Label label15;
        private TextBox tbFirstName;
        private Label label1;
        private TextBox tbLastName;
        private Label label2;
        private TextBox tbHomePhone;
        private Label label3;
        private TextBox tbCellPhone;
        private Label label4;
        private TextBox tbEmail;
    }
}