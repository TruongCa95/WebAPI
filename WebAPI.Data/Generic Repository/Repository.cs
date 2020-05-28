using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using WebAPI.Data.DataContext;

namespace WebAPI.Data.Generic_Repository
{
    /// <summary>
    /// Generic repository class that defined operatin related to CRUD
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly APIDataContext _dbContext;
        private DbSet<T> entities;
        /// <summary>
        /// Initializes a new instance of the <see cref="Repository1{T}" /> class
        /// </summary>
        /// <param name="context"></param>
        public Repository(APIDataContext context)
        {
            _dbContext = context;
            entities = context.Set<T>();
        }
        public void Delete(T entity)
        {
            //if (id == null) throw new ArgumentNullException("entity");

            //T entity = entities.SingleOrDefault(s => s.id == id);
            entities.Remove(entity);
        }

        public async Task<IList<T>> GetAll()
        {
            return await entities.ToListAsync();
        }

        public async Task<T> GetById(Guid id)
        {
            return await entities.FindAsync(id);
        }

        public void Insert(T entity)
        {
            entities.Add(entity);
        }

        public void Update(T entity)
        {
            entities.Update(entity);
        }
    }
}
