using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EL
{
    public class PropertySale
    {
        public int ID { get; set; }
        public int PropertyId { get; set; }
        public Property Property { get; set; }
        public int SellerCustomerId { get; set; }
        public Customer SellerCustomer { get; set; }
        public int BuyerCustomerId { get; set; }
        public Customer BuyerCustomer { get; set; }
        public DateTime SaleDate { get; set; }
        public int RealEstateAgentId { get; set; }
        public Workplace RealEstateAgent { get; set; }
    }
}
