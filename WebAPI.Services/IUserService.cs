using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WebAPI.Domain;

namespace WebAPI.Services
{
   public interface IUserService
    {
        bool IsUserExits(string firstname, string lastname);
        IList<User> GetUsers();
        Task<User> GetUserById(Guid id);
        Task<User> AddUserAsync(User user);
        Task<User> DeleteUserAsync(User user);
        Task<User> UpdateUserAsync(User user);
        Task<User> Authentication(string email, string password);
    }
}
