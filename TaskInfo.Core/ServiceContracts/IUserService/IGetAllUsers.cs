using TaskInfo.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskInfo.Core.ServiceContracts.IUserService
{
    public interface IGetAllUsers
    {
        public Task<List<User>> GetAllAUsers();
    }
}
