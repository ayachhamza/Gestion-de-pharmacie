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
    public partial class FRM_ADD_SCIENTIFIC_NAME : Form
    {
        public FRM_ADD_SCIENTIFIC_NAME()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_annuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_ajouter_Click(object sender, EventArgs e)
        {
            if (txt_sn.Text=="")
            {
                MessageBox.Show("Inserez le nom scientifique !!");
                return;
            }
             int i =CLASS_SCIENTIFIQUE_NAME.sp_addScientificName(txt_sn.Text);
            MessageBox.Show(""+i+" Element est ajouter avec succée !!");
            txt_sn.Text = "";
        }
    }
}
