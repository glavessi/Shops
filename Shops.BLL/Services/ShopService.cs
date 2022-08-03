using Microsoft.Extensions.Logging;
using Shops.Data.EF.DAL;
using Shops.Data.EF.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shops.BLL.Services
{
    public class ShopService : BaseService<IShopRepository, Shop>, IShopService
    {
        public ShopService(IShopRepository repo, ILogger<ShopService> log) : base(repo, log)
        {
        }
    }
}
