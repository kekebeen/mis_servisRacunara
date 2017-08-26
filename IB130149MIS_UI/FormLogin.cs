using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using IB130149MIS_DAL;

namespace IB130149MIS_UI
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //send txt username and pw to getuserlogin function
            var username = txtBox_Username.Text.Trim();
            var password = txtBox_Password.Text.Trim();

            DSLogin.KorisniksDataTable dtLogin = new DSLogin.KorisniksDataTable();
            dtLogin.Clear();


            DALogin.getKorisnikByUsernameAndPassword(dtLogin, username, password);


            if(dtLogin.Rows.Count == 1)
            {
                FrmDashboard formDashboard = new FrmDashboard();
                this.Hide();
                formDashboard.Show();
            }else
            {
                MessageBox.Show("Check your username and password");
            }
        }

    }
}
