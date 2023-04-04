using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Runtime.Remoting.Messaging;

namespace DormitoryManagment
{
    internal class Phong
    {
        DATA dal = new DATA();
        public DataTable GETROOM()
        {
            string sql = "SELECT IDROOM,NUMST,NUMSTMAX,STYLE,FLOOR,STATUS,MONEYBILL,STATUSBILL FROM ROOM";
            return dal.GetTable(sql);
        }

        public DataTable SEARCH(String chuoi, String truong)
        {
            string sql = "SELECT * FROM ROOM WHERE " + truong + " LIKE N'%" + chuoi + "%'";
            return dal.GetTable(sql);

        }
        public DataTable GETROOMHAVESLOT()
        {
            string st = "Thiếu";
            string sql = "SELECT * FROM ROOM WHERE STATUS = N'" + st + "'";
            return dal.GetTable(sql);
        }
    }
}
