
namespace TmanagerFramework.ServiceInterface.Services
{
    using FluentValidation.Results;
    using ServiceStack.ServiceInterface;
    using TaskManager.BLL;
    using TaskManager.Common.DTO;
    using TaskManager.Common.Validations;
    using TaskManager.ServiceModel.DTO;

    public class EditTaskService : Service
    {
        private readonly ITaskBll _taskBll;
        private readonly IUserBll _userBll;
        public EditTaskService(ITaskBll taskBll, IUserBll userBll)
        {
            _taskBll = taskBll;
            _userBll = userBll;
        }

        public object POST(EditUserTask Request)
        {
            TaskDto task = Request.NewTaskData;
            var user = _userBll.GetUser(Request.NewTaskData.Email);
            task.UserId = user.UserId;
            TaskValidations obj = new TaskValidations();
            ValidationResult result = obj.Validate(task);
            if (result.IsValid)
            {
               
                return _taskBll.EditTask(Request.NewTaskData);
            }
            else
            {
                return "Error";
            }
        }
    }
}
