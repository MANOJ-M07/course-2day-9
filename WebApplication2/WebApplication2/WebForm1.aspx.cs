using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnRegister_Click(object sender, EventArgs e)
        {
            LblMsg.Text = "Welcome to ASP.NET";
            LblMsg.Text += "<br>User Name:" + txtname.Text;
            LblMsg.Text += "<br>User Password:" + txtpwd.Text;
            LblMsg.Text += "<br>About:" + txtabout.Text;

        }
    }
}