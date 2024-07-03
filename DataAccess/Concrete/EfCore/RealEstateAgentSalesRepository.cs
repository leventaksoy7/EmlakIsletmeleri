using DAL.Abstract;
using EL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Concrete.EfCore
{
    public class RealEstateAgentSalesRepository : GenericRepository<RealEstateAgentSales>, IRealEstateAgentSalesRepository
    {
        public RealEstateAgentSalesRepository(EfContext context) : base(context)
        {
        }
    }
}
