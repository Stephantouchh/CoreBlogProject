using EntityLayer.Concrete;
using FluentValidation;
using System.Text.RegularExpressions;

namespace BusinessLayer.ValidationRules
{
    public class UserValidator : AbstractValidator<AppUser>
    {
        public UserValidator()
        {
            RuleFor(x => x.NameSurname).NotEmpty().WithMessage("Lütfen Yazar Adı Soyadı kısmını boş geçmeyiniz!");
            RuleFor(x => x.Email).NotEmpty().WithMessage("Lütfen Mail Adresi kısmını boş geçmeyiniz!");
            //RuleFor(x => x.PasswordHash).NotEmpty().WithMessage("Şifre boş geçilemez!");
            RuleFor(x => x.NameSurname).MinimumLength(2).WithMessage("Lütfen en az 2 karakterlik veri girişi yapınız!");
            RuleFor(x => x.NameSurname).MaximumLength(50).WithMessage("Lütfen en fazla 50 karakterlik veri girişi yapınız!");
        }
        private bool IsPasswordValid(string arg)
        {
            try
            {
                Regex regex = new Regex(@"^(?=.*[A-Z])(?=.*[a-z])(?=.*\d)(?=.*[0-9])[A-Za-z\d]");
                return regex.IsMatch(arg);
            }
            catch
            {
                return false;
            }
        }
    }
}
