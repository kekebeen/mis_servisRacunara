using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IB130149MIS_DAL
{
    public class DALogin
    {
        public static void getKorisnikByUsernameAndPassword(DSLogin.KorisniksDataTable dtLogin, string username, string password)
        {
            SqlConnection cn = Connection.GetConnection();

            if (cn.State == System.Data.ConnectionState.Closed)
            {
                cn.Open();
            }

            try
            {
                SqlCommand cmd = new SqlCommand("usp_Login", cn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                if (username != "")
                    cmd.Parameters.Add("@KorisnickoIme", SqlDbType.NVarChar).Value = username;

                if (password != "")
                    cmd.Parameters.Add("@Lozinka", SqlDbType.NVarChar).Value = password;

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dtLogin);
            }
            finally
            {

            }
        }
    }
}
