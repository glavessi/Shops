using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shops.BLL.DTO
{
    public class EmployeeTypeDTO
    {
        private int _TypeId;
        private string _Name;
        private decimal? _Salary;

        public int TypeId { get => _TypeId; set => _TypeId = value; }
        public string Name { get => _Name; set => _Name = value; }
        public decimal? Salary { get => _Salary; set => _Salary = value; }
    }
}
