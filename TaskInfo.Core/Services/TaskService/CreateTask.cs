using TaskInfo.Core.Domain.Entities;
using TaskInfo.Core.Domain.RepositoryContracts;
using TaskInfo.Core.ServiceContracts.ITaskService;

namespace TaskInfo.Core.Services.TaskService
{
    public class CreateTask : ICreateTask
    {
        private readonly ITaskRepository _taskRepository;

        public CreateTask(ITaskRepository taskRepository)
        {
            _taskRepository = taskRepository;
        }
        public async Task<MyTask> CreateNewTask(MyTask myTask)
        {
            await _taskRepository.AddNewTask(myTask);

            return myTask;

        }
    }
}
