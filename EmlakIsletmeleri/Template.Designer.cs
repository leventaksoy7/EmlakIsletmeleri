namespace EmlakIsletmeleri
{
    partial class Template
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Template));
            btnWorkplace = new Button();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            btnLogin = new Button();
            btnRaport = new Button();
            btnSearch = new Button();
            btnProperty = new Button();
            btnCostumer = new Button();
            btnExit = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // btnWorkplace
            // 
            btnWorkplace.Anchor = AnchorStyles.Left;
            btnWorkplace.BackColor = Color.FromArgb(19, 93, 102);
            btnWorkplace.FlatAppearance.BorderSize = 0;
            btnWorkplace.FlatStyle = FlatStyle.Flat;
            btnWorkplace.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            btnWorkplace.ForeColor = Color.White;
            btnWorkplace.Image = (Image)resources.GetObject("btnWorkplace.Image");
            btnWorkplace.ImageAlign = ContentAlignment.MiddleLeft;
            btnWorkplace.Location = new Point(3, 0);
            btnWorkplace.Name = "btnWorkplace";
            btnWorkplace.Size = new Size(244, 50);
            btnWorkplace.TabIndex = 0;
            btnWorkplace.Text = "İŞLETME KAYIT";
            btnWorkplace.UseVisualStyleBackColor = false;
            btnWorkplace.Click += btnWorkplace_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top;
            panel1.BackColor = Color.FromArgb(118, 171, 174);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1920, 100);
            panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(200, 100);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Left;
            panel2.BackColor = Color.FromArgb(118, 171, 174);
            panel2.Controls.Add(btnLogin);
            panel2.Controls.Add(btnRaport);
            panel2.Controls.Add(btnSearch);
            panel2.Controls.Add(btnProperty);
            panel2.Controls.Add(btnCostumer);
            panel2.Controls.Add(btnExit);
            panel2.Controls.Add(btnWorkplace);
            panel2.Location = new Point(0, 100);
            panel2.Name = "panel2";
            panel2.Size = new Size(250, 950);
            panel2.TabIndex = 2;
            // 
            // btnLogin
            // 
            btnLogin.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnLogin.BackColor = Color.FromArgb(19, 93, 102);
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            btnLogin.ForeColor = Color.White;
            btnLogin.Image = (Image)resources.GetObject("btnLogin.Image");
            btnLogin.ImageAlign = ContentAlignment.MiddleLeft;
            btnLogin.Location = new Point(3, 822);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(244, 50);
            btnLogin.TabIndex = 20;
            btnLogin.Text = "İŞLETME GİRİŞİ";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnRaport
            // 
            btnRaport.Anchor = AnchorStyles.Left;
            btnRaport.BackColor = Color.FromArgb(19, 93, 102);
            btnRaport.FlatAppearance.BorderSize = 0;
            btnRaport.FlatStyle = FlatStyle.Flat;
            btnRaport.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            btnRaport.ForeColor = Color.White;
            btnRaport.Image = (Image)resources.GetObject("btnRaport.Image");
            btnRaport.ImageAlign = ContentAlignment.MiddleLeft;
            btnRaport.Location = new Point(3, 224);
            btnRaport.Name = "btnRaport";
            btnRaport.Size = new Size(244, 50);
            btnRaport.TabIndex = 19;
            btnRaport.Text = "RAPORLAR";
            btnRaport.UseVisualStyleBackColor = false;
            btnRaport.Visible = false;
            btnRaport.Click += btnRaport_Click;
            // 
            // btnSearch
            // 
            btnSearch.Anchor = AnchorStyles.Left;
            btnSearch.BackColor = Color.FromArgb(19, 93, 102);
            btnSearch.FlatAppearance.BorderSize = 0;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            btnSearch.ForeColor = Color.White;
            btnSearch.Image = (Image)resources.GetObject("btnSearch.Image");
            btnSearch.ImageAlign = ContentAlignment.MiddleLeft;
            btnSearch.Location = new Point(3, 168);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(244, 50);
            btnSearch.TabIndex = 18;
            btnSearch.Text = "EMLAK ARAMA";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Visible = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnProperty
            // 
            btnProperty.Anchor = AnchorStyles.Left;
            btnProperty.BackColor = Color.FromArgb(19, 93, 102);
            btnProperty.FlatAppearance.BorderSize = 0;
            btnProperty.FlatStyle = FlatStyle.Flat;
            btnProperty.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            btnProperty.ForeColor = Color.White;
            btnProperty.Image = (Image)resources.GetObject("btnProperty.Image");
            btnProperty.ImageAlign = ContentAlignment.MiddleLeft;
            btnProperty.Location = new Point(3, 112);
            btnProperty.Name = "btnProperty";
            btnProperty.Size = new Size(244, 50);
            btnProperty.TabIndex = 17;
            btnProperty.Text = "EMLAK KAYIT";
            btnProperty.UseVisualStyleBackColor = false;
            btnProperty.Visible = false;
            btnProperty.Click += btnProperty_Click;
            // 
            // btnCostumer
            // 
            btnCostumer.Anchor = AnchorStyles.Left;
            btnCostumer.BackColor = Color.FromArgb(19, 93, 102);
            btnCostumer.FlatAppearance.BorderSize = 0;
            btnCostumer.FlatStyle = FlatStyle.Flat;
            btnCostumer.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            btnCostumer.ForeColor = Color.White;
            btnCostumer.Image = (Image)resources.GetObject("btnCostumer.Image");
            btnCostumer.ImageAlign = ContentAlignment.MiddleLeft;
            btnCostumer.Location = new Point(3, 56);
            btnCostumer.Name = "btnCostumer";
            btnCostumer.Size = new Size(244, 50);
            btnCostumer.TabIndex = 16;
            btnCostumer.Text = "MÜŞTERİ KAYIT";
            btnCostumer.UseVisualStyleBackColor = false;
            btnCostumer.Visible = false;
            btnCostumer.Click += btnCostumer_Click;
            // 
            // btnExit
            // 
            btnExit.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnExit.BackColor = Color.FromArgb(19, 93, 102);
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            btnExit.ForeColor = Color.White;
            btnExit.Image = (Image)resources.GetObject("btnExit.Image");
            btnExit.ImageAlign = ContentAlignment.MiddleLeft;
            btnExit.Location = new Point(3, 878);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(244, 50);
            btnExit.TabIndex = 15;
            btnExit.Text = "ÇIKIŞ";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // Template
            // 
            AutoScaleDimensions = new SizeF(16F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(34, 40, 49);
            ClientSize = new Size(1920, 1040);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(7);
            Name = "Template";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Template";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button btnWorkplace;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Button btnSearch;
        private Button btnProperty;
        private Button btnCostumer;
        private Button btnExit;
        private Button btnLogin;
        private Button btnRaport;
    }
}