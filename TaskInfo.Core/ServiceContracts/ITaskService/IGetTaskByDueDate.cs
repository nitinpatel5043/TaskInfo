using TaskInfo.Core.Domain.Entities;

namespace TaskInfo.Core.ServiceContracts.ITaskService
{
    public interface IGetTaskByDueDate
    {
        public Task<List<MyTask>> GetTaskByADueDate(DateTime dateTime);
    }
}
