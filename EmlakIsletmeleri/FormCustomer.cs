using BLL.Abstract;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static EmlakIsletmeleri.Lib.Lib;
using static EmlakIsletmeleri.Lib.AppVariables;
using System.Net;

namespace EmlakIsletmeleri
{
    public partial class FormCustomer : Form
    {
        private Customer _customer;
        private readonly ICustomerService _customerService;

        public FormCustomer(ICustomerService customerService)
        {
            _customerService = customerService;

            InitializeComponent();
            InitializeTextBoxRestrictions();
        }

        public FormCustomer(
            ICustomerService customerService,
            Customer customer) : this(customerService)
        {
            _customer = customer;
            PopulateCustomerDetails();
        }

        private void PopulateCustomerDetails()
        {
            if (_customer != null)
            {
                tbFirstName.Text = _customer.FirstName;
                tbLastName.Text = _customer.LastName;
                tbHomePhone.Text = _customer.HomePhone;
                tbCellPhone.Text = _customer.CellPhone;
                tbEmail.Text = _customer.Email;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string firstName = tbFirstName.Text.Trim();
            string lastName = tbLastName.Text.Trim();
            string homePhone = tbHomePhone.Text.Trim();
            string cellPhone = tbCellPhone.Text.Trim();
            string email = tbEmail.Text.Trim();

            if (!IsValidCheck(firstName, lastName, homePhone, cellPhone, email))
            {
                return;
            }

            // Yeni müşteri nesnesi
            //Customer newCustomer = new Customer
            //{
            //    FirstName = firstName,
            //    LastName = lastName,
            //    HomePhone = homePhone,
            //    CellPhone = cellPhone,
            //    Email = email,
            //    WorkplaceID = currentUser.ID
            //};

            if (_customer == null)
            {
                _customer = new Customer();
            }

            _customer.FirstName = firstName;
            _customer.LastName = lastName;
            _customer.HomePhone = homePhone;
            _customer.CellPhone = cellPhone;
            _customer.Email = email;
            _customer.WorkplaceID = currentUser.ID;

            // müşteriyi kaydet
            if (_customer.ID == 0)
            {
                _customerService.Create(_customer);
                _customer = new Customer();
            }
            else
            {
                _customerService.Update(_customer);
                FormMsg.ShowWarning("Müşteri başarıyla kaydedildi.");
                this.Close();
            }

            FormMsg.ShowWarning("Müşteri başarıyla kaydedildi.");

            TextboxClean();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TextboxClean()
        {
            tbFirstName.Clear();
            tbLastName.Clear();
            tbHomePhone.Clear();
            tbCellPhone.Clear();
            tbEmail.Clear();
        }

        private bool IsValidCheck(string firstName, string lastName, string homePhone, string cellPhone, string email)
        {

            // Boş alan kontrolü
            if (string.IsNullOrWhiteSpace(firstName) || string.IsNullOrWhiteSpace(lastName))
            {
                FormMsg.ShowWarning("Ad ve Soyad alanları boş olamaz.");
                return false;
            }

            if (!IsValidName(firstName))
            {
                FormMsg.ShowWarning("Geçerli bir isim giriniz.");
                return false;
            }

            if (!IsValidName(lastName))
            {
                FormMsg.ShowWarning("Geçerli bir soy isim giriniz.");
                return false;
            }

            // Telefon numarası kontrolü 
            if (string.IsNullOrWhiteSpace(homePhone) && string.IsNullOrWhiteSpace(cellPhone))
            {
                FormMsg.ShowWarning("Ev Telefonu veya Cep Telefonu alanlarından en az biri doldurulmalıdır.");
                return false;
            }

            // Ev telefonu geçerliliği
            if (!string.IsNullOrWhiteSpace(homePhone) && !IsValidPhoneNumber(homePhone))
            {
                FormMsg.ShowWarning("Geçerli bir ev telefonu numarası giriniz.");
                return false;
            }

            // Cep telefonu geçerliliği
            if (!string.IsNullOrWhiteSpace(cellPhone) && !IsValidPhoneNumber(cellPhone))
            {
                FormMsg.ShowWarning("Geçerli bir cep telefonu numarası giriniz.");
                return false;
            }

            // Email adresi kontrolü
            if (!string.IsNullOrWhiteSpace(email) && !IsValidEmail(email))
            {
                FormMsg.ShowWarning("Geçerli bir email adresi giriniz.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(email))
            {
                var message = "E-mail eksik. Devam etmek istiyor musunuz?";
                var result = FormMsg.ShowYesNo(message);
                if (result == DialogResult.Yes)
                {
                    return true;
                }
                return false;
            }

            return true;
        }

        private void InitializeTextBoxRestrictions()
        {
            tbFirstName.KeyPress += TextBox_KeyPressCharOnly;

            tbLastName.KeyPress += TextBox_KeyPressCharOnly;

            tbHomePhone.KeyPress += TextBox_KeyPressNumericOnly;

            tbCellPhone.KeyPress += TextBox_KeyPressNumericOnly;
        }
    }
}
