using System.Drawing;
using System.Xml.Linq;

namespace escolhercores
{
    public partial class Form1 : Form


    {
        string nome;




        string color;


        public Form1()
        {
            InitializeComponent();
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {


            if (radioButton1.Checked == true)
            {
                nome = textBox1.Text;
                color = "rosa";
                this.BackColor = System.Drawing.Color.Fuchsia;
                textBox1.Text = nome;
                label2.Text = label2.Text = "A cor escolhida por " + nome + " foi " + color;

            }



        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {




        }

        private void button1_Click_2(object sender, EventArgs e)
        {



        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                nome = textBox1.Text;
                color = "azul";
                this.BackColor = System.Drawing.Color.Blue;
                textBox1.Text = nome;
                label2.Text = label2.Text = "A cor escolhida por " + nome + " foi " + color;
            }


        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked == true)
            {
                nome = textBox1.Text;
                color = "verde";
                this.BackColor = System.Drawing.Color.Lime;
                textBox1.Text = nome;
                label2.Text = "A cor escolhida por " + nome + " foi " + color;
            }

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked == true)
            {
                nome = textBox1.Text;
                color = "laranja";
                this.BackColor = System.Drawing.Color.OrangeRed;
                textBox1.Text = nome;
                label2.Text = "A cor escolhida por " + nome + " foi " + color;
            }
        }
    }
}