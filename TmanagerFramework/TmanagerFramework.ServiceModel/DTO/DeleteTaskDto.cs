namespace TaskManager.ServiceModel.DTO
{
    using ServiceStack.ServiceHost;

    [Route("/deletetask/{id}", "GET")]
    public class DeleteUserTask : IReturn<DeleteTaskResponse>
    {
        public int Id { get; set; }
    }

    public class DeleteTaskResponse
    {
        public bool deleteTask { get; set; }
    }
}
