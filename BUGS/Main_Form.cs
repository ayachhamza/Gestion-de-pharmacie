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
    public partial class Main_Form : Form
    {
        public Main_Form()
        {
            InitializeComponent();
        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public void movePanle(Control btn)
        {
            panel_slide.Width = btn.Width;
            panel_slide.Left = btn.Left;
        }


        private void Main_Form_Load(object sender, EventArgs e)
        {

        }

        private void TSMFile_Click(object sender, EventArgs e)
        {
            movePanle(TSMFil);
        }

        private void TSMProducts_Click(object sender, EventArgs e)
        {
            movePanle(TSMProducts);
        }

        private void TSMClients_Click(object sender, EventArgs e)
        {
            movePanle(TSMClients);
        }

        private void TSMSupplier_Click(object sender, EventArgs e)
        {
            movePanle(TSMSupplier);
        }

        private void TSMUsers_Click(object sender, EventArgs e)
        {
            movePanle(TSMUsers);
        }

        private void TSMFil_MouseHover(object sender, EventArgs e)
        {
            panel_fichier.Visible = true;
        }

        private void TSMFil_MouseLeave(object sender, EventArgs e)
        {
            panel_fichier.Visible = false;
        }

        private void panel_fichier_MouseEnter(object sender, EventArgs e)
        {
            panel_fichier.Visible = true;
        }

        private void panel_fichier_MouseLeave(object sender, EventArgs e)
        {
            panel_fichier.Visible = false;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void TSMlogin_Click(object sender, EventArgs e)
        {

        }

        private void TMStypesManage_Click(object sender, EventArgs e)
        {

        }
    }
}
