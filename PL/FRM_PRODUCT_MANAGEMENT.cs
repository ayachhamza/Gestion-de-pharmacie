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
using System.Data.SqlClient;
using System.IO;
using CrystalDecisions.Shared;

namespace PROJECT_FIN_ETUDE.PL
{
    public partial class FRM_PRODUCT_MANAGEMENT : Form
    {
        public FRM_PRODUCT_MANAGEMENT()
        {
            InitializeComponent();
            btn_afficher_Click(null, null);
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btn_afficher_Click(object sender, EventArgs e)
        {
            
            DataTable dt = CLASS_PRODUCT.sp_selectAllProducts();
            dgv_products.Rows.Clear();
            foreach (DataRow dr in dt.Rows)
            {
                dgv_products.Rows.Add(dr[0], dr[1], dr[2], dr[3], dr[4], dr[5], dr[6], dr[7],dr[8],dr[9]);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = CLASS_PRODUCT.sp_searchProduct(textBox1.Text);
            dgv_products.Rows.Clear();
            foreach (DataRow dr in dt.Rows)
            {
                dgv_products.Rows.Add(dr[0], dr[1], dr[2], dr[3], dr[4], dr[5], dr[6], dr[7], dr[8], dr[9]);
            }
        }

        private void btn_image_Click(object sender, EventArgs e)
        {
            byte[] arr= CLASS_PRODUCT.sp_getImage(int.Parse(dgv_products.SelectedRows[0].Cells[0].Value.ToString()));
            MemoryStream ms = new MemoryStream(arr);
            FRM_PRODUCT_IMAGE frm = new FRM_PRODUCT_IMAGE();
            frm.pic_image.Image = Image.FromStream(ms);
            frm.ShowDialog();
            
        }

        private void btn_validite_Click(object sender, EventArgs e)
        {
            DataTable dt = CLASS_PRODUCT.sp_expireDate(int.Parse(dgv_products.SelectedRows[0].Cells[0].Value.ToString()));
            if (dt.Rows.Count > 0)
            {
                FRM_EXPIRE_DATE frm = new FRM_EXPIRE_DATE();
                frm.DGV_PRODUCT_EXPIRE_DATE.DataSource = dt;
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("La validité de ce produit n'existe pas !!");
            }
        }
            public static int id;
        private void btn_supprimer_Click(object sender, EventArgs e)
        {

            id = int.Parse(dgv_products.SelectedRows[0].Cells[0].Value.ToString());

            DialogResult dr = MessageBox.Show("Voukez-vous vraiment supprimer ce produit ?", "Confirmation !", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
            if (dr==System.Windows.Forms.DialogResult.Yes)
            {
                CLASS_PRODUCT.sp_deletProduct(id);
                MessageBox.Show("Le produits a était supprimer avec succée !!");
                btn_afficher_Click(null, null);
            }
                
            
        }

        private void FRM_PRODUCT_MANAGEMENT_Activated(object sender, EventArgs e)
        {
            btn_afficher_Click(null, null);
        }

        public static bool isUpdate_insert = false;

        private void btn_ajouter_Click(object sender, EventArgs e)
        {
            new FRM_ADD_PRODUCTS(false).ShowDialog();
        }

        private void btn_modifier_Click(object sender, EventArgs e)
        {
            new FRM_ADD_PRODUCTS(true).ShowDialog();
            id = int.Parse(dgv_products.SelectedRows[0].Cells[0].Value.ToString());
            btn_afficher_Click(null,null);

        }

        private void FRM_PRODUCT_MANAGEMENT_Load(object sender, EventArgs e)
        {

        }

        private void btn_imprimer_element_Click(object sender, EventArgs e)
        {
            RPT.FRM_REPORTS frm = new RPT.FRM_REPORTS();
            RPT.Print_select_product pro1 = new RPT.Print_select_product();
            pro1.SetParameterValue("@id", dgv_products.SelectedRows[0].Cells[0].Value);
            frm.crystalReportViewer1.ReportSource = pro1;
            frm.ShowDialog();

        }

        private void btn_imprimer_Click(object sender, EventArgs e)
        {
            RPT.FRM_REPORTS frm = new RPT.FRM_REPORTS();
            RPT.RPT_ALL_PRODUCTS pro = new RPT.RPT_ALL_PRODUCTS();
            frm.crystalReportViewer1.ReportSource = pro;
            frm.ShowDialog();
        }

       
        private void btn_sauvgarder_Click(object sender, EventArgs e)
        {
            if (txt_save_name.Text!="")
            {
                RPT.RPT_ALL_PRODUCTS report = new RPT.RPT_ALL_PRODUCTS();
                DiskFileDestinationOptions Destination = new DiskFileDestinationOptions();
                Destination.DiskFileName = @"C:\Users\Hamza's Laptop\OneDrive\Documents\"+ txt_save_name.Text + ".xls";
                ExcelFormatOptions excelFormat = new ExcelFormatOptions();

                ExportOptions export = new ExportOptions();
                export = report.ExportOptions;
                export.ExportDestinationType = ExportDestinationType.DiskFile;
                export.ExportFormatType = ExportFormatType.Excel;
                export.ExportDestinationOptions = Destination;
                export.ExportFormatOptions = excelFormat;
                report.Export();
                MessageBox.Show("raport est Sauvgarder avec succée !!");
                txt_save_name.Text = "";
            }
            else
            {
                MessageBox.Show("Veuiller saisie le nom de fichier a sauvgarder !!");
                return;
            }
            
        }
    }
}
