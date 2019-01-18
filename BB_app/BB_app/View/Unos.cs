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
    public partial class Unos : Form
    {
        public Unos()
        {
            InitializeComponent();
        }

        private void btnUnosIgrac_Click(object sender, EventArgs e)
        {
            //za poziciju na ekranu, da se pojavi na sredini slike
            var x = (this.Width / 2) - (panelUnosIgr.Width / 2); //sredina forme - polovica sirine panela za prikazati 
            var y = (this.Height / 2) - (panelUnosIgr.Height / 2);//isto za visinu
            panelUnosIgr.Location = new Point(x, y); //stvaranje nove tocke za lokaciju panela

            var ek = new List<Ekipa>();
            DB_connection.OpenConn();
            ek = DB_GET.Ekipa_Get_All(); //dohvacanje listu ekipa
            DB_connection.CloseConn();
            cmbUnosIgr01.Items.Clear(); //praznjenje comboboxa (drop down menu) ako ima vec unutra nesto
            cmbUnosIgr01.DisplayMember = "Naziv"; //prikaz samo imena
            foreach(var i in ek) { cmbUnosIgr01.Items.Add(i); } //punjenje combo box sa svakim dohvacenim elemntom

            //sve se nalazi na jednoj formi
            //pa za prikaz jednog treba sakriti druge kontrole
            //enable --> ne moze se klikat, visible --> ne vidi s
            panelUnosIgr.Visible = true;
            panelUnosIgr.Enabled = true;
            btnUnosIgrac.Visible = false;
            btnUnosIgrac.Enabled = false;
            btnUnosVjezba.Visible = false;
            btnUnosVjezba.Enabled = false;
            btnUnosEkipa.Visible = false;
            btnUnosEkipa.Enabled = false;
            btnUnosBrisi.Visible = false;
            btnUnosBrisi.Enabled = false;
        }

        private void btnUnosIgrPut_Click(object sender, EventArgs e)
        {
            var Igr = new Igraci();
            var Ek = new Ekipa();
            Ek = (Ekipa)cmbUnosIgr01.SelectedItem; //spremanje u var odabranu ekipu iz combo boxa
            Igr.Ime = txtbUnosIgr01.Text; //podatak iz text boxa
            Igr.Prezime = txtbUnosIgr02.Text;
            Igr.Godiste = Int32.Parse(txtbUnosIgr03.Text); //parsanje --> text box je string, treba int, pa se parsa na int32 (int)

            if (rbtnUnosIgr01.Checked) { Igr.Spol = Char.Parse(rbtnUnosIgr01.Text); } //provjerea ako je oznacen radio button
            else if (rbtnUnosIgr02.Checked) { Igr.Spol = Char.Parse(rbtnUnosIgr02.Text); }

            if (chbUnosIgr01.Checked){ Igr.Karton = true; } //provjera ako je check box oznacen
            else{ Igr.Karton = false; }
            Igr.Ekipa_id = Ek.Id;
            DB_connection.OpenConn();
            DB_PUT.Igraci_Put(Igr); //spremanje objekta igraca sa podacima
            DB_connection.CloseConn();
        }

        private void chbUnosVj05_CheckedChanged(object sender, EventArgs e)
        {
            //ovisno ako je check box oznacen se prikazuje textbox
            if (chbUnosVj05.Checked) { txtbUnosVj03.Visible = true; } 
            else { txtbUnosVj03.Visible = false; }
        }

        private void btnUnosVjezba_Click(object sender, EventArgs e)
        {
            var x = (this.Width/2)-(panelUnosVj.Width/2);
            var y = (this.Height/2)-(panelUnosVj.Height/2);
            panelUnosVj.Location = new Point(x, y);
            panelUnosVj.Enabled = true;
            panelUnosVj.Visible = true;

            btnUnosIgrac.Visible = false;
            btnUnosIgrac.Enabled = false;
            btnUnosVjezba.Visible = false;
            btnUnosVjezba.Enabled = false;
            btnUnosEkipa.Visible = false;
            btnUnosEkipa.Enabled = false;
            btnUnosBrisi.Visible = false;
            btnUnosBrisi.Enabled = false;
        }

        private void btnUnosVj01_Click(object sender, EventArgs e)
        {
            var vj = new Vjezbe();

            vj.Naziv = txtbUnosVj01.Text;
            vj.Opis = txtbUnosVj02.Text;

            if(chbUnosVj05.Checked && txtbUnosVj03.Text.Length != 0) { vj.Drugo = txtbUnosVj03.Text; }

            if (chbUnosVj01.Checked) { vj.Sutevi = true; }
            if (chbUnosVj02.Checked) { vj.Brzina = true; }
            if (chbUnosVj03.Checked) { vj.Brojac = true; }
            if (chbUnosVj04.Checked) { vj.Udaljenost = true; }

            DB_connection.OpenConn();
            DB_PUT.Vjezbe_Put(vj);
            DB_connection.CloseConn();
        }

        private void btnUnosEkipa_Click(object sender, EventArgs e)
        {
            var x = (this.Width / 2) - (panelUnosEkipa.Width / 2);
            var y = (this.Height / 2) - (panelUnosEkipa.Height / 2);
            panelUnosEkipa.Location = new Point(x, y);
            panelUnosEkipa.Visible = true;
            panelUnosEkipa.Enabled = true;
            btnUnosIgrac.Visible = false;
            btnUnosIgrac.Enabled = false;
            btnUnosVjezba.Visible = false;
            btnUnosVjezba.Enabled = false;
            btnUnosEkipa.Visible = false;
            btnUnosEkipa.Enabled = false;
            btnUnosBrisi.Visible = false;
            btnUnosBrisi.Enabled = false;
        }

        private void btnUnosIgraca02_Click(object sender, EventArgs e)
        {
            panelUnosIgr.Visible = false;
            panelUnosIgr.Enabled = false;
            btnUnosIgrac.Visible = true;
            btnUnosIgrac.Enabled = true;
            btnUnosVjezba.Visible = true;
            btnUnosVjezba.Enabled = true;
            btnUnosEkipa.Visible = true;
            btnUnosEkipa.Enabled = true;
            btnUnosBrisi.Visible = true;
            btnUnosBrisi.Enabled = true;
        }

        private void btnUnosVjezbi02_Click(object sender, EventArgs e)
        {
            panelUnosVj.Visible = false;
            panelUnosVj.Enabled = false;
            btnUnosIgrac.Visible = true;
            btnUnosIgrac.Enabled = true;
            btnUnosVjezba.Visible = true;
            btnUnosVjezba.Enabled = true;
            btnUnosEkipa.Visible = true;
            btnUnosEkipa.Enabled = true;
            btnUnosBrisi.Visible = true;
            btnUnosBrisi.Enabled = true;
        }

        private void btnUnosEkipe02_Click(object sender, EventArgs e)
        {
            panelUnosEkipa.Visible = false;
            panelUnosEkipa.Enabled = false;
            btnUnosIgrac.Visible = true;
            btnUnosIgrac.Enabled = true;
            btnUnosVjezba.Visible = true;
            btnUnosVjezba.Enabled = true;
            btnUnosEkipa.Visible = true;
            btnUnosEkipa.Enabled = true;
            btnUnosBrisi.Visible = true;
            btnUnosBrisi.Enabled = true;
        }

        private void btnUnosEkipe01_Click(object sender, EventArgs e)
        {
            var ek = new Ekipa();
            ek.Naziv = txtbUnosEkipe.Text;
            ek.Trener = txtbUnosEkipe02.Text;

            DB_connection.OpenConn();
            DB_PUT.Ekipa_Put(ek);
            DB_connection.CloseConn();
        }

        private void btnUnosBrisi_Click(object sender, EventArgs e)
        {
            new Brisanje_popup().Show();
        }
    }
}
