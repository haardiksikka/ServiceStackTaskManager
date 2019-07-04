namespace TaskManager.ServiceModel.DTO
{
    using ServiceStack.ServiceHost;
    using TaskManager.Common.DTO;

    [Route("/authenticate", "POST")]
    public class AuthenticateUser : IReturn<AuthResponse>
    {
        public string Password { get; set; }
        public string Email { get; set; }
    }

    public class AuthResponse
    {
        public UserDto UserResponse { get; set; }
    }

}
