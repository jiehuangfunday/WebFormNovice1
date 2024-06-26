﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebFormNovice1.Models;

namespace WebFormNovice1
{
    public partial class Contact : BasePage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSend_Click(object sender, EventArgs e)
        {
            if (Validation(out List<string> msg))
            {
                try
                {
                    using (var db = new DBModel())
                    {
                        db.Contacts.Add(new Models.Contact
                        {
                            UserName = HttpUtility.HtmlEncode(txtUserName.Text),
                            Email = HttpUtility.HtmlEncode(txtEmail.Text),
                            Message = HttpUtility.HtmlEncode(txtMsg.Text)
                        });
                        db.SaveChanges();
                    }
                }
                catch (Exception ex)
                {
                    Alert($"Save Contact Data Error：{ex.Message}");
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
            if (string.IsNullOrEmpty(txtMsg.Text))
            {
                msg.Add("Pleass Write User Name !!");
            }
            if (!msg.Any()) 
            { 
                result = true; 
            }
            return result;
        }
    }
}