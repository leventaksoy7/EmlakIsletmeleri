using BLL.Concrete;
using DAL.Concrete.EfCore;
using EmlakIsletmeleri.Lib;
using Microsoft.Extensions.Configuration;
using static DAL.Concrete.EfCore.EfContext;


namespace EmlakIsletmeleri
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            // Baðýmlýlýklarý oluþturma ve çözme
            EfContext context = new EfContext();

            WorkplaceRepository workplaceRepository = new WorkplaceRepository(context);
            WorkplaceService workplaceService = new WorkplaceService(workplaceRepository);

            CustomerRepository customerRepository = new CustomerRepository(context);
            CustomerService customerService = new CustomerService(customerRepository);

            PropertyRepository propertyRepository = new PropertyRepository(context);
            PropertyService propertyService = new PropertyService(propertyRepository);

            PropertySaleRepository propertySaleRepository = new PropertySaleRepository(context);
            PropertySaleService propertySaleService = new PropertySaleService(propertySaleRepository);

            RealEstateAgentSalesRepository realEstateAgentSalesRepository = new RealEstateAgentSalesRepository(context);
            RealEstateAgentSalesService realEstateAgentSalesService = new RealEstateAgentSalesService(realEstateAgentSalesRepository);

            //Application.Run(new MainForm(workplaceService));
            Application.Run(new Template(
                workplaceService,
                customerService,
                propertyService,
                propertySaleService,
                realEstateAgentSalesService));
        }
    }
}