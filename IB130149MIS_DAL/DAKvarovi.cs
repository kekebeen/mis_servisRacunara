using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IB130149MIS_DAL
{
    public class DAKvarovi
    {
        public static void GetKvarovi(Kvarovi.KvarsDataTable dtKvarovi)
        {
            //open connection
            SqlConnection cn = Connection.GetConnection();

            if(cn.State == System.Data.ConnectionState.Closed)
            {
                cn.Open();
            }

            try
            {
                SqlCommand cmd = new SqlCommand("usp_Kvarovi", cn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dtKvarovi);
            }
            finally
            {

            }
        }
    }
}
