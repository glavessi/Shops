using Microsoft.Extensions.Logging;
using Shops.BLL.DTO;
using Shops.Data.EF.DAL;
using Shops.Data.EF.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shops.BLL.Services
{
    public class EmployeeService : BaseService<IEmployeeRepository, Employee>, IEmployeeService
    {
        IEmployeeRepository _repo;
        public EmployeeService(IEmployeeRepository repo, ILogger<EmployeeService> log) : base(repo,log)
        {
            _repo = repo;
        }

        public async Task<bool> AddEmployee(EmployeeDTO employee)
        {
            try
            {                
                var entity = await InsertAsync(Mapper.Map<Employee>(employee));
                if (entity != null)
                    return true;
            }
            catch (Exception ex)
            {
                Logger.LogError(ex.Message);
                throw new Exception(ex.InnerException == null ? ex.Message : ex.InnerException.Message);
            }
            return false;
        }

        public async Task<List<EmployeeDTO>> GetAllEmployees()
        {
            List<EmployeeDTO> lDto = new List<EmployeeDTO>();
            try
            {
                var obj = await _repo.GetEmployeesData();
                lDto = Mapper.Map<List<EmployeeDTO>>(obj);
            }
            catch (Exception ex)
            {
                Logger.LogError(ex.Message);
                throw new Exception(ex.InnerException == null ? ex.Message : ex.InnerException.Message);
            }
            return lDto;
        }

        public async Task<List<EmployeeTypeDTO>> GetAllTypes()
        {
            List<EmployeeTypeDTO> lDto = new List<EmployeeTypeDTO>();
            try
            {
                var obj = await _repo.GetTypes();
                lDto = Mapper.Map<List<EmployeeTypeDTO>>(obj);
            }
            catch (Exception ex)
            {
                Logger.LogError(ex.Message);
                throw new Exception(ex.InnerException == null ? ex.Message : ex.InnerException.Message);
            }
            return lDto;
        }
    }
}
