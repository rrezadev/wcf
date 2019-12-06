using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RR_WCF_NWUI_1107
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Thursday.NorthwindClient hello = new Thursday.NorthwindClient();
            var goodbye = hello.GetProduct(Convert.ToInt32(TextBox1.Text));
            Label1.Text = "Product Name" + " " + goodbye.ProductName;
        }
    }
}
