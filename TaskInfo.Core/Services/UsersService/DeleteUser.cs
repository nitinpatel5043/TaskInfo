using TaskInfo.Core.Domain.Entities;
using TaskInfo.Core.Domain.RepositoryContracts;
using TaskInfo.Core.ServiceContracts.IUserService;

namespace TaskInfo.Core.Services.UsersService
{
    public class DeleteUser : IDeleteUser
    {
        private readonly IUserRepository _userRepository;

        public DeleteUser(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        public async Task<User?> DeleteAnUser(string UserName)
        {
            // Attempt to delete the user via the repository
            return await _userRepository.DeleteUser(UserName);
        }

    }
}
