using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Corp.Prod.BusinessLogic.Entities;
using Corp.Prod.BusinessLogic.Interfaces;
using Corp.Prod.BusinessLogic.Validation;
using FluentValidation.Results;

namespace Corp.Prod.BusinessLogic
{
    public class RecipientLogic : IRecipientLogic
    {

        Recipient recipient { get; set; }

        public RecipientLogic(Recipient recipient)
        {
            this.recipient = recipient;
            RecipientValidator validator = new();
            ValidationResult result = validator.Validate(recipient);
        }


        public bool IsInAustria()
        {
            if (this.recipient.Country == "Austria") return true;
            else return false;
        }
    }
}
