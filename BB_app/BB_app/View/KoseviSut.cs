﻿using System;
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
        public Ekipa ekipa = new Ekipa();
        public KoseviSut(char source, Ekipa ek)
        {
            ekipa = ek;
            InitializeComponent();
            s = source;
            if(source == 'E')
            {
                lblKoseviSutIzvor.Text = ek.Naziv.ToString();
                lblKoseviSutIzvor.Visible = true;
            }
            else if(source == 'I')
            {
                //grid view se generira
                gridView = new GridView_punjenje(source, 12, 100, ek.Id);
                this.Controls.Add(gridView.gv); //dodavanje novog grid view (kontrole) na formu
                lblKoseviSutIzvor.Text = ek.Naziv.ToString();
                lblKoseviSutIzvor.Visible = true;
            }
            
            

        }

        //kada se klikne na sliku
        private void picbKoseviTeren_MouseUp(object sender, MouseEventArgs e)
        {
            Kosevi kos = new Kosevi();
            //metoda od klase Kosevi
            kos.Set_XY((decimal)e.Location.X, (decimal)e.Location.Y, (decimal)picbKoseviTeren.Height, (decimal)picbKoseviTeren.Width);
            if(s == 'E')
            {
                kos.Suter_id = ekipa.Id;
            }
            else if (s == 'I')
            {
                kos.Suter_id = gridView.igrac_id.Id;
            }
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
