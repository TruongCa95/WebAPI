using System;
using System.Threading.Tasks;
using WebAPI.Model.DataContext;

namespace WebAPI.Model.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private bool disposed = false;
        private readonly APIDataContext _dbcontext;
        public UnitOfWork(APIDataContext dbcontext)
        {
            _dbcontext = dbcontext;

        }

         public async Task Commit()
        {
            await _dbcontext.SaveChangesAsync();
        }

        public virtual void Dispose(bool disposing)
        {
            if(!disposed)
            {
                if(disposing)
                {
                    _dbcontext.Dispose();
                }
            }
            disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
