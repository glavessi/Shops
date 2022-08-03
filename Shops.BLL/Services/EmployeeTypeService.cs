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
    public class EmployeeTypeService : BaseService<IEmployeeTypeRepository, EmployeeType>, IEmployeeTypeService
    {
        public EmployeeTypeService(IEmployeeTypeRepository repo, ILogger<EmployeeTypeService> log) : base(repo, log)
        {
        }
    }
}
