using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Projeodev
{
    public partial class Odevproje : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_giris_Click(object sender, EventArgs e)
        {

            Response.Redirect("/Odeme.aspx");

        }

        protected void btn_giris_Click1(object sender, EventArgs e)
        {
            Response.Redirect("/AdminKontrol.aspx");
        }
    }
}