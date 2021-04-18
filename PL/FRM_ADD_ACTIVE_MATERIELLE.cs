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

namespace PROJECT_FIN_ETUDE.PL
{
    public partial class FRM_ADD_ACTIVE_MATERIELLE : Form
    {
        public FRM_ADD_ACTIVE_MATERIELLE()
        {
            InitializeComponent();
        }

        private void FRM_ADD_ACTIVE_MATERIELLE_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txt_nom.Text==string.Empty && txt_desc.Text==string.Empty)
            {
                MessageBox.Show("Inserer Les information (Nom,Description) !!!");
            }
            int i = CLASS_ACTIVE_MATERIEL.sp_addActiveMateriel(txt_nom.Text, txt_desc.Text);
            MessageBox.Show("" + i + " Element Ajouter avec succée !!");
            txt_nom.Text = "";
            txt_desc.Text="";
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
