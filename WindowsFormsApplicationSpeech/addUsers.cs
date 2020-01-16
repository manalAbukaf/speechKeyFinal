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
    public partial class addUsers : Form
    {
        public addUsers()
        {
            InitializeComponent();
        }

        private void addUsers_Load(object sender, EventArgs e)
        {
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        //add deaf Button
        private void button1_Click(object sender, EventArgs e)
        {
            deaf d = new deaf(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text);
            if (d.insertDeaf())
            {
                MessageBox.Show(" The deaf is added !!!!!!");

                //clean botton
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";


            }
            else
            {
                MessageBox.Show(" the Deaf is exsist !!!!!!");
            }
        }
        //log Out Button
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmLogin fl = new FrmLogin();
            fl.Show();

        }


        //stuter add button
        private void button2_Click(object sender, EventArgs e)
        {
            stutter s = new stutter(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text);
            if (s.insertStuttr())
            {
                MessageBox.Show(" The Stutter is added !!!!!!");

                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";

            }
            else
            {
                MessageBox.Show(" the Stutter is exsist !!!!!!");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            adminPage ad = new adminPage();
            ad.Show();
        }
    }
}
