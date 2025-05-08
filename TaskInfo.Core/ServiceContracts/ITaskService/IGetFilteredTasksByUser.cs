using TaskInfo.Core.Domain.Entities;
using TaskInfo.Core.Enums;

namespace TaskInfo.Core.ServiceContracts.ITaskService
{
    public interface IGetFilteredTasksByUser
    {
        Task<List<MyTask>?> FilterTasksByAnUser(Guid userId, string? title, CustomTaskStatus? status, DateTime? dueDate);

    }
}
