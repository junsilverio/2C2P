
using System;
using CreditCardValidatorBusinessRule.Interfaces;
using CreditCardValidatorBusinessRule.Models;
using Helpers;

namespace CreditCardValidatorBusinessRule.RulesProcessors.Visa
{
    public class CreditCardVisa : ICreditCard
    {
        private bool _result;
        public CreditCardConstants.CardType GetCardType()
        {
           return _result ? CreditCardConstants.CardType.Visa : CreditCardConstants.CardType.UnKnown;
        }

        private int GetYear(string expiryDate)
        {
            return int.Parse(expiryDate.Substring(2, 4));
        }
        private bool IsLeapYear(string expiryYear)
        {
            return DateTime.IsLeapYear(GetYear(expiryYear));
        }
        public bool Validate(CreditCardModel creditCardInfo)
        {
            _result =  IsLeapYear(creditCardInfo.ExpiryDate);
            return _result;
        }

    }
}
