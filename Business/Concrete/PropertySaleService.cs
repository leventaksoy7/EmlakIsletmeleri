using BLL.Abstract;
using DAL.Abstract;
using DAL.Concrete.EfCore;
using EL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Concrete
{
    public class PropertySaleService : IPropertySaleService
    {
        private readonly IPropertySaleRepository _propertySaleRepository;

        public PropertySaleService(IPropertySaleRepository propertySaleRepository)
        {
            _propertySaleRepository = propertySaleRepository;
        }

        public bool Create(PropertySale entity)
        {
            try
            {
                _propertySaleRepository.Create(entity);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public PropertySale GetById(int id)
        {
            return _propertySaleRepository.GetById(id);
        }

        public void Delete(PropertySale entity)
        {
            _propertySaleRepository.Delete(entity);
        }

        public List<PropertySale> GetAll()
        {
            return _propertySaleRepository.GetAll();
        }

        public void Update(PropertySale entity)
        {
            _propertySaleRepository.Update(entity);
        }
    }
}
