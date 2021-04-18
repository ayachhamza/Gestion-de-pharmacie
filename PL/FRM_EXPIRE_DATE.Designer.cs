namespace PROJECT_FIN_ETUDE.PL
{
    partial class FRM_EXPIRE_DATE
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
            this.DGV_PRODUCT_EXPIRE_DATE = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_PRODUCT_EXPIRE_DATE)).BeginInit();
            this.SuspendLayout();
            // 
            // DGV_PRODUCT_EXPIRE_DATE
            // 
            this.DGV_PRODUCT_EXPIRE_DATE.AllowUserToAddRows = false;
            this.DGV_PRODUCT_EXPIRE_DATE.AllowUserToDeleteRows = false;
            this.DGV_PRODUCT_EXPIRE_DATE.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_PRODUCT_EXPIRE_DATE.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_PRODUCT_EXPIRE_DATE.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGV_PRODUCT_EXPIRE_DATE.Location = new System.Drawing.Point(0, 0);
            this.DGV_PRODUCT_EXPIRE_DATE.MultiSelect = false;
            this.DGV_PRODUCT_EXPIRE_DATE.Name = "DGV_PRODUCT_EXPIRE_DATE";
            this.DGV_PRODUCT_EXPIRE_DATE.RowHeadersVisible = false;
            this.DGV_PRODUCT_EXPIRE_DATE.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_PRODUCT_EXPIRE_DATE.Size = new System.Drawing.Size(385, 290);
            this.DGV_PRODUCT_EXPIRE_DATE.TabIndex = 0;
            this.DGV_PRODUCT_EXPIRE_DATE.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_PRODUCT_EXPIRE_DATE_CellContentClick);
            // 
            // FRM_EXPIRE_DATE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 290);
            this.Controls.Add(this.DGV_PRODUCT_EXPIRE_DATE);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FRM_EXPIRE_DATE";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FRM_EXPIRE_DATE";
            ((System.ComponentModel.ISupportInitialize)(this.DGV_PRODUCT_EXPIRE_DATE)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView DGV_PRODUCT_EXPIRE_DATE;
    }
}