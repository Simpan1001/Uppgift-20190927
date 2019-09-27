using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CAlculator.Component;

namespace Uppgift_20190927
{
    public partial class Form1 : Form
    {
        CAlculator.Component.Calculator myCalculator = new CAlculator.Component.Calculator();
        public Form1()
        {
            InitializeComponent();

            button1.Text = "+";
            button2.Text = "-";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string op = ((Button)sender).Text;

            double x = double.Parse(textBox1.Text);
            double y = double.Parse(textBox2.Text);
            double result = myCalculator.Add(x, y);

            ShowResult(x, y, result, op);
        }

        private void ShowResult(double x, double y, double result, string op)
        {
            listBox1.Items.Add(string.Format("{0} {1} {2} = {3}", x, op, y, result));
            textBox1.Clear();
            textBox2.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Button b;
            b = (Button)sender;
            string op = button2.Text;

            double x = double.Parse(textBox1.Text);
            double y = double.Parse(textBox2.Text);
            double result = myCalculator.Sub(x, y);

            ShowResult(x, y, result, op);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string op = ((Button)sender).Text;

            double x = double.Parse(textBox1.Text);
            double y = double.Parse(textBox2.Text);
            double result = myCalculator.Div(x, y);

            ShowResult(x, y, result, op);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string op = ((Button)sender).Text;

            double x = double.Parse(textBox1.Text);
            double y = double.Parse(textBox2.Text);
            double result = myCalculator.Div(x, y);

            ShowResult(x, y, result, op);
        }
    }
}
