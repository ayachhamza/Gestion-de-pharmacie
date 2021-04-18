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
    public partial class FRM_SUPPLIER_MANAGMENT : Form
    {
        public FRM_SUPPLIER_MANAGMENT()
        {
            InitializeComponent();
            button4_Click(null, null);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FRM_ADD_NEW_SUPPLIER ajo = new FRM_ADD_NEW_SUPPLIER(true);
            ajo.ShowDialog();
        }
        public static int id;
        private void button2_Click(object sender, EventArgs e)
        {
            id = int.Parse(dgv_supplier.SelectedRows[0].Cells[0].Value.ToString());
            FRM_ADD_NEW_SUPPLIER mod = new FRM_ADD_NEW_SUPPLIER(false);
            mod.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DataTable dt = CLASS_SUPPLIER.sp_select_supplier();
            dgv_supplier.DataSource = dt;
        }

        private void txt_rechercher_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = CLASS_SUPPLIER.sp_search_supplier(txt_rechercher.Text);
            dgv_supplier.DataSource = dt;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            id = int.Parse(dgv_supplier.SelectedRows[0].Cells[0].Value.ToString());
            CLASS_SUPPLIER.sp_delete_supplier(id);
            MessageBox.Show("supprimer avec succes !!");
        }

        private void dgv_supplier_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FRM_SUPPLIER_MANAGMENT_Activated(object sender, EventArgs e)
        {
            button4_Click(null, null);
        }
    }
}
