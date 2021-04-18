namespace PROJECT_FIN_ETUDE.PL
{
    partial class FRM_ADD_ACTIVE_MATERIELLE
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_nom = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_desc = new System.Windows.Forms.TextBox();
            this.btn_annuler = new System.Windows.Forms.Button();
            this.btn_ajouter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 13F);
            this.label1.Location = new System.Drawing.Point(252, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom du Matiére actif";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txt_nom
            // 
            this.txt_nom.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_nom.Font = new System.Drawing.Font("Sitka Small", 13F);
            this.txt_nom.Location = new System.Drawing.Point(459, 81);
            this.txt_nom.Name = "txt_nom";
            this.txt_nom.Size = new System.Drawing.Size(209, 29);
            this.txt_nom.TabIndex = 1;
            this.txt_nom.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 13F);
            this.label2.Location = new System.Drawing.Point(338, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Description";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txt_desc
            // 
            this.txt_desc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_desc.Font = new System.Drawing.Font("Sitka Small", 13F);
            this.txt_desc.Location = new System.Drawing.Point(459, 124);
            this.txt_desc.Multiline = true;
            this.txt_desc.Name = "txt_desc";
            this.txt_desc.Size = new System.Drawing.Size(209, 98);
            this.txt_desc.TabIndex = 1;
            this.txt_desc.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // btn_annuler
            // 
            this.btn_annuler.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_annuler.Font = new System.Drawing.Font("Microsoft Tai Le", 12F);
            this.btn_annuler.Location = new System.Drawing.Point(571, 246);
            this.btn_annuler.Name = "btn_annuler";
            this.btn_annuler.Size = new System.Drawing.Size(134, 44);
            this.btn_annuler.TabIndex = 2;
            this.btn_annuler.Text = "Annuler";
            this.btn_annuler.UseVisualStyleBackColor = true;
            this.btn_annuler.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_ajouter
            // 
            this.btn_ajouter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_ajouter.Font = new System.Drawing.Font("Microsoft Tai Le", 12F);
            this.btn_ajouter.Location = new System.Drawing.Point(422, 246);
            this.btn_ajouter.Name = "btn_ajouter";
            this.btn_ajouter.Size = new System.Drawing.Size(134, 44);
            this.btn_ajouter.TabIndex = 2;
            this.btn_ajouter.Text = "Ajouter";
            this.btn_ajouter.UseVisualStyleBackColor = true;
            this.btn_ajouter.Click += new System.EventHandler(this.button2_Click);
            // 
            // FRM_ADD_ACTIVE_MATERIELLE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 410);
            this.Controls.Add(this.btn_ajouter);
            this.Controls.Add(this.btn_annuler);
            this.Controls.Add(this.txt_desc);
            this.Controls.Add(this.txt_nom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FRM_ADD_ACTIVE_MATERIELLE";
            this.Text = "Ajouter la Matiére active";
            this.Load += new System.EventHandler(this.FRM_ADD_ACTIVE_MATERIELLE_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_nom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_desc;
        private System.Windows.Forms.Button btn_annuler;
        private System.Windows.Forms.Button btn_ajouter;
    }
}