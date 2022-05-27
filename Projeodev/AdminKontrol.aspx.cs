using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Projeodev
{
    public partial class AdminKontrol : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            var yemek = new Veritabanı.Cesitler();
            yemek.cesit_ad = TextBox1.Text;
            yemek.cesit_fiyat = TextBox2.Text;

            if (DropDownList1.SelectedValue == "Çorbalar")
                yemek.yemek_fk_id = 1;
            else if (DropDownList1.SelectedValue == "Tostlar")
                yemek.yemek_fk_id = 2;
            else if (DropDownList1.SelectedValue == "Yumurtalar")
                yemek.yemek_fk_id = 3;

            var fonk = new Siniflarim.Admin().yemekekle(yemek);
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            var yemek1 = new Veritabanı.Cesitler();
            yemek1.cesit_ad = TextBox1.Text;
            yemek1.cesit_fiyat = TextBox2.Text;
            var fonk = new Siniflarim.Admin().yemekcikar(yemek1);

        }
    }
}