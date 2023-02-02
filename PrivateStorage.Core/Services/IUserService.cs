using PrivateStorage.Core.DTO;
using PrivateStorage.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivateStorage.Core.Services
{
    public interface IUserService
    {
        Task<User> getUserByIdAsync(int id);
        Task<User> getUserByEmailAsync(string email);
        Task<User> createUserAsync(CreateUserRequest user);
    }
}
