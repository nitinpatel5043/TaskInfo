using TaskInfo.Core.Domain.Entities;
using TaskInfo.Core.Enums;

namespace TaskInfo.Core.ServiceContracts.ITaskService
{
    public interface IChangeStatus
    {
        public Task<MyTask> ChangeAStatus(string Title, CustomTaskStatus newStatus);
    }
}
