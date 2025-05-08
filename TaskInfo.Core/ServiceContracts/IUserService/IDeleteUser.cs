using TaskInfo.Core.Domain.Entities;

namespace TaskInfo.Core.ServiceContracts.IUserService
{
    public interface IDeleteUser
    {
        public Task<User> DeleteAnUser(string UserName);
    }
}
