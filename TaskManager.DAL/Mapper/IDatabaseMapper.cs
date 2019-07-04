namespace TaskManager.DAL.Mapper
{
    using System.Collections.Generic;
    using TaskManager.Common.DTO;
    using TaskManager.DAL.Model;

    public interface IDatabaseMapper
    {
        Task TaskDtoToTask(TaskDto taskDto);
        IEnumerable<TaskDto> TaskListToDto(IEnumerable<Task> task);
        TaskDto TaskToTaskDto(Task task);
        User UserDtoToUser(UserDto userDto);
        UserDto UserToDto(User user);
        Category CategoryDtoToCategory(CategoryDto categoryDto);
        IEnumerable<CategoryDto> CategoryListToDto(IEnumerable<Category> category);
        IEnumerable<UserDto> UserListToDto(IEnumerable<User> user);
    }
}