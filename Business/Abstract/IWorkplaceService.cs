using EL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Abstract
{
    public interface IWorkplaceService : IService<Workplace>
    {
        public Workplace GetWorkplaceByUserNameAndPassword(string userName, string password);
    }
}
