using Microsoft.EntityFrameworkCore;
using PrivateStorage.Core.DTO;
using PrivateStorage.Core.Services;
using PrivateStorage.DataAccess;
using PrivateStorage.DataAccess.Entities;


namespace BusinessLogic.Services
{
    public class UserService : IUserService
    {

        private readonly PrivateCloudContext _context;
        public UserService(PrivateCloudContext context) { 
            _context = context;
        }    
        public async Task<User> getUserByIdAsync(int id)
        {
            var user = await _context.Users.FindAsync(id);

            return user;
        }

        public async Task<User> getUserByEmailAsync(string email)
        {
            var user = await _context.Users.FirstOrDefaultAsync(_user => _user.Email == email);

            return user;
        }

        public async Task<User> createUserAsync(CreateUserRequest _user)
        {
            var user = new User { Email = _user.Email, NickName = _user.NickName, Password = _user.Password };
            var result = await _context.Users.AddAsync(user);
            await _context.SaveChangesAsync();
            return result.Entity;
        }

    }
}
