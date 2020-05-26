using System.Threading.Tasks;
using WebAPI.Domain.Generic_Repository.Repositories;

namespace WebAPI.Domain.Unit_Of_Work
{
    /// <summary>
    /// this is the wraper around repository, this create the instance of the context and retirn the repository called
    /// </summary>
    public interface IUnitOfWork
    {
        /// <summary>
        /// Gets the by indentifier
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        UserRepository UserRepository { get; }
        //IRepository<T> Repository<T>() where T : BaseModel;
        /// <summary>
        /// Save this instance
        /// </summary>
        /// <returns></returns>
        Task Commit();
    }
}
