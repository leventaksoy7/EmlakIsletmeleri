namespace EmlakIsletmeleri
{
    partial class FormReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormReport));
            btnExit = new Button();
            dataGridView1 = new DataGridView();
            label14 = new Label();
            cbCustomers = new ComboBox();
            btnCustomerProperty = new Button();
            btnCustomerList = new Button();
            btnCustomerUpdate = new Button();
            btnSalesReport = new Button();
            btnRentReport = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
            btnExit.Location = new Point(1156, 763);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(244, 50);
            btnExit.TabIndex = 63;
            btnExit.Text = "ÇIKIŞ";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(337, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(1063, 745);
            dataGridView1.TabIndex = 64;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label14.Location = new Point(23, 12);
            label14.Name = "label14";
            label14.Size = new Size(125, 32);
            label14.TabIndex = 66;
            label14.Text = "MÜŞTERİ:";
            // 
            // cbCustomers
            // 
            cbCustomers.FlatStyle = FlatStyle.Flat;
            cbCustomers.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            cbCustomers.FormattingEnabled = true;
            cbCustomers.Location = new Point(23, 58);
            cbCustomers.Name = "cbCustomers";
            cbCustomers.Size = new Size(308, 38);
            cbCustomers.TabIndex = 67;
            // 
            // btnCustomerProperty
            // 
            btnCustomerProperty.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnCustomerProperty.BackColor = Color.FromArgb(19, 93, 102);
            btnCustomerProperty.FlatAppearance.BorderSize = 0;
            btnCustomerProperty.FlatStyle = FlatStyle.Flat;
            btnCustomerProperty.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            btnCustomerProperty.ForeColor = Color.White;
            btnCustomerProperty.ImageAlign = ContentAlignment.MiddleLeft;
            btnCustomerProperty.Location = new Point(23, 158);
            btnCustomerProperty.Name = "btnCustomerProperty";
            btnCustomerProperty.Size = new Size(308, 50);
            btnCustomerProperty.TabIndex = 68;
            btnCustomerProperty.Text = "MÜLKLERİNİ GETİR";
            btnCustomerProperty.UseVisualStyleBackColor = false;
            btnCustomerProperty.Click += btnCustomerProperty_Click;
            // 
            // btnCustomerList
            // 
            btnCustomerList.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnCustomerList.BackColor = Color.FromArgb(19, 93, 102);
            btnCustomerList.FlatAppearance.BorderSize = 0;
            btnCustomerList.FlatStyle = FlatStyle.Flat;
            btnCustomerList.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            btnCustomerList.ForeColor = Color.White;
            btnCustomerList.ImageAlign = ContentAlignment.MiddleLeft;
            btnCustomerList.Location = new Point(23, 214);
            btnCustomerList.Name = "btnCustomerList";
            btnCustomerList.Size = new Size(308, 50);
            btnCustomerList.TabIndex = 69;
            btnCustomerList.Text = "TÜM MÜŞTERİ LİSTESİ";
            btnCustomerList.UseVisualStyleBackColor = false;
            btnCustomerList.Click += btnCustomerList_Click;
            // 
            // btnCustomerUpdate
            // 
            btnCustomerUpdate.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnCustomerUpdate.BackColor = Color.FromArgb(19, 93, 102);
            btnCustomerUpdate.FlatAppearance.BorderSize = 0;
            btnCustomerUpdate.FlatStyle = FlatStyle.Flat;
            btnCustomerUpdate.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            btnCustomerUpdate.ForeColor = Color.White;
            btnCustomerUpdate.ImageAlign = ContentAlignment.MiddleLeft;
            btnCustomerUpdate.Location = new Point(23, 102);
            btnCustomerUpdate.Name = "btnCustomerUpdate";
            btnCustomerUpdate.Size = new Size(308, 50);
            btnCustomerUpdate.TabIndex = 70;
            btnCustomerUpdate.Text = "MÜŞTERİYİ GÜNCELLE";
            btnCustomerUpdate.UseVisualStyleBackColor = false;
            btnCustomerUpdate.Click += btnCustomerUpdate_Click;
            // 
            // btnSalesReport
            // 
            btnSalesReport.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnSalesReport.BackColor = Color.FromArgb(19, 93, 102);
            btnSalesReport.FlatAppearance.BorderSize = 0;
            btnSalesReport.FlatStyle = FlatStyle.Flat;
            btnSalesReport.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            btnSalesReport.ForeColor = Color.White;
            btnSalesReport.ImageAlign = ContentAlignment.MiddleLeft;
            btnSalesReport.Location = new Point(23, 707);
            btnSalesReport.Name = "btnSalesReport";
            btnSalesReport.Size = new Size(308, 50);
            btnSalesReport.TabIndex = 71;
            btnSalesReport.Text = "SATIŞ RAPORLARI";
            btnSalesReport.UseVisualStyleBackColor = false;
            btnSalesReport.Click += btnSalesReport_Click;
            // 
            // btnRentReport
            // 
            btnRentReport.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnRentReport.BackColor = Color.FromArgb(19, 93, 102);
            btnRentReport.FlatAppearance.BorderSize = 0;
            btnRentReport.FlatStyle = FlatStyle.Flat;
            btnRentReport.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            btnRentReport.ForeColor = Color.White;
            btnRentReport.ImageAlign = ContentAlignment.MiddleLeft;
            btnRentReport.Location = new Point(23, 651);
            btnRentReport.Name = "btnRentReport";
            btnRentReport.Size = new Size(308, 50);
            btnRentReport.TabIndex = 72;
            btnRentReport.Text = "KİRALAMA RAPORLARI";
            btnRentReport.UseVisualStyleBackColor = false;
            btnRentReport.Click += btnRentReport_Click;
            // 
            // FormReport
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(119, 176, 170);
            ClientSize = new Size(1412, 825);
            Controls.Add(btnRentReport);
            Controls.Add(btnSalesReport);
            Controls.Add(btnCustomerUpdate);
            Controls.Add(btnCustomerList);
            Controls.Add(btnCustomerProperty);
            Controls.Add(label14);
            Controls.Add(cbCustomers);
            Controls.Add(dataGridView1);
            Controls.Add(btnExit);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormReport";
            StartPosition = FormStartPosition.CenterParent;
            Text = "FormReport";
            Load += FormReport_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnExit;
        private DataGridView dataGridView1;
        private Label label14;
        private ComboBox cbCustomers;
        private Button btnCustomerProperty;
        private Button btnCustomerList;
        private Button btnCustomerUpdate;
        private Button btnSalesReport;
        private Button btnRentReport;
    }
}