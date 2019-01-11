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
    public partial class Pocetna : Form
    {
        public Pocetna()
        {
            InitializeComponent();

        }
        private void btnTrening_Click(object sender, EventArgs e)
        {
            //otvaranje nove forme
            new Trening_kreiranje().Show();
        }

        private void btnTrening_MouseHover(object sender, EventArgs e)
        {

        }

        private void btnUnos_Click(object sender, EventArgs e)
        {
            new Unos().Show();
        }

        private void btnPocetnaKosevi_Click(object sender, EventArgs e)
        {
            new Prikaz_suteva().Show();
        }

        private void btnZapisnik_Click(object sender, EventArgs e)
        {
            new Zapisnik_unos().Show();
        }
    }
}
