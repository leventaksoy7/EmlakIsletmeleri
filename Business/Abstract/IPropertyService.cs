using DAL.Abstract;
using EL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Abstract
{
    public interface IPropertyService : IService<Property>
    {
        List<Property> FilterProperties(PropertyFilterCriteria criteria, int workplaceId);
        List<Property> GetPropertiesByCustomerId(int customerId);
    }
}
