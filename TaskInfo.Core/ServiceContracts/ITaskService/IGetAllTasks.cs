using TaskInfo.Core.Domain.Entities;

namespace TaskInfo.Core.ServiceContracts.ITaskService
{
    public interface IGetAllTasks
    {
        public Task<List<MyTask>> GetAllPossibleTasks();
    }
}