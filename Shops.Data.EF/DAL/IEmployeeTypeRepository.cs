using Shops.Data.EF.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shops.Data.EF.DAL
{
    public interface IEmployeeTypeRepository : IBaseRepository<EmployeeType>
    {
        /*add methods especific to EmployeeType table if needed*/
    }
}
