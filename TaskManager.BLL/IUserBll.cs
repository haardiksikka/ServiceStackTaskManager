namespace TaskManager.BLL
{
    using TaskManager.Common.DTO;

    public interface IUserBll
    {
        UserDto GetUser(string email);
        UserDto GetUserByEmail(string email, string password);
        UserDto RegisterUser(UserDto userDto);
    }
}