namespace TaskManager.BLL
{
    using System;
    using System.Collections.Generic;
    using TaskManager.Common.DTO;
    using TaskManager.DAL.Repository;

    public class TaskBll : ITaskBll
    {
        private readonly ITaskDal _taskDal;
        //private readonly IUserBll _userBll;
        public TaskBll(ITaskDal taskDal)
        {
            _taskDal = taskDal;
        }

        public TaskDto AddNewTask(TaskDto taskDto)
        {
            try
            {
                return _taskDal.AddTask(taskDto);
            }
            catch (Exception e)
            {
               // _logger.Error("Exception Thrown", e);
                throw;
            }
        }

        public bool DeleteTask(int id)
        {
            try
            {
                return _taskDal.DeleteTask(id);
            }
            catch (Exception e)
            {

               // _logger.Error("Exception Thrown", e);
                throw;
            }
        }



        public IEnumerable<UserDto> GetUserTask(string Email)
        {
            try
            {
                return _taskDal.GetUserTask(Email);
            }
            catch (Exception e)
            {

               // _logger.Error("Exception Thrown", e);
                throw;
            }
        }

        public bool EditTask(TaskDto taskDto)
        {
            
            return _taskDal.EditTask(taskDto);
        }

    }
}
