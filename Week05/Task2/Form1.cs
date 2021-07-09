using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string value = textBox1.Text;
            if(value!= " "){
            listBox1.Items.Add(value);

            }
            textBox1.Clear();
            textBox1.Focus();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string value = textBox1.Text;
            label1.Text = value;

        }

        
    }
}
