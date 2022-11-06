using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using Corp.Prod.BusinessLogic.Entities;

namespace Corp.Prod.BusinessLogic.Validation
{
    public class RecipientValidator : AbstractValidator<Recipient>
    {
        public RecipientValidator()
        {
            When(recipient => recipient.Country.Equals("Austria") || recipient.Country.Equals("Österreich"), () =>
            {
                RuleFor(recipient => recipient.Street).Matches(@"[\wß]{1,}\s[0-9/a-z]+");
                RuleFor(recipient => recipient.City).Matches(@"[A-Z]{1,1}[\w- ]+");
                RuleFor(recipient => recipient.PostalCode).Matches(@"^A-\d{1,4}$");
                RuleFor(recipient => recipient.Name).Matches(@"[A-Z]{1,1}[\w- ]+");
            });
        }
    }
}
