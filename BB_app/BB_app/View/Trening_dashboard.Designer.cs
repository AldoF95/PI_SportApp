namespace BB_app.View
{
    partial class Trening_dashboard
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Trening_dashboard));
            this.lblDashboard01 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timerDashboard = new System.Windows.Forms.Timer(this.components);
            this.lblDashboardTimer = new MetroFramework.Controls.MetroLabel();
            this.btnDashboardUnos01 = new MetroFramework.Controls.MetroButton();
            this.btnDashboardUnos02 = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDashboard01
            // 
            this.lblDashboard01.AutoSize = true;
            this.lblDashboard01.BackColor = System.Drawing.Color.Transparent;
            this.lblDashboard01.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDashboard01.ForeColor = System.Drawing.SystemColors.Control;
            this.lblDashboard01.Location = new System.Drawing.Point(38, 19);
            this.lblDashboard01.Name = "lblDashboard01";
            this.lblDashboard01.Size = new System.Drawing.Size(46, 17);
            this.lblDashboard01.TabIndex = 0;
            this.lblDashboard01.Text = "label1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(355, 57);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(615, 571);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // timerDashboard
            // 
            this.timerDashboard.Tick += new System.EventHandler(this.timerDashboard_Tick);
            // 
            // lblDashboardTimer
            // 
            this.lblDashboardTimer.AutoSize = true;
            this.lblDashboardTimer.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblDashboardTimer.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblDashboardTimer.Location = new System.Drawing.Point(1058, 98);
            this.lblDashboardTimer.Margin = new System.Windows.Forms.Padding(6);
            this.lblDashboardTimer.Name = "lblDashboardTimer";
            this.lblDashboardTimer.Size = new System.Drawing.Size(88, 25);
            this.lblDashboardTimer.TabIndex = 2;
            this.lblDashboardTimer.Text = "00:00:00";
            this.lblDashboardTimer.Click += new System.EventHandler(this.lblDashboardTimer_Click);
            // 
            // btnDashboardUnos01
            // 
            this.btnDashboardUnos01.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnDashboardUnos01.Location = new System.Drawing.Point(72, 640);
            this.btnDashboardUnos01.Name = "btnDashboardUnos01";
            this.btnDashboardUnos01.Size = new System.Drawing.Size(133, 72);
            this.btnDashboardUnos01.TabIndex = 3;
            this.btnDashboardUnos01.Text = "Brzina";
            this.btnDashboardUnos01.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnDashboardUnos01.UseSelectable = true;
            // 
            // btnDashboardUnos02
            // 
            this.btnDashboardUnos02.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnDashboardUnos02.Location = new System.Drawing.Point(236, 640);
            this.btnDashboardUnos02.Name = "btnDashboardUnos02";
            this.btnDashboardUnos02.Size = new System.Drawing.Size(133, 72);
            this.btnDashboardUnos02.TabIndex = 4;
            this.btnDashboardUnos02.Text = "Udaljenost";
            this.btnDashboardUnos02.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnDashboardUnos02.UseSelectable = true;
            // 
            // Trening_dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BB_app.Properties.Resources._1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1232, 724);
            this.Controls.Add(this.btnDashboardUnos02);
            this.Controls.Add(this.btnDashboardUnos01);
            this.Controls.Add(this.lblDashboardTimer);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblDashboard01);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Trening_dashboard";
            this.Text = "Trening dashboard";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDashboard01;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timerDashboard;
        private MetroFramework.Controls.MetroLabel lblDashboardTimer;
        private MetroFramework.Controls.MetroButton btnDashboardUnos01;
        private MetroFramework.Controls.MetroButton btnDashboardUnos02;
    }
}