using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech;
using System.Speech.Synthesis;
namespace WindowsFormsApplicationSpeech
{
    public partial class practice : Form
    {
        public practice()
        {
            InitializeComponent();
        }
        SpeechSynthesizer reader = new SpeechSynthesizer();
        PromptBuilder pBuilder = new PromptBuilder();
        private void button1_Click(object sender, EventArgs e)
        {
            pBuilder.ClearContent();
            pBuilder.AppendText("good morning");
            reader.Speak(pBuilder);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pBuilder.ClearContent();
            pBuilder.AppendText("good night");
            reader.Speak(pBuilder);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pBuilder.ClearContent();
            pBuilder.AppendText("how are you?");
            reader.Speak(pBuilder);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pBuilder.ClearContent();
            pBuilder.AppendText("how long does it take?");
            reader.Speak(pBuilder);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            pBuilder.ClearContent();
            pBuilder.AppendText("do you agree?");
            reader.Speak(pBuilder);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            pBuilder.ClearContent();
            pBuilder.AppendText("where can i get it?");
            reader.Speak(pBuilder);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            pBuilder.ClearContent();
            pBuilder.AppendText("how do you feel?");
            reader.Speak(pBuilder);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            pBuilder.ClearContent();
            pBuilder.AppendText("how old are you?");
            reader.Speak(pBuilder);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            pBuilder.ClearContent();
            pBuilder.AppendText("what are you doing?");
            reader.Speak(pBuilder);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            pBuilder.ClearContent();
            pBuilder.AppendText("how much?");
            reader.Speak(pBuilder);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            pBuilder.ClearContent();
            pBuilder.AppendText("no wonder");
            reader.Speak(pBuilder);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            pBuilder.ClearContent();
            pBuilder.AppendText("thank you");
            reader.Speak(pBuilder);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            pBuilder.ClearContent();
            pBuilder.AppendText("sure");
            reader.Speak(pBuilder);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            pBuilder.ClearContent();
            pBuilder.AppendText("i am glad");
            reader.Speak(pBuilder);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            pBuilder.ClearContent();
            pBuilder.AppendText("no way");
            reader.Speak(pBuilder);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            pBuilder.ClearContent();
            pBuilder.AppendText("stop");
            reader.Speak(pBuilder);
        }

        private void button20_Click(object sender, EventArgs e)
        {
            pBuilder.ClearContent();
            pBuilder.AppendText("realy");
            reader.Speak(pBuilder);
        }

        private void button19_Click(object sender, EventArgs e)
        {
            pBuilder.ClearContent();
            pBuilder.AppendText("sorry");
            reader.Speak(pBuilder);
        }

        private void button18_Click(object sender, EventArgs e)
        {
            pBuilder.ClearContent();
            pBuilder.AppendText("great");
            reader.Speak(pBuilder);
        }

        private void button17_Click(object sender, EventArgs e)
        {
            pBuilder.ClearContent();
            pBuilder.AppendText("early");
            reader.Speak(pBuilder);
        }

        private void button24_Click(object sender, EventArgs e)
        {
            pBuilder.ClearContent();
            pBuilder.AppendText("difference");
            reader.Speak(pBuilder);
        }

        private void button27_Click(object sender, EventArgs e)
        {
            pBuilder.ClearContent();
            pBuilder.AppendText("because");
            reader.Speak(pBuilder);
        }

        private void button26_Click(object sender, EventArgs e)
        {
            pBuilder.ClearContent();
            pBuilder.AppendText("carefully");
            reader.Speak(pBuilder);
        }

        private void button25_Click(object sender, EventArgs e)
        {
            pBuilder.ClearContent();
            pBuilder.AppendText("congressional");
            reader.Speak(pBuilder);
        }

        private void button23_Click(object sender, EventArgs e)
        {
            pBuilder.ClearContent();
            pBuilder.AppendText("drive");
            reader.Speak(pBuilder);
        }

        private void button22_Click(object sender, EventArgs e)
        {
            pBuilder.ClearContent();
            pBuilder.AppendText("education");
            reader.Speak(pBuilder);
        }

        private void button21_Click(object sender, EventArgs e)
        {
            pBuilder.ClearContent();
            pBuilder.AppendText("family");
            reader.Speak(pBuilder);
        }

