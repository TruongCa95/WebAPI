using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using WebAPI.Data.Model;

namespace WebAPI.Model.Generic_Repository
{
    public interface IRepository<T> where T : BaseEntity
    {
        IEnumerable<T> GetAll();
        Task<T> GetById(Guid id);
        void Insert(T entity);
        void Update(T entity);
        void Delete(Guid id);
    }
}
