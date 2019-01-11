﻿using System;
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
    public partial class Zapisnik_unos : Form
    {
        Ekipa ek;
        public Zapisnik_unos()
        {
            InitializeComponent();
            var ek = new List<Ekipa>();
            DB_connection.OpenConn();
            ek = DB_GET.Ekipa_Get_All();//dohvacanje ekipa za dombo box
            DB_connection.CloseConn();
            cmbZapisnik01.Items.Clear();
            cmbZapisnik01.DisplayMember = "Naziv";
            foreach (var i in ek) { cmbZapisnik01.Items.Add(i); }
        }

        private void btnZapisnik01_Click(object sender, EventArgs e)
        {
            var X = btnZapisnik01.Location.X;
            var Y = btnZapisnik01.Location.Y;
            new Zapisnik_popup(X, Y, ek).Show(); //za pojavu popup iznad gumba kojeg se kliknulo
        }

        private void btnZapisnik02_Click(object sender, EventArgs e)
        {
            var zap = new Zapisnik();
            
            zap.Datum = (DateTime)calendarZapisnik.SelectionRange.Start; //odaberen datum iz kalendara
            zap.Ekipa_id = ek.Id;
            zap.Ekipa_gost = txtbZapisnik01.Text;
            zap.Rez_dom = Int32.Parse(txtbZapisnik02.Text);
            zap.Rez_gost = Int32.Parse(txtbZapisnik03.Text);

            DB_connection.OpenConn();
            DB_PUT.Zapisnik_Put(zap); //spremanje zapisnika
            DB_connection.CloseConn();
        }

        private void btnZapisnik03_Click(object sender, EventArgs e)
        {
            this.Close(); //zatvara formu
        }

        private void cmbZapisnik01_SelectedIndexChanged(object sender, EventArgs e)
        {
            //odabrana ekipa iz combo boxa
            ek = new Ekipa();
            ek = (Ekipa)cmbZapisnik01.SelectedItem;
        }
    }
}