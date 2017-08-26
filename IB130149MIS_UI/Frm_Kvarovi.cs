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
    public partial class Frm_Kvarovi : Form
    {
        private Control[] dgKvarovi;

        public Frm_Kvarovi()
        {
            InitializeComponent();
        }

        private void Frm_Kvarovi_Load(object sender, EventArgs e)
        {
            //get all Kvarovi
            Kvarovi.KvarsDataTable dtKvarovi = new Kvarovi.KvarsDataTable();

            DAKvarovi.GetKvarovi(dtKvarovi);

            dataGridKvarovi.DataSource = dtKvarovi;

        }
    }
}
