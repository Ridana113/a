using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Algoritms
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a, b, nod;
           try
            {
                a = double.Parse(textBox1.Text);
                b = double.Parse(textBox2.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Уважаемый пользователь, пожалуйста, введите ЧИСЛО!");
                textBox1.Select();
                textBox2.Select();
                return;
            }
            if (b == 0)
            {
                nod = 0;
                a = b;
                b = nod;
            }
            if (a == 0)
            {
                nod = 0;
                b = a;
                a = nod;
            }
            else
            {
                while (Math.Abs(b)> 0)
                {
                    nod = a % b;
                    a =b;
                    b =nod;
                }
            }
            textBox3.Text = a.ToString();
           
        }
    }
}
