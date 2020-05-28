using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WebAPI.Data;

namespace WebAPI.Services
{
   public interface IUserService
    {
        bool IsUserExits(string firstname, string lastname);
        Task<IList<User>> GetUsers();
        Task<User> GetUserById(Guid id);
        Task<User> AddUserAsync(User user);
        Task<User> DeleteUserAsync(User user);
        Task<User> UpdateUserAsync(User user);
        Task<User> Authentication(string email, string password);
    }
}
