namespace TmanagerFramework.ServiceInterface.Services
{
    using System;
    using FluentValidation.Results;
    using ServiceStack.ServiceInterface;
    using TaskManager.BLL;
    using TaskManager.Common.DTO;
    using TaskManager.Common.Validations;
    using TaskManager.ServiceModel.DTO;
    public class AddTaskService : Service
    {
        private readonly ITaskBll _taskBll;
        private readonly IUserBll _userBll;
        public AddTaskService(ITaskBll taskBll, IUserBll userBll)
        {
            _taskBll = taskBll;
            _userBll = userBll;
        }

        public object POST(AddUserTask Request)
        {
           
            TaskDto task = Request.NewTask;
            var user = _userBll.GetUser(Request.NewTask.Email);
            task.UserId = user.UserId;
            TaskValidations obj = new TaskValidations();
            ValidationResult result = obj.Validate(task);
            if (result.IsValid)
            {
                try
                {
                   
                    var newTask = _taskBll.AddNewTask(task);
                    // var result = _mapper.TaskDtoToTask(newTask);
                    //   return CreatedAtAction(nameof(AddNewTask), new { email = user.Email }, result);
                    return newTask;
                }
                catch (Exception e)
                {

                    // _logger.Error("Exception Thrown", e);
                    throw e;
                }
            }
            else
            {
                return "Error";
            }
        }
    }
}
