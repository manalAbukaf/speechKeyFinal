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
    public partial class reportStutter : Form
    {
        public reportStutter()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmLogin fl = new FrmLogin();
            fl.Show();
        }

        //full bage
        private void reportStutter_Load(object sender, EventArgs e)
        {
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            stutterRepurte r = new stutterRepurte(textBox1.Text);
            if (r.checkIfReportExsist())
            {
                panel1.Visible = true;
                string sql = "select activityTime from [stutterReport] where userName='" + textBox1.Text + "'";
                DataTable dt = DBFunctions.SelectFromTable(sql);
                dataGridView1.DataSource = dt;//تعويض الجدول داخل التقرير
            }
            else
            {
                MessageBox.Show("please cheeck your user name,");
                
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            stutterer s = new stutterer();
            s.Show();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
