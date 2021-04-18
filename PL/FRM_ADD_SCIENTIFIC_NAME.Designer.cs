namespace PROJECT_FIN_ETUDE.PL
{
    partial class FRM_ADD_SCIENTIFIC_NAME
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
            this.btn_annuler = new System.Windows.Forms.Button();
            this.btn_ajouter = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_sn = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_annuler
            // 
            this.btn_annuler.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_annuler.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_annuler.Location = new System.Drawing.Point(453, 203);
            this.btn_annuler.Name = "btn_annuler";
            this.btn_annuler.Size = new System.Drawing.Size(136, 43);
            this.btn_annuler.TabIndex = 7;
            this.btn_annuler.Text = "Annuler";
            this.btn_annuler.UseVisualStyleBackColor = true;
            this.btn_annuler.Click += new System.EventHandler(this.btn_annuler_Click);
            // 
            // btn_ajouter
            // 
            this.btn_ajouter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_ajouter.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ajouter.Location = new System.Drawing.Point(302, 203);
            this.btn_ajouter.Name = "btn_ajouter";
            this.btn_ajouter.Size = new System.Drawing.Size(136, 43);
            this.btn_ajouter.TabIndex = 6;
            this.btn_ajouter.Text = "Ajouter";
            this.btn_ajouter.UseVisualStyleBackColor = true;
            this.btn_ajouter.Click += new System.EventHandler(this.btn_ajouter_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(159, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "Le Nom scientific";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txt_sn
            // 
            this.txt_sn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_sn.Font = new System.Drawing.Font("Sitka Small", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_sn.Location = new System.Drawing.Point(329, 131);
            this.txt_sn.Multiline = true;
            this.txt_sn.Name = "txt_sn";
            this.txt_sn.Size = new System.Drawing.Size(218, 30);
            this.txt_sn.TabIndex = 4;
            // 
            // FRM_ADD_SCIENTIFIC_NAME
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_annuler);
            this.Controls.Add(this.btn_ajouter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_sn);
            this.Name = "FRM_ADD_SCIENTIFIC_NAME";
            this.Text = "FRM_ADD_SCIENTIFIC_NAME";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_annuler;
        private System.Windows.Forms.Button btn_ajouter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_sn;
    }
}