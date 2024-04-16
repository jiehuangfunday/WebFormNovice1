using Microsoft.Ajax.Utilities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebFormNovice1.Models;

namespace WebFormNovice1
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLodin_Click(object sender, EventArgs e)
        {
            if (CheckData()) 
            {
                SetCookie();
                Response.Redirect("default.aspx");
            }
        }

        public bool CheckData()
        {
            var result = false;
            using (var db = new DBModel())
            {
                if (db.Users.Any(x => x.UserName == txtUserName.Text && x.Password == txtPassword.Text))
                {
                    result = true;
                }
            }

            return result;
        }

        private void SetCookie()
        {
            string userData = JsonConvert.SerializeObject(new { UserName = txtUserName.Text });

            FormsAuthenticationTicket ticket = new FormsAuthenticationTicket(1,
              txtUserName.Text,
              DateTime.Now,
              DateTime.Now.AddMinutes(30),
              true,
              userData,
              FormsAuthentication.FormsCookiePath);

            string encTicket = FormsAuthentication.Encrypt(ticket);
            Response.Cookies.Add(new HttpCookie(FormsAuthentication.FormsCookieName, encTicket));
        }
    }
}