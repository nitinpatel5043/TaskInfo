using TaskInfo.Core.Domain.Entities;
using TaskInfo.Core.Domain.RepositoryContracts;
using TaskInfo.Core.Enums;
using TaskInfo.Core.ServiceContracts.ITaskService;

namespace TaskInfo.Core.Services.TaskService
{
    public class GetTaskByStatus : IGetTaskByStatus
    {
        private readonly ITaskRepository _taskRepository;

        public GetTaskByStatus(ITaskRepository taskRepository)
        {
            _taskRepository = taskRepository;
        }
        public async Task<List<MyTask>> GetTasksByAStatus(CustomTaskStatus customTaskStatus)
        {
            List<MyTask>? tasks = await _taskRepository.GetAllTasksByStatus(customTaskStatus);

            return tasks.ToList();
        }
    }
}
