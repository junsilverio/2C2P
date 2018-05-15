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
            return _result ? CreditCardConstants.CardType.JCB : CreditCardConstants.CardType.UnKnown;
        }

        public bool Validate(CreditCardModel creditCardInfo)
        {
            _result = true;
            return _result;
        }
    }
}
