﻿using System;
using System.Web.UI;

namespace WebApplication2
{
    public partial class ManageEmployees : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Session["rpt"] = "TimeSheet";
        }
    }
}