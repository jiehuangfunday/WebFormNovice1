using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebFormNovice1.Models;

namespace WebFormNovice1
{
    public partial class Register : BasePage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            if (Validation(out List<string> msg))
            {
                try
                {
                    using (var db = new DBModel())
                    {
                        db.Users.Add(new User
                        {
                            UserName = HttpUtility.HtmlEncode(txtUserName.Text),
                            Email = HttpUtility.HtmlEncode(txtEmail.Text),
                            Password = HttpUtility.HtmlEncode(txtPassword.Text)
                        });
                        db.SaveChanges();
                    }
                }
                catch (Exception ex)
                {
                    Alert($"Save User Data Error：{ex.Message}");
                }
            }
            else
            {
                Alert(msg);
            }
        }

        private bool Validation(out List<string> msg)
        {
            var result = false;
            msg = new List<string>();
            if (string.IsNullOrEmpty(txtUserName.Text))
            {
                msg.Add("Pleass Write User Name!!");
            }
            if (string.IsNullOrEmpty(txtEmail.Text))
            {
                msg.Add("Pleass Write Email!!");
            }
            if (string.IsNullOrEmpty(txtPassword.Text))
            {
                msg.Add("Pleass Write Password !!");
            }
            if (!msg.Any())
            {
                result = true;
            }
            return result;
        }
    }
}