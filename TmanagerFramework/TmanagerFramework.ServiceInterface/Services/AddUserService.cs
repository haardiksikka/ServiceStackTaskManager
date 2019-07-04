namespace TmanagerFramework.ServiceInterface.Services
{
    using System;
    using FluentValidation.Results;
    using ServiceStack.ServiceInterface;
    using TaskManager.BLL;
    using TaskManager.Common.Validations;
    using TaskManager.ServiceModel.DTO;

    public class AddUserService : Service
    {
        private readonly IUserBll _userBll;
        public AddUserService(IUserBll userBll)
        {
            _userBll = userBll;
        }    
        public object POST(AddUser Request)
        {
           
            var user = Request.NewUser;
            UserValidations obj = new UserValidations();
             ValidationResult result = obj.Validate(user);
            if (result.IsValid)
            {

                try
                {
                    var newUser = _userBll.RegisterUser(user);
                    if (newUser == null)
                    {
                        return null;
                    }
                    else
                    {
                        return newUser;
                    }
                }
                catch (Exception e)
                {

                    // _logger.Error("Exception Thrown", e);
                    throw e;
                }
            }
            else
            {
                return "Error";
            }
        }
    }
}
