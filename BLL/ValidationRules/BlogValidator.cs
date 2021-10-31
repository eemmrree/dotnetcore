using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EL.Concrete;
using FluentValidation;

namespace BLL.ValidationRules
{
    public class BlogValidator:AbstractValidator<Blog>
    {
        public BlogValidator()
        {
            RuleFor(x => x.BlogTitle).NotEmpty().WithMessage("Blog başlığı boş geçilemez.");
            RuleFor(x => x.BlogTitle).MaximumLength(150).WithMessage("Blog başlığı  150 karakterden daha az veri girişi yapın.");
            RuleFor(x => x.BlogTitle).MinimumLength(5).WithMessage("Blog başlığı  4 karakterden daha fazla veri girişi yapın.");
            RuleFor(x => x.BlogContent).NotEmpty().WithMessage("Blog içeriğini boş geçilemez.");
            RuleFor(x => x.BlogContent).MaximumLength(1500).WithMessage("Blog içeriğini  1500 karakterden daha az veri girişi yapın.");
            RuleFor(x => x.BlogContent).MinimumLength(50).WithMessage("Blog içeriğini  1500 karakterden daha fazla veri girişi yapın.");
            RuleFor(x=>x.BlogImage).NotEmpty().WithMessage("Blog gorselini boş geçilemez.");
            RuleFor(x => x.CategoryID).NotEmpty().WithMessage("Lütfen Kategori Seçiniz");

        }
    }
}
