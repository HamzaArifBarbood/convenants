using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Management_Of_Convenants
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            frmView f = new frmView() { TopLevel = false, TopMost = false };
            btnView.IdleFillColor = Color.White;
            btnView.IdleForecolor = Color.SeaGreen;
            btnView.IdleLineColor = Color.SeaGreen;
            panel4.Controls.Clear();
            panel4.Controls.Add(f);
            f.Show();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                WindowState = FormWindowState.Normal;
            }

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            
                frmAdd f = new frmAdd() { TopLevel = false, TopMost = true };
                btnAdd.IdleFillColor = Color.White;
                btnAdd.IdleForecolor = Color.SeaGreen;
                btnAdd.IdleLineColor = Color.SeaGreen;
                btnView.IdleFillColor = Color.SeaGreen;
                btnView.IdleForecolor = Color.White;
                btnView.IdleLineColor = Color.White;
                panel4.Controls.Clear();
                panel4.Controls.Add(f);
                f.Show();


            
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            //Environment.Exit(1);
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            frmView f = new frmView() { TopLevel = false, TopMost = false };
            
            panel4.Controls.Clear();
            btnView.IdleFillColor = Color.White;
            btnView.IdleForecolor = Color.SeaGreen;
            btnView.IdleLineColor = Color.SeaGreen;
            btnAdd.IdleFillColor = Color.SeaGreen;
            btnAdd.IdleForecolor = Color.White;
            btnAdd.IdleLineColor = Color.White;
            panel4.Controls.Add(f);
            f.Show();

        }
    }
}
