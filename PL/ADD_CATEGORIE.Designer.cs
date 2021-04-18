namespace PROJECT_FIN_ETUDE.PL
{
    partial class ADD_CATEGORIE
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
            this.txt_famille = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_ajouter = new System.Windows.Forms.Button();
            this.btn_annuler = new System.Windows.Forms.Button();
            this.gunaControlBox1 = new Guna.UI.WinForms.GunaControlBox();
            this.SuspendLayout();
            // 
            // txt_famille
            // 
            this.txt_famille.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_famille.Font = new System.Drawing.Font("Sitka Small", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_famille.Location = new System.Drawing.Point(412, 110);
            this.txt_famille.Multiline = true;
            this.txt_famille.Name = "txt_famille";
            this.txt_famille.Size = new System.Drawing.Size(218, 30);
            this.txt_famille.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(316, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Famille :";
            // 
            // btn_ajouter
            // 
            this.btn_ajouter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_ajouter.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ajouter.Location = new System.Drawing.Point(359, 183);
            this.btn_ajouter.Name = "btn_ajouter";
            this.btn_ajouter.Size = new System.Drawing.Size(136, 43);
            this.btn_ajouter.TabIndex = 2;
            this.btn_ajouter.Text = "Ajouter";
            this.btn_ajouter.UseVisualStyleBackColor = true;
            this.btn_ajouter.Click += new System.EventHandler(this.btn_ajouter_Click);
            // 
            // btn_annuler
            // 
            this.btn_annuler.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_annuler.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_annuler.Location = new System.Drawing.Point(514, 183);
            this.btn_annuler.Name = "btn_annuler";
            this.btn_annuler.Size = new System.Drawing.Size(136, 43);
            this.btn_annuler.TabIndex = 3;
            this.btn_annuler.Text = "Annuler";
            this.btn_annuler.UseVisualStyleBackColor = true;
            this.btn_annuler.Click += new System.EventHandler(this.btn_annuler_Click);
            // 
            // gunaControlBox1
            // 
            this.gunaControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaControlBox1.AnimationHoverSpeed = 0.07F;
            this.gunaControlBox1.AnimationSpeed = 0.03F;
            this.gunaControlBox1.IconColor = System.Drawing.Color.Black;
            this.gunaControlBox1.IconSize = 15F;
            this.gunaControlBox1.Location = new System.Drawing.Point(980, 2);
            this.gunaControlBox1.Name = "gunaControlBox1";
            this.gunaControlBox1.OnHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            this.gunaControlBox1.OnHoverIconColor = System.Drawing.Color.White;
            this.gunaControlBox1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaControlBox1.Size = new System.Drawing.Size(45, 29);
            this.gunaControlBox1.TabIndex = 14;
            this.gunaControlBox1.Click += new System.EventHandler(this.gunaControlBox1_Click);
            // 
            // ADD_CATEGORIE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 429);
            this.Controls.Add(this.gunaControlBox1);
            this.Controls.Add(this.btn_annuler);
            this.Controls.Add(this.btn_ajouter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_famille);
            this.Name = "ADD_CATEGORIE";
            this.Text = "ADD_CATEGORIE";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_famille;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_ajouter;
        private System.Windows.Forms.Button btn_annuler;
        private Guna.UI.WinForms.GunaControlBox gunaControlBox1;
    }
}