﻿using System.Web;
using System.Web.Mvc;

namespace CompanyManagementSystem_employee
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
