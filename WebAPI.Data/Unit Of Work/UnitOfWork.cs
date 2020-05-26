using System;
using System.Threading.Tasks;
using WebAPI.Domain.DataContext;
using WebAPI.Domain.Generic_Repository.Repositories;
using WebAPI.Domain.Unit_Of_Work;

namespace WebAPI.Domain.UnitOfWork
{
    public class UnitOfWork : IDisposable, IUnitOfWork
    {
        private bool disposed = false;
        private readonly APIDataContext _dbcontext;
        //private Dictionary<string, object> repositories;
        private UserRepository _userRepository;
        public UserRepository UserRepository
        {
            get => _userRepository ?? (_userRepository = new UserRepository(_dbcontext));
        }

        public UnitOfWork(APIDataContext dbcontext)
        {
            _dbcontext = dbcontext;

        }

        public async Task Commit()
        {
            await _dbcontext.SaveChangesAsync();
        }
        /// <summary>
        /// Releases unmanaged and - optionally - managed resources
        /// </summary>
        /// <param name="disposing"><c>true</c> to release both managed and unmanaged resource;
        /// <c>false</c> to release only unmanaged resource.</param>
        public virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    _dbcontext.Dispose();
                }
            }
            disposed = true;
        }
        /// <summary>
        /// Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources
        /// </summary>
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        /// <summary>
        /// repository instance
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        //public IRepository<T> Repository<T>() where T : BaseModel
        //{
        //    if (repositories == null)
        //    {
        //        repositories = new Dictionary<string, object>();
        //    }
        //    var type = typeof(T).Name;
        //    if (!repositories.ContainsKey(type))
        //    {
        //        var repositoryType = typeof(Repository<>);
        //        var repositoryInstance = Activator.CreateInstance(repositoryType.MakeGenericType(typeof(T)), _dbcontext);
        //        repositories.Add(type, repositoryInstance);
        //    }
        //    return (Repository<T>)repositories[type];
        //}
    }
}
