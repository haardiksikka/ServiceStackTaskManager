namespace TaskManager.BLL
{
    using System.Collections.Generic;
    using TaskManager.Common.DTO;

    public interface ITaskBll
    {
        TaskDto AddNewTask(TaskDto taskDto);
        bool DeleteTask(int id);
        bool EditTask(TaskDto taskDto);
        IEnumerable<UserDto> GetUserTask(string Email);
    }
}