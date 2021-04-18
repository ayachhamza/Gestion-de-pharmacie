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
    public partial class FRM_ACTIVE_MATERIEL_MANAGE : Form
    {
        public FRM_ACTIVE_MATERIEL_MANAGE()
        {
            InitializeComponent();
        }

        private void btn_afficher_Click(object sender, EventArgs e)
        {
           DataTable dt = CLASS_ACTIVE_MATERIEL.sp_selectAllActiveMateriel();
            dgv_matiereActif.DataSource = dt;

        }

        private void dgv_matiereActif_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >=0)
            {
                txt_id.Text = dgv_matiereActif.Rows[e.RowIndex].Cells[0].Value.ToString();
                txt_nom.Text = dgv_matiereActif.Rows[e.RowIndex].Cells[1].Value.ToString();
                txt_desc.Text = dgv_matiereActif.Rows[e.RowIndex].Cells[2].Value.ToString();
            }
        }

        private void btn_rechercher_Click(object sender, EventArgs e)
        {
            if (txt_rechercher.Text == "")
            {
                MessageBox.Show("Inserez le nom a rechercher !!");
                return;
            }
            DataTable dt = CLASS_ACTIVE_MATERIEL.sp_SearchActiveMateriel(txt_rechercher.Text);
            dgv_matiereActif.DataSource = dt;
        }

        private void btn_modifier_Click(object sender, EventArgs e)
        {
            if (txt_id.Text=="" && txt_nom.Text=="" && txt_desc.Text=="")
            {
                MessageBox.Show("selectionner un matiére actif !!");
                return;
            }
            int i = CLASS_ACTIVE_MATERIEL.sp_updateActiveMateriel(Int32.Parse(txt_id.Text), txt_nom.Text, txt_desc.Text);
            MessageBox.Show("" + i + " Element est Modifier Avec succée !!");
            btn_afficher_Click(null, null);
            txt_id.Text = "";
            txt_nom.Text = "";
            txt_desc.Text = "";
        }

        private void FRM_ACTIVE_MATERIEL_MANAGE_Load(object sender, EventArgs e)
        {
            btn_afficher_Click(null, null);
        }

        private void btn_supprimer_Click(object sender, EventArgs e)
        {
            if (txt_id.Text == "" && txt_nom.Text == "" && txt_desc.Text == "")
            {
                MessageBox.Show("selectionner un matiére actif !!");
                return;
            }
            int i = CLASS_ACTIVE_MATERIEL.sp_deleteActiveMateriel(Int32.Parse(txt_id.Text));
            MessageBox.Show("" + i + " Element est supprimer Avec succée !!");
            btn_afficher_Click(null, null);
            txt_id.Text = "";
            txt_nom.Text = "";
            txt_desc.Text = "";
        }
    }
}
