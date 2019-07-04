namespace TaskManager.Common.Validations
{
    using FluentValidation;
    using TaskManager.Common.DTO;

    public class UserValidations : AbstractValidator<UserDto>
    {
        public UserValidations()
        {
            RuleFor(x => x.FirstName).NotEmpty().WithMessage("First Name is required");
            RuleFor(x => x.Email).NotEmpty().WithMessage("E-Mail_ID is required");
            RuleFor(x => x.Password).NotEmpty().WithMessage("Password is required");
            RuleFor(x => x.Email).EmailAddress().WithMessage("Email Address is not correct");
        }
    }
}
