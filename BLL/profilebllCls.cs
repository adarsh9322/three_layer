using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DAL;

namespace BLL
{
    public class profilebllCls
    {
        ConCls objdal = new ConCls();
        public SqlDataReader fun_GetData(int id)
        {
            string strsel = "select name,age,address,photo from tab where Id=" + id + "";
            SqlDataReader dr = objdal.Fn_Reader(strsel);
            return dr;
        }
        public DataSet fun_GetDataSet(int id)
        {
            string strsel = "select name,age,address,photo from tab where Id=" + id + "";
            DataSet dr = objdal.Fn_Dataset(strsel);
            return dr;
        }
        public DataTable fun_GetDataTable(int id)
        {
            string strsel = "select name,age,address,photo from tab where Id=" + id + "";
            DataTable dr = objdal.Fn_Datatable(strsel);
            return dr;
        }

    }
}
