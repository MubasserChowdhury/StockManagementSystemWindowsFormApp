using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockManagementSystem.UI
{
    public partial class HomeUi : Form
    {
        public HomeUi()
        {
            InitializeComponent();
            activePanel.Height = homeButton.Height;
            activePanel.Top = homeButton.Top;

            timeLabel.Text = "";
            // timeLabel.Text= DateTime.Now.ToString("hh:mm:ss tt");
        }
        private void homeButton_Click(object sender, EventArgs e)
        {
            activePanel.Height = homeButton.Height;
            activePanel.Top = homeButton.Top;
        }

        private void categoryButton_Click(object sender, EventArgs e)
        {
            activePanel.Height = categoryButton.Height;
            activePanel.Top = categoryButton.Top;

            CategoryUi categoryUi=new CategoryUi();
            categoryUi.TopLevel = false;
            mainPanel.Controls.Add(categoryUi);
            categoryUi.BringToFront();
            categoryUi.Show();

        }

        private void productButton_Click(object sender, EventArgs e)
        {
            activePanel.Height = productButton.Height;
            activePanel.Top = productButton.Top;

          

        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult;
            dialogResult = MessageBox.Show(@"Are you sure, you want to exit?", @"Message Box", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }

        }

        public const int WmNclbuttondown = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void topPanel_MouseMove(object sender, MouseEventArgs e)
        {

            
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WmNclbuttondown, HT_CAPTION, 0);
            }
        }

        private void minimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

    
        


    }
}
