using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;

namespace WindowsFormsApplicationSpeech
{
    public partial class contactUs : Form
    {
        NetworkCredential login;
        SmtpClient client;
        MailMessage msg;
        public contactUs()
        {
            InitializeComponent();
        }
       
        
        //send button
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
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
           this.Hide();
            //Contact con = new Contact();
          //  con.Show();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmLogin fl = new FrmLogin();
            fl.Show();
        }
        // full page
        private void contactUs_Load(object sender, EventArgs e)
        {
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Show();
            deafPage d = new deafPage();
            d.Show();
        }
    }
}
