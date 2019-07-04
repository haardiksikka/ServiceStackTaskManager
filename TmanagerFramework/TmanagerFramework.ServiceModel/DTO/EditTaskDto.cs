namespace TaskManager.ServiceModel.DTO
{
    using ServiceStack.ServiceHost;
    using TaskManager.Common.DTO;

    [Route("/edittask", "POST")]
    public class EditUserTask : IReturn<EditResponse>
    {
        public TaskDto NewTaskData { get; set; }
    }

    public class EditResponse
    {
        public bool Response { get; set; }
    }
}
