using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class WriterValidator : AbstractValidator<Writer>
    {
        public WriterValidator()
        {
            RuleFor(x => x.WriterName).NotEmpty().WithMessage("Lütfen Yazar Adı Soyadı kısmını boş geçmeyiniz!");
            RuleFor(x => x.WriterMail).NotEmpty().WithMessage("Lütfen Mail Adresi kısmını boş geçmeyiniz!");
            RuleFor(x => x.WriterPassword).NotEmpty().WithMessage("Şifre boş geçilemez!");
            RuleFor(x => x.WriterName).MinimumLength(2).WithMessage("Lütfen en az 2 karakterlik veri girişi yapınız!");
            RuleFor(x => x.WriterName).MaximumLength(50).WithMessage("Lütfen en fazla 50 karakterlik veri girişi yapınız!");
        }
    }
}
