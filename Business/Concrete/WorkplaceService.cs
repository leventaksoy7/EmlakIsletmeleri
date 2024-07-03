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
    public class WorkplaceService : IWorkplaceService
    {
        private readonly IWorkplaceRepository _workplaceRepository;

        public WorkplaceService(IWorkplaceRepository workplaceRepository)
        {
            _workplaceRepository = workplaceRepository;
        }

        public Workplace GetById(int id)
        {
            return _workplaceRepository.GetById(id);
        }

        public List<Workplace> GetAll()
        {
            return _workplaceRepository.GetAll();
        }

        public bool Create(Workplace entity)
        {
            try
            {
                _workplaceRepository.Create(entity);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public void Update(Workplace entity)
        {
            _workplaceRepository.Update(entity);
        }

        public void Delete(Workplace entity)
        {
            _workplaceRepository.Delete(entity);
        }

        public Workplace GetWorkplaceByUserNameAndPassword(string userName, string password)
        {
            return _workplaceRepository.GetWorkplaceByUserNameAndPassword(userName, password);
        }
    }
}
