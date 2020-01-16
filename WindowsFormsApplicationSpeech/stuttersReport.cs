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
    public partial class stuttersReport : Form
    {
        public stuttersReport()
        {
            InitializeComponent();
        }

        private void stuttersReport_Load(object sender, EventArgs e)
        {

            string sql = "select * from  [Stutter] ";
            DataTable dt = DBFunctions.SelectFromTable(sql);
            dataGridView1.DataSource = dt;//تعويض الجدول داخل التقرير


            //full  page

            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmLogin fl = new FrmLogin();
            fl.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            this.Hide();
            adminPage a = new adminPage();
            a.Show();
        }
    }
}
