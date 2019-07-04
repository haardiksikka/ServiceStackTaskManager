namespace TaskManager.DAL.Repository
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using TaskManager.Common.DTO;
    using TaskManager.DAL.Context;
    using TaskManager.DAL.Mapper;

    public class TaskDal : ITaskDal
    {
        private readonly TaskManagerContext _context;
        private readonly IDatabaseMapper _mapper;
        public TaskDal(IDatabaseMapper mapper)
        {
            _context = new TaskManagerContext();
            _mapper = mapper;
        }

        public TaskDto AddTask(TaskDto newTask)
        {
            var task = _mapper.TaskDtoToTask(newTask);
            _context.Tasks.Add(task);
            _context.SaveChanges();
            return newTask;
        }

        public IEnumerable<UserDto> GetUserTask(string Email)
        {
            try
            {
                var user = _context.Users.SingleOrDefault(x => x.Email.Equals(Email));
                // var task = _context.Tasks.Where(x => x.UserId == user.UserId);
                var task = _context.Users.Include(u => u.Tasks.Select(c => c.TaskCategory)).Where(uu => uu.UserId == user.UserId).ToList();
                // var task = _context.Tasks.Include(c => c.TaskCategory).Where(x => x.UserId == user.UserId);

                // return _mapper.TaskListToDto(task);
                return _mapper.UserListToDto(task);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool DeleteTask(int id)
        {
            try
            {
                var task = _context.Tasks.Find(id);
                if (task == null)
                {
                    return false;
                }
                else
                {
                    _context.Tasks.Remove(task);
                    _context.SaveChanges();
                    return true;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool EditTask(TaskDto taskDto)
        {

            var task = _mapper.TaskDtoToTask(taskDto);
            var oldtask = _context.Tasks.Find(task.TaskId);
            //_context.Tasks.Remove(oldtask);
            _context.Tasks.AddOrUpdate(task);
         //   _context.Tasks.Add(task);
         //   _context.Entry(task).State = EntityState.Detached;
          //  _context.Entry(oldtask).State = EntityState.Modified;           
            _context.SaveChanges();

            return true;
        }
    }

}

