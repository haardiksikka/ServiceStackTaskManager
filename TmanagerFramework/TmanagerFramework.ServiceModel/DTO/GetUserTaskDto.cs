namespace TaskManager.ServiceModel.DTO
{
    using System.Collections.Generic;
    using ServiceStack.ServiceHost;
    using TaskManager.Common.DTO;

    [Route("/usertask/{email}", "GET")]
    public class UserTask : IReturn<TaskResponse>
    {
        public string Email { get; set; }
    }

    public class TaskResponse
    {
        public IEnumerable<UserDto> AllUserTask { get; set; }
    }
}
