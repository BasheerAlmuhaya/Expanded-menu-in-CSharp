using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Expanded_menu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void PnlMenuGroup1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PnlMenuGroup1.Height = 25;
            PnlMenuGroup2.Height = 25;

            btnMenuGroup1.Image = Properties.Resources.down;
            btnMenuGroup2.Image = Properties.Resources.down;

            PnlMenuGroup2.Top = PnlMenuGroup1.Bottom + 1;
        }

        private void btnMenuGroup1_Click(object sender, EventArgs e)
        {
            if (PnlMenuGroup1.Height == 25)
            {
                PnlMenuGroup1.Height = (25 * 4);
                btnMenuGroup1.Image = Properties.Resources.up;
                PnlMenuGroup2.Top = PnlMenuGroup1.Bottom + 1;  
            }
            else
            {
                PnlMenuGroup1.Height = 25 ;
                btnMenuGroup1.Image = Properties.Resources.down;
                PnlMenuGroup2.Top = PnlMenuGroup1.Bottom + 1;
            }
        }

        private void btnMenuGroup2_Click(object sender, EventArgs e)
        {
            if (PnlMenuGroup2.Height == 25)
            {
                PnlMenuGroup2.Height = (25 * 4);
                btnMenuGroup2.Image = Properties.Resources.up;
                
            }
            else
            {
                PnlMenuGroup2.Height = 25;
                btnMenuGroup2.Image = Properties.Resources.down;
                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.WindowState != FormWindowState.Maximized)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            
            this.WindowState = FormWindowState.Minimized;
        }

        
    }
}
