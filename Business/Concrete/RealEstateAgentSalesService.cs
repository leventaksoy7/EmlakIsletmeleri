using BLL.Abstract;
using DAL.Abstract;
using EL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Concrete
{
    public class RealEstateAgentSalesService:IRealEstateAgentSalesService
    {
        private readonly IRealEstateAgentSalesRepository _realEstateAgentSalesRepository;

        public RealEstateAgentSalesService(IRealEstateAgentSalesRepository realEstateAgentSalesRepository)
        {
            _realEstateAgentSalesRepository = realEstateAgentSalesRepository;
        }

        public RealEstateAgentSales GetById(int id)
        {
            return _realEstateAgentSalesRepository.GetById(id);
        }

        public List<RealEstateAgentSales> GetAll()
        {
            return _realEstateAgentSalesRepository.GetAll();
        }

        public bool Create(RealEstateAgentSales entity)
        {
            try
            {
                _realEstateAgentSalesRepository.Create(entity);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public void Update(RealEstateAgentSales entity)
        {
            _realEstateAgentSalesRepository.Update(entity);
        }

        public void Delete(RealEstateAgentSales entity)
        {
            _realEstateAgentSalesRepository.Delete(entity);
        }
    }
}
