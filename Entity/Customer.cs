using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EL
{
    public class Customer
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string HomePhone { get; set; }
        public string CellPhone { get; set; }
        public string Email { get; set; }

        // Tam adı döndür
        public string FullName => $"{FirstName} {LastName}";

        // İlişki: İş yeri
        public int WorkplaceID { get; set; }
        public Workplace Workplace { get; set; }

        // Müşterinin sahip olduğu mülkler
        public virtual ICollection<Property> OwnedProperties { get; set; }

        // Müşterinin kiraladığı mülkler
        public virtual ICollection<Property> RentedProperties { get; set; }

        // Satışlar
        public virtual ICollection<PropertySale> SalesAsSeller { get; set; }
        public virtual ICollection<PropertySale> SalesAsBuyer { get; set; }
    }
}
