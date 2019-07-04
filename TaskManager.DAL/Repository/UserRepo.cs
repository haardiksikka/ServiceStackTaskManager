namespace TaskManager.DAL.Repository
{
    using System;
    using System.Linq;
    using TaskManager.Common.DTO;
    using TaskManager.DAL.Context;
    using TaskManager.DAL.Mapper;

    public class UserRepo : IUserRepo
    {
        private readonly TaskManagerContext _context;
        private readonly IDatabaseMapper _mapper;

        public UserRepo(IDatabaseMapper mapper)
        {
            _context = new TaskManagerContext();
            _mapper = mapper;
        }

        public UserDto RegisterUser(UserDto userDto)
        {
            var user = _mapper.UserDtoToUser(userDto);
            try
            {
                _context.Users.Add(user);

                _context.SaveChanges();
                return userDto;
            }
            catch (Exception)
            {
                throw;
            }


        }

        public UserDto GetUserByEmail(string Email)
        {
            try
            {
                var user = _context.Users.SingleOrDefault(x => x.Email.Equals(Email));
                if (user == null)
                {
                    return null;
                }
                else
                {
                     return _mapper.UserToDto(user);
                   
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
