namespace TaskManager.ServiceModel.DTO
{
    using ServiceStack.ServiceHost;
    using TaskManager.Common.DTO;

    [Route("/newtask", "POST")]
    public class AddUserTask : IReturn<Response>
    {
        public TaskDto NewTask { get; set; }
    }

    public class Response
    {
        public TaskDto NewTask { get; set; }
    }
}
