using ParamApi.Base;
using ParamApi.Service.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParamApi.Service.Concrete
{
    public abstract class BaseService<Dto, Entity> : IBaseService<Dto, Entity> where Dto : class
    {
        
        public Task<BaseResponse<Dto>> AddAsync(Dto addResource)
        {
            throw new NotImplementedException();
        }

        public Task<BaseResponse<IEnumerable<Dto>>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<BaseResponse<Dto>> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<BaseResponse<Dto>> RemoveAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<BaseResponse<Dto>> UpdateAsync(int id, Dto updateResource)
        {
            throw new NotImplementedException();
        }
    }
}
