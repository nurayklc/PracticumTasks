using ParamApi.Data.Model;
using ParamApi.Data.Repository.Abstract;
using ParamApi.Dto.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParamApi.Service.Abstract
{
    public interface IAccountService : IBaseService<AccountDto,Account>
    {
    }
}
