using AutoMapper;
using ParamApi.Base;
using ParamApi.Data.Context;
using ParamApi.Data.Model;
using ParamApi.Data.Repository.Abstract;
using ParamApi.Data.Repository.Concrete;
using ParamApi.Data.UOW.Abstract;
using ParamApi.Dto.Dtos;
using ParamApi.Service.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParamApi.Service.Concrete
{
    public class PersonService : BaseService<PersonDto, Person>, IPersonService
    {
        private readonly IGenericRepository<Person> _genericRepository;

        public PersonService(IGenericRepository<Person> genericRepository, IMapper mapper, IUnitOfWork unitOfWork) 
            : base(genericRepository, mapper, unitOfWork)
        {
            _genericRepository = genericRepository;
        }
        public async Task<BaseResponse<PersonDto>> InsertAsync(PersonDto person)
        {
            if (person == null)
                return new BaseResponse<PersonDto>("Id is null");

            return await base.AddAsync(person);
        }
    }
}
