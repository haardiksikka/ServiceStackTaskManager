namespace TaskManager.Common.Validations
{
    using FluentValidation;
    using TaskManager.Common.DTO;

    public class TaskValidations : AbstractValidator<TaskDto>
    {
        public TaskValidations()
        {
            RuleFor(x => x.UserStory).NotEmpty().WithMessage("UserStory is required");
            RuleFor(x => x.AllocatedTime).NotEmpty().WithMessage("Allocated Time is required");
            RuleFor(x => x.TimeLogged).NotEmpty().WithMessage("TimeLogged is required");
            RuleFor(x => x.CategoryId).NotEmpty().WithMessage("Category Id is required");
            RuleFor(x => x.UserId).NotEmpty().WithMessage("User Id is required");
            RuleFor(x => x.Email).NotEmpty().WithMessage("E-Mail_ID is required");
            RuleFor(x => x.Email).EmailAddress().WithMessage("Email Address is not correct");
        }
    }
}

