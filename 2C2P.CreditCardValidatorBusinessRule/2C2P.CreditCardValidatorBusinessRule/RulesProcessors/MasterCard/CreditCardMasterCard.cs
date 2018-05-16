
using CreditCardValidatorBusinessRule.Interfaces;
using CreditCardValidatorBusinessRule.Models;
using Helpers;

namespace CreditCardValidatorBusinessRule.RulesProcessors.MasterCard
{
    public class CreditCardMasterCard : ICreditCard
    {
        private bool _result;
        public CreditCardConstants.CardType GetCardType()
        {
            return _result ? CreditCardConstants.CardType.MasterCard : CreditCardConstants.CardType.UnKnown;
        }

        public bool Validate(CreditCardModel creditCardInfo)
        {
            _result = IsPrimeNumber(GetYear(creditCardInfo.ExpiryDate));
            return _result;
        }

        private int GetYear(string expiryDate)
        {
            return int.Parse(expiryDate.Substring(2, 4));
        }
        private bool IsPrimeNumber(int expiryYear)
        {
            bool isPrimeNumber = true;
            for(int iLoopYear = 1; iLoopYear <= expiryYear; iLoopYear++)
            {
                for(int iDivisor = 2; iDivisor <= iLoopYear; iDivisor ++)
                {
                    if(iLoopYear != iDivisor && iLoopYear % iDivisor == 0)
                    {
                        isPrimeNumber = false;
                        break;
                    }
                }
            }
            return isPrimeNumber;
        }
    }
}
