using Shops.Data.EF.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shops.Data.EF.DAL
{
    public interface IShopRepository : IBaseRepository<Shop>
    {
        /*add methods especific to Shop table if needed*/
    }
}
