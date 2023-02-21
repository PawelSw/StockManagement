using FluentValidation;
using StockManagement.ApplicationServices.API.Domain.ItemCaseServices;


namespace StockManagement.ApplicationServices.API.Validators.ItemCaseValidator
{
    public class AddItemCaseRequestValidator : AbstractValidator<AddItemCaseRequest>
    {
        public AddItemCaseRequestValidator()
        {
            RuleFor(x => x.Number).InclusiveBetween(1, 100);

        }
    }
}
