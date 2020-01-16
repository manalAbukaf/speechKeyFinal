using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

using System.Data.SqlClient;
using WindowsFormsApplicationSpeech.Class;


namespace WindowsFormsApplicationSpeech
{
    public partial class addImige : Form
    {
        public addImige()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\khawla\Desktop\1\WindowsFormsApplicationSpeech\WindowsFormsApplicationSpeech\WindowsFormsApplicationSpeech\DatabaseUsers.mdf;Integrated Security=True");
        string imglocatin = "";
        SqlCommand cmd;
        //browsser button
        private void buttonBrowsse_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Title = "please select a photo";
            dialog.Filter = "jpg files(*.jpg)|*.jpg| PNG files(*.png)|*.png|All Files(*.*)|*.*";
            dialog.Multiselect = false;
            if (dialog.ShowDialog() == DialogResult.OK)
            {

                imglocatin = dialog.FileName.ToString();
                pictureBoxPhoto.ImageLocation = imglocatin;
            }
        }
       

        



        //save button
        private void buttonSave_Click(object sender, EventArgs e)
        {

           
           byte[] imag = null;
            FileStream fs = new FileStream(imglocatin, FileMode.Open, FileAccess.Read);
            BinaryReader brs = new BinaryReader(fs);
            imag = brs.ReadBytes((int)fs.Length);
            con.Open();
            string sqlQ = @"insert into [imges](imageName,image)Values('" + textBox1.Text + "',@imag)";
            cmd = new SqlCommand(sqlQ, con);
            cmd.Parameters.Add(new SqlParameter("@imag",imag));
            int n = cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show(n.ToString() + "photo seved successfully......!");


        }

        private void buttonView_Click(object sender, EventArgs e)
        {
            con.Open();
            string sqlQ = "select  *  from [imges] where  imageName ='" + textBox1.Text + "'";
           
            cmd = new SqlCommand(sqlQ, con);
            SqlDataReader dataRead = cmd.ExecuteReader();
            dataRead.Read();
         

            if (dataRead.HasRows)
            {
                textBox1.Text = dataRead[0].ToString();
                byte[] images =((byte[])dataRead[1]);

                if (images == null)
                {
                    pictureBoxPhoto.Image = null;
                }


                else
                {
                    MemoryStream mstreem = new MemoryStream(images);
                    pictureBoxPhoto.Image = Image.FromStream(mstreem);
                }
            }
            else
            {
                MessageBox.Show("This Data Not Availabal");
            }
            con.Close();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            pictureBoxPhoto.Image = null;
        }

        //home button
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            deafPage d = new deafPage();
            d.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmLogin fl = new FrmLogin();
            fl.Show();
        }
        //full page
        private void addImige_Load(object sender, EventArgs e)
        {
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;

        }
    }
}
