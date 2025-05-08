using TaskInfo.Core.Domain.Entities;
using TaskInfo.Core.Domain.RepositoryContracts;
using TaskInfo.Core.ServiceContracts.ITaskService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskInfo.Core.Services.TaskService
{
    public class GetTaskByTitle : IGetTaskByTitle
    {
        private readonly ITaskRepository _taskRepository;

        public GetTaskByTitle(ITaskRepository taskRepository)
        {
            _taskRepository = taskRepository;
        }
        public async Task<MyTask> GetMyTaskByATitle(string Title)
        {
            MyTask myTask = await _taskRepository.GetTaskByTitle(Title);

            return myTask;
        }
    }
}
