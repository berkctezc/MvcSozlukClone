using EntityLayer.Concrete;
using FluentValidation;

namespace BusinessLayer.ValidationRules
{
    public class WriterValidator : AbstractValidator<Writer>
    {
        public WriterValidator()
        {
            RuleFor(w => w.WriterName).NotEmpty().WithMessage("Yazar adı boş olamaz");
            RuleFor(w => w.WriterName).MinimumLength(2).WithMessage("Yazar adı 2 karaktereden az olamaz");
            RuleFor(w => w.WriterSurname).NotEmpty().WithMessage("Yazar soyadı boş olamaz");
            RuleFor(w => w.WriterTitle).MinimumLength(2).WithMessage("Yazar Ünvanı 2 karaktereden az olamaz");
            RuleFor(w => w.WriterSurname).MinimumLength(2).WithMessage("Yazar soyadı 2 karaktereden az olamaz");

            RuleFor(w => w.WriterAbout).Must(ContainsLetterA).WithMessage("A harfi içermelidir");
        }

        private bool ContainsLetterA(string arg)
        {
            if (arg == null) arg = " ";

            arg = arg.ToLower();
            return arg.Contains("a");
        }
    }
}