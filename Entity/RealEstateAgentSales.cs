using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EL
{
    public class RealEstateAgentSales
    {
        public int ID { get; set; }
        public int RealEstateAgentId { get; set; }
        public Workplace RealEstateAgent { get; set; }
        public int PropertySaleId { get; set; }
        public PropertySale PropertySale { get; set; }
        public decimal SaleAmount { get; set; }
        public DateTime SaleDate { get; set; }
    }
}
