namespace TaskManager.DAL.Repository
{
    using System.Collections.Generic;
    using TaskManager.Common.DTO;

    public interface ITaskDal
    {
        TaskDto AddTask(TaskDto newTask);
        bool DeleteTask(int id);
        bool EditTask(TaskDto taskDto);
        IEnumerable<UserDto> GetUserTask(string Email);
    }
}