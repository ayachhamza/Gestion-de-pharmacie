using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
namespace PROJECT_FIN_ETUDE.PL
{
    public partial class FORM_USER : Form
    {
        public FORM_USER()
        {
            InitializeComponent();
            CustomizeDesign();
        }
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void CustomizeDesign()
        {
            panel_clients.Visible = false;
            panel_fichier.Visible = false;
            panel_fourn.Visible = false; 
            panel_produits.Visible = false;
            panel_user.Visible = false;
        }

        public void movePanle(Control btn)
        {
            panel_slide.Width = btn.Width;
            panel_slide.Left = btn.Left;
        }

        private void hideSubMenu()
        {
            if (panel_fichier.Visible == true)
                panel_fichier.Visible = false;
            if (panel_produits.Visible == true)
                panel_produits.Visible = false;
            if (panel_clients.Visible == true)
                panel_clients.Visible = false;
            if (panel_fourn.Visible == true)
                panel_fourn.Visible = false;
            if (panel_user.Visible == true)
                panel_user.Visible = false;
        }

        private void ShowSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            // with code below the form will behaive like a control
            childForm.TopLevel = false;
            //we remove the border of the form
            childForm.FormBorderStyle = FormBorderStyle.None;
            //set the dock propriete to fill the entire container
            childForm.Dock = DockStyle.Fill;
            //now we add the form to the list of the container panel 
            PanleChildForm.Controls.Add(childForm);
            //now we associate the container with the form panel
            PanleChildForm.Tag = childForm;
            //in my case i put a logo in the container i should bring the new from to the front 
            childForm.BringToFront();
            //finally we show the child form
            childForm.Show();

        }
        private void FORM_USER_Load(object sender, EventArgs e)
        {

        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void TSMFil_Click(object sender, EventArgs e)
        {
            movePanle(TSMFil);
            ShowSubMenu(panel_fichier);

        }

        private void TSMProducts_Click(object sender, EventArgs e)
        {
            movePanle(TSMProducts);
            ShowSubMenu(panel_produits);
        }

        private void TSMClients_Click(object sender, EventArgs e)
        {
            movePanle(TSMClients);
            ShowSubMenu(panel_clients);
        }

        private void TSMSupplier_Click(object sender, EventArgs e)
        {
            movePanle(TSMSupplier);
            ShowSubMenu(panel_fourn);
        }

        private void TSMUsers_Click(object sender, EventArgs e)
        {
            movePanle(TSMUsers);
            ShowSubMenu(panel_user);
        }
        //check if the user loggedin or no 
        public static bool check = false;
        private void TSMlogin_Click(object sender, EventArgs e)
        {
            hideSubMenu();

            LOGIN login = new LOGIN();
            login.ShowDialog();
        }

        private void TSMlogout_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            check = false;
            TSMProducts.Enabled = TSMClients.Enabled = TSMSupplier.Enabled = TSMUsers.Enabled = TMSbackup.Enabled = TMSrestore.Enabled = check;
            PanleChildForm.Controls.Clear();
            pictureBox1.BringToFront();
            pictureBox1.Show();
            PanleChildForm.Controls.Add(pictureBox1);
        }

        private void TMSbackup_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void TMSrestore_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void TMSproductManage_Click(object sender, EventArgs e)
        {
            openChildForm(new FRM_PRODUCT_MANAGEMENT());
            hideSubMenu();
        }

        private void TMSaddProduct_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            openChildForm(new FRM_ADD_PRODUCTS(false));
        }

        private void TMStypesManage_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            openChildForm(new FRM_CATEGORIE_MANAGEMENT());
        }

        private void TMSAddType_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            openChildForm(new ADD_CATEGORIE());
            
        }

        private void TMSClientsManage_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void TMSclientsAdd_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void TMSbuymanage_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void TMSaddSell_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void TMSsupplierManage_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            openChildForm(new FRM_SUPPLIER_MANAGMENT());
        }

        private void TMSSupplierAdd_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            openChildForm(new FRM_ADD_NEW_SUPPLIER(true));
        }

        private void TMSSellManage_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void TMSSellAdd_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void TMUserManage_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void TMSUserAdd_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void FORM_USER_Activated(object sender, EventArgs e)
        {
            TSMProducts.Enabled = TSMClients.Enabled = TSMSupplier.Enabled = TSMUsers.Enabled = TMSbackup.Enabled = TMSrestore.Enabled = check;
        }


        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TMSAddActifMateriel_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            openChildForm(new FRM_ADD_ACTIVE_MATERIELLE());
        }

        private void TMSmanageActifMateriel_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            openChildForm(new FRM_ACTIVE_MATERIEL_MANAGE());
        }

        private void TMSManagescientifiqueName_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            openChildForm(new FRM_SCIENTIFIC_MANAGEMENT());
        }

        private void TMSAddscientifcName_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            openChildForm(new FRM_ADD_SCIENTIFIC_NAME());
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {

        }
    }
}
