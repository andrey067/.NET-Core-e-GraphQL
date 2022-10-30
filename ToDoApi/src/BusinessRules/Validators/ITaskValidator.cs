using FluentValidation;
using src.BusinessRules.Request;

namespace src.BusinessRules.Validators
{
    public interface ITaskValidator : IValidator<UpersetTaskRequest>
    {}
}
