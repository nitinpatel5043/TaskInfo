using TaskInfo.Core.Domain.Entities;

namespace TaskInfo.Core.ServiceContracts.ITaskService
{
    public interface ICreateTask
    {
        public Task<MyTask> CreateNewTask(MyTask myTask);
    }
}
