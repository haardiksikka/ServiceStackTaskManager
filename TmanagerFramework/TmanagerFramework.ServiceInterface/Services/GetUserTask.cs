namespace TaskManager.ServiceInterface.Services
{
    using ServiceStack.ServiceInterface;
    using TaskManager.BLL;
    using TaskManager.ServiceModel.DTO;

    public class GetUserTask : Service
    {
        private ITaskBll _taskBll;
        public GetUserTask(ITaskBll taskBll)
        {
            _taskBll = taskBll;
        }
        public object Get(UserTask Request)
        {
            if (!Request.Email.Equals("Undefined"))
            {
                return _taskBll.GetUserTask(Request.Email);
            }
            else
            {
                return "Error";
            }
        }
    }
}
