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
    public partial class FRM_ADD_NEW_SUPPLIER : Form
    {
        bool _check;
        public FRM_ADD_NEW_SUPPLIER(bool check)
        {
            InitializeComponent();
            _check = check;
            if (_check)
            {
                btn_ajouter.Text = "Ajouter";
                txt_titre.Text = "Ajouter Fournisseur";
                this.Text = "Ajouter fournisseur";
            }
            else
            {
                btn_ajouter.Text = "Modifier";
                txt_titre.Text = "Modifier Fournisseur";
                this.Text = "Modifier fournisseur";
                DataTable dt = CLASS_SUPPLIER.sp_supplier_select_id(FRM_SUPPLIER_MANAGMENT.id);
                foreach (DataRow dr in dt.Rows)
                {
                    txt_nom.Text = dr["nom_su"].ToString();
                    txt_tele.Text = dr["mobile_sup"].ToString();
                    txt_email.Text = dr["email_sup"].ToString();
                }
            }
        }

        private void btn_ajouter_Click(object sender, EventArgs e)
        {
            if (_check)
            {
                CLASS_SUPPLIER.sp_add_new_sup(txt_nom.Text, txt_tele.Text, txt_email.Text);
                MessageBox.Show("le fournisseur a été ajouter avec succées !!");
                txt_email.Text = txt_nom.Text = txt_tele.Text = "";
            }
            else
            {
                CLASS_SUPPLIER.sp_update_supplier(FRM_SUPPLIER_MANAGMENT.id, txt_nom.Text, txt_tele.Text, txt_email.Text);
                MessageBox.Show("le fournisseur a été Modifier avec succées !!");
            }
            
        }

        private void btn_annuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void FRM_ADD_NEW_SUPPLIER_Load(object sender, EventArgs e)
        {

        }
    }
}
