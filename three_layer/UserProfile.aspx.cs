using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
using System.Data.SqlClient;
using System.Data;

namespace three_layer
{
    public partial class UserProfile : System.Web.UI.Page
    {
        profilebllCls obj = new profilebllCls();
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Session["uid"]);
            SqlDataReader dr = obj.fun_GetData(id);
            while (dr.Read())
            {
                Label1.Text = dr["name"].ToString();
                Label2.Text = dr["age"].ToString();
                Label3.Text = dr["Address"].ToString();
                Image1.ImageUrl = dr["photo"].ToString();
            }
            DataSet ds = obj.fun_GetDataSet(Convert.ToInt32(Session["uid"]));
            GridView1.DataSource = ds;
            GridView1.DataBind();

            DataTable dt = obj.fun_GetDataTable(Convert.ToInt32(Session["uid"]));
            GridView2.DataSource = dt;
            GridView2.DataBind();
        }
    }
}