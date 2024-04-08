using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;

namespace WebFormNovice1
{
    public class Global : HttpApplication
    {
        private static int totalNumberOfUsers = 0;
        void Application_Start(object sender, EventArgs e)
        {
            // 應用程式啟動時執行的程式碼
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }

        protected void Session_Start(Object sender, EventArgs e)
        {
            totalNumberOfUsers += 1;
        }
        public static int TotalNumberOfUsers
        {
            get
            {
                return totalNumberOfUsers;
            }
        }
    }
}