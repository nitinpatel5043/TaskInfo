﻿using TaskInfo.Core.Domain.Entities;
using TaskInfo.Core.Enums;

namespace TaskInfo.Core.Domain.RepositoryContracts
{
    public interface ITaskRepository
    {

        Task<List<MyTask>> GetAllTasks();
        Task<MyTask> AddNewTask(MyTask myTask);
        Task<MyTask?> UpdateTaskStatus(string Title, CustomTaskStatus newStatus);
        Task<bool> DeleteExistingTask(string Title);
        Task<List<MyTask>?> GetAllTasksByStatus(CustomTaskStatus status);
        Task<List<MyTask>?> GetAllTasksByDueDate(DateTime dueDate);
        Task<MyTask?> GetTaskByTitle(string Title);
        Task<MyTask> EditATask(MyTask myTask);
        Task<List<MyTask>?> GetAllTasksByUserID(Guid userId);

    }
}