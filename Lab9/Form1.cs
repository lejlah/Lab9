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
            var n = textBox1.Text.Length;
            int[] a = new int[50];

            for (int i = 0; i < n - 1; i++)
            {
                if (Char.IsDigit(textBox1.Text[i]))
                    a[i] = textBox1.Text[i];
            }

            double average = 0;
            double sum = 0;
            for (int i = 0; i < a.Length - 1; i++)
            {
                sum = sum + a[i];
            }

            average = sum / a.Length-1;
            label1.Text = average.ToString();
        }
    }
}
