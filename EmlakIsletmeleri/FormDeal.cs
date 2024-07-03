using BLL.Abstract;
using BLL.Concrete;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Windows.Forms;
using EL;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static EmlakIsletmeleri.Lib.AppVariables;

namespace EmlakIsletmeleri
{
    public partial class FormDeal : Form
    {
        private EL.Property _property;
        private Customer selectedCustomer;

        private readonly IPropertyService _propertyService;
        private readonly ICustomerService _customerService;
        private readonly IPropertySaleService _propertySaleService;
        private readonly IRealEstateAgentSalesService _realEstateAgentSalesService;

        public FormDeal(
            EL.Property property,
            IPropertyService propertyService,
            ICustomerService customerService,
            IPropertySaleService propertySaleService,
            IRealEstateAgentSalesService realEstateAgentSalesService)
        {
            InitializeComponent();

            _property = property;

            _propertyService = propertyService;
            _customerService = customerService;

            _propertySaleService = propertySaleService;
            _realEstateAgentSalesService = realEstateAgentSalesService;

            PopulatePropertyDetails();
            PopulateCustomerComboBox();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PopulatePropertyDetails()
        {
            lblPropertyType.Text = _property.PropertyType;
            lblAreaSquareMeters.Text = _property.AreaSquareMeters.ToString();
            lblNumberOfRooms.Text = _property.NumberOfRooms.ToString();
            lblFloor.Text = _property.Floor.ToString();
            lblBuildingFloors.Text = _property.BuildingFloors.ToString();
            lblHeatingType.Text = _property.HeatingType;
            lblPrice.Text = Convert.ToBoolean(_property.IsForSale) ? _property.SalePrice.ToString() : _property.RentPrice.ToString();
            lblCity.Text = _property.City;
            lblDistrict.Text = _property.District;
            lblNeighborhood.Text = _property.Neighborhood;
            lblStreetAddress.Text = _property.StreetAddress;

            lblDate.Text = DateTime.Now.ToString();
            lblOwner.Text = _customerService.GetById(_property.OwnerId).FullName;
        }

        private void PopulateCustomerComboBox()
        {
            var customers = _customerService.GetAll();
            cbCustomers.DataSource = customers;
            cbCustomers.DisplayMember = "FullName";
            cbCustomers.ValueMember = "ID";
        }

        private void btnDeal_Click(object sender, EventArgs e)
        {
            // Seçili müşteri kontrolü
            if (cbCustomers.SelectedIndex == -1 || cbCustomers.SelectedItem == null)
            {
                if (FormMsg.ShowYesNo("Seçili müşteri yok. Yeni müşteri kaydedilsin mi?") == DialogResult.Yes)
                {
                    // Yeni müşteri kaydetme işlemi
                    FormCustomer f = new FormCustomer(_customerService);
                    f.ShowDialog();
                }
                else
                {
                    FormMsg.ShowWarning("Lütfen geçerli bir müşteri seçin.");
                    return;
                }
            }
            else
            {
                selectedCustomer = (Customer)cbCustomers.SelectedItem;
            }

            // Eğer emlak satılıyorsa
            if (Convert.ToBoolean(_property.IsForSale))
            {
                // Yeni bir PropertySale oluşturulması
                //EL.PropertySale propertySale = new EL.PropertySale
                //{
                //    PropertyId = _property.Id,
                //    Property = _property,
                //    SellerCustomerId = _property.OwnerId,
                //    SellerCustomer = selectedCustomer,
                //    BuyerCustomerId = selectedCustomer.ID,
                //    BuyerCustomer = selectedCustomer,
                //    SaleDate = DateTime.Now,
                //    RealEstateAgentId = currentUser.ID,
                //    RealEstateAgent = currentUser
                //};

                //_propertySaleService.Create(propertySale); // PropertySale kaydedildi

                _property.SaleSoldDate = DateTime.Now;
                _property.Owner = selectedCustomer;
                _property.OwnerId = selectedCustomer.ID; // Emlak sahibi güncellendi
                _property.Workplace = currentUser;
                _property.WorkplaceID = currentUser.ID;

                // Emlak sahibi müşteri ve emlak bilgileri güncellendi
                _propertyService.Update(_property);

                //// RealEstateAgentSales tablosuna kayıt eklenmesi
                //RealEstateAgentSales realEstateAgentSales = new RealEstateAgentSales
                //{
                //    RealEstateAgentId = currentUser.ID,
                //    RealEstateAgent = currentUser,
                //    PropertySaleId = propertySale.ID, // İlgili PropertySale ID'si
                //    PropertySale = propertySale,
                //    SaleAmount = _property.SalePrice,
                //    SaleDate = DateTime.Now
                //};

                //_realEstateAgentSalesService.Create(realEstateAgentSales); // Emlak danışmanı satış kaydını ekle

                //GenerateReport(_property, selectedCustomer,currentUser);
            }

            // Eğer emlak kiralanıyorsa
            if (Convert.ToBoolean(_property.IsForRent))
            {
                _property.RentEndDate = DateTime.Now.AddMonths(1); // Kiralama 1 ay için geçerli
                _property.TenantCustomerId = selectedCustomer.ID; // Kiracı güncellendi

                // Kiracı müşteri ve emlak bilgileri güncellendi
                _propertyService.Update(_property);
            }

            FormMsg.ShowWarning("iŞLEM TAMAMLANDI.");

            this.Close();
        }

        private void btnRapor_Click(object sender, EventArgs e)
        {

        }

        private void GenerateReport(EL.Property propertySale, Customer customer, Workplace workplace)
        {
            // DataSet
            DataSet ds = new DataSet("PropertyDataSet");

            //DataTable propertySaleTable = new DataTable("PropertySaleTable");
            //propertySaleTable.Columns.Add("PropertyType", typeof(string));
            //propertySaleTable.Columns.Add("AreaSquareMeters", typeof(int));
            //propertySaleTable.Columns.Add("NumberOfRooms", typeof(int));
            //propertySaleTable.Columns.Add("Floor", typeof(int));
            //propertySaleTable.Columns.Add("BuildingFloors", typeof(int));
            //propertySaleTable.Columns.Add("HeatingType", typeof(string));
            //propertySaleTable.Columns.Add("Price", typeof(decimal));
            //propertySaleTable.Columns.Add("City", typeof(string));
            //propertySaleTable.Columns.Add("District", typeof(string));
            //propertySaleTable.Columns.Add("Neighborhood", typeof(string));
            //propertySaleTable.Columns.Add("StreetAddress", typeof(string));
            //propertySaleTable.Columns.Add("OwnerName", typeof(string));

            //// PropertySaleTable verileri ekle
            //propertySaleTable.Rows.Add(
            //    propertySale.Property.PropertyType,
            //    propertySale.Property.AreaSquareMeters,
            //    propertySale.Property.NumberOfRooms,
            //    propertySale.Property.Floor,
            //    propertySale.Property.BuildingFloors,
            //    propertySale.Property.HeatingType,
            //    propertySale.Property.IsForSale == 1 ? propertySale.Property.SalePrice : propertySale.Property.RentPrice,
            //    propertySale.Property.City,
            //    propertySale.Property.District,
            //    propertySale.Property.Neighborhood,
            //    propertySale.Property.StreetAddress,
            //    customer.FirstName + " " + customer.LastName
            //);

            // Customer tablosu için DataTable
            DataTable customerTable = new DataTable("Customer_");
            customerTable.Columns.Add("FirstName", typeof(string));
            customerTable.Columns.Add("LastName", typeof(string));
            customerTable.Columns.Add("HomePhone", typeof(string));
            customerTable.Columns.Add("CellPhone", typeof(string));
            customerTable.Columns.Add("Email", typeof(string));

            // Customer tablosuna verileri
            customerTable.Rows.Add(
                customer.FirstName,
                customer.LastName,
                customer.HomePhone,
                customer.CellPhone,
                customer.Email
            );

            // Workplace tablosu için DataTable
            DataTable workplaceTable = new DataTable("Workplace_");
            workplaceTable.Columns.Add("Name", typeof(string));
            workplaceTable.Columns.Add("AuthorizedPerson", typeof(string));
            workplaceTable.Columns.Add("Address", typeof(string));
            workplaceTable.Columns.Add("Phone", typeof(string));
            workplaceTable.Columns.Add("Fax", typeof(string));

            // Workplace tablosuna verileri
            workplaceTable.Rows.Add(
                workplace.Name,
                workplace.AuthorizedPerson,
                workplace.Address,
                workplace.Phone,
                workplace.Fax
            );

            // DataSet tabloları ekle
            //ds.Tables.Add(propertySaleTable);
            ds.Tables.Add(customerTable);
            ds.Tables.Add(workplaceTable);

            // Raporu oluşturun veriyi ekle
            ReportDocument reportDocument = new ReportDocument();
            reportDocument.Load("C:\\Users\\Levent AKSOY\\source\\repos\\EmlakIsletmeleri_LeventAksoy\\EmlakIsletmeleri/PropertyReport.rpt");
            reportDocument.SetDataSource(ds);

            //CrystalReportViewer 
            CrystalReportViewerForm viewerForm = new CrystalReportViewerForm(reportDocument);
            viewerForm.ShowDialog();
        }
    }
}
