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
    public partial class deafsReport : Form
    {
        public deafsReport()
        {
            InitializeComponent();
        }

        private void deafsReport_Load(object sender, EventArgs e)
        {
            string sql = "select * from  [Deaf] ";
            DataTable dt = DBFunctions.SelectFromTable(sql);
            dataGridView1.DataSource = dt;//تعويض الجدول داخل التقرير

            //full page 
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            adminPage a = new adminPage();
            a.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmLogin fl = new FrmLogin();
            fl.Show();
        }
    }
}
