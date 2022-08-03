﻿using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shops.BLL.MapperService
{
    public class ObjectMapper
    {
        public static IMapper Mapper
        {
            get { return mapper.Value; }
        }

        public static IConfigurationProvider Configuration
        {
            get { return config.Value; }
        }

        public static Lazy<IMapper> mapper = new Lazy<IMapper>(() =>
        {
            var mapper = new Mapper(Configuration);
            return mapper;
        });

        public static Lazy<IConfigurationProvider> config = new Lazy<IConfigurationProvider>(() =>
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<MapperProfile>();                
            });

            return config;
        });
    }
}
