using BLL.Abstract;
using BLL.Concrete;
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
    public partial class Template : Form
    {
        private readonly IWorkplaceService _workplaceService;
        private readonly ICustomerService _customerService;
        private readonly IPropertyService _propertyService;
        private readonly IPropertySaleService _propertySaleService;
        private readonly IRealEstateAgentSalesService _realEstateAgentSalesService;
        public Template(IWorkplaceService workplaceService,
            ICustomerService customerService,
            IPropertyService propertyService,
            IPropertySaleService propertySaleService,
            IRealEstateAgentSalesService realEstateAgentSalesService)
        {
            _workplaceService = workplaceService;
            _customerService = customerService;
            _propertyService = propertyService;
            _propertySaleService = propertySaleService;
            _realEstateAgentSalesService = realEstateAgentSalesService;

            InitializeComponent();
        }

        private void btnWorkplace_Click(object sender, EventArgs e)
        {
            Form f = new FormWorkplace(_workplaceService);
            f.ShowDialog();
        }

        private void btnCostumer_Click(object sender, EventArgs e)
        {
            Form f = new FormCustomer(_customerService);
            f.ShowDialog();
        }

        private void btnProperty_Click(object sender, EventArgs e)
        {
            Form f = new FormProperty(_customerService, _propertyService);
            f.ShowDialog();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Form f = new FormSearch(
                _propertyService,
                _customerService,
                _propertySaleService,
                _realEstateAgentSalesService);
            f.ShowDialog();
        }

        private void btnRaport_Click(object sender, EventArgs e)
        {
            Form f = new FormReport(
                _customerService,
                _propertyService);
            f.ShowDialog();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (!isLoggedIn)
            {
                Form f = new FormLogin(_workplaceService);
                f.ShowDialog();

                if (currentUser != null)
                {
                    isLoggedIn = true;
                    MenuButonsVisibilty(true);
                    btnLogin.Text = "İŞLETME ÇIKIŞ";
                }
            }
            else
            {
                // Logout işlemi
                DialogResult result = FormMsg.ShowYesNo("Çıkış yapmak istediğinize emin misiniz?");

                if (result == DialogResult.Yes)
                {
                    isLoggedIn = false;

                    MenuButonsVisibilty(false);
                    btnLogin.Text = "İŞLETME GİRİŞİ"; 

                    FormMsg.ShowWarning("Çıkış yapıldı.");

                    currentUser = null; 
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MenuButonsVisibilty(bool situation)
        {
            btnWorkplace.Visible = !situation;
            btnCostumer.Visible = situation;
            btnProperty.Visible = situation;
            btnSearch.Visible = situation;
            btnRaport.Visible = situation;
        }
    }
}
