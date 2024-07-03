namespace EmlakIsletmeleri
{
    partial class FormMsg
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
            btnYes = new Button();
            btnOk = new Button();
            btnNo = new Button();
            rtbWarning = new RichTextBox();
            SuspendLayout();
            // 
            // btnYes
            // 
            btnYes.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnYes.BackColor = Color.FromArgb(19, 93, 102);
            btnYes.FlatAppearance.BorderSize = 0;
            btnYes.FlatStyle = FlatStyle.Flat;
            btnYes.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            btnYes.ForeColor = Color.White;
            btnYes.ImageAlign = ContentAlignment.MiddleLeft;
            btnYes.Location = new Point(12, 292);
            btnYes.Name = "btnYes";
            btnYes.Size = new Size(244, 50);
            btnYes.TabIndex = 21;
            btnYes.Text = "EVET";
            btnYes.UseVisualStyleBackColor = false;
            btnYes.Click += BtnYes_Click;
            // 
            // btnOk
            // 
            btnOk.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnOk.BackColor = Color.FromArgb(19, 93, 102);
            btnOk.FlatAppearance.BorderSize = 0;
            btnOk.FlatStyle = FlatStyle.Flat;
            btnOk.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            btnOk.ForeColor = Color.White;
            btnOk.ImageAlign = ContentAlignment.MiddleLeft;
            btnOk.Location = new Point(262, 292);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(244, 50);
            btnOk.TabIndex = 22;
            btnOk.Text = "TAMAM";
            btnOk.UseVisualStyleBackColor = false;
            btnOk.Click += BtnOk_Click;
            // 
            // btnNo
            // 
            btnNo.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnNo.BackColor = Color.FromArgb(19, 93, 102);
            btnNo.FlatAppearance.BorderSize = 0;
            btnNo.FlatStyle = FlatStyle.Flat;
            btnNo.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            btnNo.ForeColor = Color.White;
            btnNo.ImageAlign = ContentAlignment.MiddleLeft;
            btnNo.Location = new Point(512, 292);
            btnNo.Name = "btnNo";
            btnNo.Size = new Size(244, 50);
            btnNo.TabIndex = 23;
            btnNo.Text = "HAYIR";
            btnNo.UseVisualStyleBackColor = false;
            btnNo.Click += BtnNo_Click;
            // 
            // rtbWarning
            // 
            rtbWarning.BackColor = Color.IndianRed;
            rtbWarning.BorderStyle = BorderStyle.None;
            rtbWarning.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            rtbWarning.Location = new Point(12, 12);
            rtbWarning.Name = "rtbWarning";
            rtbWarning.ReadOnly = true;
            rtbWarning.Size = new Size(744, 265);
            rtbWarning.TabIndex = 24;
            rtbWarning.Text = "";
            // 
            // FormMsg
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.IndianRed;
            ClientSize = new Size(766, 354);
            Controls.Add(rtbWarning);
            Controls.Add(btnNo);
            Controls.Add(btnOk);
            Controls.Add(btnYes);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormMsg";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormMessagebox";
            ResumeLayout(false);
        }

        #endregion

        private Button btnYes;
        private Button btnOk;
        private Button btnNo;
        private RichTextBox rtbWarning;
    }
}