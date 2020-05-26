using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace WebAPI.Domain.Generic_Repository.Repositories
{
   public interface IUserRepository
    {
        Task<User> FindMemberByEmailAndPassword(string email, string password);
        bool CheckExitMember(string firstname, string lastname);
    }
}
