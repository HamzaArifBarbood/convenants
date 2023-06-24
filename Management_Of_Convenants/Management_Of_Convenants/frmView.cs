using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Management_Of_Convenants
{
    public partial class frmView : Form
    {
        public frmView()
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

       
        void FillDataGrid()
        {
            OleDbConnection cn = new OleDbConnection("Provider=MSDAORA;Data Source=orcl2;Persist Security Info=True;User ID=system ;Password=o;");

            try
            {
                cn.Open();
                OleDbCommand cmd = new OleDbCommand("select * from convenants", cn);
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                DataTable Dt = new DataTable();
                da.Fill(Dt);
                //dataGridView1.DataSource = null;
                dataGridView1.DataSource = Dt;
                dataGridView1.Columns[0].HeaderText = "الأسم";
                dataGridView1.Columns[1].HeaderText = "النوع";
                dataGridView1.Columns[2].HeaderText = "الموظف";
                dataGridView1.Columns[3].HeaderText = "التاريخ";
                
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

        private void frmView_Load(object sender, EventArgs e)
        {
            FillDataGrid();
        }
    }
}
