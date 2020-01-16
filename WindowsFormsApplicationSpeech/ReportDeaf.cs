using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplicationSpeech.Class;

namespace WindowsFormsApplicationSpeech
{
    public partial class ReportDeaf : Form
    {
        public ReportDeaf()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }
        //full page
        private void ReportDeaf_Load(object sender, EventArgs e)
        {
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Report r = new Report(textBox1.Text);
            if (r.checkIfReportExsist())
            {
                panel1.Visible = true;
                string sql = "select activityTime from reports where userName='" + textBox1.Text + "'";
                DataTable dt = DBFunctions.SelectFromTable(sql);
                dataGridView1.DataSource = dt;//تعويض الجدول داخل التقرير
            }
            else
            {
                //MessageBox.Show("please cheeck your user name,");
                MessageBox.Show(DateTime.Now.ToString("please enter username"));
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmLogin fl = new FrmLogin();
            fl.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            deafPage d = new deafPage();
            d.Show();
        }
    }
}
