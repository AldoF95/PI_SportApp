using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BB_app.Model.DB;
using BB_app.Model;

namespace BB_app.View
{
    //forma za biranje bodova i pogodeno ili ne
    public partial class Kosevi_popup : Form
    {
        Kosevi kos_sut = new Kosevi();

        public Kosevi_popup(int X, int Y, int formX, int formY, Kosevi kos)
        {
            
            InitializeComponent();
            //lokacija popoupa
            this.Location = new Point(formX + X, formY + Y);
            kos_sut = kos;
        }

        //kada se odabere broj bodova
        private void rbtnKoseviPopup02_CheckedChanged(object sender, EventArgs e)
        {
            //ponavalja se za sve bodove
            if (rbtnKoseviPopup02.Checked)
            {
                kos_sut.Br_Bod = 1;
                if (chbKoseviPogodeno.Checked) { kos_sut.Pogodak = true; }
                else { kos_sut.Pogodak = false; }
            }
            DB_connection.OpenConn();
            DB_PUT.Kosevi_Put(kos_sut); //spremanje suta
            DB_connection.CloseConn();
            this.Close();//zatvaranje popupa
        }

        private void rbtnKoseviPopup03_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnKoseviPopup03.Checked)
            {
                kos_sut.Br_Bod = 2;
                if (chbKoseviPogodeno.Checked) { kos_sut.Pogodak = true; }
                else { kos_sut.Pogodak = false; }
            }
            DB_connection.OpenConn();
            DB_PUT.Kosevi_Put(kos_sut);
            DB_connection.CloseConn();
            this.Close();

        }

        private void rbtnKoseviPopup04_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnKoseviPopup04.Checked)
            {
                kos_sut.Br_Bod = 3;
                if (chbKoseviPogodeno.Checked) { kos_sut.Pogodak = true; }
                else { kos_sut.Pogodak = false; }
            }
            DB_connection.OpenConn();
            DB_PUT.Kosevi_Put(kos_sut);
            DB_connection.CloseConn();
            this.Close();
        }
    }
}
