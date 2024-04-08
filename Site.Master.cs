using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebFormNovice1.Models;

namespace WebFormNovice1
{
    public partial class SiteMaster : MasterPage
    {
        public static User UserInfo { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (!Context.User.Identity.IsAuthenticated)
                {
                    Response.Redirect("login.aspx");
                }
                else
                {
                    GetUserInfoData();
                }
            }
        }

        protected void btnLogOut_Click(object sender, EventArgs e)
        {
            FormsAuthentication.SignOut();
            Response.Redirect("login.aspx");
        }

        private void GetUserInfoData()
        {
            FormsIdentity id = (FormsIdentity)Context.User.Identity;
            FormsAuthenticationTicket ticket = id.Ticket;
            if (!string.IsNullOrEmpty(ticket.UserData))
            {
                UserInfo = JsonConvert.DeserializeObject<User>(ticket.UserData);
            }
        }
    }
}