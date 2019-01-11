using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BB_app.Presenter;
using BB_app.Model.DB;
using BB_app.Model;

namespace BB_app.View
{
    public partial class Prikaz_suteva : Form
    {
        public GridView_punjenje gridView;
        public Prikaz_suteva()
        {
            InitializeComponent();
            //grid view se generira ovisno o zelji
            gridView = new GridView_punjenje('I', 0);
            this.Controls.Add(gridView.gv);
        }

        private void btnPrikazSuteva01_Click(object sender, EventArgs e)
        {
            DB_connection.OpenConn();
            List<Kosevi> sut = DB_GET.Kosevi_Get_By_Id(gridView.igrac_id.Id); //dobivanje suteva po igracu
            DB_connection.CloseConn();
            var picb_H = picbPrikazSutevaTeren.Height;
            var picb_W = picbPrikazSutevaTeren.Width;
            List<PictureBox> control = new List<PictureBox>();
            
            if(control.Count > 0)
            {
                foreach(var c in control)
                {
                    
                    c.Visible = false;
                } //ako su vec prikazani neki sutevi, da se sakriju
                control.Clear();
            }

            foreach(var sutevi in sut)
            {
                var poz_X = sutevi.Poz_X * picb_W + picbPrikazSutevaTeren.Location.X;
                var poz_Y = sutevi.Poz_Y * picb_H + picbPrikazSutevaTeren.Location.Y;
                var img = new PrikazSuteva_pozicije(sutevi.Pogodak, poz_X, poz_Y); //instanciranje novog prikaza za svaki sut
                control.Add(img.pic);
                this.Controls.Add(img.pic);
                img.pic.BringToFront(); //da bude ispred prijasnje dodanih
            }
            metroLabel1.Text = control.Count().ToString();
        }
    }
}
