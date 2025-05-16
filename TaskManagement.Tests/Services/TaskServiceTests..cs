using Moq;
using TaskInfo.Core.Domain.Entities;
using TaskInfo.Core.Domain.RepositoryContracts;
using TaskInfo.Core.Services.TaskService;
using Xunit;
using System.Threading.Tasks;

namespace TaskInfo.Tests
{
    public class CreateTaskTests
    {
        private readonly Mock<ITaskRepository> _taskRepositoryMock;
        private readonly CreateTask _createTaskService;

        public CreateTaskTests()
        {
            _taskRepositoryMock = new Mock<ITaskRepository>();
            _createTaskService = new CreateTask(_taskRepositoryMock.Object);
        }

        [Fact]
        public async Task CreateNewTask_ValidInput_ReturnsCreatedTask()
        {
            // Arrange
            var newTask = new MyTask
            {
                Title = "Test Task",
                Description = "Test description",
                DueDate = DateTime.UtcNow.AddDays(1),
                UserId = Guid.NewGuid()
            };

            //_taskRepositoryMock
            //    .Setup(repo => repo.AddNewTask(newTask))
            //    .Returns(Task.CompletedTask);

            // Act
            var result = await _createTaskService.CreateNewTask(newTask);

            // Assert
            Assert.NotNull(result);
            Assert.Equal("Test Task", result.Title);
            _taskRepositoryMock.Verify(repo => repo.AddNewTask(newTask), Times.Once);
        }

        [Fact]
        public async Task CreateNewTask_NullTask_ThrowsArgumentNullException()
        {
            // Act & Assert
            await Assert.ThrowsAsync<ArgumentNullException>(() => _createTaskService.CreateNewTask(null));
        }
    }
}
