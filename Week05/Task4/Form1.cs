using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string value = textBox1.Text.Trim().ToUpper();
            if (!string.IsNullOrEmpty(value))
            {
                listBox1.Items.Add(value);
                textBox1.Clear();
                textBox1.Focus();

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"{listBox1.Items.Count}");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string a = textBox2.Text.Trim().ToUpper();
            textBox2.Clear();
            textBox2.Focus();
            if (listBox1.Items.Contains(a))
            {
                MessageBox.Show("Bu ad listde movcuddur");
            }
            else
            {
                MessageBox.Show("Bu ad listde movcud deyil");
            }
        }
    }
}