        private void button37_Click(object sender, EventArgs e)
        {
            pBuilder.ClearContent();
            pBuilder.AppendText("glass");
            reader.Speak(pBuilder);
        }

        private void button36_Click(object sender, EventArgs e)
        {
            pBuilder.ClearContent();
            pBuilder.AppendText("happy");
            reader.Speak(pBuilder);
        }

        private void button35_Click(object sender, EventArgs e)
        {
            pBuilder.ClearContent();
            pBuilder.AppendText("emotional");
            reader.Speak(pBuilder);
        }
        
        private void button34_Click(object sender, EventArgs e)
        {
            pBuilder.ClearContent();
            pBuilder.AppendText("Vegetable");
            reader.Speak(pBuilder);
        }

        private void button33_Click(object sender, EventArgs e)
        {
            pBuilder.ClearContent();
            pBuilder.AppendText("ussally");
            reader.Speak(pBuilder);
        }

        private void button32_Click(object sender, EventArgs e)
        {
            pBuilder.ClearContent();
            pBuilder.AppendText("summer");
            reader.Speak(pBuilder);
        }

        private void button31_Click(object sender, EventArgs e)
        {
            pBuilder.ClearContent();
            pBuilder.AppendText("swim");
            reader.Speak(pBuilder);
        }

        private void button30_Click(object sender, EventArgs e)
        {
            pBuilder.ClearContent();
            pBuilder.AppendText("talent");
            reader.Speak(pBuilder);
        }

        private void button29_Click(object sender, EventArgs e)
        {
            pBuilder.ClearContent();
            pBuilder.AppendText("technical");
            reader.Speak(pBuilder);
        }

        private void button28_Click(object sender, EventArgs e)
        {
            pBuilder.ClearContent();
            pBuilder.AppendText("unfortunately");
            reader.Speak(pBuilder);
        }

        private void button40_Click(object sender, EventArgs e)
        {
            pBuilder.ClearContent();
            pBuilder.AppendText("vacation");
            reader.Speak(pBuilder);
        }

        private void button39_Click(object sender, EventArgs e)
        {
            pBuilder.ClearContent();
            pBuilder.AppendText("volunteer");
            reader.Speak(pBuilder);
        }

        private void button38_Click(object sender, EventArgs e)
        {
            pBuilder.ClearContent();
            pBuilder.AppendText("weekned");
            reader.Speak(pBuilder);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void button48_Click(object sender, EventArgs e)
        {
            pBuilder.ClearContent();
            pBuilder.AppendText("yard");
            reader.Speak(pBuilder);
        }

        private void button47_Click(object sender, EventArgs e)
        {
            pBuilder.ClearContent();
            pBuilder.AppendText("yesterday");
            reader.Speak(pBuilder);
        }

        private void button46_Click(object sender, EventArgs e)
        {
            pBuilder.ClearContent();
            pBuilder.AppendText("wonderful");
            reader.Speak(pBuilder);
        }

        private void button45_Click(object sender, EventArgs e)
        {
            pBuilder.ClearContent();
            pBuilder.AppendText("widespread");
            reader.Speak(pBuilder);
        }

        private void button44_Click(object sender, EventArgs e)
        {
            pBuilder.ClearContent();
            pBuilder.AppendText("whatever");
            reader.Speak(pBuilder);
        }

        private void button43_Click(object sender, EventArgs e)
        {
            pBuilder.ClearContent();
            pBuilder.AppendText("welcom");
            reader.Speak(pBuilder);
        }

        private void button42_Click(object sender, EventArgs e)
        {
            pBuilder.ClearContent();
            pBuilder.AppendText("wedding");
            reader.Speak(pBuilder);
        }

        private void button41_Click(object sender, EventArgs e)
        {
            pBuilder.ClearContent();
            pBuilder.AppendText("university");
            reader.Speak(pBuilder);
        }

        private void button50_Click(object sender, EventArgs e)
        {
            pBuilder.ClearContent();
            pBuilder.AppendText("understanding");
            reader.Speak(pBuilder);
        }

        private void button49_Click(object sender, EventArgs e)
        {
            pBuilder.ClearContent();
            pBuilder.AppendText("throughout");
            reader.Speak(pBuilder);
        }
        //full page
        private void practice_Load(object sender, EventArgs e)
        {
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
        }

        private void button51_Click(object sender, EventArgs e)
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

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
