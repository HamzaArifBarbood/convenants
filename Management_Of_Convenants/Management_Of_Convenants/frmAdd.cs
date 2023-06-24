using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Management_Of_Convenants
{
    public partial class frmAdd : Form
    {
        public frmAdd()
        {
            InitializeComponent();
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuMaterialTextbox1_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuMaterialTextbox2_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            OleDbConnection cn = new OleDbConnection("Provider=MSDAORA;Data Source=orcl2;Persist Security Info=True;User ID=system ;Password=o;");

            try
            {
                if (txtName.Text != "" && txtDate.Text != "" && txtType.Text != "" && txtEmp.Text != "")
                {
                    cn.Open();
                    OleDbCommand cmd = new OleDbCommand("insert into convenants(NAME,TYPE,EMPLOYEES,DATECONV) values('" + txtName.Text + "', '" + txtType.Text + "','" + txtEmp.Text + "', to_Date('" +txtDate.Text + "'))", cn);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("تمت الإضافة");
                }
                else
                {
                    MessageBox.Show("أدخل جميع البيانات");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }
    }
}
