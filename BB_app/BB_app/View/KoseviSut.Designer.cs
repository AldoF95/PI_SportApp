namespace BB_app.View
{
    partial class KoseviSut
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KoseviSut));
            this.picbKoseviTeren = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picbKoseviTeren)).BeginInit();
            this.SuspendLayout();
            // 
            // picbKoseviTeren
            // 
            this.picbKoseviTeren.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picbKoseviTeren.Image = ((System.Drawing.Image)(resources.GetObject("picbKoseviTeren.Image")));
            this.picbKoseviTeren.Location = new System.Drawing.Point(404, 12);
            this.picbKoseviTeren.Name = "picbKoseviTeren";
            this.picbKoseviTeren.Size = new System.Drawing.Size(673, 614);
            this.picbKoseviTeren.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picbKoseviTeren.TabIndex = 0;
            this.picbKoseviTeren.TabStop = false;
            this.picbKoseviTeren.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picbKoseviTeren_MouseUp);
            // 
            // KoseviSut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BB_app.Properties.Resources._1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1097, 638);
            this.Controls.Add(this.picbKoseviTeren);
            this.Name = "KoseviSut";
            this.Text = "Kosevi";
            ((System.ComponentModel.ISupportInitialize)(this.picbKoseviTeren)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picbKoseviTeren;
    }
}