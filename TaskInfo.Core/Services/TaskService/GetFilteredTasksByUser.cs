using TaskInfo.Core.Domain.Entities;
using TaskInfo.Core.Domain.RepositoryContracts;
using TaskInfo.Core.Enums;
using TaskInfo.Core.ServiceContracts.ITaskService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskInfo.Core.Services.TaskService
{
    public class GetFilteredTasksByUser : IGetFilteredTasksByUser
    {
        private readonly IGetByUserID _getByUserID;
        public GetFilteredTasksByUser(IGetByUserID getByUserID) {
            _getByUserID = getByUserID;
        }
        public async Task<List<MyTask>?> FilterTasksByAnUser(Guid userId, string? title, CustomTaskStatus? status, DateTime? dueDate)
        {
            List<MyTask>? tasks = await _getByUserID.GetTaskByUserID(userId);

            if (!string.IsNullOrEmpty(title))
            {
                tasks = tasks.Where(t => t.Title.Contains(title, StringComparison.OrdinalIgnoreCase)).ToList();
            }

            if (status.HasValue)
            {
                tasks = tasks.Where(t => t.Status == status).ToList();
            }

            if (dueDate.HasValue)
            {
                tasks = tasks.Where(t => t.DueDate.Date <= dueDate.Value.Date).ToList();
            }

            return tasks;


        }
    }
}
