using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using WebAPI.Data.Model;
using WebAPI.Model.DataContext;
using Microsoft.EntityFrameworkCore;

namespace WebAPI.Model.Generic_Repository
{
    public class Repository<T> : IRepository<T> where T : BaseEntity
    {
        private readonly APIDataContext _dbContext;
        private DbSet<T> entities;
        public Repository(APIDataContext context)
        {
            _dbContext = context;
            entities = context.Set<T>();
        }
        public void Delete(Guid id)
        {
            if (id == null) throw new ArgumentNullException("entity");

            T entity = entities.SingleOrDefault(s => s.id == id);
            entities.Remove(entity);
        }

        public IEnumerable<T> GetAll()
        {
            return entities.ToList();
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
