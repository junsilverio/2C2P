﻿using System.Web;
using System.Web.Mvc;

namespace _2C2P.CreditCardValidator
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
