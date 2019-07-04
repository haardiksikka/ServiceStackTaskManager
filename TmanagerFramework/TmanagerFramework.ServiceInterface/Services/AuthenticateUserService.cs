namespace TmanagerFramework.ServiceInterface.Services
{
    using System;
    using ServiceStack.ServiceInterface;
    using TaskManager.BLL;
    using TaskManager.ServiceModel.DTO;

    public class AuthenticateUserService : Service
    {
        readonly private IUserBll _userBll;
       // readonly private ILogger _logger;
        public AuthenticateUserService(IUserBll userBll)
        {
            _userBll = userBll;
        }
        public object POST(AuthenticateUser Request)
        {
            string email = Request.Email;
            string password = Request.Password;
            try
            {
                var userData = _userBll.GetUserByEmail(email, password);
                if (userData == null)
                {
                    return null;
                }
                else
                {
                    return userData;
                }
            }
            catch (Exception e)
            {
                //  _logger.Error("Exception Thrown", e);
                return "Error";
            }
        }
    }
}
