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
    public partial class ADD_CATEGORIE : Form
    {
        public ADD_CATEGORIE()
        {
            InitializeComponent();
        }

        private void gunaControlBox1_Click(object sender, EventArgs e)
        {

        }

        private void btn_ajouter_Click(object sender, EventArgs e)
        {
            
            if (txt_famille.Text==string.Empty)
            {
                MessageBox.Show("Inserer le Nom de la famille !!");
                return;
            }
            else
            {
               int i = PROJECT_FIN_ETUDE.BL.CLASS_CATEGORIE.sp_addCategorie(txt_famille.Text);
                MessageBox.Show("" + txt_famille.Text.ToString() + " Ajouter avec succées !");
                txt_famille.Text = "";
            }
        }

        private void btn_annuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
