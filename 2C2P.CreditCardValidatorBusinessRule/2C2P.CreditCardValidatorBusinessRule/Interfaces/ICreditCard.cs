using CreditCardValidatorBusinessRule.Models;
using Helpers;

namespace CreditCardValidatorBusinessRule.Interfaces
{
    interface ICreditCard
    {
        bool Validate(CreditCardModel creditCardInfo);
        CreditCardConstants.CardType GetCardType();

    }
}
