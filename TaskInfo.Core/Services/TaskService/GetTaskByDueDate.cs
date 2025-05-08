using TaskInfo.Core.Domain.Entities;
using TaskInfo.Core.Domain.RepositoryContracts;
using TaskInfo.Core.ServiceContracts.ITaskService;

namespace TaskInfo.Core.Services.TaskService
{
    public class GetTaskByDueDate : IGetTaskByDueDate
    {
        private readonly ITaskRepository _taskRepository;

        public GetTaskByDueDate(ITaskRepository taskRepository)
        {
            _taskRepository = taskRepository;
        }

        public async Task<List<MyTask>> GetTaskByADueDate(DateTime dateTime)
        {
            List<MyTask> myTasks = await _taskRepository.GetAllTasksByDueDate(dateTime);

            return myTasks;
        }
    }
}
