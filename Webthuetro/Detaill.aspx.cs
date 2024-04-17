using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Webthuetro
{
    public partial class Detaill : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void a_click(object sender, EventArgs e)
        {
            //Response.Write("Button clicked!");

            ScriptManager.RegisterStartupScript(this, GetType(), "showalert", "alert('Xin chào từ C#!');", true);

        }
    }
}