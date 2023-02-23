using AutoMapper;
using ParamApi.Data.Model;
using ParamApi.Data.Repository.Abstract;
using ParamApi.Data.Repository.Concrete;
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

            services.AddScoped<IGenericRepository<Person>, GenericRepository<Person>>();
            services.AddScoped<IGenericRepository<Account>, GenericRepository<Account>>();

            services.AddScoped<IPersonRepository, PersonRepository>();
            services.AddScoped<IAccountRepository, AccountRepository>();

            var mapperConfig = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new MappingProfile());
            });
            services.AddSingleton(mapperConfig.CreateMapper());
        }
    }
}
