using AutoMapper;
using Shops.BLL.DTO;
using Shops.Data.EF.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shops.BLL.MapperService
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            //Employee Table Mapper
            CreateMap<EmployeeDTO, Employee>();
            CreateMap<Employee, EmployeeDTO>();
            //EmployeeType Table Mapper
            CreateMap<EmployeeTypeDTO, EmployeeType>();
            CreateMap<EmployeeType, EmployeeTypeDTO>();
            //EmployeeShop Table Mapper
            CreateMap<EmployeeShopDTO, EmployeeShop>();
            CreateMap<EmployeeShop, EmployeeShopDTO>();
            //Shop Table Mapper
            CreateMap<ShopDTO, Shop>();
            CreateMap<Shop, ShopDTO>();
        }
    }
}
