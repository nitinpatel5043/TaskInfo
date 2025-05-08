using TaskInfo.Core.Domain.Entities;
using TaskInfo.Core.Domain.RepositoryContracts;
using TaskInfo.Core.Enums;
using TaskInfo.Core.ServiceContracts.ITaskService;

namespace TaskInfo.Core.Services.TaskService
{
    public class ChangeStatus : IChangeStatus
    {
        private readonly ITaskRepository _taskRepository;

        public ChangeStatus(ITaskRepository taskRepository)
        {
            _taskRepository = taskRepository;
        }
        public async Task<MyTask> ChangeAStatus(string Title, CustomTaskStatus newStatus)
        {

            MyTask? myTask = await _taskRepository.UpdateTaskStatus(Title, newStatus);

            return myTask;
        }
    }
}
