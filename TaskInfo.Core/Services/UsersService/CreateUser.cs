using TaskInfo.Core.Domain.Entities;
using TaskInfo.Core.Domain.RepositoryContracts;
using TaskInfo.Core.ServiceContracts.IUserService;

namespace TaskInfo.Core.Services.UsersService
{
    public class CreateUser : ICreateUser
    {
        private readonly IUserRepository _userRepository;

        public CreateUser(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<User?> CreateAnUser(User user)
        {
            return await _userRepository.CreateUser(user);
        }

    }
}
