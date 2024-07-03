using EL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Abstract
{
    public interface ICustomerService : IService<Customer>
    {
        public List<Customer> GetCustomersBySearchText(string searchText);
    }
}
