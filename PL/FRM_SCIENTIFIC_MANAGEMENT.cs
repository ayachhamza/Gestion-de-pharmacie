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
    public partial class FRM_SCIENTIFIC_MANAGEMENT : Form
    {
        public FRM_SCIENTIFIC_MANAGEMENT()
        {
            InitializeComponent();
        }

        private void btn_rechercher_Click(object sender, EventArgs e)
        {
            if (txt_rechercher.Text=="")
            {
                MessageBox.Show("inserer le mot a rechercher !!");
                return;
            }
            DataTable dt = CLASS_SCIENTIFIQUE_NAME.sp_searchScientificName(txt_rechercher.Text);
            dgv_nomSC.DataSource = dt;
        }

        private void btn_modifier_Click(object sender, EventArgs e)
        {
            if (txt_id.Text=="" && txt_nom.Text=="" )
            {
                MessageBox.Show("Selectionner un nom scientifique !!");
                return;
            }
            int i = CLASS_SCIENTIFIQUE_NAME.sp_updateScientificName(Int32.Parse(txt_id.Text), txt_nom.Text);
            btn_afficher_Click(null, null);
            MessageBox.Show("" + i + "Element est Modifier avec succée !!");
            txt_id.Text = "";
            txt_nom.Text = "";

        }

        private void btn_afficher_Click(object sender, EventArgs e)
        {
            DataTable dt = CLASS_SCIENTIFIQUE_NAME.sp_selectAllScientificName();
            dgv_nomSC.DataSource = dt;
        }

        private void btn_supprimer_Click(object sender, EventArgs e)
        {
            if (txt_id.Text == "" && txt_nom.Text == "")
            {
                MessageBox.Show("Selectionner un nom scientifique !!");
                return;
            }
            int i = CLASS_SCIENTIFIQUE_NAME.sp_deleteScientificName(Int32.Parse(txt_id.Text));
            btn_afficher_Click(null, null);
            MessageBox.Show("" + i + "Element est Supprimer avec succée !!");
            txt_id.Text = "";
            txt_nom.Text = "";
        }

        private void dgv_nomSC_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex>=0)
            {
                txt_id.Text = dgv_nomSC.Rows[e.RowIndex].Cells[0].Value.ToString();
                txt_nom.Text = dgv_nomSC.Rows[e.RowIndex].Cells[1].Value.ToString();
            }
        }
           

        private void FRM_SCIENTIFIC_MANAGEMENT_Load(object sender, EventArgs e)
        {
            btn_afficher_Click(null,null);
        }

        private void txt_rechercher_TextChanged(object sender, EventArgs e)
        {
            btn_rechercher_Click(null, null);
        }
    }
 }
