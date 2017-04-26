using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] numbers = textBox1.Text.Split(',');

            int sum = 0;
            foreach (string num in numbers)            
                sum += Convert.ToInt32(num);

            label1.Text = "Average is " + (sum / numbers.Length);
        }
    }
}
