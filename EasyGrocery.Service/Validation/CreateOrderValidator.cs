using ESasyGrocery.Service.Dto;
using FluentValidation;

namespace ESasyGrocery.Service.Validation
{
    public class CreateOrderCommandValidator : AbstractValidator<ESasyGrocery.Service.Dto.Order>
    {
        public CreateOrderCommandValidator()
        {
            RuleFor(order => order.CustomerId)
                .NotEmpty().WithMessage("Customer Id is required.")
                .GreaterThan(0).WithMessage("Customer Id must be greater than 0");

        }
    }
}
