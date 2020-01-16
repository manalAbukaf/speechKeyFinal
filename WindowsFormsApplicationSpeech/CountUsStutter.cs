using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;

namespace WindowsFormsApplicationSpeech
{
    public partial class CountUsStutter : Form
    {
        NetworkCredential login;
        SmtpClient client;
        MailMessage msg;
        public CountUsStutter()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string to, from, pass, mail;
            //to = (textBox1.Text).ToString();
            from = (textBox2.Text).ToString();
            mail = (textBox3.Text).ToString();
            pass = (textBox4.Text).ToString();
            MailMessage message = new MailMessage();
            message.To.Add("maramalasad9@gmail.com");
            message.From = new MailAddress(from);
            message.Body = mail;
            message.Subject = textBox1.Text.ToString();
            SmtpClient smtp = new SmtpClient("smtp.gmail.com");
            smtp.EnableSsl = true;
            smtp.Port = 587;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.Credentials = new NetworkCredential(from, pass);
            try
            {
                smtp.Send(message);
                MessageBox.Show("Email send successfully", "Email", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CountUsStutter_Load(object sender, EventArgs e)
        {
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
        }
        //

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            stutterer s = new stutterer();
            s.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmLogin fl = new FrmLogin();
            fl.Show();
        }
    }
}
