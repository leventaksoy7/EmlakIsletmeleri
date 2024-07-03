using BLL.Abstract;
using BLL.Concrete;
using EL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static EmlakIsletmeleri.Lib.AppVariables;

namespace EmlakIsletmeleri
{
    public partial class FormLogin : Form
    {
        private readonly IWorkplaceService _workplaceService;

        public FormLogin(IWorkplaceService workplaceService)
        {
            _workplaceService = workplaceService;
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnWorkplace_Click(object sender, EventArgs e)
        {
            Form f = new FormWorkplace(_workplaceService);
            f.ShowDialog();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            string userName = tbUserName.Text.Trim();
            string password = tbPassword.Text.Trim();

            ValidateUser(userName, password);

            if (currentUser != null)
            {
                FormMsg.ShowWarning($"Hoşgeldiniz, {currentUser.Name}!");
                this.Close();
            }
        }

        private void ValidateUser(string userName, string password)
        {
            if (string.IsNullOrWhiteSpace(userName) || string.IsNullOrWhiteSpace(password))
            {
                FormMsg.ShowWarning("Kullanıcı adı ve şifre alanları boş bırakılamaz.");
                return;
            }

            // Kullanıcıyı veritabanında ara
            currentUser = _workplaceService.GetWorkplaceByUserNameAndPassword(userName, password);

            if (currentUser == null)
            {
                FormMsg.ShowWarning("Kullanıcı adı veya şifre hatalı. Lütfen tekrar deneyin.");
            }
        }
    }
}
