using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EL
{
    public class Property
    {
        public int Id { get; set; }
        public string PropertyType { get; set; }
        public double AreaSquareMeters { get; set; }
        public int NumberOfRooms { get; set; }
        public int Floor { get; set; }
        public int BuildingFloors { get; set; }
        public string HeatingType { get; set; }

        // Kiralama ve satış
        public byte IsForSale { get; set; }
        public decimal SalePrice { get; set; }
        public DateTime? SaleSoldDate { get; set; }

        public byte IsForRent { get; set; }
        public decimal RentPrice { get; set; }
        public DateTime? RentEndDate { get; set; }

        public DateTime? ListedDate { get; set; }

        // Adres
        public string City { get; set; }
        public string District { get; set; }
        public string Neighborhood { get; set; }
        public string StreetAddress { get; set; }

        // Emlağın sahibi (Müşteri)
        public int OwnerId { get; set; }
        public Customer Owner { get; set; }

        // Kiralık durumu için kiracı müşteri
        public int? TenantCustomerId { get; set; }
        public Customer TenantCustomer { get; set; }

        // İş yeri
        public int WorkplaceID { get; set; }
        public Workplace Workplace { get; set; }

        // Satış bilgileri
        public virtual ICollection<PropertySale> PropertySales { get; set; }
    }
}
