using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PROJECT_FIN_ETUDE.BL;
using System.IO;

namespace PROJECT_FIN_ETUDE.PL
{
    public partial class FRM_ADD_PRODUCTS : Form
    {
        bool _IsUpdate;
        public FRM_ADD_PRODUCTS(bool IsUpdate)
        {
            InitializeComponent();
            this._IsUpdate = IsUpdate;
            //loading the combo box of categorie

            DataTable DTcat = CLASS_PRODUCT.sp_Fill_combo_cat();
            comboBox_famille.DataSource = DTcat;
            comboBox_famille.DisplayMember = "nom_cat";
            comboBox_famille.ValueMember = "id_cat";

            //loading the combo box of active materiel
            DataTable DTam = CLASS_PRODUCT.sp_Fill_combo_am();
            comboBox_matiereActif.DataSource = DTam;
            comboBox_matiereActif.DisplayMember = "name_am";
            comboBox_matiereActif.ValueMember = "id_am";
            //loading the combo box of scientific name
            DataTable DTsn = CLASS_PRODUCT.sp_Fill_combo_sn();
            comboBox_nomScientifique.DataSource = DTsn;
            comboBox_nomScientifique.DisplayMember = "nom_NS";
            comboBox_nomScientifique.ValueMember = "id_NS";

            if (_IsUpdate == true)
            {
                this.Text = "Modifier les infos du produit";
                button2.Text = "Modifier ";
                DataTable dt = CLASS_PRODUCT.sp_getSelectedProduct(FRM_PRODUCT_MANAGEMENT.id);
                foreach (DataRow dr in dt.Rows)
                {
                    comboBox_famille.Text = dr["nom_cat"].ToString();
                    txt_NomProduit.Text = dr["nom_p"].ToString();
                    txt_description_produit.Text = dr["desc_p"].ToString();
                    txt_prixAchat.Text = dr["buy_price"].ToString();
                    txt_prixVente.Text = dr["sell_price"].ToString();
                    comboBox_matiereActif.Text = dr["name_am"].ToString();
                    comboBox_nomScientifique.Text = dr["nom_NS"].ToString();
                    txt_barcode.Text = dr["barcode"].ToString();
                    byte[] arr = (byte[])dr["image_p"];
                    MemoryStream ms = new MemoryStream(arr);
                    pictureBox_produit.Image = Image.FromStream(ms);

                }
            }
            else
            {
                this.Name = "Ajouter";
                button2.Text = "Ajouter ";
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void txt_NomProduit_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_description_produit_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (_IsUpdate == false)
                {

                    MemoryStream ms = new MemoryStream();
                    pictureBox_produit.Image.Save(ms, pictureBox_produit.Image.RawFormat);
                    byte[] arr = ms.ToArray();
                    CLASS_PRODUCT.sp_addProduct(txt_NomProduit.Text, txt_description_produit.Text, arr, txt_prixAchat.Text, txt_prixVente.Text, (int)comboBox_famille.SelectedValue, (int)comboBox_matiereActif.SelectedValue, (int)comboBox_nomScientifique.SelectedValue, txt_barcode.Text);

                    MessageBox.Show("Le produit a était ajouter avec succée !!");

                    foreach (Control item in groupBox1.Controls)
                    {
                        if (item is TextBox)
                        {
                            item.Text = string.Empty;
                        }
                    }
                }
                else
                {
                    MemoryStream ms = new MemoryStream();
                    pictureBox_produit.Image.Save(ms, pictureBox_produit.Image.RawFormat);
                    byte[] arr = ms.ToArray();
                    CLASS_PRODUCT.sp_updateProduct((int)FRM_PRODUCT_MANAGEMENT.id, txt_NomProduit.Text, txt_description_produit.Text, arr, txt_prixAchat.Text, txt_prixVente.Text, (int)comboBox_famille.SelectedValue, (int)comboBox_matiereActif.SelectedValue, (int)comboBox_nomScientifique.SelectedValue, txt_barcode.Text);

                    MessageBox.Show("Le produit a était Modifier avec succée !!");
                    foreach (Control item in groupBox1.Controls)
                    {
                        if (item is TextBox)
                        {
                            item.Text = string.Empty;
                        }
                    }
                    this.Close();

                }
            }
            catch (Exception m)
            {

                MessageBox.Show(m.Message);
            }
           
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = "All Files |*.*|JPG|jpg|PNG|png";
                ofd.ShowDialog();
                pictureBox_produit.Image = Image.FromFile(ofd.FileName);
            }
            catch (Exception m)
            {

                MessageBox.Show(m.Message);
            }
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void sdd_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void comboBox_famille_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
