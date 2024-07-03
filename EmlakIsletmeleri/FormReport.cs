using BLL.Abstract;
using EL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmlakIsletmeleri
{
    public partial class FormReport : Form
    {
        private readonly ICustomerService _customerService;
        private readonly IPropertyService _propertyService;

        public FormReport(
            ICustomerService customerService,
            IPropertyService propertyService)
        {
            _customerService = customerService;
            _propertyService = propertyService;

            InitializeComponent();
        }

        private void FormReport_Load(object sender, EventArgs e)
        {
            CustomerList();
        }

        private void CustomerList()
        {
            var allCustomers = _customerService.GetAll();
            cbCustomers.DisplayMember = "FullName";
            cbCustomers.ValueMember = "ID";
            cbCustomers.DataSource = allCustomers;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSalesReport_Click(object sender, EventArgs e)
        {
            FormMsg.ShowWarning("YAPIM AŞAMASINDA.");
        }

        private void btnRentReport_Click(object sender, EventArgs e)
        {
            FormMsg.ShowWarning("YAPIM AŞAMASINDA.");
        }

        private void btnCustomerProperty_Click(object sender, EventArgs e)
        {
            if (cbCustomers.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen bir müşteri seçin.");
                return;
            }

            int selectedCustomerId = (int)cbCustomers.SelectedValue;
            PopulatePropertiesDataGrid(selectedCustomerId);
        }

        private void PopulatePropertiesDataGrid(int customerId)
        {
            var properties = _propertyService.GetPropertiesByCustomerId(customerId);
            dataGridView1.DataSource = properties.Select(p => new
            {
                p.PropertyType,
                p.AreaSquareMeters,
                p.NumberOfRooms,
                p.Floor,
                p.BuildingFloors,
                p.HeatingType,
                Price = p.IsForSale == 1 ? p.SalePrice : p.RentPrice,
                p.City,
                p.District,
                p.Neighborhood,
                p.StreetAddress
            }).ToList();
        }

        private void btnCustomerList_Click(object sender, EventArgs e)
        {
            var customers = _customerService.GetAll();
            dataGridView1.DataSource = customers.Select(c => new
            {
                c.ID,
                c.FirstName,
                c.LastName,
                c.HomePhone,
                c.CellPhone,
                c.Email
            }).ToList();
        }

        private void btnCustomerUpdate_Click(object sender, EventArgs e)
        {
            if (cbCustomers.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen bir müşteri seçin.");
                return;
            }

            int selectedCustomerId = (int)cbCustomers.SelectedValue;
            var customer = _customerService.GetById(selectedCustomerId);

            FormCustomer formCustomer = new FormCustomer(_customerService, customer);
            formCustomer.ShowDialog();
            CustomerList();
        }
    }
}
