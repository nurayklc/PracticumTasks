using AutoMapper;
using ParamApi.Data.UOW.Abstract;
using ParamApi.Data.UOW.Concrete;
using ParamApi.Service.Abstract;
using ParamApi.Service.Concrete;
using ParamApi.Service.Mapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParamApi.Extension
{
    public static class StartupDIExtension
    {
        public static void AddServicesDI(this IServiceCollection services) 
        {
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<IPersonService, PersonService>();
            services.AddScoped<IAccountService, AccountService>();

            var mapperConfig = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new MappingProfile());
            });
            services.AddSingleton(mapperConfig.CreateMapper());
        }
    }
}
