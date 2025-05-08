using TaskInfo.Core.Domain.Entities;
using TaskInfo.Core.Enums;
namespace TaskInfo.Core.ServiceContracts.ITaskService
{
    public interface IGetTaskByStatus
    {
        public Task<List<MyTask>> GetTasksByAStatus(CustomTaskStatus customTaskStatus);
    }
}
