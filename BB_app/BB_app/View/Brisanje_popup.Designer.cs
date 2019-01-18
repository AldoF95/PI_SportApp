namespace BB_app.View
{
    partial class Brisanje_popup
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
            this.cmbBrisanjeOdabir = new MetroFramework.Controls.MetroComboBox();
            this.dgvBrisanje = new System.Windows.Forms.DataGridView();
            this.btnBrisanjeIzadi = new MetroFramework.Controls.MetroButton();
            this.btnBrisanjeBrisi = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBrisanje)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbBrisanjeOdabir
            // 
            this.cmbBrisanjeOdabir.FormattingEnabled = true;
            this.cmbBrisanjeOdabir.ItemHeight = 24;
            this.cmbBrisanjeOdabir.Items.AddRange(new object[] {
            "EKIPA",
            "IGRAČI",
            "PRISUTNOST",
            "TRENING",
            "STATISTIKA",
            "ZAPISNIK",
            "VJEŽBE",
            "ŠUTEVI"});
            this.cmbBrisanjeOdabir.Location = new System.Drawing.Point(37, 74);
            this.cmbBrisanjeOdabir.Name = "cmbBrisanjeOdabir";
            this.cmbBrisanjeOdabir.Size = new System.Drawing.Size(225, 30);
            this.cmbBrisanjeOdabir.TabIndex = 0;
            this.cmbBrisanjeOdabir.UseSelectable = true;
            this.cmbBrisanjeOdabir.SelectedIndexChanged += new System.EventHandler(this.cmbBrisanjeOdabir_SelectedIndexChanged);
            // 
            // dgvBrisanje
            // 
            this.dgvBrisanje.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBrisanje.Location = new System.Drawing.Point(351, 74);
            this.dgvBrisanje.Name = "dgvBrisanje";
            this.dgvBrisanje.RowTemplate.Height = 24;
            this.dgvBrisanje.Size = new System.Drawing.Size(1153, 585);
            this.dgvBrisanje.TabIndex = 1;
            this.dgvBrisanje.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBrisanje_CellClick);
            // 
            // btnBrisanjeIzadi
            // 
            this.btnBrisanjeIzadi.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnBrisanjeIzadi.Location = new System.Drawing.Point(40, 565);
            this.btnBrisanjeIzadi.Name = "btnBrisanjeIzadi";
            this.btnBrisanjeIzadi.Size = new System.Drawing.Size(222, 94);
            this.btnBrisanjeIzadi.TabIndex = 2;
            this.btnBrisanjeIzadi.Text = "Izađi";
            this.btnBrisanjeIzadi.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnBrisanjeIzadi.UseSelectable = true;
            this.btnBrisanjeIzadi.Click += new System.EventHandler(this.btnBrisanjeIzadi_Click);
            // 
            // btnBrisanjeBrisi
            // 
            this.btnBrisanjeBrisi.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnBrisanjeBrisi.Location = new System.Drawing.Point(40, 432);
            this.btnBrisanjeBrisi.Name = "btnBrisanjeBrisi";
            this.btnBrisanjeBrisi.Size = new System.Drawing.Size(222, 94);
            this.btnBrisanjeBrisi.TabIndex = 3;
            this.btnBrisanjeBrisi.Text = "Izbriši";
            this.btnBrisanjeBrisi.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnBrisanjeBrisi.UseSelectable = true;
            this.btnBrisanjeBrisi.Click += new System.EventHandler(this.btnBrisanjeBrisi_Click);
            // 
            // Brisanje_popup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BB_app.Properties.Resources._1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1530, 685);
            this.Controls.Add(this.btnBrisanjeBrisi);
            this.Controls.Add(this.btnBrisanjeIzadi);
            this.Controls.Add(this.dgvBrisanje);
            this.Controls.Add(this.cmbBrisanjeOdabir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Brisanje_popup";
            this.Text = "Brisanje_popup";
            ((System.ComponentModel.ISupportInitialize)(this.dgvBrisanje)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroComboBox cmbBrisanjeOdabir;
        private System.Windows.Forms.DataGridView dgvBrisanje;
        private MetroFramework.Controls.MetroButton btnBrisanjeIzadi;
        private MetroFramework.Controls.MetroButton btnBrisanjeBrisi;
    }
}