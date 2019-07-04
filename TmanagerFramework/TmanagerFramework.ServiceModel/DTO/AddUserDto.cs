namespace TaskManager.ServiceModel.DTO
{
    using ServiceStack.ServiceHost;
    using TaskManager.Common.DTO;

    [Route("/register", "POST")]
    public class AddUser : IReturn<AddUserResponse>
    {
        public UserDto NewUser { get; set; }
    }

    public class AddUserResponse
    {
        public UserDto AddedUser { get; set; }
    }
}
