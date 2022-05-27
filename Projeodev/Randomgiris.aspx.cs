using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Projeodev
{
    public partial class Randomgiris : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }
        public static string CreateRandomPassword(int PasswordLength)
        {
            string _allowedChars = "0123456789abcdefghijkmnopqrstuvwxyzABCDEFGHJKLMNOPQRSTUVWXYZ";
            Random randNum = new Random();
            char[] chars = new char[PasswordLength];
            int allowedCharCount = _allowedChars.Length;
            for (int i = 0; i < PasswordLength; i++)
            {
                chars[i] = _allowedChars[(int)((_allowedChars.Length) * randNum.NextDouble())];
            }
            return new string(chars);
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            Label1.Text = CreateRandomPassword(8);
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text == Label1.Text) 
            { 
                Response.Redirect("/SanalPos.aspx"); 
            }

              
        }
    }   
}