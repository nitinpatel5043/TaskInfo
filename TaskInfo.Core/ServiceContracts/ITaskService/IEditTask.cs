using TaskInfo.Core.Domain.Entities;

namespace TaskInfo.Core.ServiceContracts.ITaskService
{
    public interface IEditTask
    {
        public Task<MyTask> EditATask(MyTask myTask);
    }
}
