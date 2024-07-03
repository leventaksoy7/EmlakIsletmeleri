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
    public class PropertyService : IPropertyService
    {
        private readonly IPropertyRepository _propertyRepository;

        public PropertyService(IPropertyRepository propertyRepository)
        {
            _propertyRepository = propertyRepository;
        }

        public bool Create(Property entity)
        {
            try
            {
                _propertyRepository.Create(entity);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public Property GetById(int id)
        {
            return _propertyRepository.GetById(id);
        }

        public List<Property> GetAll()
        {
            return _propertyRepository.GetAll();
        }

        public void Update(Property entity)
        {
            _propertyRepository.Update(entity);
        }

        public void Delete(Property entity)
        {
            _propertyRepository.Delete(entity);
        }

        public List<Property> FilterProperties(PropertyFilterCriteria criteria, int workplaceId)
        {
            return _propertyRepository.FilterProperties(criteria, workplaceId);
        }

        public List<Property> GetPropertiesByCustomerId(int customerId)
        {
            return _propertyRepository.GetPropertiesByCustomerId(customerId);
        }
    }
}
