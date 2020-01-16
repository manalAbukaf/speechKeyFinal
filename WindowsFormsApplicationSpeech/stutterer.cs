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
    public partial class stutterer : Form
    {
        public stutterer()
        {
            InitializeComponent();
        }
        //deleat stutter
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            deleteStutter ss = new deleteStutter();
            ss.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
            SspeeckForm speak = new SspeeckForm();
            speak.Show();


        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            updateStutter ss = new updateStutter();
            ss.Show();
        }
        // repot button
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Hide();
            reportStutter report = new reportStutter();
            report.Show();

        }
        // conversation  button
        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Hide();
            practice recognition = new practice();
            recognition.Show();
        }
        // Speech Recognition button
        private void pictureBox6_Click(object sender, EventArgs e)
        {

            SpeechRecognition s = new SpeechRecognition();
            s.Show();

        }
        // contact button
        private void pictureBox7_Click(object sender, EventArgs e)
        {
            this.Hide();
            contactUs us = new contactUs();
            us.Show();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmLogin fl = new FrmLogin();
            fl.Show();
        }
        //full page
        private void stutterer_Load(object sender, EventArgs e)
        {
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            this.Hide();
            CountUsStutter s = new CountUsStutter();
            s.Show();
        }
    }
}
