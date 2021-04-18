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
    public partial class FRM_CATEGORIE_MANAGEMENT : Form
    {
        public FRM_CATEGORIE_MANAGEMENT()
        {
            InitializeComponent();
            btn_afficher_Click(null, null);
        }

        private void FRM_CATEGORIE_MANAGEMENT_Load(object sender, EventArgs e)
        {

        }

        private void btn_modifier_Click(object sender, EventArgs e)
        {
            if (txt_id.Text == string.Empty)
            {
                MessageBox.Show("Veuillez selectionner la famille a supprimer !!");
                return;
            }
            int i = CLASS_CATEGORIE.sp_updateCat(Int32.Parse(txt_id.Text), txt_nom.Text.ToString());
            MessageBox.Show("Modifier sur "+i+" élément avec succée !!") ;
            btn_afficher_Click(null, null);
        }

        private void btn_afficher_Click(object sender, EventArgs e)
        {
            DataTable dt =CLASS_CATEGORIE.selectAllCategorie();
            DGV_CATEGORIES.DataSource = dt;
        }

        private void DGV_CATEGORIES_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txt_id.Text = DGV_CATEGORIES.Rows[e.RowIndex].Cells[0].Value.ToString();
                txt_nom.Text = DGV_CATEGORIES.Rows[e.RowIndex].Cells[1].Value.ToString();

            }
        }

        private void btn_rechercher_Click(object sender, EventArgs e)
        {
            if (txt_rechercher.Text==string.Empty)
            {
                MessageBox.Show("Veuillez Inserer la famille a rechercher !!");
                return;
            }
            DataTable dt = CLASS_CATEGORIE.sp_searchCategorie(txt_rechercher.Text);
            DGV_CATEGORIES.DataSource = dt;

        }

        private void btn_supprimer_Click(object sender, EventArgs e)
        {
            if (txt_id.Text == string.Empty)
            {
                MessageBox.Show("Veuillez selectionner la famille a supprimer !!");
                return;
            }
            int i = CLASS_CATEGORIE.sp_deleteCat(Int32.Parse(txt_id.Text));
            MessageBox.Show("" + i + " Element a été supprimer avec succée !!");
            btn_afficher_Click(null, null);
        }

        private void btn_imprimer_Click(object sender, EventArgs e)
        {

        }

        private void DGV_CATEGORIES_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
