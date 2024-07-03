using BLL.Abstract;
using BLL.Concrete;
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
using static EmlakIsletmeleri.Lib.Lib;

namespace EmlakIsletmeleri
{
    public partial class FormProperty : Form
    {
        private int? selectedCustomerId = null;

        private EL.Property _property;
        private bool _isEditMode;

        private readonly ICustomerService _customerService;
        private readonly IPropertyService _propertyService;

        public FormProperty(
            ICustomerService customerService,
            IPropertyService propertyService)
        {
            _customerService = customerService;
            _propertyService = propertyService;

            InitializeComponent();
            InitializeTextBoxRestrictions();

            _isEditMode = false;
        }

        public FormProperty(
            ICustomerService customerService, 
            IPropertyService propertyService, 
            EL.Property property)
            : this(customerService, propertyService)
        {
            _property = property;
            _isEditMode = true;
            PopulatePropertyDetails();
        }
        private void PopulatePropertyDetails()
        {
            if (_property != null)
            {
                cbPropertyType.SelectedItem = _property.PropertyType;
                tbAreaSquareMeters.Text = _property.AreaSquareMeters.ToString();
                tbNumberOfRooms.Text = _property.NumberOfRooms.ToString();
                tbFloor.Text = _property.Floor.ToString();
                tbBuildingFloors.Text = _property.BuildingFloors.ToString();
                cbHeatingType.Text = _property.HeatingType;

                rbIsForSale.Checked = Convert.ToBoolean(_property.IsForSale);
                tbSalePrice.Text = _property.SalePrice.ToString();

                rbIsForRent.Checked = Convert.ToBoolean(_property.IsForRent);
                tbRentPrice.Text = _property.RentPrice.ToString();

                cbCity.Text = _property.City;
                tbDistrict.Text = _property.District;
                tbNeighborhood.Text = _property.Neighborhood;
                tbStreetAddress.Text = _property.StreetAddress;
            }
        }

