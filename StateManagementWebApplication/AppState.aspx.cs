﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StateManagementWebApplication
{
    public partial class AppState : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            label.Text = String.Format("Server was runnig {0}.", Application["date"].ToString());
        }
    }
}