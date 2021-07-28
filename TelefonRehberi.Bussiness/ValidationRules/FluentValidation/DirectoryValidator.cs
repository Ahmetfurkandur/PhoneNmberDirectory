using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelefonRehberi.Entities.Concrete;

namespace TelefonRehberi.Bussiness.ValidationRules.FluentValidation
{
    public class DirectoryValidator:AbstractValidator<Directory>
    {
        public DirectoryValidator()
        {
            RuleFor(d => d.NameAndSurname).NotEmpty().WithMessage("Ad ve Soyad bölümü boş bırakılamaz");
            RuleFor(d => d.EmailAdress).NotEmpty().WithMessage("Email adresi boş bırakılamaz").EmailAddress().WithMessage("Lütfen kullanılan bir email adresi giriniz.");
            RuleFor(d => d.PhoneNumber).NotEmpty().WithMessage("Telefon numarası boş olamaz");
        }
    }
}
