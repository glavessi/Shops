using Shops.Data.EF.Data;
using Shops.Data.EF.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shops.Data.EF.DAL
{
    public class EmployeeShopRepository : BaseRepository<EmployeeShop>, IEmployeeShopRepository
    {

        public EmployeeShopRepository(ChallengeDBContext context) : base(context)
        {            
        }

        /*Implement methods specific to employeesShop table if needed*/

    }
}
