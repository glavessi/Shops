using Shops.Data.EF.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shops.Data.EF.DAL
{
    public interface IEmployeeShopRepository : IBaseRepository<EmployeeShop>
    {
        /*add methods especific to employeesShop table if needed*/
    }
}
