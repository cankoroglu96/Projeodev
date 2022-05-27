using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;

namespace Projeodev
{
    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {

        }

        protected void Session_Start(object sender, EventArgs e)
        {

        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }

        protected void Session_End(object sender, EventArgs e)
        {

        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
        void UrlKalip(RouteCollection routes)
        {
            routes.MapPageRoute("AdminKontrol", "AdminKontrol", "~/AdminKontrol.aspx");
            routes.MapPageRoute("Giris", "Giris", "~/Giris1.aspx");
            routes.MapPageRoute("Admin Giris", "Admin Giris", "~/Giris2.aspx");
            routes.MapPageRoute("Musteri Sayfasi", "Musteri Sayfasi", "~/Odeme.aspx");
            routes.MapPageRoute("Dogrulama", "Dogrulama", "~/Randomgiris.aspx");
            routes.MapPageRoute("Sanal Odeme", "Sanal Odeme", "~/SanalPos.aspx");


        }
    }
}