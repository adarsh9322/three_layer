using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;

namespace three_layer
{
    
    public partial class InsertDB : System.Web.UI.Page
    {
        InseertbllCls objbll = new InseertbllCls();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string s = "~/photos/" + FileUpload1.FileName;
            FileUpload1.SaveAs(MapPath(s));

            int i = objbll.DBInsert(TextBox1.Text, Convert.ToInt32(TextBox2.Text), TextBox3.Text, s, TextBox4.Text, TextBox5.Text);
            if (i == 1)
            {
                Label1.Text = "inserted";

            }

        }
    }
}