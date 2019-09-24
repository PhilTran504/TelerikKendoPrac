﻿using System;
using System.Web.Mvc;
using Kendo.Mvc.UI;

namespace KendoQsBoilerplate
{

    public class Employee
    {

        public int EmployeeId { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Title { get; set; }
        public string HomePhone { get; set; }
        public string Notes { get; set; }

        public string FullName
        {
            get
            {
                return string.Format("{0} {1}", FirstName, LastName);
            }
        }

        internal static object ToDataSourceResult(DataSourceRequest request, ModelStateDictionary modelState)
        {
            throw new NotImplementedException();
        }
    }
}