using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;

using System.Web.Http;
using CreditCardValidatorBusinessRule.Base;
using CreditCardValidatorBusinessRule.Models;
using Helpers;


namespace CreditCardServiceApi.Controllers
{
    public class CreditCardValidatorController : ApiController
    {
        public CreditCardModel Get(long CreditCardNumber, string ExpiryDate)
        {

            CreditCardModel creditCardModel = new CreditCardModel();
            CreditCard creditCard = new CreditCard(CreditCardNumber, ExpiryDate);
            creditCard.ProcessCreditCardValidation();
            creditCardModel = creditCard.CardModel; 
            return creditCardModel;
        }
    }
}
