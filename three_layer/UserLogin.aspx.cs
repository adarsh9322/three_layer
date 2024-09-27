using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;

namespace three_layer
{
    public partial class UserLogin : System.Web.UI.Page
    {
        loginbllCls lcls = new loginbllCls();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string cid = lcls.GetCountId(TextBox1.Text, TextBox2.Text);
            if (cid == "1")
            {
                string id = lcls.GetId(TextBox1.Text, TextBox2.Text);
                Session["uid"] = id;
                Response.Redirect("Userprofile.aspx");
            }
            else
            {
                Label1.Text = "invalid username and password";
            }

        }
    }
}