﻿namespace PROJECT_FIN_ETUDE.PL
{
    partial class FRM_SCIENTIFIC_MANAGEMENT
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
            this.txt_rechercher = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_supprimer = new System.Windows.Forms.Button();
            this.btn_imprimer = new System.Windows.Forms.Button();
            this.btn_modifier = new System.Windows.Forms.Button();
            this.btn_afficher = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_nom = new System.Windows.Forms.TextBox();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgv_nomSC = new System.Windows.Forms.DataGridView();
            this.btn_rechercher = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_nomSC)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 12F);
            this.label1.Location = new System.Drawing.Point(47, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 21);
            this.label1.TabIndex = 10;
            this.label1.Text = "Le Mot a rechercher";
            // 
            // txt_rechercher
            // 
            this.txt_rechercher.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_rechercher.Font = new System.Drawing.Font("Sitka Small", 13F);
            this.txt_rechercher.Location = new System.Drawing.Point(209, 57);
            this.txt_rechercher.Name = "txt_rechercher";
            this.txt_rechercher.Size = new System.Drawing.Size(173, 29);
            this.txt_rechercher.TabIndex = 9;
            this.txt_rechercher.TextChanged += new System.EventHandler(this.txt_rechercher_TextChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox3.Controls.Add(this.btn_supprimer);
            this.groupBox3.Controls.Add(this.btn_imprimer);
            this.groupBox3.Controls.Add(this.btn_modifier);
            this.groupBox3.Controls.Add(this.btn_afficher);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox3.Location = new System.Drawing.Point(542, 197);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(407, 172);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Les operation";
            // 
            // btn_supprimer
            // 
            this.btn_supprimer.Font = new System.Drawing.Font("Microsoft Tai Le", 10F);
            this.btn_supprimer.Location = new System.Drawing.Point(218, 99);
            this.btn_supprimer.Name = "btn_supprimer";
            this.btn_supprimer.Size = new System.Drawing.Size(153, 55);
            this.btn_supprimer.TabIndex = 3;
            this.btn_supprimer.Text = "Supprimer Le nom scientifique";
            this.btn_supprimer.UseVisualStyleBackColor = true;
            this.btn_supprimer.Click += new System.EventHandler(this.btn_supprimer_Click);
            // 
            // btn_imprimer
            // 
            this.btn_imprimer.Font = new System.Drawing.Font("Microsoft Tai Le", 10F);
            this.btn_imprimer.Location = new System.Drawing.Point(52, 99);
            this.btn_imprimer.Name = "btn_imprimer";
            this.btn_imprimer.Size = new System.Drawing.Size(153, 55);
            this.btn_imprimer.TabIndex = 2;
            this.btn_imprimer.Text = "Imprimer Les nom scientifique";
            this.btn_imprimer.UseVisualStyleBackColor = true;
            // 
            // btn_modifier
            // 
            this.btn_modifier.Font = new System.Drawing.Font("Microsoft Tai Le", 10F);
            this.btn_modifier.Location = new System.Drawing.Point(52, 30);
            this.btn_modifier.Name = "btn_modifier";
            this.btn_modifier.Size = new System.Drawing.Size(153, 55);
            this.btn_modifier.TabIndex = 0;
            this.btn_modifier.Text = "Modifier Le nom scientifique";
            this.btn_modifier.UseVisualStyleBackColor = true;
            this.btn_modifier.Click += new System.EventHandler(this.btn_modifier_Click);
            // 
            // btn_afficher
            // 
            this.btn_afficher.Font = new System.Drawing.Font("Microsoft Tai Le", 10F);
            this.btn_afficher.Location = new System.Drawing.Point(218, 30);
            this.btn_afficher.Name = "btn_afficher";
            this.btn_afficher.Size = new System.Drawing.Size(153, 55);
            this.btn_afficher.TabIndex = 1;
            this.btn_afficher.Text = "Afficher Les  noms scientifique";
            this.btn_afficher.UseVisualStyleBackColor = true;
            this.btn_afficher.Click += new System.EventHandler(this.btn_afficher_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txt_nom);
            this.groupBox2.Controls.Add(this.txt_id);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox2.Location = new System.Drawing.Point(542, 38);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(421, 132);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Les Informations ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 12F);
            this.label3.Location = new System.Drawing.Point(15, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nom";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 12F);
            this.label2.Location = new System.Drawing.Point(14, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "ID Nom scientifique";
            // 
            // txt_nom
            // 
            this.txt_nom.Location = new System.Drawing.Point(166, 68);
            this.txt_nom.Name = "txt_nom";
            this.txt_nom.Size = new System.Drawing.Size(231, 28);
            this.txt_nom.TabIndex = 3;
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(166, 31);
            this.txt_id.Name = "txt_id";
            this.txt_id.ReadOnly = true;
            this.txt_id.Size = new System.Drawing.Size(231, 28);
            this.txt_id.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.dgv_nomSC);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Tai Le", 12F);
            this.groupBox1.Location = new System.Drawing.Point(55, 113);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(458, 286);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Les Noms scientifique";
            // 
            // dgv_nomSC
            // 
            this.dgv_nomSC.AllowUserToAddRows = false;
            this.dgv_nomSC.AllowUserToDeleteRows = false;
            this.dgv_nomSC.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_nomSC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_nomSC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_nomSC.Location = new System.Drawing.Point(3, 24);
            this.dgv_nomSC.Name = "dgv_nomSC";
            this.dgv_nomSC.ReadOnly = true;
            this.dgv_nomSC.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_nomSC.Size = new System.Drawing.Size(452, 259);
            this.dgv_nomSC.TabIndex = 0;
            this.dgv_nomSC.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_nomSC_CellClick);
            // 
            // btn_rechercher
            // 
            this.btn_rechercher.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_rechercher.Font = new System.Drawing.Font("Microsoft Tai Le", 10F);
            this.btn_rechercher.Location = new System.Drawing.Point(401, 47);
            this.btn_rechercher.Name = "btn_rechercher";
            this.btn_rechercher.Size = new System.Drawing.Size(113, 50);
            this.btn_rechercher.TabIndex = 5;
            this.btn_rechercher.Text = "Rechercher";
            this.btn_rechercher.UseVisualStyleBackColor = true;
            this.btn_rechercher.Click += new System.EventHandler(this.btn_rechercher_Click);
            // 
            // FRM_SCIENTIFIC_MANAGEMENT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 451);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_rechercher);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_rechercher);
            this.Name = "FRM_SCIENTIFIC_MANAGEMENT";
            this.Text = "FRM_SCIENTIFIC_MANAGEMENT";
            this.Load += new System.EventHandler(this.FRM_SCIENTIFIC_MANAGEMENT_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_nomSC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_rechercher;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_supprimer;
        private System.Windows.Forms.Button btn_imprimer;
        private System.Windows.Forms.Button btn_modifier;
        private System.Windows.Forms.Button btn_afficher;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_nom;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgv_nomSC;
        private System.Windows.Forms.Button btn_rechercher;
    }
}