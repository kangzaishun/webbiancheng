using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace li3_3
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Button1_Click(object sender, EventArgs e)
        {
            if (DropDownList1.SelectedIndex == 0)
                Response.Redirect("http://www.google.com");

            if (DropDownList1.SelectedIndex == 0)
                Response.Redirect("http://www.baidu.com");

            if (DropDownList1.SelectedIndex == 0)
                Response.Redirect("http://www.sougou.com");
           
        }
    }
}