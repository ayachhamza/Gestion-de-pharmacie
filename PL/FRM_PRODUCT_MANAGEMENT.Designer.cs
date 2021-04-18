namespace PROJECT_FIN_ETUDE.PL
{
    partial class FRM_PRODUCT_MANAGEMENT
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
            this.dgv_products = new System.Windows.Forms.DataGridView();
            this.Numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_save_name = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btn_validite = new System.Windows.Forms.Button();
            this.btn_sauvgarder = new System.Windows.Forms.Button();
            this.btn_imprimer_element = new System.Windows.Forms.Button();
            this.btn_imprimer = new System.Windows.Forms.Button();
            this.btn_image = new System.Windows.Forms.Button();
            this.btn_supprimer = new System.Windows.Forms.Button();
            this.btn_modifier = new System.Windows.Forms.Button();
            this.btn_ajouter = new System.Windows.Forms.Button();
            this.btn_afficher = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_products)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.dgv_products);
            this.groupBox1.Location = new System.Drawing.Point(1, 61);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1009, 303);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Produits";
            // 
            // dgv_products
            // 
            this.dgv_products.AllowUserToAddRows = false;
            this.dgv_products.AllowUserToDeleteRows = false;
            this.dgv_products.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_products.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_products.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Numero,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column9,
            this.Column8});
            this.dgv_products.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_products.Location = new System.Drawing.Point(3, 16);
            this.dgv_products.MultiSelect = false;
            this.dgv_products.Name = "dgv_products";
            this.dgv_products.ReadOnly = true;
            this.dgv_products.RowHeadersVisible = false;
            this.dgv_products.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_products.Size = new System.Drawing.Size(1003, 284);
            this.dgv_products.TabIndex = 0;
            // 
            // Numero
            // 
            this.Numero.HeaderText = "Numero Produit";
            this.Numero.Name = "Numero";
            this.Numero.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Famille";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nom Produit";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Matiére Actiif";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Nom Scientifique";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Prix d\'achat";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Prix de vente";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Quantité";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Barcode";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Description";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox1.Location = new System.Drawing.Point(321, 28);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(437, 28);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(180, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Le Mot a rechercher :";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox2.Controls.Add(this.txt_save_name);
            this.groupBox2.Controls.Add(this.btn_validite);
            this.groupBox2.Controls.Add(this.btn_sauvgarder);
            this.groupBox2.Controls.Add(this.btn_imprimer_element);
            this.groupBox2.Controls.Add(this.btn_imprimer);
            this.groupBox2.Controls.Add(this.btn_image);
            this.groupBox2.Controls.Add(this.btn_supprimer);
            this.groupBox2.Controls.Add(this.btn_modifier);
            this.groupBox2.Controls.Add(this.btn_ajouter);
            this.groupBox2.Controls.Add(this.btn_afficher);
            this.groupBox2.Location = new System.Drawing.Point(4, 367);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1003, 144);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Les Operation";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // txt_save_name
            // 
            this.txt_save_name.BackColor = System.Drawing.Color.White;
            this.txt_save_name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_save_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txt_save_name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_save_name.HintForeColor = System.Drawing.Color.DimGray;
            this.txt_save_name.HintText = "Enter Nom fichier";
            this.txt_save_name.isPassword = false;
            this.txt_save_name.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(117)))), ((int)(((byte)(109)))));
            this.txt_save_name.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(178)))), ((int)(((byte)(111)))));
            this.txt_save_name.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(117)))), ((int)(((byte)(109)))));
            this.txt_save_name.LineThickness = 3;
            this.txt_save_name.Location = new System.Drawing.Point(557, 82);
            this.txt_save_name.Margin = new System.Windows.Forms.Padding(4);
            this.txt_save_name.Name = "txt_save_name";
            this.txt_save_name.Size = new System.Drawing.Size(152, 44);
            this.txt_save_name.TabIndex = 30;
            this.txt_save_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btn_validite
            // 
            this.btn_validite.Font = new System.Drawing.Font("Microsoft Tai Le", 10F);
            this.btn_validite.Location = new System.Drawing.Point(348, 82);
            this.btn_validite.Name = "btn_validite";
            this.btn_validite.Size = new System.Drawing.Size(153, 44);
            this.btn_validite.TabIndex = 29;
            this.btn_validite.Text = "Afficher La validité du produit selectionner";
            this.btn_validite.UseVisualStyleBackColor = true;
            this.btn_validite.Click += new System.EventHandler(this.btn_validite_Click);
            // 
            // btn_sauvgarder
            // 
            this.btn_sauvgarder.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_sauvgarder.Font = new System.Drawing.Font("Microsoft Tai Le", 10F);
            this.btn_sauvgarder.Location = new System.Drawing.Point(716, 82);
            this.btn_sauvgarder.Name = "btn_sauvgarder";
            this.btn_sauvgarder.Size = new System.Drawing.Size(191, 44);
            this.btn_sauvgarder.TabIndex = 27;
            this.btn_sauvgarder.Text = "Sauvgarder La liste des produits dans une fichier";
            this.btn_sauvgarder.UseVisualStyleBackColor = true;
            this.btn_sauvgarder.Click += new System.EventHandler(this.btn_sauvgarder_Click);
            // 
            // btn_imprimer_element
            // 
            this.btn_imprimer_element.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_imprimer_element.Font = new System.Drawing.Font("Microsoft Tai Le", 10F);
            this.btn_imprimer_element.Location = new System.Drawing.Point(151, 82);
            this.btn_imprimer_element.Name = "btn_imprimer_element";
            this.btn_imprimer_element.Size = new System.Drawing.Size(191, 44);
            this.btn_imprimer_element.TabIndex = 26;
            this.btn_imprimer_element.Text = "Imprimer Produit selectionner";
            this.btn_imprimer_element.UseVisualStyleBackColor = true;
            this.btn_imprimer_element.Click += new System.EventHandler(this.btn_imprimer_element_Click);
            // 
            // btn_imprimer
            // 
            this.btn_imprimer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_imprimer.Font = new System.Drawing.Font("Microsoft Tai Le", 10F);
            this.btn_imprimer.Location = new System.Drawing.Point(852, 23);
            this.btn_imprimer.Name = "btn_imprimer";
            this.btn_imprimer.Size = new System.Drawing.Size(141, 44);
            this.btn_imprimer.TabIndex = 25;
            this.btn_imprimer.Text = "Imprimer Les produits";
            this.btn_imprimer.UseVisualStyleBackColor = true;
            this.btn_imprimer.Click += new System.EventHandler(this.btn_imprimer_Click);
            // 
            // btn_image
            // 
            this.btn_image.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_image.Font = new System.Drawing.Font("Microsoft Tai Le", 10F);
            this.btn_image.Location = new System.Drawing.Point(695, 23);
            this.btn_image.Name = "btn_image";
            this.btn_image.Size = new System.Drawing.Size(141, 44);
            this.btn_image.TabIndex = 24;
            this.btn_image.Text = "Afficher l\'image du produit";
            this.btn_image.UseVisualStyleBackColor = true;
            this.btn_image.Click += new System.EventHandler(this.btn_image_Click);
            // 
            // btn_supprimer
            // 
            this.btn_supprimer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_supprimer.Font = new System.Drawing.Font("Microsoft Tai Le", 10F);
            this.btn_supprimer.Location = new System.Drawing.Point(528, 23);
            this.btn_supprimer.Name = "btn_supprimer";
            this.btn_supprimer.Size = new System.Drawing.Size(141, 44);
            this.btn_supprimer.TabIndex = 23;
            this.btn_supprimer.Text = "Supprimer le produit selectionner";
            this.btn_supprimer.UseVisualStyleBackColor = true;
            this.btn_supprimer.Click += new System.EventHandler(this.btn_supprimer_Click);
            // 
            // btn_modifier
            // 
            this.btn_modifier.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_modifier.Font = new System.Drawing.Font("Microsoft Tai Le", 10F);
            this.btn_modifier.Location = new System.Drawing.Point(362, 23);
            this.btn_modifier.Name = "btn_modifier";
            this.btn_modifier.Size = new System.Drawing.Size(141, 44);
            this.btn_modifier.TabIndex = 22;
            this.btn_modifier.Text = "Modifier Le produit selectionner";
            this.btn_modifier.UseVisualStyleBackColor = true;
            this.btn_modifier.Click += new System.EventHandler(this.btn_modifier_Click);
            // 
            // btn_ajouter
            // 
            this.btn_ajouter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_ajouter.Font = new System.Drawing.Font("Microsoft Tai Le", 10F);
            this.btn_ajouter.Location = new System.Drawing.Point(188, 23);
            this.btn_ajouter.Name = "btn_ajouter";
            this.btn_ajouter.Size = new System.Drawing.Size(141, 44);
            this.btn_ajouter.TabIndex = 21;
            this.btn_ajouter.Text = "Ajouter nouveaux produit";
            this.btn_ajouter.UseVisualStyleBackColor = true;
            this.btn_ajouter.Click += new System.EventHandler(this.btn_ajouter_Click);
            // 
            // btn_afficher
            // 
            this.btn_afficher.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_afficher.Font = new System.Drawing.Font("Microsoft Tai Le", 10F);
            this.btn_afficher.Location = new System.Drawing.Point(16, 23);
            this.btn_afficher.Name = "btn_afficher";
            this.btn_afficher.Size = new System.Drawing.Size(141, 44);
            this.btn_afficher.TabIndex = 20;
            this.btn_afficher.Text = "Afficher Les produits";
            this.btn_afficher.UseVisualStyleBackColor = true;
            this.btn_afficher.Click += new System.EventHandler(this.btn_afficher_Click);
            // 
            // FRM_PRODUCT_MANAGEMENT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1009, 536);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBox1);
            this.Name = "FRM_PRODUCT_MANAGEMENT";
            this.Text = "FRM_PRODUCT_MANAGEMENT";
            this.Activated += new System.EventHandler(this.FRM_PRODUCT_MANAGEMENT_Activated);
            this.Load += new System.EventHandler(this.FRM_PRODUCT_MANAGEMENT_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_products)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dgv_products;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_imprimer;
        private System.Windows.Forms.Button btn_image;
        private System.Windows.Forms.Button btn_supprimer;
        private System.Windows.Forms.Button btn_modifier;
        private System.Windows.Forms.Button btn_ajouter;
        private System.Windows.Forms.Button btn_afficher;
        private System.Windows.Forms.Button btn_sauvgarder;
        private System.Windows.Forms.Button btn_imprimer_element;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.Button btn_validite;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_save_name;
    }
}