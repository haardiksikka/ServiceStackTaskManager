namespace TmanagerFramework.ServiceInterface.Services
{
    using ServiceStack.ServiceInterface;
    using TaskManager.BLL;
    using TaskManager.ServiceModel.DTO;

    public class DeleteTaskService : Service
    {
        private readonly ITaskBll _taskBll;
        public DeleteTaskService(ITaskBll taskBll)
        {
            _taskBll = taskBll;
        }

        public object GET(DeleteUserTask Request)
        {
            try
            {
                return _taskBll.DeleteTask(Request.Id);
            }
            catch (Exception e)
            {

                return "Error";
            }
        }
    }
}
