using DAL.Abstract;
using EL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Concrete.EfCore
{
    public class WorkplaceRepository : GenericRepository<Workplace>, IWorkplaceRepository
    {
        public WorkplaceRepository(EfContext context) : base(context)
        {
        }

        public Workplace GetWorkplaceByUserNameAndPassword(string userName, string password)
        {
            using (var context = new EfContext())
            {
                return context.Workplaces
                    .FirstOrDefault(w => w.UserName == userName && w.Password == password);
            }
        }
    }
}
