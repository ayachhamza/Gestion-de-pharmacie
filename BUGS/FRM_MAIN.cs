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
    
    public partial class FRM_MAIN : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();


        public FRM_MAIN()
        {
            InitializeComponent();
        }
        public void movePanle(Control btn)
        {
            panel_slide.Width = btn.Width;
            panel_slide.Left = btn.Left;
        }

        private void gunaControlBox1_Click(object sender, EventArgs e)
        {

        }

        private void FRM_MAIN_Load(object sender, EventArgs e)
        {
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;
            panel5.Visible = false;
            panel6.Visible = false;
        }

        private void TSMFile_Click(object sender, EventArgs e)
        {
            movePanle(TSMFile);
            SelectSlide(panel2);

        }

        private void TSMProducts_Click(object sender, EventArgs e)
        {
            movePanle(TSMProducts);
            SelectSlide(panel3);
        }

        public void SelectSlide(Panel pnl)
        {
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;
            panel5.Visible = false;
            panel6.Visible = false;

            pnl.Visible = true;
        }
        private void TSMClients_Click(object sender, EventArgs e)
        {
            movePanle(TSMClients);
            SelectSlide(panel4);

        }

        private void TSMSupplier_Click(object sender, EventArgs e)
        {
            movePanle(TSMSupplier);
            SelectSlide(panel3);
        }

        private void TSMUsers_Click(object sender, EventArgs e)
        {
            movePanle(TSMUsers);
            SelectSlide(panel6);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
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

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void TSMFile_MouseHover(object sender, EventArgs e)
        {
            panel2.Visible = true;

        }

        private void TSMFile_MouseLeave(object sender, EventArgs e)
        {
           panel2.Visible = false;
        }

        private void panel2_MouseEnter(object sender, EventArgs e)
        {
            panel2.Visible = true;
        }

        private void panel2_MouseLeave(object sender, EventArgs e)
        {
            panel2.Visible = false;
        }

        private void TSMProducts_MouseHover(object sender, EventArgs e)
        {
            panel3.Visible = true;
        }

        private void TSMProducts_MouseLeave(object sender, EventArgs e)
        {
            panel3.Visible = false;
        }

        private void panel3_MouseEnter(object sender, EventArgs e)
        {
            panel3.Visible = true;
        }

        private void panel3_MouseLeave(object sender, EventArgs e)
        {
            panel3.Visible = false;
        }

        private void TSMClients_MouseHover(object sender, EventArgs e)
        {
            panel4.Visible = true;
        }

        private void TSMClients_MouseLeave(object sender, EventArgs e)
        {
            panel4.Visible = false;
        }

        private void panel4_MouseEnter(object sender, EventArgs e)
        {
            panel4.Visible = true;
        }

        private void panel4_MouseHover(object sender, EventArgs e)
        {

        }

        private void panel4_MouseLeave(object sender, EventArgs e)
        {
            panel4.Visible = false;
        }

        private void TSMSupplier_MouseHover(object sender, EventArgs e)
        {
            panel5.Visible = true;
        }

        private void TSMSupplier_MouseLeave(object sender, EventArgs e)
        {
            panel5.Visible = false;
        }

        private void panel5_MouseEnter(object sender, EventArgs e)
        {
            panel5.Visible = true;
        }

        private void panel5_MouseLeave(object sender, EventArgs e)
        {
            panel5.Visible = false;
        }

        private void TSMUsers_MouseHover(object sender, EventArgs e)
        {
            panel6.Visible = true;
        }

        private void TSMUsers_MouseLeave(object sender, EventArgs e)
        {
            panel6.Visible = false;
        }

        private void panel6_MouseEnter(object sender, EventArgs e)
        {
            panel6.Visible = true;
        }

        private void panel6_MouseLeave(object sender, EventArgs e)
        {
            panel6.Visible = false;
        }

        private void panel2_MouseHover(object sender, EventArgs e)
        {
           
        }

        private void TSMUsers_Click_1(object sender, EventArgs e)
        {
            movePanle(TSMUsers);
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;
            panel5.Visible = false;
        }

        private void TMSaddProduct_Click(object sender, EventArgs e)
        {

        }
    }
}
