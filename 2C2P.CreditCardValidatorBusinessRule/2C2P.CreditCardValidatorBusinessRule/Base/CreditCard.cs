
using CreditCardValidatorBusinessRule.Interfaces;
using CreditCardValidatorBusinessRule.Models;
using Helpers;

namespace CreditCardValidatorBusinessRule.Base
{
    public class CreditCard 
    {
        private long _creditCardNumber = 0;
        private string _expiryDate = string.Empty;
        private CreditCardModel _creditCardModel = new CreditCardModel();
        private ICreditCard _creditCard;

        public CreditCard(
            long CreditCardNumber,  
            string ExpiryDate)
        {
            _creditCardNumber = CreditCardNumber;
            _expiryDate = ExpiryDate;
        }

        public CreditCardModel CardModel
        {
            get { return _creditCardModel; } 
        }

        public void ProcessCreditCardValidation()
        {
            
            if(IsCardNumberHas16Digits())
            {

                _creditCardModel.CreditCardNumber = _creditCardNumber;
                _creditCardModel.ExpiryDate = _expiryDate;

                switch (GetFirstDigitCardNumber())
                {
                    case 3: _creditCard = new RulesProcessors.JCB.CreditCardJCB();

                        _creditCardModel.Result = _creditCard.Validate(CardModel);
                        _creditCardModel.CardType = _creditCard.GetCardType();
                        break;

                    case 4: _creditCard = new RulesProcessors.Visa.CreditCardVisa();

                        _creditCardModel.Result = _creditCard.Validate(CardModel);
                        _creditCardModel.CardType = _creditCard.GetCardType();
                        break;

                    case 5: _creditCard = new RulesProcessors.MasterCard.CreditCardMasterCard();

                        _creditCardModel.Result =  _creditCard.Validate(CardModel);
                        _creditCardModel.CardType = _creditCard.GetCardType();
                        break;

                    default:
                        _creditCardModel.CreditCardNumber = _creditCardNumber;
                        _creditCardModel.ExpiryDate = _expiryDate;
                        _creditCardModel.CardType = CreditCardConstants.CardType.UnKnown;
                        _creditCardModel.Result = false;
                        break;
                }

            }
            else
            {
                _creditCardModel.CreditCardNumber = _creditCardNumber;
                _creditCardModel.ExpiryDate = _expiryDate;
                _creditCardModel.CardType = CreditCardConstants.CardType.Invalid;
                _creditCardModel.Result = false;
            }


        }

        private bool IsCardNumberHas16Digits()
        {
            return _creditCardNumber.ToString().Length >= 16;
        }

        private bool IsCorrectExpiryDateFormat()
        {
            bool correctFormat = false;

            if(_expiryDate.Length > 0)
            {

                var month = _expiryDate.Substring(0, 2);
                var year = _expiryDate.Substring(2, 4);

                if ((int.Parse(month) <= 12) && ((int.Parse(year) >= 1000) && ((int.Parse(year) <= 9999))))
                {
                    correctFormat = true;
                }

            }

            return correctFormat;
        }

        private int GetFirstDigitCardNumber()
        {
            return int.Parse(_creditCardNumber.ToString().Substring(0, 1));

        } 
    }
}