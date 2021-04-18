namespace PROJECT_FIN_ETUDE.PL
{
    partial class FRM_ADD_PRODUCTS
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_barcode = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_prixVente = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_charger_image = new System.Windows.Forms.Button();
            this.pictureBox_produit = new System.Windows.Forms.PictureBox();
            this.comboBox_nomScientifique = new System.Windows.Forms.ComboBox();
            this.comboBox_matiereActif = new System.Windows.Forms.ComboBox();
            this.comboBox_famille = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_prixAchat = new System.Windows.Forms.TextBox();
            this.txt_description_produit = new System.Windows.Forms.TextBox();
            this.txt_NomProduit = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.sdd = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_produit)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_barcode);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txt_prixVente);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.btn_charger_image);
            this.groupBox1.Controls.Add(this.pictureBox_produit);
            this.groupBox1.Controls.Add(this.comboBox_nomScientifique);
            this.groupBox1.Controls.Add(this.comboBox_matiereActif);
            this.groupBox1.Controls.Add(this.comboBox_famille);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txt_prixAchat);
            this.groupBox1.Controls.Add(this.txt_description_produit);
            this.groupBox1.Controls.Add(this.txt_NomProduit);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.sdd);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Tai Le", 12F);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(978, 365);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Les Données du produit";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txt_barcode
            // 
            this.txt_barcode.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_barcode.Font = new System.Drawing.Font("Sitka Small", 13F);
            this.txt_barcode.Location = new System.Drawing.Point(626, 128);
            this.txt_barcode.Name = "txt_barcode";
            this.txt_barcode.Size = new System.Drawing.Size(220, 29);
            this.txt_barcode.TabIndex = 25;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Tai Le", 12F);
            this.label9.Location = new System.Drawing.Point(486, 186);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(129, 21);
            this.label9.TabIndex = 24;
            this.label9.Text = "Image de produit";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Tai Le", 12F);
            this.label8.Location = new System.Drawing.Point(549, 136);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 21);
            this.label8.TabIndex = 23;
            this.label8.Text = "Barcode";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Tai Le", 12F);
            this.label5.Location = new System.Drawing.Point(486, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 21);
            this.label5.TabIndex = 22;
            this.label5.Text = "Nom scientifique";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txt_prixVente
            // 
            this.txt_prixVente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_prixVente.Font = new System.Drawing.Font("Sitka Small", 13F);
            this.txt_prixVente.Location = new System.Drawing.Point(217, 227);
            this.txt_prixVente.Name = "txt_prixVente";
            this.txt_prixVente.Size = new System.Drawing.Size(220, 29);
            this.txt_prixVente.TabIndex = 21;
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button3.Font = new System.Drawing.Font("Microsoft Tai Le", 10F);
            this.button3.Location = new System.Drawing.Point(313, 297);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(141, 44);
            this.button3.TabIndex = 20;
            this.button3.Text = "Annuler";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2.Font = new System.Drawing.Font("Microsoft Tai Le", 10F);
            this.button2.Location = new System.Drawing.Point(166, 297);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(141, 44);
            this.button2.TabIndex = 19;
            this.button2.Text = "Ajouter la produit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_charger_image
            // 
            this.btn_charger_image.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_charger_image.Font = new System.Drawing.Font("Microsoft Tai Le", 10F);
            this.btn_charger_image.Location = new System.Drawing.Point(626, 262);
            this.btn_charger_image.Name = "btn_charger_image";
            this.btn_charger_image.Size = new System.Drawing.Size(157, 31);
            this.btn_charger_image.TabIndex = 18;
            this.btn_charger_image.Text = "Charger une image";
            this.btn_charger_image.UseVisualStyleBackColor = true;
            this.btn_charger_image.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox_produit
            // 
            this.pictureBox_produit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox_produit.Location = new System.Drawing.Point(626, 168);
            this.pictureBox_produit.Name = "pictureBox_produit";
            this.pictureBox_produit.Size = new System.Drawing.Size(157, 88);
            this.pictureBox_produit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_produit.TabIndex = 17;
            this.pictureBox_produit.TabStop = false;
            this.pictureBox_produit.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // comboBox_nomScientifique
            // 
            this.comboBox_nomScientifique.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox_nomScientifique.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_nomScientifique.Font = new System.Drawing.Font("Sitka Small", 13F);
            this.comboBox_nomScientifique.FormattingEnabled = true;
            this.comboBox_nomScientifique.Location = new System.Drawing.Point(626, 85);
            this.comboBox_nomScientifique.Name = "comboBox_nomScientifique";
            this.comboBox_nomScientifique.Size = new System.Drawing.Size(220, 33);
            this.comboBox_nomScientifique.TabIndex = 16;
            // 
            // comboBox_matiereActif
            // 
            this.comboBox_matiereActif.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox_matiereActif.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_matiereActif.Font = new System.Drawing.Font("Sitka Small", 13F);
            this.comboBox_matiereActif.FormattingEnabled = true;
            this.comboBox_matiereActif.Location = new System.Drawing.Point(626, 41);
            this.comboBox_matiereActif.Name = "comboBox_matiereActif";
            this.comboBox_matiereActif.Size = new System.Drawing.Size(220, 33);
            this.comboBox_matiereActif.TabIndex = 15;
            // 
            // comboBox_famille
            // 
            this.comboBox_famille.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox_famille.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_famille.Font = new System.Drawing.Font("Sitka Small", 13F);
            this.comboBox_famille.FormattingEnabled = true;
            this.comboBox_famille.Location = new System.Drawing.Point(217, 46);
            this.comboBox_famille.Name = "comboBox_famille";
            this.comboBox_famille.Size = new System.Drawing.Size(220, 33);
            this.comboBox_famille.TabIndex = 14;
            this.comboBox_famille.SelectedIndexChanged += new System.EventHandler(this.comboBox_famille_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Tai Le", 12F);
            this.label7.Location = new System.Drawing.Point(519, 49);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 21);
            this.label7.TabIndex = 13;
            this.label7.Text = "Matiére actif";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // txt_prixAchat
            // 
            this.txt_prixAchat.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_prixAchat.Font = new System.Drawing.Font("Sitka Small", 13F);
            this.txt_prixAchat.Location = new System.Drawing.Point(217, 189);
            this.txt_prixAchat.Name = "txt_prixAchat";
            this.txt_prixAchat.Size = new System.Drawing.Size(220, 29);
            this.txt_prixAchat.TabIndex = 11;
            // 
            // txt_description_produit
            // 
            this.txt_description_produit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_description_produit.Font = new System.Drawing.Font("Sitka Small", 13F);
            this.txt_description_produit.Location = new System.Drawing.Point(217, 125);
            this.txt_description_produit.Multiline = true;
            this.txt_description_produit.Name = "txt_description_produit";
            this.txt_description_produit.Size = new System.Drawing.Size(220, 56);
            this.txt_description_produit.TabIndex = 10;
            this.txt_description_produit.TextChanged += new System.EventHandler(this.txt_description_produit_TextChanged);
            // 
            // txt_NomProduit
            // 
            this.txt_NomProduit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_NomProduit.Font = new System.Drawing.Font("Sitka Small", 13F);
            this.txt_NomProduit.Location = new System.Drawing.Point(217, 87);
            this.txt_NomProduit.Name = "txt_NomProduit";
            this.txt_NomProduit.Size = new System.Drawing.Size(220, 29);
            this.txt_NomProduit.TabIndex = 9;
            this.txt_NomProduit.TextChanged += new System.EventHandler(this.txt_NomProduit_TextChanged);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Tai Le", 12F);
            this.label6.Location = new System.Drawing.Point(98, 227);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 21);
            this.label6.TabIndex = 5;
            this.label6.Text = "Prix de vente";
            // 
            // sdd
            // 
            this.sdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sdd.AutoSize = true;
            this.sdd.Font = new System.Drawing.Font("Microsoft Tai Le", 12F);
            this.sdd.Location = new System.Drawing.Point(107, 188);
            this.sdd.Name = "sdd";
            this.sdd.Size = new System.Drawing.Size(90, 21);
            this.sdd.TabIndex = 4;
            this.sdd.Text = "Prix d\'achat";
            this.sdd.Click += new System.EventHandler(this.sdd_Click);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 12F);
            this.label4.Location = new System.Drawing.Point(53, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Description Produit";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 12F);
            this.label3.Location = new System.Drawing.Point(75, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nom du Produit";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 21);
            this.label2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 12F);
            this.label1.Location = new System.Drawing.Point(79, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom du famille";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // FRM_ADD_PRODUCTS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 365);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FRM_ADD_PRODUCTS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FRM_ADD_PRODUCTS";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_produit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_prixVente;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btn_charger_image;
        private System.Windows.Forms.PictureBox pictureBox_produit;
        private System.Windows.Forms.ComboBox comboBox_nomScientifique;
        private System.Windows.Forms.ComboBox comboBox_matiereActif;
        private System.Windows.Forms.ComboBox comboBox_famille;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_prixAchat;
        private System.Windows.Forms.TextBox txt_description_produit;
        private System.Windows.Forms.TextBox txt_NomProduit;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label sdd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_barcode;
        public System.Windows.Forms.Button button2;
    }
}