using Helpers;

namespace CreditCardValidatorBusinessRule.Models
{
    public class CreditCardModel
    {
        public int CreditCardNumber { get; set; }
        public string ExpiryDate { get; set; }
        public bool Result { get; set; }
        public CreditCardConstants.CardType CardType { get; set; }

    }
    
}
