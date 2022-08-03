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
    public class EmployeeShopService : BaseService<IEmployeeShopRepository, EmployeeShop>, IEmployeeShopService
    {
        public EmployeeShopService(IEmployeeShopRepository repo, ILogger<EmployeeShopService> log) : base(repo, log)
        {
        }
    }
}
