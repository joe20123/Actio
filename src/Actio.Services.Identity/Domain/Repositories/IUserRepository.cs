using System;
using System.Threading.Tasks;

namespace Actio.Services.Identity.Domain.Repositories
{
    public interface IUserRepository
    {
         Task<User> GetAsync(string email);
         Task<User> GetAsync(Guid id);
         Task AddAsync(User User);
    }
}