using Shops.Data.EF.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shops.Data.EF.DAL
{
    public interface IEmployeeRepository : IBaseRepository<Employee>
    {
        /*add methods especific to employees if needed*/

        Task<IList<Employee>> GetEmployeesData();
        Task<IList<EmployeeType>> GetTypes();
    }
}
