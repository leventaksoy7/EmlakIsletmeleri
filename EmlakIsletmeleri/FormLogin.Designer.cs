namespace EmlakIsletmeleri
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            btnExit = new Button();
            btnWorkplace = new Button();
            label1 = new Label();
            tbPassword = new TextBox();
            label15 = new Label();
            tbUserName = new TextBox();
            btnLogIn = new Button();
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
            btnExit.Location = new Point(543, 138);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(244, 50);
            btnExit.TabIndex = 23;
            btnExit.Text = "ÇIKIŞ";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // btnWorkplace
            // 
            btnWorkplace.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnWorkplace.BackColor = Color.FromArgb(19, 93, 102);
            btnWorkplace.FlatAppearance.BorderSize = 0;
            btnWorkplace.FlatStyle = FlatStyle.Flat;
            btnWorkplace.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            btnWorkplace.ForeColor = Color.White;
            btnWorkplace.Image = (Image)resources.GetObject("btnWorkplace.Image");
            btnWorkplace.ImageAlign = ContentAlignment.MiddleLeft;
            btnWorkplace.Location = new Point(279, 138);
            btnWorkplace.Name = "btnWorkplace";
            btnWorkplace.Size = new Size(244, 50);
            btnWorkplace.TabIndex = 24;
            btnWorkplace.Text = "KAYIT";
            btnWorkplace.UseVisualStyleBackColor = false;
            btnWorkplace.Click += btnWorkplace_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(200, 59);
            label1.Name = "label1";
            label1.Size = new Size(83, 32);
            label1.TabIndex = 57;
            label1.Text = "ŞİFRE:";
            // 
            // tbPassword
            // 
            tbPassword.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbPassword.BorderStyle = BorderStyle.None;
            tbPassword.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 162);
            tbPassword.Location = new Point(289, 59);
            tbPassword.Name = "tbPassword";
            tbPassword.PasswordChar = '*';
            tbPassword.Size = new Size(444, 32);
            tbPassword.TabIndex = 56;
            // 
            // label15
            // 
            label15.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label15.Location = new Point(87, 21);
            label15.Name = "label15";
            label15.Size = new Size(196, 32);
            label15.TabIndex = 55;
            label15.Text = "KULLANICI ADI:";
            // 
            // tbUserName
            // 
            tbUserName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbUserName.BorderStyle = BorderStyle.None;
            tbUserName.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 162);
            tbUserName.Location = new Point(289, 21);
            tbUserName.Name = "tbUserName";
            tbUserName.Size = new Size(444, 32);
            tbUserName.TabIndex = 54;
            // 
            // btnLogIn
            // 
            btnLogIn.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnLogIn.BackColor = Color.FromArgb(19, 93, 102);
            btnLogIn.FlatAppearance.BorderSize = 0;
            btnLogIn.FlatStyle = FlatStyle.Flat;
            btnLogIn.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            btnLogIn.ForeColor = Color.White;
            btnLogIn.ImageAlign = ContentAlignment.MiddleLeft;
            btnLogIn.Location = new Point(12, 138);
            btnLogIn.Name = "btnLogIn";
            btnLogIn.Size = new Size(244, 50);
            btnLogIn.TabIndex = 58;
            btnLogIn.Text = "GİRİŞ";
            btnLogIn.UseVisualStyleBackColor = false;
            btnLogIn.Click += btnLogIn_Click;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(119, 176, 170);
            ClientSize = new Size(799, 200);
            Controls.Add(btnLogIn);
            Controls.Add(label1);
            Controls.Add(tbPassword);
            Controls.Add(label15);
            Controls.Add(tbUserName);
            Controls.Add(btnWorkplace);
            Controls.Add(btnExit);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormLogin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnExit;
        private Button btnWorkplace;
        private Label label1;
        private TextBox tbPassword;
        private Label label15;
        private TextBox tbUserName;
        private Button btnLogIn;
    }
}