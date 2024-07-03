using EL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Abstract
{
    public interface IPropertyRepository : IRepository<Property>
    {
        List<Property> FilterProperties(PropertyFilterCriteria criteria,int workplaceId);
        List<Property> GetPropertiesByCustomerId(int customerId);
    }
}
