using EntityLayer.Concrete;
using FluentValidation;

namespace BusinessLayer.ValidationRules
{
    public class MessageValidator:AbstractValidator<Message>
    {
        public MessageValidator()
        {
            RuleFor(x => x.ReceiverMail).NotEmpty().WithMessage("Alıcı boş olamaz");
            RuleFor(x => x.Subject).NotEmpty().WithMessage("Konu boş olamaz");
            RuleFor(x => x.MessageContent).NotEmpty().WithMessage("Mesaj boş olamaz");
            RuleFor(x => x.Subject).MinimumLength(3).MaximumLength(100).WithMessage("3 ila 100 karakter olmalı");
        }
        
    }
}