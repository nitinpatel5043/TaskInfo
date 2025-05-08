using TaskInfo.Core.Domain.Entities;
using TaskInfo.Core.Domain.RepositoryContracts;
using TaskInfo.Core.ServiceContracts.ITaskService;

namespace TaskInfo.Core.Services.TaskService
{
    public class GetAllTasks : IGetAllTasks
    {
        private readonly ITaskRepository _taskRepository;

        public GetAllTasks(ITaskRepository taskRepository)
        {
            _taskRepository = taskRepository;
        }

        public async Task<List<MyTask>> GetAllPossibleTasks()
        {
            List<MyTask> tasks = await _taskRepository.GetAllTasks();

            return tasks.ToList();
        }
    }
}
