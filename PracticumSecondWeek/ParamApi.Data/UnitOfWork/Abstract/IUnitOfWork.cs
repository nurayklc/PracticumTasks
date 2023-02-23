using ParamApi.Data.Model;
using ParamApi.Data.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParamApi.Data.UOW.Abstract
{
    public interface IUnitOfWork : IDisposable
    {
        IGenericRepository<Account> AccountRepository { get; }
        IGenericRepository<Person> PersonRepository { get; }
        Task CompleteAsync();
    }
}
