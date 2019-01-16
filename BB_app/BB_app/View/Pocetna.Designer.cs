namespace BB_app.View
{
    partial class Pocetna
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pocetna));
            this.btnTrening = new MetroFramework.Controls.MetroButton();
            this.btnUnos = new MetroFramework.Controls.MetroButton();
            this.btnPocetnaStatistika = new MetroFramework.Controls.MetroButton();
            this.btnZapisnik = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // btnTrening
            // 
            this.btnTrening.AutoSize = true;
            this.btnTrening.BackColor = System.Drawing.Color.Navy;
            this.btnTrening.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnTrening.Location = new System.Drawing.Point(174, 99);
            this.btnTrening.Margin = new System.Windows.Forms.Padding(0);
            this.btnTrening.Name = "btnTrening";
            this.btnTrening.Size = new System.Drawing.Size(200, 160);
            this.btnTrening.TabIndex = 0;
            this.btnTrening.Text = "TRENING";
            this.btnTrening.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnTrening.UseSelectable = true;
            this.btnTrening.Click += new System.EventHandler(this.btnTrening_Click);
            this.btnTrening.MouseHover += new System.EventHandler(this.btnTrening_MouseHover);
            // 
            // btnUnos
            // 
            this.btnUnos.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnUnos.Location = new System.Drawing.Point(408, 278);
            this.btnUnos.Name = "btnUnos";
            this.btnUnos.Size = new System.Drawing.Size(200, 160);
            this.btnUnos.TabIndex = 1;
            this.btnUnos.Text = "UNOS";
            this.btnUnos.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnUnos.UseSelectable = true;
            this.btnUnos.Click += new System.EventHandler(this.btnUnos_Click);
            // 
            // btnPocetnaStatistika
            // 
            this.btnPocetnaStatistika.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnPocetnaStatistika.Location = new System.Drawing.Point(174, 278);
            this.btnPocetnaStatistika.Name = "btnPocetnaStatistika";
            this.btnPocetnaStatistika.Size = new System.Drawing.Size(200, 160);
            this.btnPocetnaStatistika.TabIndex = 2;
            this.btnPocetnaStatistika.Text = "STATISTIKA";
            this.btnPocetnaStatistika.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnPocetnaStatistika.UseSelectable = true;
            this.btnPocetnaStatistika.Click += new System.EventHandler(this.btnPocetnaStatistika_Click);
            // 
            // btnZapisnik
            // 
            this.btnZapisnik.AutoSize = true;
            this.btnZapisnik.BackColor = System.Drawing.Color.Navy;
            this.btnZapisnik.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnZapisnik.Location = new System.Drawing.Point(408, 99);
            this.btnZapisnik.Margin = new System.Windows.Forms.Padding(0);
            this.btnZapisnik.Name = "btnZapisnik";
            this.btnZapisnik.Size = new System.Drawing.Size(200, 160);
            this.btnZapisnik.TabIndex = 3;
            this.btnZapisnik.Text = "ZAPISNIK";
            this.btnZapisnik.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnZapisnik.UseSelectable = true;
            this.btnZapisnik.Click += new System.EventHandler(this.btnZapisnik_Click);
            // 
            // Pocetna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 550);
            this.Controls.Add(this.btnZapisnik);
            this.Controls.Add(this.btnPocetnaStatistika);
            this.Controls.Add(this.btnUnos);
            this.Controls.Add(this.btnTrening);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Pocetna";
            this.Text = "Pocetna";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton btnTrening;
        private MetroFramework.Controls.MetroButton btnUnos;
        private MetroFramework.Controls.MetroButton btnPocetnaStatistika;
        private MetroFramework.Controls.MetroButton btnZapisnik;
    }
}