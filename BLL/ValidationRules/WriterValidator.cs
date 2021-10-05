using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using EL.Concrete;
using FluentValidation;

namespace BLL.ValidationRules
{
    public class WriterValidator : AbstractValidator<Writer>
    {
        public WriterValidator()
        {
            RuleFor(x => x.WriterName).NotEmpty().WithMessage("Yazar Adı Soyadı kısmı boş geçilemez.");
            RuleFor(x => x.WriterMail).NotEmpty().WithMessage("Mail adresi boş geçilemez.");
            RuleFor(x => x.WriterPassword).NotEmpty().WithMessage("Şifre boş geçilemez.");
            RuleFor(x => x.WriterName).MinimumLength(2).WithMessage("Lütfen en az 2 karakter girişi yapınız.");
            RuleFor(x => x.WriterName).MaximumLength(50).WithMessage("Lütfen en fazla 50 karakter girişi yapınız.");
            RuleFor(x => x.WriterMail).EmailAddress().WithMessage("Lütfen geçerli bir e-mail giriniz.");
            RuleFor(x => x.WriterPassword).MinimumLength(6).WithMessage("Parolanız en az 6 karakter içermelir.");
            RuleFor(x => x.WriterPassword).Must(IsPasswordValid).WithMessage("Parolanızda en az bir küçük harf bir büyük harf ve rakam olmalıdır.");

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