        private bool IsValidCheck(int areaSquareMeters, int numberOfRooms, int floor, int buildingFloors,
                bool isForRent, decimal tbRentPrice, bool isForSale, decimal tbSalePrice,
                string district, string neighborhood, string streetAddress)
        {

            var result = DialogResult;

            if (selectedCustomerId == null)
            {
                result = FormMsg.ShowYesNo("EMLAK SAHİBİNİ SEÇİLMEDEN DEVAM EDİLEMEZ. YENİ KAYIT AÇMAK İSTER MİSİNİZ?");
                if (result == DialogResult.Yes)
                {
                    Form f = new FormCustomer(_customerService);
                    f.ShowDialog();
                }
                else
                {
                    return false;
                }
            }

            // Alan kontrolü
            if (areaSquareMeters <= 0)
            {
                FormMsg.ShowWarning("Geçerli bir metrekare alanı giriniz.");
                return false;
            }

            if (numberOfRooms <= 0)
            {
                FormMsg.ShowWarning("Geçerli bir oda sayısı giriniz.");
                return false;
            }

            if (floor < 0)
            {
                FormMsg.ShowWarning("Geçerli bir kat numarası giriniz.");
                return false;
            }

            if (buildingFloors <= 0)
            {
                FormMsg.ShowWarning("Geçerli bina kat sayısı giriniz.");
                return false;
            }

            if (isForRent && tbRentPrice <= 0)
            {
                FormMsg.ShowWarning("Kiralama için geçerli bir kira fiyatı giriniz.");
                return false;
            }

            if (isForSale && tbSalePrice <= 0)
            {
                FormMsg.ShowWarning("Satış için geçerli bir satış fiyatı giriniz.");
                return false;
            }

            // Adres kontrolü
            if (string.IsNullOrWhiteSpace(district))
            {
                result = FormMsg.ShowYesNo("İlçe alanı boş. Devam etmek istiyor musunuz?");
                if (result == DialogResult.No)
                {
                    return false;
                }
            }

            if (string.IsNullOrWhiteSpace(neighborhood))
            {
                result = FormMsg.ShowYesNo("Mahalle alanı boş. Devam etmek istiyor musunuz?");
                if (result == DialogResult.No)
                {
                    return false;
                }
            }

            if (string.IsNullOrWhiteSpace(streetAddress))
            {
                result = FormMsg.ShowYesNo("Sokak adresi alanı boş. Devam etmek istiyor musunuz?");
                if (result == DialogResult.No)
                {
                    return false;
                }
            }

            // Tüm kontroller geçti
            return true;


            return true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Girdi değerlerini alma
            int areaSquareMeters = int.TryParse(tbAreaSquareMeters.Text, out int area) ? area : -1;
            int numberOfRooms = int.TryParse(tbNumberOfRooms.Text, out int rooms) ? rooms : -1;
            int floor = int.TryParse(tbFloor.Text, out int f) ? f : -1;
            int buildingFloors = int.TryParse(tbBuildingFloors.Text, out int bf) ? bf : -1;
            bool isForRent = rbIsForRent.Checked;
            decimal rentPrice = decimal.TryParse(tbRentPrice.Text, out decimal rent) ? rent : -1;
            bool isForSale = rbIsForSale.Checked;
            decimal salePrice = decimal.TryParse(tbSalePrice.Text, out decimal sale) ? sale : -1;
            string district = tbDistrict.Text.Trim();
            string neighborhood = tbNeighborhood.Text.Trim();
            string streetAddress = tbStreetAddress.Text.Trim();


            if (!IsValidCheck(areaSquareMeters, numberOfRooms, floor, buildingFloors,
                rbIsForRent.Checked, rentPrice, rbIsForSale.Checked, salePrice,
                district, neighborhood, streetAddress))
            {
                return;
            }

            if (_isEditMode)
            {
                // Mevcut mülk güncelleniyor
                _property.PropertyType = cbPropertyType.SelectedItem.ToString();
                _property.AreaSquareMeters = int.Parse(tbAreaSquareMeters.Text);
                _property.NumberOfRooms = int.Parse(tbNumberOfRooms.Text);
                _property.Floor = int.Parse(tbFloor.Text);
                _property.BuildingFloors = int.Parse(tbBuildingFloors.Text);
                _property.HeatingType = cbHeatingType.Text;

                _property.IsForSale = rbIsForSale.Checked ? (byte)1 : (byte)0;
                _property.SalePrice = rbIsForSale.Checked ? decimal.Parse(tbSalePrice.Text) : 0;

                _property.IsForRent = rbIsForRent.Checked ? (byte)1 : (byte)0;
                _property.RentPrice = rbIsForRent.Checked ? decimal.Parse(tbRentPrice.Text) : 0;

                _property.City = cbCity.Text;
                _property.District = tbDistrict.Text;
                _property.Neighborhood = tbNeighborhood.Text;
                _property.StreetAddress = tbStreetAddress.Text;

                _property.OwnerId = selectedCustomerId.Value;
                _property.Owner = _customerService.GetById(selectedCustomerId.Value);

                _property.WorkplaceID = currentUser.ID;

                _propertyService.Update(_property);

                FormMsg.ShowWarning("Emlak başarıyla güncellendi!");

                this.Close();
            }
            else
            {
                Property newProperty = new Property
                {
                    PropertyType = cbPropertyType.SelectedItem.ToString(), // cbPropertyType.SelectedText yerine cbPropertyType.SelectedItem.ToString() kullanıldı
                    AreaSquareMeters = areaSquareMeters,
                    NumberOfRooms = numberOfRooms,
                    Floor = floor,
                    BuildingFloors = buildingFloors,
                    HeatingType = cbHeatingType.Text,

                    IsForSale = rbIsForSale.Checked ? (byte)1 : (byte)0,
                    SalePrice = rbIsForSale.Checked ? salePrice : 0,

                    IsForRent = rbIsForRent.Checked ? (byte)1 : (byte)0,
                    RentPrice = rbIsForRent.Checked ? rentPrice : 0,

                    ListedDate = DateTime.Now,
                    City = cbCity.Text,
                    District = tbDistrict.Text,
                    Neighborhood = tbNeighborhood.Text,
                    StreetAddress = tbStreetAddress.Text,

                    OwnerId = selectedCustomerId.Value, // selectedCustomerId null değilse değerini alır
                    Owner = _customerService.GetById(selectedCustomerId.Value),

                    WorkplaceID = currentUser.ID
                };

                _propertyService.Create(newProperty);

                FormMsg.ShowWarning("Emlak başarıyla kaydedildi!");
            }

            ClearTextBoxes();
        }

