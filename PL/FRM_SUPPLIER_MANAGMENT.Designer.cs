namespace PROJECT_FIN_ETUDE.PL
{
    partial class FRM_SUPPLIER_MANAGMENT
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_rechercher = new System.Windows.Forms.TextBox();
            this.dgv_supplier = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_supplier)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgv_supplier);
            this.groupBox1.Location = new System.Drawing.Point(13, 52);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(843, 280);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Les Données:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button5);
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Tai Le", 12F);
            this.groupBox2.Location = new System.Drawing.Point(62, 347);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(755, 117);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Les operations:";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Tai Le", 12F);
            this.button1.Location = new System.Drawing.Point(32, 43);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 42);
            this.button1.TabIndex = 0;
            this.button1.Text = "Ajouter";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Tai Le", 12F);
            this.button2.Location = new System.Drawing.Point(179, 43);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(128, 42);
            this.button2.TabIndex = 1;
            this.button2.Text = "Modifier";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Tai Le", 12F);
            this.button3.Location = new System.Drawing.Point(321, 43);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(128, 42);
            this.button3.TabIndex = 2;
            this.button3.Text = "Supprimer";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Tai Le", 12F);
            this.button4.Location = new System.Drawing.Point(462, 43);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(128, 42);
            this.button4.TabIndex = 3;
            this.button4.Text = "Afficher Tous";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Tai Le", 12F);
            this.button5.Location = new System.Drawing.Point(598, 43);
            this.button5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(142, 42);
            this.button5.TabIndex = 4;
            this.button5.Text = "Envoyer Email";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 12F);
            this.label1.Location = new System.Drawing.Point(122, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Rechercher:";
            // 
            // txt_rechercher
            // 
            this.txt_rechercher.Font = new System.Drawing.Font("Microsoft Tai Le", 12F);
            this.txt_rechercher.Location = new System.Drawing.Point(224, 14);
            this.txt_rechercher.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_rechercher.Name = "txt_rechercher";
            this.txt_rechercher.Size = new System.Drawing.Size(485, 28);
            this.txt_rechercher.TabIndex = 3;
            this.txt_rechercher.TextChanged += new System.EventHandler(this.txt_rechercher_TextChanged);
            // 
            // dgv_supplier
            // 
            this.dgv_supplier.AllowUserToAddRows = false;
            this.dgv_supplier.AllowUserToDeleteRows = false;
            this.dgv_supplier.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_supplier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_supplier.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_supplier.Location = new System.Drawing.Point(4, 26);
            this.dgv_supplier.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgv_supplier.Name = "dgv_supplier";
            this.dgv_supplier.ReadOnly = true;
            this.dgv_supplier.RowHeadersVisible = false;
            this.dgv_supplier.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_supplier.Size = new System.Drawing.Size(835, 249);
            this.dgv_supplier.TabIndex = 0;
            this.dgv_supplier.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_supplier_CellContentClick);
            // 
            // FRM_SUPPLIER_MANAGMENT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 502);
            this.Controls.Add(this.txt_rechercher);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Tai Le", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FRM_SUPPLIER_MANAGMENT";
            this.Text = "FRM_SUPPLIER_MANAGMENT";
            this.Activated += new System.EventHandler(this.FRM_SUPPLIER_MANAGMENT_Activated);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_supplier)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgv_supplier;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_rechercher;
    }
}