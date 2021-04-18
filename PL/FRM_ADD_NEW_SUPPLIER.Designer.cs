namespace PROJECT_FIN_ETUDE.PL
{
    partial class FRM_ADD_NEW_SUPPLIER
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
            this.txt_nom = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_tele = new System.Windows.Forms.TextBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_titre = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_annuler
            // 
            this.btn_annuler.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_annuler.Font = new System.Drawing.Font("Microsoft Tai Le", 12F);
            this.btn_annuler.Location = new System.Drawing.Point(211, 231);
            this.btn_annuler.Name = "btn_annuler";
            this.btn_annuler.Size = new System.Drawing.Size(130, 43);
            this.btn_annuler.TabIndex = 0;
            this.btn_annuler.Text = "Annuler";
            this.btn_annuler.UseVisualStyleBackColor = true;
            this.btn_annuler.Click += new System.EventHandler(this.btn_annuler_Click);
            // 
            // btn_ajouter
            // 
            this.btn_ajouter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_ajouter.Font = new System.Drawing.Font("Microsoft Tai Le", 12F);
            this.btn_ajouter.Location = new System.Drawing.Point(66, 231);
            this.btn_ajouter.Name = "btn_ajouter";
            this.btn_ajouter.Size = new System.Drawing.Size(120, 43);
            this.btn_ajouter.TabIndex = 1;
            this.btn_ajouter.Text = "Ajouter";
            this.btn_ajouter.UseVisualStyleBackColor = true;
            this.btn_ajouter.Click += new System.EventHandler(this.btn_ajouter_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 12F);
            this.label1.Location = new System.Drawing.Point(16, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nom Fournisseur:";
            // 
            // txt_nom
            // 
            this.txt_nom.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_nom.Font = new System.Drawing.Font("Microsoft Tai Le", 12F);
            this.txt_nom.Location = new System.Drawing.Point(168, 100);
            this.txt_nom.Name = "txt_nom";
            this.txt_nom.Size = new System.Drawing.Size(202, 28);
            this.txt_nom.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 12F);
            this.label2.Location = new System.Drawing.Point(65, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "Telephone:";
            // 
            // txt_tele
            // 
            this.txt_tele.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_tele.Font = new System.Drawing.Font("Microsoft Tai Le", 12F);
            this.txt_tele.Location = new System.Drawing.Point(168, 139);
            this.txt_tele.Name = "txt_tele";
            this.txt_tele.Size = new System.Drawing.Size(202, 28);
            this.txt_tele.TabIndex = 5;
            // 
            // txt_email
            // 
            this.txt_email.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_email.Font = new System.Drawing.Font("Microsoft Tai Le", 12F);
            this.txt_email.Location = new System.Drawing.Point(168, 174);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(202, 28);
            this.txt_email.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 12F);
            this.label3.Location = new System.Drawing.Point(91, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 21);
            this.label3.TabIndex = 6;
            this.label3.Text = "E-mail";
            // 
            // txt_titre
            // 
            this.txt_titre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_titre.AutoSize = true;
            this.txt_titre.Font = new System.Drawing.Font("Microsoft Tai Le", 23F);
            this.txt_titre.Location = new System.Drawing.Point(62, 19);
            this.txt_titre.Name = "txt_titre";
            this.txt_titre.Size = new System.Drawing.Size(286, 39);
            this.txt_titre.TabIndex = 8;
            this.txt_titre.Text = "Ajouter Fournisseur";
            this.txt_titre.Click += new System.EventHandler(this.label4_Click);
            // 
            // FRM_ADD_NEW_SUPPLIER
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 286);
            this.Controls.Add(this.txt_titre);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_tele);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_nom);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_ajouter);
            this.Controls.Add(this.btn_annuler);
            this.Name = "FRM_ADD_NEW_SUPPLIER";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FRM_ADD_NEW_SUPPLIER_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_annuler;
        private System.Windows.Forms.Button btn_ajouter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_nom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_tele;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label txt_titre;
    }
}