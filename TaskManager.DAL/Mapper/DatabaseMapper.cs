namespace TaskManager.DAL.Mapper
{
    using System.Collections.Generic;
    using AutoMapper;
    using TaskManager.Common.DTO;
    using TaskManager.DAL.Model;

    public class DatabaseMapper : IDatabaseMapper
    {
        readonly private IMapper mapper;
        public DatabaseMapper()
        {
            MapperConfiguration config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<User, UserDto>().ReverseMap();
                cfg.CreateMap<Task, TaskDto>().ReverseMap();

            });
            mapper = config.CreateMapper();
        }

        public UserDto UserToDto(User user)
        {
            return mapper.Map<UserDto>(user);
        }

        public User UserDtoToUser(UserDto userDto)
        {
            return mapper.Map<User>(userDto);
        }

        public TaskDto TaskToTaskDto(Task task)
        {
            return mapper.Map<TaskDto>(task);
        }

        public IEnumerable<TaskDto> TaskListToDto(IEnumerable<Task> task)
        {
            return mapper.Map<IEnumerable<TaskDto>>(task);
        }

        public Task TaskDtoToTask(TaskDto taskDto)
        {
            return mapper.Map<Task>(taskDto);
        }

        public Category CategoryDtoToCategory(CategoryDto categoryDto)
        {
            return mapper.Map<Category>(categoryDto);
        }

        public IEnumerable<CategoryDto> CategoryListToDto(IEnumerable<Category> category)
        {
            return mapper.Map<IEnumerable<CategoryDto>>(category);
        }

        public IEnumerable<UserDto> UserListToDto(IEnumerable<User> user)
        {
            return mapper.Map<IEnumerable<UserDto>>(user);
        }
    }
}
