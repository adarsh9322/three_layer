using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class loginbllCls
    {
        ConCls objdal = new ConCls();
        public string GetCountId(string una,string pwd)
        {
            string str = "select count(Id) from tab where username='" + una + "' and password='" + pwd + "'";
            string cid = objdal.Fn_Scalr(str);
            return cid;
        }
        public string GetId(string una,string pwd)
        {
            string str = "select Id from tab where username='" + una + "' and password='" + pwd + "'";
            string id = objdal.Fn_Scalr(str);
            return id;
        }
    }
}
