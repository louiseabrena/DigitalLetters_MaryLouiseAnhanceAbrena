﻿using System.Web;
using System.Web.Mvc;

namespace DigitalLetters_MaryLouiseAnhanceAbrena
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
