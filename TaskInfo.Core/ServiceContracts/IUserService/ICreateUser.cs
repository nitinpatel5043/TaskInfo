using TaskInfo.Core.Domain.Entities;

namespace TaskInfo.Core.ServiceContracts.IUserService
{
    public interface ICreateUser
    {
        public Task<User> CreateAnUser(User user);
    }
}
