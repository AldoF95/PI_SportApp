namespace BB_app.View
{
    partial class Prikaz_suteva
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Prikaz_suteva));
            this.picbPrikazSutevaTeren = new System.Windows.Forms.PictureBox();
            this.piePrikazSuteva = new LiveCharts.WinForms.PieChart();
            this.chartPrikazSuteva = new LiveCharts.WinForms.CartesianChart();
            this.lblPrikazSutevaIme = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picbPrikazSutevaTeren)).BeginInit();
            this.SuspendLayout();
            // 
            // picbPrikazSutevaTeren
            // 
            this.picbPrikazSutevaTeren.Image = ((System.Drawing.Image)(resources.GetObject("picbPrikazSutevaTeren.Image")));
            this.picbPrikazSutevaTeren.Location = new System.Drawing.Point(572, 12);
            this.picbPrikazSutevaTeren.Name = "picbPrikazSutevaTeren";
            this.picbPrikazSutevaTeren.Size = new System.Drawing.Size(800, 740);
            this.picbPrikazSutevaTeren.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picbPrikazSutevaTeren.TabIndex = 0;
            this.picbPrikazSutevaTeren.TabStop = false;
            // 
            // piePrikazSuteva
            // 
            this.piePrikazSuteva.BackColor = System.Drawing.Color.Transparent;
            this.piePrikazSuteva.Location = new System.Drawing.Point(168, 161);
            this.piePrikazSuteva.Name = "piePrikazSuteva";
            this.piePrikazSuteva.Size = new System.Drawing.Size(248, 244);
            this.piePrikazSuteva.TabIndex = 1;
            this.piePrikazSuteva.Text = "pieChart1";
            // 
            // chartPrikazSuteva
            // 
            this.chartPrikazSuteva.BackColor = System.Drawing.Color.Transparent;
            this.chartPrikazSuteva.Location = new System.Drawing.Point(28, 451);
            this.chartPrikazSuteva.Name = "chartPrikazSuteva";
            this.chartPrikazSuteva.Size = new System.Drawing.Size(500, 301);
            this.chartPrikazSuteva.TabIndex = 2;
            this.chartPrikazSuteva.Text = "cartesianChart1";
            // 
            // lblPrikazSutevaIme
            // 
            this.lblPrikazSutevaIme.BackColor = System.Drawing.Color.Transparent;
            this.lblPrikazSutevaIme.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrikazSutevaIme.ForeColor = System.Drawing.Color.White;
            this.lblPrikazSutevaIme.Location = new System.Drawing.Point(28, 14);
            this.lblPrikazSutevaIme.Name = "lblPrikazSutevaIme";
            this.lblPrikazSutevaIme.Size = new System.Drawing.Size(364, 62);
            this.lblPrikazSutevaIme.TabIndex = 3;
            this.lblPrikazSutevaIme.Text = "label1";
            // 
            // Prikaz_suteva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.BackgroundImage = global::BB_app.Properties.Resources._1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1384, 762);
            this.Controls.Add(this.lblPrikazSutevaIme);
            this.Controls.Add(this.chartPrikazSuteva);
            this.Controls.Add(this.piePrikazSuteva);
            this.Controls.Add(this.picbPrikazSutevaTeren);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Prikaz_suteva";
            this.Text = "Prikaz_suteva";
            ((System.ComponentModel.ISupportInitialize)(this.picbPrikazSutevaTeren)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picbPrikazSutevaTeren;
        private LiveCharts.WinForms.PieChart piePrikazSuteva;
        private LiveCharts.WinForms.CartesianChart chartPrikazSuteva;
        private System.Windows.Forms.Label lblPrikazSutevaIme;
    }
}