using AutoMapper;
using ParamApi.Data.Model;
using ParamApi.Dto.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParamApi.Service.Mapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Person,PersonDto>().ReverseMap();
            CreateMap<Account,AccountDto>().ReverseMap();
        }
    }
}
