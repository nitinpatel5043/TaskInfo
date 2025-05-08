using TaskInfo.Core.Domain.Entities;
using TaskInfo.Core.Domain.RepositoryContracts;
using TaskInfo.Core.ServiceContracts.ITaskService;

namespace TaskInfo.Core.Services.TaskService
{
    public class EditTask : IEditTask
    {
        private readonly ITaskRepository _taskRepository;

        public EditTask(ITaskRepository taskRepository)
        {
            _taskRepository = taskRepository;
        }
        public async Task<MyTask> EditATask(MyTask myTask)
        {
            MyTask myTask1 = await _taskRepository.EditATask(myTask);

            return myTask1;
        }
    }
}