        private void ClearTextBoxes()
        {
            tbAreaSquareMeters.Clear();
            tbNumberOfRooms.Clear();
            tbFloor.Clear();
            tbBuildingFloors.Clear();
            tbSalePrice.Clear();
            tbRentPrice.Clear();
            tbDistrict.Clear();
            tbNeighborhood.Clear();
            tbStreetAddress.Clear();
            rbIsForSale.Checked = false;
            rbIsForRent.Checked = false;
            rbNull.Checked = false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbOwner_TextChanged(object sender, EventArgs e)
        {
            if (cbOwner.Text.Length == 0)
                return;

            string searchText = cbOwner.Text.Trim().ToLower();

            // Müşteri listesinden arama
            var filteredCustomers = _customerService.GetCustomersBySearchText(searchText);

            if (filteredCustomers == null)
                return;

            // Eğer uygun müşteriler varsa, ComboBox'ı aç
            if (filteredCustomers != null && filteredCustomers.Any())
            {
                cbOwner.DataSource = filteredCustomers;
                cbOwner.DisplayMember = "FullName";
                cbOwner.ValueMember = "ID";
                cbOwner.DroppedDown = true;

                // Kullanıcının yazdığı metni seçimi ile tekrar ayarlayın
                cbOwner.SelectionStart = cbOwner.Text.Length;
            }

            // TextChanged olayını tetiklememesi için geçici bir çözüm
            cbOwner.TextChanged -= cbOwner_TextChanged;
            cbOwner.Text = searchText;
            cbOwner.SelectionStart = searchText.Length;
            cbOwner.TextChanged += cbOwner_TextChanged;
        }

        private void FormProperty_Load(object sender, EventArgs e)
        {
            var allCustomers = _customerService.GetAll(); // Tüm müşterileri al
            cbOwner.DisplayMember = "FullName"; // Görüntülenecek özellik
            cbOwner.ValueMember = "ID"; // Değer olarak saklanacak özellik
            cbOwner.DataSource = allCustomers; // DataSource ile tüm müşteri nesnelerini ekle

            ComboboxesMembers();
        }

        private void cbOwner_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbOwner.SelectedItem != null)
            {
                selectedCustomerId = (int)cbOwner.SelectedValue; // Seçili olan müşteri ID'sini alın
            }
            else
            {
                selectedCustomerId = null;
            }
        }

        private void ComboboxesMembers()
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

        private void InitializeTextBoxRestrictions()
        {
            tbAreaSquareMeters.KeyPress += TextBox_KeyPressNumericOnly;

            tbNumberOfRooms.KeyPress += TextBox_KeyPressNumericOnly;

            tbFloor.KeyPress += TextBox_KeyPressNumericOnly;

            tbBuildingFloors.KeyPress += TextBox_KeyPressNumericOnly;

            tbSalePrice.KeyPress += TextBox_KeyPressNumericOnly;

            tbRentPrice.KeyPress += TextBox_KeyPressNumericOnly;
        }

        private void rbIsForSale_CheckedChanged(object sender, EventArgs e)
        {
            if (!tbSalePrice.Visible)
            {
                tbSalePrice.Visible = true;
                label7.Visible = true;
            }
            else
            {
                tbSalePrice.Visible = false;
                label7.Visible = false;
            }
        }

        private void rbIsForRent_CheckedChanged(object sender, EventArgs e)
        {
            if (!tbRentPrice.Visible)
            {
                tbRentPrice.Visible = true;
                label10.Visible = true;
            }
            else
            {
                tbRentPrice.Visible = false;
                label10.Visible = false;
            }
        }

        private void rbNull_CheckedChanged(object sender, EventArgs e)
        {
            tbRentPrice.Visible = false;
            label10.Visible = false;

            tbSalePrice.Visible = false;
            label7.Visible = false;

        }
    }
}
