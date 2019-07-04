namespace TaskManager.BLL
{
    using System;
    using TaskManager.Common.DTO;
    using TaskManager.DAL.Repository;

    public class UserBll : IUserBll
    {
        private readonly IUserRepo _userDal;
        public UserBll(IUserRepo userDal)
        {
            _userDal = userDal;
        }
        public UserDto RegisterUser(UserDto userDto)
        {
            try
            {
                if (_userDal.GetUserByEmail(userDto.Email) == null)
                {

                    return _userDal.RegisterUser(userDto);
                }
                else
                {

                    return null;
                }
            }
            catch (Exception e)
            {
              //  _iLogger.Error("Exception Thrown", e);
                throw;
            }
        }


        public UserDto GetUserByEmail(string email, string password)
        {
            try
            {
                var user = _userDal.GetUserByEmail(email);
                if (user != null)
                {
                 
                    if (!password.Equals(user.Password))
                    {
                        user = null;
                    }
                }
                return user;
            }
            catch (Exception ex)
            {
                //  _iLogger.Error("Exception Thrown", ex);
                throw;
            }
        }

        public UserDto GetUser(string email)
        {

            try
            {
                return _userDal.GetUserByEmail(email);
            }
            catch (Exception e)
            {

              //  _iLogger.Error("Exception Thrown", e);
                throw;
            }
        }

    }
}
