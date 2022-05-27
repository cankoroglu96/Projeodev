using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace Projeodev
{
    public partial class Odeme : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DropDownList2.DataSource = new Siniflarim.Cesit().Ces(DropDownList1.SelectedIndex);
            DropDownList2.DataValueField = "cesit_id";
            DropDownList2.DataTextField = "cesit_ad";
            DropDownList2.DataBind();

        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            
          

           
        }
    }
}