using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            X = 0;
            Y = 0;
            Z = 0;

            xYZClassBindingSource.DataSource = new XYZClass();
        }

        public double X { get {
                double x = 0;
                double.TryParse(textBox1.Text, out x);
                textBox1.Text = x.ToString();
                return x;
            }
            set
            {
                textBox1.Text = value.ToString();
            }
        }
        public double Y
        {
            get
            {
                double x = 0;
                double.TryParse(textBox2.Text, out x);
                textBox2.Text = x.ToString();
                return x;
            }
            set
            {
                textBox2.Text = value.ToString();
            }
        }
        public double Z
        {
            get
            {
                double x = 0;
                double.TryParse(textBox3.Text, out x);
                textBox3.Text = x.ToString();
                return x;
            }
            set
            {
                textBox3.Text = value.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x = X;
            X = Y;
            Y = x;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double x = Z;
            Z = Y;
            Y = X;
            X = Z;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Y = X;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Z = Y;
            Y = X;
        }

        private void toolStripStatusLabel2_Click(object sender, EventArgs e)
        {
            X = Math.PI;
        }

        private void toolStripStatusLabel3_Click(object sender, EventArgs e)
        {
            X = Math.E;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            X = X + Y;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            X = X - Y;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            X = X * Y;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            X = X / Y;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            X = -X;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            X += 1;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            X -= 1;
        }
    }
}
