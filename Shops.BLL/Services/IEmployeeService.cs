using Shops.BLL.DTO;
using Shops.Data.EF.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shops.BLL.Services
{
    public interface IEmployeeService : IBaseService<Employee>
    {
        /*add methods usable only for employee services*/
        Task<List<EmployeeDTO>> GetAllEmployees();
        Task<List<EmployeeTypeDTO>> GetAllTypes();
        Task<bool> AddEmployee(EmployeeDTO employee);
    }
}
