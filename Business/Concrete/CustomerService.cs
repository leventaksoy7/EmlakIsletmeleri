using EL;
using DAL.Abstract;
using BLL.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Concrete
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepository _customerRepository;

        public CustomerService(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        public Customer GetById(int id)
        {
            return _customerRepository.GetById(id);
        }

        public List<Customer> GetAll()
        {
            return _customerRepository.GetAll();
        }

        public bool Create(Customer entity)
        {
            try
            {
                _customerRepository.Create(entity);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public void Update(Customer entity)
        {
            _customerRepository.Update(entity);
        }

        public void Delete(Customer entity)
        {
            _customerRepository.Delete(entity);
        }

        public List<Customer> GetCustomersBySearchText(string searchText)
        {
            return _customerRepository.GetCustomersBySearchText(searchText);
        }
    }
}
