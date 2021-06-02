using EntityLayer.Concrete;
using FluentValidation;

namespace BusinessLayer.ValidationRules
{
    public class CategoryValidator : AbstractValidator<Category>
    {
        public CategoryValidator()
        {
            RuleFor(c => c.CategoryName).NotEmpty().WithMessage("Kategori adı boş olamaz");
            RuleFor(c => c.CategoryDescription).NotNull().NotEmpty().WithMessage("Kategori açıklaması boş olamaz");
            RuleFor(c => c.CategoryName).MinimumLength(3).WithMessage("Kategori adı 3 karaktereden az olamaz");
            RuleFor(c => c.CategoryName).MaximumLength(20).WithMessage("Kategori adı 20 karaktereden fazla olamaz");
        }
    }
}