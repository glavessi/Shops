using Microsoft.EntityFrameworkCore;
using Shops.Data.EF.Data;
using Shops.Data.EF.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shops.Data.EF.DAL
{
    public class EmployeeRepository : BaseRepository<Employee>, IEmployeeRepository
    {

        public EmployeeRepository(ChallengeDBContext context) : base(context)
        {            
        }

        public async Task<IList<Employee>> GetEmployeesData()
        {
            try
            {
                return await _Context.Set<Employee>().Include(s => s.Type).Include(x => x.EmployeeShops).ToListAsync();
            }
            catch (Exception ex)
            {
                throw new Exception($"Couldn't retrieve registries: {ex.Message}");
            }
        }

        public async Task<IList<EmployeeType>> GetTypes()
        {
            try
            {
                return await _Context.Set<EmployeeType>().AsNoTracking().ToListAsync();
            }
            catch (Exception ex)
            {
                throw new Exception($"Couldn't retrieve registries: {ex.Message}");
            }
        }

        /*Implement methods specific to employees if needed*/

    }
}
