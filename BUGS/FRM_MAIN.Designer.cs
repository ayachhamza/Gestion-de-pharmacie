namespace PROJECT_FIN_ETUDE.PL
{
    partial class FRM_MAIN
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.gunaControlBox1 = new Guna.UI.WinForms.GunaControlBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Main_panel = new System.Windows.Forms.Panel();
            this.panel_slide = new System.Windows.Forms.Panel();
            this.TSMUsers = new System.Windows.Forms.Button();
            this.TSMSupplier = new System.Windows.Forms.Button();
            this.TSMClients = new System.Windows.Forms.Button();
            this.TSMProducts = new System.Windows.Forms.Button();
            this.TSMFile = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.TMSrestore = new System.Windows.Forms.Button();
            this.TMSbackup = new System.Windows.Forms.Button();
            this.TSMlogout = new System.Windows.Forms.Button();
            this.TSMlogin = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.TMSAddType = new System.Windows.Forms.Button();
            this.TMStypesManage = new System.Windows.Forms.Button();
            this.TMSaddProduct = new System.Windows.Forms.Button();
            this.TMSproductManage = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.TMSaddSell = new System.Windows.Forms.Button();
            this.TMSbuymanage = new System.Windows.Forms.Button();
            this.TMSclientsAdd = new System.Windows.Forms.Button();
            this.TMSClientsManage = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.TMSSellAdd = new System.Windows.Forms.Button();
            this.TMSSellManage = new System.Windows.Forms.Button();
            this.TMSSupplierAdd = new System.Windows.Forms.Button();
            this.TMSsupplierManage = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.TMSUserAdd = new System.Windows.Forms.Button();
            this.TMUserManage = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.Main_panel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(225)))), ((int)(((byte)(121)))));
            this.panel1.Controls.Add(this.gunaControlBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1010, 30);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // gunaControlBox1
            // 
            this.gunaControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaControlBox1.AnimationHoverSpeed = 0.07F;
            this.gunaControlBox1.AnimationSpeed = 0.03F;
            this.gunaControlBox1.IconColor = System.Drawing.Color.Black;
            this.gunaControlBox1.IconSize = 15F;
            this.gunaControlBox1.Location = new System.Drawing.Point(965, -3);
            this.gunaControlBox1.Name = "gunaControlBox1";
            this.gunaControlBox1.OnHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            this.gunaControlBox1.OnHoverIconColor = System.Drawing.Color.White;
            this.gunaControlBox1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaControlBox1.Size = new System.Drawing.Size(45, 29);
            this.gunaControlBox1.TabIndex = 13;
            this.gunaControlBox1.Click += new System.EventHandler(this.gunaControlBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(117)))), ((int)(((byte)(109)))));
            this.label1.Location = new System.Drawing.Point(412, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gestion Pharmacie";
            // 
            // Main_panel
            // 
            this.Main_panel.BackColor = System.Drawing.Color.SeaGreen;
            this.Main_panel.Controls.Add(this.panel_slide);
            this.Main_panel.Controls.Add(this.TSMUsers);
            this.Main_panel.Controls.Add(this.TSMSupplier);
            this.Main_panel.Controls.Add(this.TSMClients);
            this.Main_panel.Controls.Add(this.TSMProducts);
            this.Main_panel.Controls.Add(this.TSMFile);
            this.Main_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.Main_panel.Location = new System.Drawing.Point(0, 30);
            this.Main_panel.Name = "Main_panel";
            this.Main_panel.Size = new System.Drawing.Size(1010, 39);
            this.Main_panel.TabIndex = 3;
            // 
            // panel_slide
            // 
            this.panel_slide.BackColor = System.Drawing.Color.White;
            this.panel_slide.Location = new System.Drawing.Point(1, -1);
            this.panel_slide.Name = "panel_slide";
            this.panel_slide.Size = new System.Drawing.Size(187, 6);
            this.panel_slide.TabIndex = 4;
            // 
            // TSMUsers
            // 
            this.TSMUsers.FlatAppearance.BorderSize = 0;
            this.TSMUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TSMUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TSMUsers.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TSMUsers.Location = new System.Drawing.Point(772, 0);
            this.TSMUsers.Name = "TSMUsers";
            this.TSMUsers.Size = new System.Drawing.Size(187, 40);
            this.TSMUsers.TabIndex = 4;
            this.TSMUsers.Text = "Utilisateurs";
            this.TSMUsers.UseVisualStyleBackColor = true;
            this.TSMUsers.Click += new System.EventHandler(this.TSMUsers_Click_1);
            this.TSMUsers.MouseLeave += new System.EventHandler(this.TSMUsers_MouseLeave);
            this.TSMUsers.MouseHover += new System.EventHandler(this.TSMUsers_MouseHover);
            // 
            // TSMSupplier
            // 
            this.TSMSupplier.FlatAppearance.BorderSize = 0;
            this.TSMSupplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TSMSupplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TSMSupplier.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TSMSupplier.Location = new System.Drawing.Point(579, 0);
            this.TSMSupplier.Name = "TSMSupplier";
            this.TSMSupplier.Size = new System.Drawing.Size(187, 40);
            this.TSMSupplier.TabIndex = 3;
            this.TSMSupplier.Text = "Fournisseurs";
            this.TSMSupplier.UseVisualStyleBackColor = true;
            this.TSMSupplier.Click += new System.EventHandler(this.TSMSupplier_Click);
            this.TSMSupplier.MouseLeave += new System.EventHandler(this.TSMSupplier_MouseLeave);
            this.TSMSupplier.MouseHover += new System.EventHandler(this.TSMSupplier_MouseHover);
            // 
            // TSMClients
            // 
            this.TSMClients.FlatAppearance.BorderSize = 0;
            this.TSMClients.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TSMClients.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TSMClients.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TSMClients.Location = new System.Drawing.Point(386, 0);
            this.TSMClients.Name = "TSMClients";
            this.TSMClients.Size = new System.Drawing.Size(187, 40);
            this.TSMClients.TabIndex = 2;
            this.TSMClients.Text = "Clientes";
            this.TSMClients.UseVisualStyleBackColor = true;
            this.TSMClients.Click += new System.EventHandler(this.TSMClients_Click);
            this.TSMClients.MouseLeave += new System.EventHandler(this.TSMClients_MouseLeave);
            this.TSMClients.MouseHover += new System.EventHandler(this.TSMClients_MouseHover);
            // 
            // TSMProducts
            // 
            this.TSMProducts.FlatAppearance.BorderSize = 0;
            this.TSMProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TSMProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TSMProducts.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TSMProducts.Location = new System.Drawing.Point(193, 0);
            this.TSMProducts.Name = "TSMProducts";
            this.TSMProducts.Size = new System.Drawing.Size(187, 40);
            this.TSMProducts.TabIndex = 1;
            this.TSMProducts.Text = "Produits";
            this.TSMProducts.UseVisualStyleBackColor = true;
            this.TSMProducts.Click += new System.EventHandler(this.TSMProducts_Click);
            this.TSMProducts.MouseLeave += new System.EventHandler(this.TSMProducts_MouseLeave);
            this.TSMProducts.MouseHover += new System.EventHandler(this.TSMProducts_MouseHover);
            // 
            // TSMFile
            // 
            this.TSMFile.FlatAppearance.BorderSize = 0;
            this.TSMFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TSMFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TSMFile.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TSMFile.Location = new System.Drawing.Point(0, -1);
            this.TSMFile.Name = "TSMFile";
            this.TSMFile.Size = new System.Drawing.Size(187, 40);
            this.TSMFile.TabIndex = 0;
            this.TSMFile.Text = "Fichier";
            this.TSMFile.UseVisualStyleBackColor = true;
            this.TSMFile.Click += new System.EventHandler(this.TSMFile_Click);
            this.TSMFile.MouseLeave += new System.EventHandler(this.TSMFile_MouseLeave);
            this.TSMFile.MouseHover += new System.EventHandler(this.TSMFile_MouseHover);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SeaGreen;
            this.panel2.Controls.Add(this.TMSrestore);
            this.panel2.Controls.Add(this.TMSbackup);
            this.panel2.Controls.Add(this.TSMlogout);
            this.panel2.Controls.Add(this.TSMlogin);
            this.panel2.Location = new System.Drawing.Point(1, 69);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(187, 190);
            this.panel2.TabIndex = 4;
            this.panel2.MouseEnter += new System.EventHandler(this.panel2_MouseEnter);
            this.panel2.MouseLeave += new System.EventHandler(this.panel2_MouseLeave);
            this.panel2.MouseHover += new System.EventHandler(this.panel2_MouseHover);
            // 
            // TMSrestore
            // 
            this.TMSrestore.FlatAppearance.BorderSize = 0;
            this.TMSrestore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TMSrestore.Font = new System.Drawing.Font("Microsoft YaHei Light", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TMSrestore.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TMSrestore.Location = new System.Drawing.Point(0, 140);
            this.TMSrestore.Name = "TMSrestore";
            this.TMSrestore.Size = new System.Drawing.Size(187, 40);
            this.TMSrestore.TabIndex = 8;
            this.TMSrestore.Text = "Restore";
            this.TMSrestore.UseVisualStyleBackColor = true;
            this.TMSrestore.Click += new System.EventHandler(this.button4_Click);
            // 
            // TMSbackup
            // 
            this.TMSbackup.FlatAppearance.BorderSize = 0;
            this.TMSbackup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TMSbackup.Font = new System.Drawing.Font("Microsoft YaHei Light", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TMSbackup.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TMSbackup.Location = new System.Drawing.Point(0, 94);
            this.TMSbackup.Name = "TMSbackup";
            this.TMSbackup.Size = new System.Drawing.Size(187, 40);
            this.TMSbackup.TabIndex = 7;
            this.TMSbackup.Text = "Backup";
            this.TMSbackup.UseVisualStyleBackColor = true;
            // 
            // TSMlogout
            // 
            this.TSMlogout.FlatAppearance.BorderSize = 0;
            this.TSMlogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TSMlogout.Font = new System.Drawing.Font("Microsoft YaHei Light", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TSMlogout.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TSMlogout.Location = new System.Drawing.Point(0, 48);
            this.TSMlogout.Name = "TSMlogout";
            this.TSMlogout.Size = new System.Drawing.Size(187, 40);
            this.TSMlogout.TabIndex = 6;
            this.TSMlogout.Text = "Deconnecter";
            this.TSMlogout.UseVisualStyleBackColor = true;
            // 
            // TSMlogin
            // 
            this.TSMlogin.FlatAppearance.BorderSize = 0;
            this.TSMlogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TSMlogin.Font = new System.Drawing.Font("Microsoft YaHei Light", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TSMlogin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TSMlogin.Location = new System.Drawing.Point(0, 2);
            this.TSMlogin.Name = "TSMlogin";
            this.TSMlogin.Size = new System.Drawing.Size(187, 40);
            this.TSMlogin.TabIndex = 5;
            this.TSMlogin.Text = "Connecter";
            this.TSMlogin.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.SeaGreen;
            this.panel3.Controls.Add(this.TMSAddType);
            this.panel3.Controls.Add(this.TMStypesManage);
            this.panel3.Controls.Add(this.TMSaddProduct);
            this.panel3.Controls.Add(this.TMSproductManage);
            this.panel3.Location = new System.Drawing.Point(193, 69);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(187, 190);
            this.panel3.TabIndex = 9;
            this.panel3.MouseEnter += new System.EventHandler(this.panel3_MouseEnter);
            this.panel3.MouseLeave += new System.EventHandler(this.panel3_MouseLeave);
            // 
            // TMSAddType
            // 
            this.TMSAddType.FlatAppearance.BorderSize = 0;
            this.TMSAddType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TMSAddType.Font = new System.Drawing.Font("Microsoft YaHei Light", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TMSAddType.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TMSAddType.Location = new System.Drawing.Point(0, 140);
            this.TMSAddType.Name = "TMSAddType";
            this.TMSAddType.Size = new System.Drawing.Size(187, 40);
            this.TMSAddType.TabIndex = 8;
            this.TMSAddType.Text = "Ajouter Famille";
            this.TMSAddType.UseVisualStyleBackColor = true;
            // 
            // TMStypesManage
            // 
            this.TMStypesManage.FlatAppearance.BorderSize = 0;
            this.TMStypesManage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TMStypesManage.Font = new System.Drawing.Font("Microsoft YaHei Light", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TMStypesManage.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TMStypesManage.Location = new System.Drawing.Point(0, 94);
            this.TMStypesManage.Name = "TMStypesManage";
            this.TMStypesManage.Size = new System.Drawing.Size(187, 40);
            this.TMStypesManage.TabIndex = 7;
            this.TMStypesManage.Text = "Gestion Famille";
            this.TMStypesManage.UseVisualStyleBackColor = true;
            // 
            // TMSaddProduct
            // 
            this.TMSaddProduct.FlatAppearance.BorderSize = 0;
            this.TMSaddProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TMSaddProduct.Font = new System.Drawing.Font("Microsoft YaHei Light", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TMSaddProduct.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TMSaddProduct.Location = new System.Drawing.Point(0, 48);
            this.TMSaddProduct.Name = "TMSaddProduct";
            this.TMSaddProduct.Size = new System.Drawing.Size(187, 40);
            this.TMSaddProduct.TabIndex = 6;
            this.TMSaddProduct.Text = "Ajouter Produit";
            this.TMSaddProduct.UseVisualStyleBackColor = true;
            this.TMSaddProduct.Click += new System.EventHandler(this.TMSaddProduct_Click);
            // 
            // TMSproductManage
            // 
            this.TMSproductManage.FlatAppearance.BorderSize = 0;
            this.TMSproductManage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TMSproductManage.Font = new System.Drawing.Font("Microsoft YaHei Light", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TMSproductManage.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TMSproductManage.Location = new System.Drawing.Point(0, 2);
            this.TMSproductManage.Name = "TMSproductManage";
            this.TMSproductManage.Size = new System.Drawing.Size(187, 40);
            this.TMSproductManage.TabIndex = 5;
            this.TMSproductManage.Text = "Gestion Produits";
            this.TMSproductManage.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.SeaGreen;
            this.panel4.Controls.Add(this.TMSaddSell);
            this.panel4.Controls.Add(this.TMSbuymanage);
            this.panel4.Controls.Add(this.TMSclientsAdd);
            this.panel4.Controls.Add(this.TMSClientsManage);
            this.panel4.Location = new System.Drawing.Point(386, 68);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(187, 190);
            this.panel4.TabIndex = 10;
            this.panel4.MouseEnter += new System.EventHandler(this.panel4_MouseEnter);
            this.panel4.MouseLeave += new System.EventHandler(this.panel4_MouseLeave);
            this.panel4.MouseHover += new System.EventHandler(this.panel4_MouseHover);
            // 
            // TMSaddSell
            // 
            this.TMSaddSell.FlatAppearance.BorderSize = 0;
            this.TMSaddSell.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TMSaddSell.Font = new System.Drawing.Font("Microsoft YaHei Light", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TMSaddSell.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TMSaddSell.Location = new System.Drawing.Point(0, 140);
            this.TMSaddSell.Name = "TMSaddSell";
            this.TMSaddSell.Size = new System.Drawing.Size(187, 40);
            this.TMSaddSell.TabIndex = 8;
            this.TMSaddSell.Text = "Nouvelle vente";
            this.TMSaddSell.UseVisualStyleBackColor = true;
            // 
            // TMSbuymanage
            // 
            this.TMSbuymanage.FlatAppearance.BorderSize = 0;
            this.TMSbuymanage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TMSbuymanage.Font = new System.Drawing.Font("Microsoft YaHei Light", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TMSbuymanage.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TMSbuymanage.Location = new System.Drawing.Point(0, 94);
            this.TMSbuymanage.Name = "TMSbuymanage";
            this.TMSbuymanage.Size = new System.Drawing.Size(187, 40);
            this.TMSbuymanage.TabIndex = 7;
            this.TMSbuymanage.Text = "Gestion Ventes";
            this.TMSbuymanage.UseVisualStyleBackColor = true;
            // 
            // TMSclientsAdd
            // 
            this.TMSclientsAdd.FlatAppearance.BorderSize = 0;
            this.TMSclientsAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TMSclientsAdd.Font = new System.Drawing.Font("Microsoft YaHei Light", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TMSclientsAdd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TMSclientsAdd.Location = new System.Drawing.Point(0, 48);
            this.TMSclientsAdd.Name = "TMSclientsAdd";
            this.TMSclientsAdd.Size = new System.Drawing.Size(187, 40);
            this.TMSclientsAdd.TabIndex = 6;
            this.TMSclientsAdd.Text = "Ajouter Client";
            this.TMSclientsAdd.UseVisualStyleBackColor = true;
            // 
            // TMSClientsManage
            // 
            this.TMSClientsManage.FlatAppearance.BorderSize = 0;
            this.TMSClientsManage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TMSClientsManage.Font = new System.Drawing.Font("Microsoft YaHei Light", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TMSClientsManage.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TMSClientsManage.Location = new System.Drawing.Point(0, 2);
            this.TMSClientsManage.Name = "TMSClientsManage";
            this.TMSClientsManage.Size = new System.Drawing.Size(187, 40);
            this.TMSClientsManage.TabIndex = 5;
            this.TMSClientsManage.Text = "Gestion Clientes";
            this.TMSClientsManage.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.SeaGreen;
            this.panel5.Controls.Add(this.TMSSellAdd);
            this.panel5.Controls.Add(this.TMSSellManage);
            this.panel5.Controls.Add(this.TMSSupplierAdd);
            this.panel5.Controls.Add(this.TMSsupplierManage);
            this.panel5.Location = new System.Drawing.Point(579, 68);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(187, 190);
            this.panel5.TabIndex = 11;
            this.panel5.MouseEnter += new System.EventHandler(this.panel5_MouseEnter);
            this.panel5.MouseLeave += new System.EventHandler(this.panel5_MouseLeave);
            // 
            // TMSSellAdd
            // 
            this.TMSSellAdd.FlatAppearance.BorderSize = 0;
            this.TMSSellAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TMSSellAdd.Font = new System.Drawing.Font("Microsoft YaHei Light", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TMSSellAdd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TMSSellAdd.Location = new System.Drawing.Point(0, 140);
            this.TMSSellAdd.Name = "TMSSellAdd";
            this.TMSSellAdd.Size = new System.Drawing.Size(187, 40);
            this.TMSSellAdd.TabIndex = 8;
            this.TMSSellAdd.Text = "Nouvel achat";
            this.TMSSellAdd.UseVisualStyleBackColor = true;
            // 
            // TMSSellManage
            // 
            this.TMSSellManage.FlatAppearance.BorderSize = 0;
            this.TMSSellManage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TMSSellManage.Font = new System.Drawing.Font("Microsoft YaHei Light", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TMSSellManage.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TMSSellManage.Location = new System.Drawing.Point(0, 94);
            this.TMSSellManage.Name = "TMSSellManage";
            this.TMSSellManage.Size = new System.Drawing.Size(187, 40);
            this.TMSSellManage.TabIndex = 7;
            this.TMSSellManage.Text = "Gestion des Achats";
            this.TMSSellManage.UseVisualStyleBackColor = true;
            // 
            // TMSSupplierAdd
            // 
            this.TMSSupplierAdd.FlatAppearance.BorderSize = 0;
            this.TMSSupplierAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TMSSupplierAdd.Font = new System.Drawing.Font("Microsoft YaHei Light", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TMSSupplierAdd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TMSSupplierAdd.Location = new System.Drawing.Point(0, 48);
            this.TMSSupplierAdd.Name = "TMSSupplierAdd";
            this.TMSSupplierAdd.Size = new System.Drawing.Size(187, 40);
            this.TMSSupplierAdd.TabIndex = 6;
            this.TMSSupplierAdd.Text = "Ajouter Fournisseur";
            this.TMSSupplierAdd.UseVisualStyleBackColor = true;
            // 
            // TMSsupplierManage
            // 
            this.TMSsupplierManage.FlatAppearance.BorderSize = 0;
            this.TMSsupplierManage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TMSsupplierManage.Font = new System.Drawing.Font("Microsoft YaHei Light", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TMSsupplierManage.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TMSsupplierManage.Location = new System.Drawing.Point(0, 2);
            this.TMSsupplierManage.Name = "TMSsupplierManage";
            this.TMSsupplierManage.Size = new System.Drawing.Size(187, 40);
            this.TMSsupplierManage.TabIndex = 5;
            this.TMSsupplierManage.Text = "Gestion Fournisseurs";
            this.TMSsupplierManage.UseVisualStyleBackColor = true;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.SeaGreen;
            this.panel6.Controls.Add(this.TMSUserAdd);
            this.panel6.Controls.Add(this.TMUserManage);
            this.panel6.Location = new System.Drawing.Point(772, 68);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(187, 102);
            this.panel6.TabIndex = 12;
            this.panel6.MouseEnter += new System.EventHandler(this.panel6_MouseEnter);
            this.panel6.MouseLeave += new System.EventHandler(this.panel6_MouseLeave);
            // 
            // TMSUserAdd
            // 
            this.TMSUserAdd.FlatAppearance.BorderSize = 0;
            this.TMSUserAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TMSUserAdd.Font = new System.Drawing.Font("Microsoft YaHei Light", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TMSUserAdd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TMSUserAdd.Location = new System.Drawing.Point(0, 48);
            this.TMSUserAdd.Name = "TMSUserAdd";
            this.TMSUserAdd.Size = new System.Drawing.Size(187, 40);
            this.TMSUserAdd.TabIndex = 6;
            this.TMSUserAdd.Text = "Ajouter Utilisateur";
            this.TMSUserAdd.UseVisualStyleBackColor = true;
            // 
            // TMUserManage
            // 
            this.TMUserManage.FlatAppearance.BorderSize = 0;
            this.TMUserManage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TMUserManage.Font = new System.Drawing.Font("Microsoft YaHei Light", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TMUserManage.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TMUserManage.Location = new System.Drawing.Point(0, 2);
            this.TMUserManage.Name = "TMUserManage";
            this.TMUserManage.Size = new System.Drawing.Size(187, 40);
            this.TMUserManage.TabIndex = 5;
            this.TMUserManage.Text = "Gestion Utilisateurs";
            this.TMUserManage.UseVisualStyleBackColor = true;
            // 
            // FRM_MAIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1010, 536);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.Main_panel);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Name = "FRM_MAIN";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestion des ventes ";
            this.Load += new System.EventHandler(this.FRM_MAIN_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.Main_panel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaControlBox gunaControlBox1;
        private System.Windows.Forms.Panel Main_panel;
        private System.Windows.Forms.Panel panel_slide;
        private System.Windows.Forms.Button TSMUsers;
        private System.Windows.Forms.Button TSMSupplier;
        private System.Windows.Forms.Button TSMClients;
        private System.Windows.Forms.Button TSMProducts;
        private System.Windows.Forms.Button TSMFile;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button TMSrestore;
        private System.Windows.Forms.Button TMSbackup;
        private System.Windows.Forms.Button TSMlogout;
        private System.Windows.Forms.Button TSMlogin;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button TMSAddType;
        private System.Windows.Forms.Button TMStypesManage;
        private System.Windows.Forms.Button TMSaddProduct;
        private System.Windows.Forms.Button TMSproductManage;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button TMSaddSell;
        private System.Windows.Forms.Button TMSbuymanage;
        private System.Windows.Forms.Button TMSclientsAdd;
        private System.Windows.Forms.Button TMSClientsManage;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button TMSSellAdd;
        private System.Windows.Forms.Button TMSSellManage;
        private System.Windows.Forms.Button TMSSupplierAdd;
        private System.Windows.Forms.Button TMSsupplierManage;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button TMSUserAdd;
        private System.Windows.Forms.Button TMUserManage;
    }
}