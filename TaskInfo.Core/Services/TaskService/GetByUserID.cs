using TaskInfo.Core.Domain.Entities;
using TaskInfo.Core.Domain.RepositoryContracts;
using TaskInfo.Core.ServiceContracts.ITaskService;

namespace TaskInfo.Core.Services.TaskService
{
    public class GetByUserID : IGetByUserID
    {
        private readonly ITaskRepository _taskRepository;

        public GetByUserID(ITaskRepository taskRepository)
        {
            _taskRepository = taskRepository;
        }
        public async Task<List<MyTask>> GetTaskByUserID(Guid userId)
        {
            List<MyTask>? myTasks = await _taskRepository.GetAllTasksByUserID(userId);

            return myTasks;
        }
    }
}
