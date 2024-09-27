using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class InseertbllCls
    {
        ConCls objdal = new ConCls();
        public int DBInsert(string na,int ag,string addr,string ph,string una,string pwd)
        {
            string str = "insert into tab values('" + na + "'," + ag + ",'" + addr + "','" + ph + "','" + una + "','" + pwd + "')";
            int i = objdal.Fn_Nonquery(str);
            return i;
        }
    }
}
