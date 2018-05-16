using CreditCardValidatorBusinessRule.Interfaces;
using CreditCardValidatorBusinessRule.Models;
using Helpers;

namespace CreditCardValidatorBusinessRule.RulesProcessors.JCB
{
    public class CreditCardJCB : ICreditCard
    {
        private bool _result;
        public CreditCardConstants.CardType GetCardType()
        {
            return CreditCardConstants.CardType.JCB; 
        }

        public bool Validate(CreditCardModel creditCardInfo)
        {
            _result = true;
            return _result;
        }
    }
}
