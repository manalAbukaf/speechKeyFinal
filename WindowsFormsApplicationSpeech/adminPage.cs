using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplicationSpeech.Class
{
    public partial class adminPage : Form
    {
        public adminPage()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            addUsers add = new addUsers();
            add.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
             addUsers  add = new addUsers();
            add.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            updateUsers dd = new updateUsers();
            dd.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            updateUsers ss = new updateUsers();
            ss.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            deletUser ss = new deletUser();
            ss.Show();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            deletUser ss = new deletUser();
            ss.Show();
        }
        //report button for deaf
        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            deafsReport re = new deafsReport();
            re.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmLogin fl = new FrmLogin();
            fl.Show();
        }
        //full page
        private void adminPage_Load(object sender, EventArgs e)
        {
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            stuttersReport sR = new stuttersReport();
            sR.Show();
        }
    }
}
