namespace PROJECT_FIN_ETUDE.PL
{
    partial class FRM_PRODUCT_IMAGE
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
            this.pic_image = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic_image)).BeginInit();
            this.SuspendLayout();
            // 
            // pic_image
            // 
            this.pic_image.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pic_image.Location = new System.Drawing.Point(0, 0);
            this.pic_image.Name = "pic_image";
            this.pic_image.Size = new System.Drawing.Size(455, 343);
            this.pic_image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_image.TabIndex = 0;
            this.pic_image.TabStop = false;
            this.pic_image.Click += new System.EventHandler(this.pic_image_Click);
            // 
            // FRM_PRODUCT_IMAGE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 343);
            this.Controls.Add(this.pic_image);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRM_PRODUCT_IMAGE";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "L\'image du produit";
            ((System.ComponentModel.ISupportInitialize)(this.pic_image)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.PictureBox pic_image;
    }
}