﻿using System.Web;
using System.Web.Mvc;

namespace _1911062442_LeTanHuy_BigSchool
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
