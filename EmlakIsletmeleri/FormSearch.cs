using BLL.Abstract;
using BLL.Concrete;
using DAL.Abstract;
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
using static EmlakIsletmeleri.Lib.AppVariables;

namespace EmlakIsletmeleri
{
    public partial class FormSearch : Form
    {
        private readonly IPropertyService _propertyService;
        private readonly IPropertySaleService _propertySaleService;
        private readonly IRealEstateAgentSalesService _realEstateAgentSalesService;
        private readonly ICustomerService _customerService;

        private Property _property;

        int propertyId;

        private List<Property> properties = new List<Property>();

        public FormSearch(
            IPropertyService propertyService,
            ICustomerService customerService,
            IPropertySaleService propertySaleService,
            IRealEstateAgentSalesService realEstateAgentSalesService)
        {
            _propertyService = propertyService;
            _customerService = customerService;

            _propertySaleService = propertySaleService;
            _realEstateAgentSalesService = realEstateAgentSalesService;

            InitializeComponent();
        }

        private void btnDeal_Click(object sender, EventArgs e)
        {
            if (_property == null)
            {
                FormMsg.ShowWarning("LÜTFEN TAŞINMAZ SEÇİMİ YAPINIZ");
                return;
            }

            if (!Convert.ToBoolean(_property.IsForRent) && !Convert.ToBoolean(_property.IsForSale))
            {
                FormMsg.ShowWarning("SEÇİLEN TAŞINMAZ, SATILIK VEYA KİRALIK DEĞİL.");
                return;
            }

            Form f = new FormDeal(
                _property,
                _propertyService,
                _customerService,
                _propertySaleService,
                _realEstateAgentSalesService);

    //        Form f = new FormDeal(
    //_property,
    //_propertyService,
    //_customerService,
    //_propertySaleService,
    //_realEstateAgentSalesService);

            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            PropertyFilterCriteria criteria = new PropertyFilterCriteria
            {
                PropertyType = cbPropertyType.Text,
                MinAreaSquareMeters = ParseDouble(tbMinArea.Text),
                MaxAreaSquareMeters = ParseDouble(tbMaxArea.Text),
                MinNumberOfRooms = ParseInt(tbMinRoom.Text),
                MaxNumberOfRooms = ParseInt(tbMaxRoom.Text),
                MinFloor = ParseInt(tbMinFloor.Text),
                MaxFloor = ParseInt(tbMaxFloor.Text),
                BuildingFloors = ParseInt(tbBuildingFloors.Text),
                HeatingType = cbHeatingType.Text,
                MinSalePrice = ParseDecimal(tbMinPrice.Text),
                MaxSalePrice = ParseDecimal(tbMaxPrice.Text),
                City = cbCity.Text,
                District = tbDistrict.Text,
                Neighborhood = tbNeighborhood.Text,
                StreetAddress = tbStreetAddress.Text,
                IsForSale = rbIsForSale.Checked,
                IsForRent = rbIsForRent.Checked
            };

            List<Property> filteredProperties = _propertyService.FilterProperties(criteria, currentUser.ID);

            dgSearch.DataSource = ConvertToDataTable(filteredProperties);
        }

        private void dgSearch_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int customerCount = _propertyService.GetAll().Count();
            try
            {
                if ((e.RowIndex >= 0) && (e.RowIndex < customerCount))
                {
                    DataGridViewRow row = dgSearch.Rows[e.RowIndex];
                    propertyId = (int)row.Cells["Id"].Value;

                    _property = new Property();
                    _property = _propertyService.GetById(propertyId);

                    FormMsg.ShowWarning($"Seçilen özellik Id: {propertyId}");
                }
                else
                {
                    _property = null;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private DataTable ConvertToDataTable(List<Property> properties)
        {
            DataTable table = new DataTable();
            table.Columns.Add("Id", typeof(int));
            table.Columns.Add("PropertyType", typeof(string));
            table.Columns.Add("AreaSquareMeters", typeof(double));
            table.Columns.Add("NumberOfRooms", typeof(int));
            table.Columns.Add("Floor", typeof(int));
            table.Columns.Add("BuildingFloors", typeof(int));
            table.Columns.Add("HeatingType", typeof(string));
            table.Columns.Add("IsForSale", typeof(byte));
            table.Columns.Add("SalePrice", typeof(decimal));
            table.Columns.Add("IsForRent", typeof(byte));
            table.Columns.Add("ListedDate", typeof(DateTime));
            table.Columns.Add("City", typeof(string));
            table.Columns.Add("District", typeof(string));
            table.Columns.Add("Neighborhood", typeof(string));
            table.Columns.Add("StreetAddress", typeof(string));

            foreach (var property in properties)
            {
                table.Rows.Add(
                    property.Id,
                    property.PropertyType,
                    property.AreaSquareMeters,
                    property.NumberOfRooms,
                    property.Floor,
                    property.BuildingFloors,
                    property.HeatingType,
                    property.IsForSale,
                    property.SalePrice,
                    property.IsForRent,
                    property.ListedDate,
                    property.City,
                    property.District,
                    property.Neighborhood,
                    property.StreetAddress
                );
            }

            return table;
        }

        private double ParseDouble(string value)
        {
            double result;
            if (double.TryParse(value, out result))
                return result;
            return 0;
        }

        private int ParseInt(string value)
        {
            int result;
            if (int.TryParse(value, out result))
                return result;
            return 0;
        }

        private decimal ParseDecimal(string value)
        {
            decimal result;
            if (decimal.TryParse(value, out result))
                return result;
            return 0;
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            CleanTextboxes();
        }

        private void CleanTextboxes()
        {
            tbMaxArea.Clear();
            tbMinArea.Clear();
            tbMaxRoom.Clear();
            tbMinRoom.Clear();
            tbMaxFloor.Clear();
            tbMinFloor.Clear();
            tbBuildingFloors.Clear();
            tbMaxPrice.Clear();
            tbMinPrice.Clear();
            tbDistrict.Clear();
            tbNeighborhood.Clear();
            tbStreetAddress.Clear();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (_property == null)
            {
                FormMsg.ShowWarning("LÜTFEN TAŞINMAZ SEÇİMİ YAPINIZ");
                return;
            }

            FormProperty formProperty = new FormProperty(_customerService, _propertyService, _property);

            this.Hide();
            formProperty.ShowDialog();
            this.Show();
        }

        private void FormSearch_Load(object sender, EventArgs e)
        {
            ConfigureComboBox(cbCity, cities);
            ConfigureComboBox(cbPropertyType, propertyType);
            ConfigureComboBox(cbHeatingType, HeatingTypes);
        }


        private void ConfigureComboBox(ComboBox comboBox, string[] dataSource)
        {
            comboBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBox.AutoCompleteSource = AutoCompleteSource.CustomSource;

            var autoComplete = new AutoCompleteStringCollection();
            autoComplete.AddRange(dataSource.ToArray());

            comboBox.AutoCompleteCustomSource = autoComplete;
            comboBox.DataSource = dataSource;
        }
    }
}
