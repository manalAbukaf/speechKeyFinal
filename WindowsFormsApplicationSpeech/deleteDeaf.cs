using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using WindowsFormsApplicationSpeech.Class;

namespace WindowsFormsApplicationSpeech
{
    public partial class deleteDeaf : Form
    {
        public deleteDeaf()
        {
            InitializeComponent();
        }

        private void buttonDelete_Click(object sender, EventArgs e)

        {
            deaf C = new deaf(textBox1.Text);
          
            if (C.deleteDeaf())
            {
                MessageBox.Show("You been delete!");
                textBox1.Text = "";
                this.Hide();
                FrmLogin dd = new FrmLogin();
                dd.Show();


            }
            else
            {
                MessageBox.Show("enter ID ");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        

        // home butt
        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            deafPage d = new deafPage();
            d.Show();
        }
        //log out butt
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmLogin fl = new FrmLogin();
            fl.Show();
        }
        //full page
        private void deleteDeaf_Load(object sender, EventArgs e)
        {
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
