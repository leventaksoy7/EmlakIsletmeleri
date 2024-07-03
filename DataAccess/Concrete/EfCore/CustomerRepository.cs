using DAL.Abstract;
using EL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Concrete.EfCore
{
    public class CustomerRepository : GenericRepository<Customer>, ICustomerRepository
    {
        public CustomerRepository(EfContext context) : base(context)
        {
        }

        public List<Customer> GetCustomersBySearchText(string searchText)
        {
            var allCustomers = GetAll(); // Tüm müşterileri al

            // Verilen arama metniyle eşleşen müşterileri filtrele
            var filteredCustomers = allCustomers
                .Where(c => c.FirstName.ToLower().Contains(searchText.ToLower()) || c.LastName.ToLower().Contains(searchText.ToLower()))
                .ToList();

            return filteredCustomers;
        }
    }
}
