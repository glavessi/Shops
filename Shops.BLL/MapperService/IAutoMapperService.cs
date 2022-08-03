using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shops.BLL.MapperService
{
    public interface IAutoMapperService
    {
        IMapper Mapper { get; }
    }
}
