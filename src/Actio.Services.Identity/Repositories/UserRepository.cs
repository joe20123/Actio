using System;
using System.Threading.Tasks;
using Actio.Services.Activities.Domain.Models;
using Actio.Services.Activities.Domain.Repositories;

namespace Actio.Services.Identity.Repositories
{
    public class UserRepository : IUserRepository
    {
        public UserRepository(IMongoDatabase database)
        {

        }
        public async Task AddAsync(User user)
        {
            
        }

        public async Task<User> GetAsync(Guid id)
        {
            
        }

        public async Task<User> GetAsync(string email)
        {
            
        }
    }
}