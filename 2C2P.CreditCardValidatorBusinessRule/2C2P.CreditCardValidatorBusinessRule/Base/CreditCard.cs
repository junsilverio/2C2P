using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CreditCardValidatorBusinessRule.Interfaces;
using CreditCardValidatorBusinessRule.Models;
using CreditCardValidatorBusinessRule.RulesProcessors;

namespace CreditCardValidatorBusinessRule.Base
{
    public class CreditCard 
    {
        private int _creditCardNumber = 0;
        private string _expiryDate = string.Empty;
        public CreditCard()
        {}

        public CreditCard(
            int CreditCardNumber,  
            string ExpiryDate)
        {

            _creditCardNumber = CreditCardNumber;
            _expiryDate = ExpiryDate;
        }

        public void ProcessCreditCardValidation()
        {

        }


    }
}
