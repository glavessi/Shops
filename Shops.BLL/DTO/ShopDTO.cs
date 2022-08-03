using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shops.BLL.DTO
{
    public class ShopDTO
    {
        private int _ShopId;
        private string _Name;
        private string _Address;
        private string _Telephone;

        public int ShopId { get => _ShopId; set => _ShopId = value; }
        public string Name { get => _Name; set => _Name = value; }
        public string Address { get => _Address; set => _Address = value; }
        public string Telephone { get => _Telephone; set => _Telephone = value; }
    }
}
