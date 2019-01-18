using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using BB_app.Model;
using BB_app.Model.DB;
using BB_app.Presenter;

namespace BB_app.View
{ 
    //klasa za unos suteva po pozicji na terenu
    public partial class KoseviSut : Form
    {
        public GridView_punjenje gridView;
        public char s;
        public KoseviSut(char source, int ek_id = 0)
        {
            InitializeComponent();
            s = source;
            //grid view se generira ovisno o izvoru (ekipa ili igraci)
            gridView = new GridView_punjenje(source, 12, 12);
            this.Controls.Add(gridView.gv); //dodavanje novog grid view (kontrole) na formu

        }

        //kada se klikne na sliku
        private void picbKoseviTeren_MouseUp(object sender, MouseEventArgs e)
        {
            Kosevi kos = new Kosevi();
            //metoda od klase Kosevi
            kos.Set_XY((decimal)e.Location.X, (decimal)e.Location.Y, (decimal)picbKoseviTeren.Height, (decimal)picbKoseviTeren.Width);
            kos.Suter_id = gridView.igrac_id.Id;
            kos.Vrsta_sut = s;
            //koordinate za izracunavanje pozicjie klika
            var X = picbKoseviTeren.Location.X + e.Location.X;
            var Y = picbKoseviTeren.Location.Y + e.Location.Y;
            var formX = this.DesktopLocation.X;
            var formY = this.DesktopLocation.Y;
            //salje se na popup fomu
            new Kosevi_popup(X, Y, formX, formY, kos).Show();
        }

    }
}
