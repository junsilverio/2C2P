using CreditCardValidatorBusinessRule.Models;
using Helpers;

namespace CreditCardValidatorBusinessRule.Interfaces
{
    public interface ICreditCard
    {
        bool Validate(CreditCardModel creditCardInfo);
        CreditCardConstants.CardType GetCardType();

    }
}
