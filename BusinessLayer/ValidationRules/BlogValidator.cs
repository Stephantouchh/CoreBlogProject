using EntityLayer.Concrete;
using FluentValidation;

namespace BusinessLayer.ValidationRules
{
    public class BlogValidator : AbstractValidator<Blog>
    {
        public BlogValidator()
        {
            RuleFor(x => x.BlogTitle).NotEmpty().WithMessage("Lütfen Blog Başlığını Boş Bırakmayınız!");
            RuleFor(x => x.BlogContent).NotEmpty().WithMessage("Lütfen Blog İçeriğini Boş Bırakmayınız!");
            RuleFor(x => x.BlogImage).NotEmpty().WithMessage("Lütfen Blog Dosya Yolunu Boş Bırakmayınız!");
            RuleFor(x => x.BlogThumbnailImage).NotEmpty().WithMessage("Lütfen Blog Küçük Resmini Boş Bırakmayınız!");
            RuleFor(x => x.BlogTitle).MaximumLength(150).WithMessage("Lütfen 150 Karakter'den daha az Veri Girişi Yapınız!");
            RuleFor(x => x.BlogTitle).MinimumLength(5).WithMessage("Lütfen 4 Karakter'den daha fazla Veri Girişi Yapınız!");
            RuleFor(x => x.BlogContent).MinimumLength(5).WithMessage("Lütfen 4 Karakter'den daha fazla Veri Girişi Yapınız!");
            RuleFor(x => x.CategoryID).NotEmpty().WithMessage("Kategori Boş Geçilemez!");
        }
    }
}
