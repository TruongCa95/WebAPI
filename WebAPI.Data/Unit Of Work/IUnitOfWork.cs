using System;
using System.Threading.Tasks;

namespace WebAPI.Model.UnitOfWork
{
    public interface IUnitOfWork: IDisposable
    {
        Task Commit();
    }
}
