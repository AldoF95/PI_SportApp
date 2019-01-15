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
using System.Collections.ObjectModel;
using System.Collections.Specialized;

namespace BB_app.View
{
    public partial class Trening_dashboard : Form
    {
        Trening trening_now;
        List<Igraci> igraci_now;
        List<Vjezbe> vjezbe_now;
        Igraci igrac_odabran;
        List<Statistika> statistika = new List<Statistika>();

        public Trening_dashboard(Trening tr, List<Igraci> igr, List<Vjezbe> vj)
        {
            trening_now = tr;
            igraci_now = igr;
            vjezbe_now = vj;
            
            InitializeComponent();
            lblDashboard01.Text = tr.Naziv.ToString()+" - "+String.Format("{0:MM/dd/yy}", (DateTime)tr.Datum);
            //GRIDVIEW
            //punjenje gridview-a sa igracima
            BindingSource datasource;
            dgvDashboardIgraci.AutoGenerateColumns = false;
            dgvDashboardIgraci.ColumnCount = 2;
            var collection = new ObservableCollection<Igraci>(igraci_now);
            datasource = new BindingSource(collection, null);
            dgvDashboardIgraci.Columns[0].HeaderText = "Ime";
            dgvDashboardIgraci.Columns[0].DataPropertyName = "Ime";
            dgvDashboardIgraci.Columns[1].HeaderText = "Prezime";
            dgvDashboardIgraci.Columns[1].DataPropertyName = "Prezime";
            dgvDashboardIgraci.DataSource = datasource;
            dgvDashboardIgraci.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDashboardIgraci.AutoResizeColumns();
            dgvDashboardIgraci.AllowUserToAddRows = false;
            dgvDashboardIgraci.CellClick += (s, e) =>
            {
                igrac_odabran = (Igraci)this.igraci_now[e.RowIndex];
            };


        }
        //TIMER
        int sto = 0;
        int sec = 0;
        int min = 0;
        
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
            lblDashboradTimer.Text = min.ToString() + ":" + sec.ToString() + ":" + sto.ToString();
        }

        private void btnTimerStar_Click(object sender, EventArgs e)
        {
            var status = false;
            if(status == false)
            {
                timerDashboard.Start();
                timerDashboard.Interval = 10;
                btnTimerStar.Text = "STOP";
                status = true;
            }
            else
            {
                timerDashboard.Stop();
                btnTimerStar.Text = "START";
                status = false;
            }
            
        }

        private void btnTimerReset_Click(object sender, EventArgs e)
        {
            sto = 0;
            sec = 0;
            min = 0;
        }


        //GUMBOVI
        private void btnDashboardBrzina_Click(object sender, EventArgs e)
        {
            if(igrac_odabran != null)//pozivanje funkcije za prikaz panela ako je odabran igrac u gridview-u
            {
                Show_panel("Brzina", igrac_odabran.Ime.ToString(), igrac_odabran.Prezime.ToString()); 
            }
        }

        private void btnDashboardSprint_Click(object sender, EventArgs e)
        {
            if (igrac_odabran != null)
            {
                Show_panel("Šprint", igrac_odabran.Ime.ToString(), igrac_odabran.Prezime.ToString());
            }
        }

        private void btnDashboardSU_Click(object sender, EventArgs e)
        {
            if (igrac_odabran != null)
            {
                Show_panel("Samoubojstvo", igrac_odabran.Ime.ToString(), igrac_odabran.Prezime.ToString());
            }
        }

        private void btnDashboardSkUd_Click(object sender, EventArgs e)
        {
            if (igrac_odabran != null)
            {
                Show_panel("Skok udalj", igrac_odabran.Ime.ToString(), igrac_odabran.Prezime.ToString());
            }
        }

        //otvaranje prozora sa unosom mjerenja
        private void btnDashboardMjerenja_Click(object sender, EventArgs e)
        {
            new Mjerenja_popup(igrac_odabran, this.Location.X, this.Location.Y).Show();
        }
        //kraj treninga i spremanje podataka
        private void btnDashboardKraj_Click(object sender, EventArgs e)
        {
            Spremanje_kraj_treninga();
            this.Close();
        }

        // GUMBOVI UNUTAR UNOSA
        private void btnPanelUnos_Click(object sender, EventArgs e)
        {
            //spremanje podataka ovisno odabranog tipa unosa (buttona)

            Statistika stat = Check_instance(igrac_odabran);//provjera ako instanca sa igracem vec postoj
            switch (lblPanelTitle.Text)
            {
                case "Brzina":
                    {
                        stat.Brz_Spr = Decimal.Parse(txtbPanelValue.Text);
                        break;
                    }
                case "Šprint":
                    {
                        stat.Brz_Spr = Decimal.Parse(txtbPanelValue.Text);
                        break;
                    }
                case "Samoubojstvo":
                    {
                        stat.Brz_SU = Decimal.Parse(txtbPanelValue.Text);
                        break;
                    }
                case "Skok udalj":
                    {
                        stat.Skok_ud = Decimal.Parse(txtbPanelValue.Text);
                        break;
                    }
            }
            panelDashboardUnos.Visible = false;
        }

        private void btnPanelIzadi_Click(object sender, EventArgs e)
        {
            txtbPanelValue.Text = "";
            panelDashboardUnos.Visible = false;
        }
        //FUNKCIJE
        public void Show_panel(string titel, string igrac_ime, string igrac_prezime)
        {
            //prikaz panela
            lblPanelTitle.Text = titel;
            lblPanelIgrac.Text = igrac_ime + " " + igrac_prezime;
            panelDashboardUnos.Visible = true;
        }

        public Statistika Check_instance(Igraci igrac)
        {
            foreach(var s in statistika)
            {
                if(s.Entity_Id == igrac.Id) { return s; } 
            }
            Statistika stat = new Statistika();
            stat.Entity_Id = igrac.Id;
            stat.Entity_type = 'I';
            statistika.Add(stat);
            return stat;
        }

        public void Spremanje_kraj_treninga()
        {
            DB_connection.OpenConn();
            DB_PUT.Statistika_Put_List(statistika);
            DB_connection.CloseConn();
            this.Close();
        }


    }
}
