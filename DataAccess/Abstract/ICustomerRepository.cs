using EL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Abstract
{
    public interface ICustomerRepository : IRepository<Customer>
    {
        List<Customer> GetCustomersBySearchText(string searchText);
    }
}
