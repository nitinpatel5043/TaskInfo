using TaskInfo.Core.Domain.Entities;

namespace TaskInfo.Core.ServiceContracts.ITaskService
{
    public interface IDeleteTask
    {
        public Task<bool> DeleteATask(string Title);
    }
}
