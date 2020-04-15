using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Algoritms
{
    public partial class Form3 : Form
    { 
        int x1;
        int x2;
        int speed1;
        int speed2;
        int low;
        int time;

        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
       
        private void button2_Click(object sender, EventArgs e)
        {

            try
            {
                if (radioButton1.Checked)
                {
                    timer1.Enabled = true;
                }
                if (radioButton2.Checked)
                {
                    timer2.Enabled = true;
                }

            }
            catch 
            {
               
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                speed1 = Convert.ToInt32(textBox1.Text);
                speed2 = Convert.ToInt32(textBox2.Text);
            low = x2 - x1;
            time = low / speed1;
            x1 = x2;
            x2 = x2 + (time * speed2);
            pictureBox2.Location = new Point(x1-255, 461);
            pictureBox3.Location = new Point(x2, 657);
                if (speed1 < 0)
                {
                    timer1.Stop();
                    MessageBox.Show("Уважаемый пользователь, пожалуйста, введите скорость Ахиллеса в виде положительного числа");

                }
                if (speed2 < 0)
                {
                    timer1.Stop();
                    MessageBox.Show("Уважаемый пользователь, пожалуйста, введите скорость черепахи в виде положительного числа");
                }
            }
            catch (FormatException)
            {
                timer1.Stop();
                MessageBox.Show("Уважаемый пользователь, пожалуйста, введите ЧИСЛО!");
                textBox1.Select();
                textBox2.Select();
                return;
            }
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            try
            {
                speed1 = Convert.ToInt32(textBox1.Text);
                speed2 = Convert.ToInt32(textBox2.Text);
                if (speed1 < 0)
                {
                    timer2.Stop();
                    MessageBox.Show("Уважаемый пользователь, пожалуйста, введите скорость Ахиллеса в виде положительного числа");
                }
                if (speed2 < 0)
                {
                    timer2.Stop();
                    MessageBox.Show("Уважаемый пользователь, пожалуйста, введите скорость черепахи в виде положительного числа");
                }
            }
            catch (FormatException)
            {
                timer2.Stop();
                MessageBox.Show("Уважаемый пользователь, пожалуйста, введите ЧИСЛО!");
                textBox1.Select();
                textBox2.Select();
                return;
            }
            x1 = x1 + speed1;
            x2 = x2+ speed2;
            pictureBox2.Location = new Point(x1, 461);
            pictureBox3.Location = new Point(x2, 657);

        }
        private void button3_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            timer2.Enabled = false;
        }

       
        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                timer1.Enabled = false;
                timer2.Enabled = false;
                x2 = Convert.ToInt32(textBox3.Text);
                pictureBox3.Location = new Point(x2, 657);
                if (x2<0)
                {
                   MessageBox.Show("Уважаемый пользователь, пожалуйста, введите рекомендуемое расстояние!");
                    x1 = 0;
                    x2 = 461;
                    textBox1.Text = Convert.ToString(x1);
                    textBox2.Text = Convert.ToString(x1);
                    textBox3.Text = Convert.ToString(x1);
                    pictureBox3.Location = new Point(x2, 657);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Уважаемый пользователь, пожалуйста, введите ЧИСЛО!");
                textBox3.Select();
                return;
            }
        }

      

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            timer2.Enabled = false;
            x1 = 0;
            x2 = 461;
            textBox1.Text = Convert.ToString(x1);
            textBox2.Text = Convert.ToString(x1);
            textBox3.Text = Convert.ToString(x1);
            pictureBox2.Location = new Point(x1, 461);
            pictureBox3.Location = new Point(x2, 657);
        }
    }
}






