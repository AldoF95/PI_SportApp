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
    public partial class Brisanje_popup : Form
    {
        public List<Kosevi> kosevi = new List<Kosevi>();
        public List<Vjezbe> vjezba = new List<Vjezbe>();
        public List<Trening> trening = new List<Trening>();
        public List<Igraci> igrac = new List<Igraci>();
        public List<Prisutnost> prisutan= new List<Prisutnost>();
        public List<Ekipa> ekipe = new List<Ekipa>();
        public List<Zapisnik> zapisnik= new List<Zapisnik>();
        public List<Statistika> statistike= new List<Statistika>();

        public BindingSource datasource;
        public int id_to_delete;

        public Brisanje_popup()
        {
            InitializeComponent();
        }

        private void cmbBrisanjeOdabir_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selected_idex = cmbBrisanjeOdabir.SelectedIndex;
            
            DB_connection.OpenConn();
            switch (selected_idex)
            {
                case 0:
                    {
                        ekipe = DB_GET.Ekipa_Get_All();
                        var collection = new ObservableCollection<Ekipa>(ekipe);
                        datasource = new BindingSource(collection, null);
                        break;
                    }
                case 1:
                    {
                        igrac = DB_GET.Igraci_Get_All();
                        var collection = new ObservableCollection<Igraci>(igrac);
                        datasource = new BindingSource(collection, null);
                        break;
                    }
                case 2:
                    {
                        prisutan = DB_GET.Prisutnost_Get_All();
                        var collection = new ObservableCollection<Prisutnost>(prisutan);
                        datasource = new BindingSource(collection, null);
                        break;
                    }
                case 3:
                    {
                        trening = DB_GET.Trening_Get_All();
                        var collection = new ObservableCollection<Trening>(trening);
                        datasource = new BindingSource(collection, null);
                        break;
                    }
                case 4:
                    {
                        statistike = DB_GET.Statistika_Get_All();
                        var collection = new ObservableCollection<Statistika>(statistike);
                        datasource = new BindingSource(collection, null);
                        break;
                    }
                case 5:
                    {
                        zapisnik = DB_GET.Zapisnik_Get_All();
                        var collection = new ObservableCollection<Zapisnik>(zapisnik);
                        datasource = new BindingSource(collection, null);
                        break;
                    }
                case 6:
                    {
                        vjezba = DB_GET.Vjezbe_Get_All();
                        var collection = new ObservableCollection<Vjezbe>(vjezba);
                        datasource = new BindingSource(collection, null);
                        break;
                    }
                case 7:
                    {
                        kosevi = DB_GET.Kosevi_Get_All();
                        var collection = new ObservableCollection<Kosevi>(kosevi);
                        datasource = new BindingSource(collection, null);
                        break;
                    }
            }
            DB_connection.CloseConn();

            dgvBrisanje.DataSource = datasource;
            dgvBrisanje.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBrisanje.AutoResizeColumns();
        }

        private void btnBrisanjeIzadi_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBrisanjeBrisi_Click(object sender, EventArgs e)
        {

        }

        private void dgvBrisanje_CellClick(object sender, DataGridViewCellEventArgs e)
        {
    
        }
    }
}
