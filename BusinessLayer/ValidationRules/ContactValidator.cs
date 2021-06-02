using EntityLayer.Concrete;
using FluentValidation;

namespace BusinessLayer.ValidationRules
{
    public class ContactValidator : AbstractValidator<Contact>
    {
        public ContactValidator()
        {
            RuleFor(x => x.UserMail).NotEmpty().WithMessage("Mail adresini boş geçemezsiniz.");
            RuleFor(x => x.Subject).NotEmpty().WithMessage("Konu adını boş geçemezsiniz.");
            RuleFor(x => x.UserName).NotEmpty().MinimumLength(3).WithMessage("Kullanıcı adını boş geçemezsiniz ve minimum 3 karakter gerekmektedir.");
            RuleFor(x => x.Subject).MinimumLength(3).WithMessage("Minimum 3 karakter gerekmektedir.");
            RuleFor(x => x.Subject).MaximumLength(50).WithMessage("Maksimum 50 karakter olabilir.");
        }
    }
}