using System.Threading.Tasks;
using Actio.Services.Identity.Domain.Repositories;
using Actio.Services.Identity.Domain.Services;

namespace Actio.Services.Identity.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _repository;
        private readonly IEncryptor _encryptor;
        public UserService(IUserRepository repository, IEncryptor encryptor)
        {
            _repository = repository;
            _encryptor = encryptor;
        }
        public async Task LoginAsync(string email, string password)
        {
            var user = await _repository.GetAsync(email);
            if (user == null)
            {
                //TODO: user not exists error
                return;
            }
            if (!user.ValidatePassword(password, _encryptor) )
            {
                //TODO:
                return;
            }
            

        }

        public async Task RegisterAsync(string email, string password, string name)
        {
            var user = await _repository.GetAsync(email);
            if (user != null)
            {
                //TODO: throw user in used error
            }
            user = new User(email, name);
            user.SetPassword(password, _encryptor);

            await _repository.AddAsync(user);
        }
    }
}