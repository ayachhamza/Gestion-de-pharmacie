namespace PROJECT_FIN_ETUDE.PL
{
    partial class FRM_CATEGORIE_MANAGEMENT
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
            this.DGV_CATEGORIES = new System.Windows.Forms.DataGridView();
            this.btn_afficher = new System.Windows.Forms.Button();
            this.btn_modifier = new System.Windows.Forms.Button();
            this.btn_imprimer = new System.Windows.Forms.Button();
            this.btn_supprimer = new System.Windows.Forms.Button();
            this.btn_rechercher = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_rechercher = new System.Windows.Forms.TextBox();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.txt_nom = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_CATEGORIES)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.DGV_CATEGORIES);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Tai Le", 12F);
            this.groupBox1.Location = new System.Drawing.Point(25, 117);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(518, 272);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Les Familles";
            // 
            // DGV_CATEGORIES
            // 
            this.DGV_CATEGORIES.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_CATEGORIES.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_CATEGORIES.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGV_CATEGORIES.Location = new System.Drawing.Point(3, 24);
            this.DGV_CATEGORIES.Name = "DGV_CATEGORIES";
            this.DGV_CATEGORIES.ReadOnly = true;
            this.DGV_CATEGORIES.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_CATEGORIES.Size = new System.Drawing.Size(512, 245);
            this.DGV_CATEGORIES.TabIndex = 0;
            this.DGV_CATEGORIES.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_CATEGORIES_CellClick);
            this.DGV_CATEGORIES.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_CATEGORIES_CellContentClick);
            // 
            // btn_afficher
            // 
            this.btn_afficher.Font = new System.Drawing.Font("Microsoft Tai Le", 10F);
            this.btn_afficher.Location = new System.Drawing.Point(199, 34);
            this.btn_afficher.Name = "btn_afficher";
            this.btn_afficher.Size = new System.Drawing.Size(153, 55);
            this.btn_afficher.TabIndex = 1;
            this.btn_afficher.Text = "Afficher les Familles";
            this.btn_afficher.UseVisualStyleBackColor = true;
            this.btn_afficher.Click += new System.EventHandler(this.btn_afficher_Click);
            // 
            // btn_modifier
            // 
            this.btn_modifier.Font = new System.Drawing.Font("Microsoft Tai Le", 10F);
            this.btn_modifier.Location = new System.Drawing.Point(28, 34);
            this.btn_modifier.Name = "btn_modifier";
            this.btn_modifier.Size = new System.Drawing.Size(153, 55);
            this.btn_modifier.TabIndex = 2;
            this.btn_modifier.Text = "Modifier Les Donnée selectionners ";
            this.btn_modifier.UseVisualStyleBackColor = true;
            this.btn_modifier.Click += new System.EventHandler(this.btn_modifier_Click);
            // 
            // btn_imprimer
            // 
            this.btn_imprimer.Font = new System.Drawing.Font("Microsoft Tai Le", 10F);
            this.btn_imprimer.Location = new System.Drawing.Point(199, 102);
            this.btn_imprimer.Name = "btn_imprimer";
            this.btn_imprimer.Size = new System.Drawing.Size(153, 55);
            this.btn_imprimer.TabIndex = 3;
            this.btn_imprimer.Text = "Imprimer les Familles";
            this.btn_imprimer.UseVisualStyleBackColor = true;
            this.btn_imprimer.Click += new System.EventHandler(this.btn_imprimer_Click);
            // 
            // btn_supprimer
            // 
            this.btn_supprimer.Font = new System.Drawing.Font("Microsoft Tai Le", 10F);
            this.btn_supprimer.Location = new System.Drawing.Point(28, 102);
            this.btn_supprimer.Name = "btn_supprimer";
            this.btn_supprimer.Size = new System.Drawing.Size(153, 55);
            this.btn_supprimer.TabIndex = 4;
            this.btn_supprimer.Text = "Supprimer Les Donnée selectionners ";
            this.btn_supprimer.UseVisualStyleBackColor = true;
            this.btn_supprimer.Click += new System.EventHandler(this.btn_supprimer_Click);
            // 
            // btn_rechercher
            // 
            this.btn_rechercher.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_rechercher.Font = new System.Drawing.Font("Microsoft Tai Le", 10F);
            this.btn_rechercher.Location = new System.Drawing.Point(332, 47);
            this.btn_rechercher.Name = "btn_rechercher";
            this.btn_rechercher.Size = new System.Drawing.Size(165, 43);
            this.btn_rechercher.TabIndex = 5;
            this.btn_rechercher.Text = "Rechercher";
            this.btn_rechercher.UseVisualStyleBackColor = true;
            this.btn_rechercher.Click += new System.EventHandler(this.btn_rechercher_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 12F);
            this.label1.Location = new System.Drawing.Point(24, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(288, 21);
            this.label1.TabIndex = 6;
            this.label1.Text = "Le nom ou L\'ID du Famille a rechercher :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 21);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nom Famille";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 21);
            this.label3.TabIndex = 6;
            this.label3.Text = "ID Famille";
            // 
            // txt_rechercher
            // 
            this.txt_rechercher.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_rechercher.Font = new System.Drawing.Font("Microsoft Tai Le", 12F);
            this.txt_rechercher.Location = new System.Drawing.Point(43, 54);
            this.txt_rechercher.Name = "txt_rechercher";
            this.txt_rechercher.Size = new System.Drawing.Size(231, 28);
            this.txt_rechercher.TabIndex = 7;
            // 
            // txt_id
            // 
            this.txt_id.Font = new System.Drawing.Font("Sitka Small", 13F);
            this.txt_id.Location = new System.Drawing.Point(120, 44);
            this.txt_id.Name = "txt_id";
            this.txt_id.ReadOnly = true;
            this.txt_id.Size = new System.Drawing.Size(233, 29);
            this.txt_id.TabIndex = 8;
            // 
            // txt_nom
            // 
            this.txt_nom.Font = new System.Drawing.Font("Sitka Small", 13F);
            this.txt_nom.Location = new System.Drawing.Point(120, 101);
            this.txt_nom.Multiline = true;
            this.txt_nom.Name = "txt_nom";
            this.txt_nom.Size = new System.Drawing.Size(233, 29);
            this.txt_nom.TabIndex = 9;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox2.Controls.Add(this.txt_id);
            this.groupBox2.Controls.Add(this.txt_nom);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Tai Le", 12F);
            this.groupBox2.Location = new System.Drawing.Point(567, 40);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(374, 163);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Famille Selectionner";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox3.Controls.Add(this.btn_afficher);
            this.groupBox3.Controls.Add(this.btn_modifier);
            this.groupBox3.Controls.Add(this.btn_imprimer);
            this.groupBox3.Controls.Add(this.btn_supprimer);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Tai Le", 12F);
            this.groupBox3.Location = new System.Drawing.Point(568, 223);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(374, 180);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Les Operation sur les famille";
            // 
            // FRM_CATEGORIE_MANAGEMENT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 429);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.txt_rechercher);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_rechercher);
            this.Controls.Add(this.groupBox1);
            this.Name = "FRM_CATEGORIE_MANAGEMENT";
            this.Text = "Gestion Familles";
            this.Load += new System.EventHandler(this.FRM_CATEGORIE_MANAGEMENT_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_CATEGORIES)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView DGV_CATEGORIES;
        private System.Windows.Forms.Button btn_afficher;
        private System.Windows.Forms.Button btn_modifier;
        private System.Windows.Forms.Button btn_imprimer;
        private System.Windows.Forms.Button btn_supprimer;
        private System.Windows.Forms.Button btn_rechercher;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_rechercher;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.TextBox txt_nom;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}