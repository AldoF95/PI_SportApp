namespace BB_app.View
{
    partial class Statistika_prikaz
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
            this.cartesianChart1 = new LiveCharts.WinForms.CartesianChart();
            this.pieChart1 = new LiveCharts.WinForms.PieChart();
            this.cmbStatistikaOdabir = new MetroFramework.Controls.MetroComboBox();
            this.SuspendLayout();
            // 
            // cartesianChart1
            // 
            this.cartesianChart1.BackColor = System.Drawing.Color.Transparent;
            this.cartesianChart1.Location = new System.Drawing.Point(542, 275);
            this.cartesianChart1.Name = "cartesianChart1";
            this.cartesianChart1.Size = new System.Drawing.Size(641, 405);
            this.cartesianChart1.TabIndex = 0;
            this.cartesianChart1.Text = "cartesianChart1";
            // 
            // pieChart1
            // 
            this.pieChart1.BackColor = System.Drawing.Color.Transparent;
            this.pieChart1.Location = new System.Drawing.Point(735, 26);
            this.pieChart1.Name = "pieChart1";
            this.pieChart1.Size = new System.Drawing.Size(266, 214);
            this.pieChart1.TabIndex = 1;
            this.pieChart1.Text = "pieChart1";
            // 
            // cmbStatistikaOdabir
            // 
            this.cmbStatistikaOdabir.FormattingEnabled = true;
            this.cmbStatistikaOdabir.ItemHeight = 24;
            this.cmbStatistikaOdabir.Items.AddRange(new object[] {
            "Igrači",
            "Ekipe"});
            this.cmbStatistikaOdabir.Location = new System.Drawing.Point(72, 46);
            this.cmbStatistikaOdabir.Name = "cmbStatistikaOdabir";
            this.cmbStatistikaOdabir.Size = new System.Drawing.Size(195, 30);
            this.cmbStatistikaOdabir.TabIndex = 2;
            this.cmbStatistikaOdabir.UseSelectable = true;
            this.cmbStatistikaOdabir.SelectedIndexChanged += new System.EventHandler(this.cmbStatistikaOdabir_SelectedIndexChanged);
            // 
            // Statistika_prikaz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BB_app.Properties.Resources._1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1322, 815);
            this.Controls.Add(this.cmbStatistikaOdabir);
            this.Controls.Add(this.pieChart1);
            this.Controls.Add(this.cartesianChart1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Statistika_prikaz";
            this.Text = "Statistika_prikaz";
            this.ResumeLayout(false);

        }

        #endregion

        private LiveCharts.WinForms.CartesianChart cartesianChart1;
        private LiveCharts.WinForms.PieChart pieChart1;
        private MetroFramework.Controls.MetroComboBox cmbStatistikaOdabir;
    }
}