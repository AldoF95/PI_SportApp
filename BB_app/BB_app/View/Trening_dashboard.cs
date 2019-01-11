using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BB_app.Model;
using BB_app.Model.DB;

namespace BB_app.View
{
    public partial class Trening_dashboard : Form
    {
        Trening trening_now;
        List<Igraci> igraci_now;
        List<Vjezbe> vjezbe_now;

        public Trening_dashboard(Trening tr, List<Igraci> igr, List<Vjezbe> vj)
        {
            trening_now = tr;
            igraci_now = igr;
            vjezbe_now = vj;
            
            InitializeComponent();
            lblDashboard01.Text = tr.Naziv.ToString()+" - "+String.Format("{0:MM/dd/yy}", (DateTime)tr.Datum);
        }
        int sto = 0;
        int sec = 0;
        int min = 0;
        private void lblDashboardTimer_Click(object sender, EventArgs e)
        {
            var status = false;
            if(status == false && sto == 0 && sec == 0 && min == 0)
            {
                timerDashboard.Start();
                timerDashboard.Interval = 10;
                status = true;
            }
            else if (status == false && (sto != 0 || sec != 0 || min != 0))
            {
                sto = 0; sec = 0; min = 0;
                lblDashboardTimer.Text = min.ToString() + ":" + sec.ToString() + ":" + sto.ToString();
            }
            else if(status == true)
            {
                timerDashboard.Stop();
                status = false;
            }
        }
        private void timerDashboard_Tick(object sender, EventArgs e)
        {
            sto++;
            if(sto == 99)
            {
                sec++;
                sto = 0;
            }
            if(sec == 59)
            {
                min++;
                sec = 0;
            }
            lblDashboardTimer.Text = min.ToString() + ":" + sec.ToString() + ":" + sto.ToString();
        }
    }
}
