﻿using System;
using System.Collections.Generic;

using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace cedocabar
{
    public partial class denegado : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Finalizar(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx");
        }
    }
}