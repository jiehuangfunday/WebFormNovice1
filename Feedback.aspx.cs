using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Web;
using System.Web.Services.Description;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;
using System.Xml.Linq;
using WebFormNovice1.Models;

namespace WebFormNovice1
{
    public partial class Feedback : BasePage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSend_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtMsg.Text))
            {
                SendMail();
                RedirectAlert("Send Mail Success", "default.aspx");
            }
            else
            {
                Alert("Pleass Write Message!!");
            }
        }

        private void SendMail()
        {
            string mailUserName = "system@funyday.com";
            string mailPassword = "***";
            string adminEmail = "admin@funyday.com";
            using (MailMessage msg = new MailMessage(mailUserName, adminEmail))
            using (var smtpClient = new SmtpClient())
            {
                msg.Subject = "Feedback Message";
                StringBuilder sb = new StringBuilder();
                sb.AppendLine("Date Time: " + DateTime.Now.ToString("yyyy-MM-dd"));
                sb.AppendLine("Feedback Message: " + txtMsg.Text);
                msg.Body = sb.ToString();

                smtpClient.Credentials = new System.Net.NetworkCredential(mailUserName, mailPassword);
                smtpClient.Port = 999;
                smtpClient.Host = "funday.smtp.com";
                smtpClient.EnableSsl = true;
                //不實際寄出
                //smtpClient.Send(msg);
            }
        }
    }
}