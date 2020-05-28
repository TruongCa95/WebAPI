using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace WebAPI.Data.Generic_Repository
{
    /// <summary>
    /// Generic repository class that defined operatin related to CRUD
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IRepository<T> where T : class
    {
        Task <IList<T>> GetAll();
        Task<T> GetById(Guid id);
        void Insert(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
