using ParamApi.Data.Context;
using ParamApi.Data.Model;
using ParamApi.Data.Repository.Abstract;
using ParamApi.Data.Repository.Concrete;
using ParamApi.Data.UOW.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParamApi.Data.UOW.Concrete
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _appDbContext;
        public bool IsDisposed { get; private set; }
        public IGenericRepository<Account> AccountRepository { get; private set; }
        public IGenericRepository<Person> PersonRepository { get; private set; }
        public UnitOfWork(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
            AccountRepository = new GenericRepository<Account>(appDbContext);
            PersonRepository = new GenericRepository<Person>(appDbContext);
        }

        public async Task CompleteAsync()
        {
            using (var dbContextTransaction = _appDbContext.Database.BeginTransaction())
            {
                try
                {
                    _appDbContext.SaveChanges();
                    dbContextTransaction.Commit();
                }
                catch (Exception ex)
                {
                    dbContextTransaction.Rollback();
                }
            }
        }
        protected virtual void Dispose(bool disposing)
        {
            if(!IsDisposed)
            {
                if(disposing)
                    _appDbContext.Dispose();
            }
            IsDisposed = true;
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
