﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebFormNovice1
{
    public partial class CurrentDatetime : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            txtDateTime.Text = DateTime.Now.ToString("yyyy-MM-dd hh:mm:dd");
        }
    }
}