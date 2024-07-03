using BLL.Abstract;
using DAL.Concrete.EfCore;
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
using static EmlakIsletmeleri.Lib.Lib;

namespace EmlakIsletmeleri
{
    public partial class FormWorkplace : Form
    {
        private readonly IWorkplaceService _workplaceService;
        public FormWorkplace(IWorkplaceService workplaceService)
        {
            _workplaceService = workplaceService;
            InitializeComponent();
            InitializeTextBoxRestrictions();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Zorunlu alanlar için kontrol
            if (string.IsNullOrWhiteSpace(tbUserName.Text) ||
                string.IsNullOrWhiteSpace(tbPassword.Text) ||
                string.IsNullOrWhiteSpace(tbName.Text) ||
                string.IsNullOrWhiteSpace(tbAuthorizedPerson.Text) ||
                string.IsNullOrWhiteSpace(tbPhone.Text))
            {
                FormMsg.ShowWarning("Lütfen zorunlu alanları doldurun: Kullanıcı Adı, Şifre, İsim, Yetkili Kişi, Telefon."); 
                return;
            }

            if (!IsValidPhoneNumber(tbPhone.Text))
            {
                FormMsg.ShowWarning("Geçerli bir telefon numarası giriniz.");
                return;
            }

            if (!IsValidName(tbName.Text))
            {
                FormMsg.ShowWarning("Geçerli bir isim giriniz.");
                return;
            }

            if (!IsValidName(tbAuthorizedPerson.Text))
            {
                FormMsg.ShowWarning("Geçerli bir yetkili kişi ismi giriniz.");
                return;
            }

            // Eksik alanlar için kontrol ve kullanıcı onayı
            var missingFields = new List<string>();
            if (string.IsNullOrWhiteSpace(tbAddress.Text))
                missingFields.Add("Adres");
            if (string.IsNullOrWhiteSpace(tbFax.Text))
                missingFields.Add("Fax");

            if (missingFields.Any())
            {
                var message = "Bazı alanlar eksik: " + string.Join(", ", missingFields) + ". Devam etmek istiyor musunuz?";
                var result = FormMsg.ShowYesNo(message);
                if (result != DialogResult.Yes)
                {
                    return;
                }
            }

            // Yeni workplace nesnesi oluşturma
            Workplace newWorkplace = new Workplace
            {
                UserName = tbUserName.Text,
                Password = tbPassword.Text,
                Name = tbName.Text,
                AuthorizedPerson = tbAuthorizedPerson.Text,
                Address = tbAddress.Text,
                Phone = tbPhone.Text,
                Fax = tbFax.Text
            };

            _workplaceService.Create(newWorkplace);

            textboxClean();

            FormMsg.ShowWarning("İş yeri başarıyla kaydedildi.");

            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textboxClean()
        {
            tbUserName.Clear();
            tbPassword.Clear();
            tbName.Clear();
            tbAuthorizedPerson.Clear();
            tbAddress.Clear();
            tbPhone.Clear();
            tbFax.Clear();
        }

        private void InitializeTextBoxRestrictions()
        {
            tbFax.KeyPress += TextBox_KeyPressNumericOnly;

            tbPhone.KeyPress += TextBox_KeyPressNumericOnly;

            tbName.KeyPress += TextBox_KeyPressCharOnly;

            tbAuthorizedPerson.KeyPress += TextBox_KeyPressCharOnly;
        }
    }
}
