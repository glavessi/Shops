using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shops.BLL.DTO
{
    public class EmployeeDTO
    {
        private int _EmployeeId;
        private string _Name;
        private int _TypeID;
        private string _Telephone;
        private string _Address;
        private DateTime _EmploymentDate;
        private EmployeeTypeDTO _Type;
        //private EmployeeShopDTO _EmployeeShops;

        public int EmployeeId { get => _EmployeeId; set => _EmployeeId = value; }
        public string Name { get => _Name; set => _Name = value; }
        public int TypeID { get => _TypeID; set => _TypeID = value; }
        public string Telephone { get => _Telephone; set => _Telephone = value; }
        public string Address { get => _Address; set => _Address = value; }
        public DateTime EmploymentDate { get => _EmploymentDate; set => _EmploymentDate = value; }
        public EmployeeTypeDTO Type { get => _Type; set => _Type = value; }
        //public EmployeeShopDTO EmployeeShops { get => _EmployeeShops; set => _EmployeeShops = value; }
    }
}
