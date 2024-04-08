using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebFormNovice1
{
    public class BasePage : System.Web.UI.Page
    {
        public void Alert(string message)
        {
            ClientScript.RegisterStartupScript(this.GetType(), Guid.NewGuid().ToString(),
                  string.Format("alert('{0}');",
                    message.Replace("'", @"\'").Replace("\n", "\\n").Replace("\r", "\\r")), true);
        }
        public void Alert(List<string> messages)
        {
            ClientScript.RegisterStartupScript(this.GetType(), Guid.NewGuid().ToString(),
                  string.Format("alert('{0}');",
                    string.Join("\n\r",messages).Replace("'", @"\'").Replace("\n", "\\n").Replace("\r", "\\r")), true);
        }
        public void RedirectAlert(string message, string url)
        {
            ClientScript.RegisterStartupScript(this.GetType(), Guid.NewGuid().ToString(),
                  string.Format("alert('{0}');window.location.href = '{1}'",
                    message.Replace("'", @"\'").Replace("\n", "\\n").Replace("\r", "\\r"), url),
                  true);
            
        }
        public void RedirectAlert(List<string> messages, string url)
        {
            ClientScript.RegisterStartupScript(this.GetType(), Guid.NewGuid().ToString(),
                  string.Format("alert('{0}');window.location.href = '{1}'",
                    string.Join("\n\r", messages).Replace("'", @"\'").Replace("\n", "\\n").Replace("\r", "\\r"), url),
                  true);
        }
    }
}