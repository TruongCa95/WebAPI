using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Domain.DataContext;

namespace WebAPI.Domain.Generic_Repository.Repositories
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        private readonly APIDataContext _dbcontext;
        public UserRepository(APIDataContext dbcontext) : base(dbcontext)
        {
            _dbcontext = dbcontext;
        }
        public bool CheckExitMember(string firstname, string lastname)
        {
            return _dbcontext.Users.Any(x => x.FirstName == firstname || x.LastName == lastname);
        }

        public async Task<User> FindMemberByEmailAndPassword(string email, string password)
        {
            return await _dbcontext.Users.FirstOrDefaultAsync(x => x.Email == email && x.Password == password);
        }
    }
}
