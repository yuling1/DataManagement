﻿using System.Web;
using System.Web.Mvc;

namespace BYS.SZ.Internal.portal
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
