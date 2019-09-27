using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uppgift_20190927
{
    public partial class Form1 : Form
    {
        Calculator myCalculator = new Calculator();
        public Form1()
        {
            InitializeComponent();

            button1.Text = "+";
            button2.Text = "-";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string op = button1.Text;
            int x = int.Parse(textBox1.Text);
            int y = int.Parse(textBox2.Text);
            int result = myCalculator.Add(x, y);

            ShowResult(x, y, result, op);
        }

        private void ShowResult(int x, int y, int result, string op)
        {
            listBox1.Items.Add(string.Format("{0} {3} {1} = {2}", x, y, result, op));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string op = button2.Text;
            int x = int.Parse(textBox1.Text);
            int y = int.Parse(textBox2.Text);
            int result = myCalculator.Sub(x, y);

            ShowResult(x, y, result, op);
        }
    }
}
