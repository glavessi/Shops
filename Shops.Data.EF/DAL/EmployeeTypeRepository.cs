using Shops.Data.EF.Data;
using Shops.Data.EF.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shops.Data.EF.DAL
{
    public class EmployeeTypeRepository : BaseRepository<EmployeeType>, IEmployeeTypeRepository
    {

        public EmployeeTypeRepository(ChallengeDBContext context) : base(context)
        {
        }

        /*Implement methods specific to EmployeesType table if needed*/

    }
}
