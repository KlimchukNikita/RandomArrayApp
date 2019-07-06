using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Random_Array_App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double D, sum = 0, min = 100, n = 0, mini = 0;
            int[] a;
            a = new int[6];
            Random rnd = new Random();
            for (int i = 0; i < 6; i++)
            {
                a[i] = rnd.Next(-10, 10);
            }

            for (int i = 0; i < 6; i++)
            {
                sum = sum + a[i];
            }
            D = sum / 6;
            for (int i = 0; i < 6; i++)
            {
                n = Math.Abs(a[i] - D);
                if (n < min)
                {
                    min = n;
                    mini = i;
                }
            }
            textBox1.Text = Convert.ToString(D);
            textBox2.Text = Convert.ToString(n);
            textBox3.Text = Convert.ToString(mini);
            textBox4.Text = Convert.ToString(a[0]);
            textBox5.Text = Convert.ToString(a[1]);
            textBox6.Text = Convert.ToString(a[2]);
            textBox7.Text = Convert.ToString(a[3]);
            textBox8.Text = Convert.ToString(a[4]);
            textBox9.Text = Convert.ToString(a[5]);

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
