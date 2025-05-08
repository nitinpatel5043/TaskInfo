using TaskInfo.Core.Domain.RepositoryContracts;
using TaskInfo.Core.ServiceContracts.IUserService;

namespace TaskInfo.Core.Services.UsersService
{
    public class UserExistsOrNot : IUserExistsOrNot
    {
        private readonly IUserRepository _userRepository;
        public UserExistsOrNot(IUserRepository userRepository) {
            _userRepository = userRepository;
        }
        public async Task<bool> IsUserExistsOrNotExists(string? userId, Guid? guid)
        {
            if (userId != null || guid != null)
            {
               return await _userRepository.UserExists(userId, guid);
            }

            return false;
        }
    }
}
