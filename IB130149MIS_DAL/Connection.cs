using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IB130149MIS_DAL
{
    public class Connection
    {
        //return sql connection object
        public static SqlConnection GetConnection()
        {
            SqlConnection cn = new SqlConnection(Properties.Settings.Default.si105ConnectionString);
            cn.Open();

            return cn;
        }

    }
}
