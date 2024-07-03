using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmlakIsletmeleri
{
    public partial class FormMsg : Form
    {
        public DialogResult Result { get; private set; }
        public FormMsg()
        {
            InitializeComponent();
            btnYes.Click += BtnYes_Click;
            btnNo.Click += BtnNo_Click;
            btnOk.Click += BtnOk_Click;
        }

        private void BtnYes_Click(object sender, EventArgs e)
        {
            Result = DialogResult.Yes;
            this.Close();
        }

        private void BtnNo_Click(object sender, EventArgs e)
        {
            Result = DialogResult.No;
            this.Close();
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            Result = DialogResult.OK;
            this.Close();
        }

        public static void ShowWarning(string message)
        {
            using (FormMsg formMsg = new FormMsg())
            {
                formMsg.rtbWarning.Text = message;
                formMsg.btnYes.Visible = false;
                formMsg.btnNo.Visible = false;
                formMsg.btnOk.Visible = true;
                formMsg.ShowDialog();
            }
        }

        public static DialogResult ShowYesNo(string message)
        {
            using (FormMsg formMsg = new FormMsg())
            {
                formMsg.rtbWarning.Text = message.ToUpper();
                formMsg.rtbWarning.SelectionAlignment = HorizontalAlignment.Center;
                formMsg.btnYes.Visible = true;
                formMsg.btnNo.Visible = true;
                formMsg.btnOk.Visible = false;
                formMsg.ShowDialog();
                return formMsg.Result;
            }
        }
    }
}
