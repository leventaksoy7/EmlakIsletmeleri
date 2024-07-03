using DAL.Abstract;
using EL;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Concrete.EfCore
{
    public class PropertyRepository : GenericRepository<Property>, IPropertyRepository
    {
        public PropertyRepository(EfContext context) : base(context)
        {
        }

        public List<Property> GetPropertiesByCustomerId(int customerId)
        {
            var context = new EfContext();
            return context.Properties.Where(p => p.OwnerId == customerId).ToList();
        }

        public List<Property> FilterProperties(PropertyFilterCriteria criteria,int workplaceId)
        {
            var context = new EfContext();
            var query = context.Properties.AsQueryable();
            query = query.Where(p => p.WorkplaceID == workplaceId);

            // Filtreleme işlemleri
            if (!string.IsNullOrEmpty(criteria.PropertyType))
            {
                query = query.Where(p => p.PropertyType == criteria.PropertyType);
            }

            if (criteria.MinAreaSquareMeters > 0)
            {
                query = query.Where(p => p.AreaSquareMeters >= criteria.MinAreaSquareMeters);
            }

            if (criteria.MaxAreaSquareMeters > 0)
            {
                query = query.Where(p => p.AreaSquareMeters <= criteria.MaxAreaSquareMeters);
            }

            if (criteria.MinNumberOfRooms > 0)
            {
                query = query.Where(p => p.NumberOfRooms >= criteria.MinNumberOfRooms);
            }

            if (criteria.MaxNumberOfRooms > 0)
            {
                query = query.Where(p => p.NumberOfRooms <= criteria.MaxNumberOfRooms);
            }

            if (criteria.MinFloor > 0)
            {
                query = query.Where(p => p.Floor >= criteria.MinFloor);
            }

            if (criteria.MaxFloor > 0)
            {
                query = query.Where(p => p.Floor <= criteria.MaxFloor);
            }

            if (criteria.BuildingFloors > 0)
            {
                query = query.Where(p => p.BuildingFloors == criteria.BuildingFloors);
            }

            if (!string.IsNullOrEmpty(criteria.HeatingType))
            {
                query = query.Where(p => p.HeatingType == criteria.HeatingType);
            }

            if (criteria.MinSalePrice > 0)
            {
                query = query.Where(p => p.SalePrice >= criteria.MinSalePrice);
            }

            if (criteria.MaxSalePrice > 0)
            {
                query = query.Where(p => p.SalePrice <= criteria.MaxSalePrice);
            }

            if (!string.IsNullOrEmpty(criteria.City))
            {
                query = query.Where(p => p.City == criteria.City);
            }

            if (!string.IsNullOrEmpty(criteria.District))
            {
                query = query.Where(p => p.District == criteria.District);
            }

            if (!string.IsNullOrEmpty(criteria.Neighborhood))
            {
                query = query.Where(p => p.Neighborhood == criteria.Neighborhood);
            }

            if (!string.IsNullOrEmpty(criteria.StreetAddress))
            {
                query = query.Where(p => p.StreetAddress == criteria.StreetAddress);
            }

            if (criteria.IsForSale)
            {
                query = query.Where(p => p.IsForSale == 1);
            }

            if (criteria.IsForRent)
            {
                query = query.Where(p => p.IsForRent == 1);
            }

            return query.ToList();
        }
    }
}
