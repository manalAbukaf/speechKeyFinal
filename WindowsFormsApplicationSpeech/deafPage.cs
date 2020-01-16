using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplicationSpeech
{
    public partial class deafPage : Form
    {
        public deafPage()
        {
            InitializeComponent();
        }
        // speack button
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            speeckForm speak = new speeckForm();
            speak.Show();
        }
        //update button
        private void pictureBox2_Click(object sender, EventArgs e)
        {

            this.Hide();
            updeatDeaf up = new updeatDeaf();
            up.Show();
        }
        //image button
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
            deleteDeaf dd = new deleteDeaf();
            dd.Show();
        }
        //contact button
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Hide();
            contactUs c = new contactUs();
            c.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Hide();
            addImige add = new addImige();
            add.Show();
        }
        //report button
        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.Hide();
            ReportDeaf Rd = new ReportDeaf();
            Rd.Show();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            this.Hide();
          addImige vi = new addImige();
            vi.Show();
        }

        private void pictureBox7_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            FrmLogin fl = new FrmLogin();
            fl.Show();


        }
        //full page
        private void deafPage_Load(object sender, EventArgs e)
        {
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
