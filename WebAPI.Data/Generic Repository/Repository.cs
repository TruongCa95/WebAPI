using System;
using System.Collections.Generic;
using System.Text;
using WebAPI.Data.Model;

namespace WebAPI.Model.Generic_Repository
{
    public class Repository<T> : IRepository<T> where T : BaseEntity
    {

        public void Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> GetAll()
        {
            throw new NotImplementedException();
        }

        public T GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Insert(T entity)
        {
            throw new NotImplementedException();
        }

        public void Update(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
