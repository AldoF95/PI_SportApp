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
            this.btnPrikazSuteva01 = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.picbPrikazSutevaTeren)).BeginInit();
            this.SuspendLayout();
            // 
            // picbPrikazSutevaTeren
            // 
            this.picbPrikazSutevaTeren.Image = ((System.Drawing.Image)(resources.GetObject("picbPrikazSutevaTeren.Image")));
            this.picbPrikazSutevaTeren.Location = new System.Drawing.Point(349, 15);
            this.picbPrikazSutevaTeren.Name = "picbPrikazSutevaTeren";
            this.picbPrikazSutevaTeren.Size = new System.Drawing.Size(670, 610);
            this.picbPrikazSutevaTeren.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picbPrikazSutevaTeren.TabIndex = 0;
            this.picbPrikazSutevaTeren.TabStop = false;
            // 
            // btnPrikazSuteva01
            // 
            this.btnPrikazSuteva01.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnPrikazSuteva01.Location = new System.Drawing.Point(88, 527);
            this.btnPrikazSuteva01.Name = "btnPrikazSuteva01";
            this.btnPrikazSuteva01.Size = new System.Drawing.Size(162, 74);
            this.btnPrikazSuteva01.TabIndex = 2;
            this.btnPrikazSuteva01.Text = "Prikaži";
            this.btnPrikazSuteva01.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnPrikazSuteva01.UseSelectable = true;
            this.btnPrikazSuteva01.Click += new System.EventHandler(this.btnPrikazSuteva01_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(24, 474);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(84, 20);
            this.metroLabel1.TabIndex = 3;
            this.metroLabel1.Text = "metroLabel1";
            // 
            // Prikaz_suteva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.BackgroundImage = global::BB_app.Properties.Resources._1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1031, 637);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.btnPrikazSuteva01);
            this.Controls.Add(this.picbPrikazSutevaTeren);
            this.Name = "Prikaz_suteva";
            this.Text = "Prikaz_suteva";
            ((System.ComponentModel.ISupportInitialize)(this.picbPrikazSutevaTeren)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picbPrikazSutevaTeren;
        private MetroFramework.Controls.MetroButton btnPrikazSuteva01;
        private MetroFramework.Controls.MetroLabel metroLabel1;
    }
}