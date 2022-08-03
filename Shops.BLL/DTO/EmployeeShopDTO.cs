using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shops.BLL.DTO
{
    public class EmployeeShopDTO
    {
        private int _EmployeeId;
        private int _ShopId;
        private DateTime _Workday;
        private EmployeeDTO _Employee;
        private ShopDTO _Shop;

        public int EmployeeId { get => _EmployeeId; set => _EmployeeId = value; }
        public int ShopId { get => _ShopId; set => _ShopId = value; }
        public DateTime Workday { get => _Workday; set => _Workday = value; }
        public EmployeeDTO Employee { get => _Employee; set => _Employee = value; }
        public ShopDTO Shop { get => _Shop; set => _Shop = value; }
    }
}
