using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WebAPI.Domain;
using WebAPI.Domain.Generic_Repository;
using WebAPI.Domain.Unit_Of_Work;

namespace WebAPI.Services
{
    public class UserService : IUserService
    {
        private readonly IUnitOfWork _unitOfWork;
   
        public UserService(IUnitOfWork unitOfWork, IRepository<User> repository)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<User> AddUserAsync(User user)
        {
            _unitOfWork.UserRepository.Insert(user);
            await _unitOfWork.Commit();
            return user;
        }

        public Task<User> Authentication(string email, string password)
        {
            throw new NotImplementedException();
        }

        public async Task<User> DeleteUserAsync(User user)
        {
            var currentUser = await _unitOfWork.UserRepository.FindMemberByEmailAndPassword(user.Email, user.Password);
            _unitOfWork.UserRepository.Delete(currentUser);
            await _unitOfWork.Commit();
            return user;
        }

        public async Task<User> GetUserById(Guid id)
        {
            var userlist = await _unitOfWork.UserRepository.GetById(id);
            userlist.Password = null;
            return userlist;
        }

        public async Task<IList<User>> GetUsers()
        {
            return await _unitOfWork.UserRepository.GetAll();
        }

        public bool IsUserExits(string firstname, string lastname)
        {
            return _unitOfWork.UserRepository.CheckExitMember(firstname, lastname);
        }

        public async Task<User> UpdateUserAsync(User user)
        {
            var currentUser = await _unitOfWork.UserRepository.FindMemberByEmailAndPassword(user.Email, user.Password);
            currentUser.LastName = user.LastName;
            currentUser.FirstName = user.FirstName;
            currentUser.Gender = user.Gender;
            currentUser.DateOfBirth = user.DateOfBirth;
            await _unitOfWork.Commit();
            return currentUser;
        }
    }
}
