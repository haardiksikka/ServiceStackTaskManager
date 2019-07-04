namespace TaskManager.DAL.Repository
{
    using TaskManager.Common.DTO;

    public interface IUserRepo
    {
        UserDto GetUserByEmail(string Email);
        UserDto RegisterUser(UserDto userDto);
    }
}