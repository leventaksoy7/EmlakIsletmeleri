using DAL.Concrete.EfCore;
using EL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmlakIsletmeleri.Lib
{
    public static class SeedData
    {
        public static void InitializeSampleData(EfContext context)
        {
            if (!context.Workplaces.Any())
            {
                var workplace = new Workplace
                {
                    UserName = "admin",
                    Password = "admin123",
                    Name = "Fonet Emlak",
                    AuthorizedPerson = "Levent AKSOY",
                    Address = "Merkez Mahallesi, 123 Sokak",
                    Phone = "555-1234",
                    Fax = "555-5678",
                    Customers = new List<Customer>()
                };

                var customers = new List<Customer>
                {
                    new Customer
                    {
                        FirstName = "Ahmet",
                        LastName = "Yılmaz",
                        HomePhone = "555-1111",
                        CellPhone = "555-2222",
                        Email = "ahmet.yilmaz@example.com",
                        OwnedProperties = new List<Property>(),
                        Workplace = workplace
                    },
                    new Customer
                    {
                        FirstName = "Mehmet",
                        LastName = "Öztürk",
                        HomePhone = "555-3333",
                        CellPhone = "555-4444",
                        Email = "mehmet.ozturk@example.com",
                        OwnedProperties = new List<Property>(),
                        Workplace = workplace
                    },
                };

                workplace.Customers = customers;

                var properties = new List<Property>
                {
                    new Property
                    {
                        PropertyType = "Apartman",
                        AreaSquareMeters = 100,
                        NumberOfRooms = 3,
                        Floor = 2,
                        BuildingFloors = 5,
                        HeatingType = "Doğalgaz",
                        IsForSale = 1,
                        SalePrice = 300000,
                        City = "İstanbul",
                        District = "Kadıköy",
                        Neighborhood = "Feneryolu",
                        StreetAddress = "Bağdat Caddesi No:123",
                        Owner = customers[0]
                    },
                    new Property
                    {
                        PropertyType = "Daire",
                        AreaSquareMeters = 85,
                        NumberOfRooms = 2,
                        Floor = 3,
                        BuildingFloors = 7,
                        HeatingType = "Kombi",
                        IsForRent = 1,
                        RentPrice = 2500,
                        City = "İstanbul",
                        District = "Beşiktaş",
                        Neighborhood = "Levent",
                        StreetAddress = "Levent Caddesi No:45",
                        Owner = customers[1]
                    },
                };

                context.Workplaces.Add(workplace);
                context.Customers.AddRange(customers);
                context.Properties.AddRange(properties);
                context.SaveChanges();
            }
        }
    }
}
