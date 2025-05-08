using TaskInfo.Core.Domain.Entities;
using TaskInfo.Core.Domain.RepositoryContracts;
using TaskInfo.Core.ServiceContracts.ITaskService;

namespace TaskInfo.Core.Services.TaskService
{
    public class DeleteTask : IDeleteTask
    {
        private readonly ITaskRepository _taskRepository;

        public DeleteTask(ITaskRepository taskRepository)
        {
            _taskRepository = taskRepository;
        }
        public async Task<bool> DeleteATask(string title)
        {
            // Attempt to get the task by title
            MyTask myTask = await _taskRepository.GetTaskByTitle(title);

            if (myTask == null)
            {
                // If no task was found, return false
                return false;
            }

            // If task exists, delete it
            bool isdel = await _taskRepository.DeleteExistingTask(title);

            return true; // Task deleted successfully
        }

    }
}
