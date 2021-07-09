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
            string a = textBox1.Text.Trim().ToLower();
            textBox1.Clear();
            textBox1.Focus();
            listBox1.Items.Add(a);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = listBox1.SelectedItems.Count - 1; i >= 0; i--)
            {

                listBox1.Items.Remove(listBox1.SelectedItems[i]);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Random rndm = new Random();
            int rndm1 = rndm.Next(0,listBox1.SelectedItems.Count);
            for (int i = 0; i < listBox1.SelectedItems.Count; i++)
            {
                listBox1.Items.IndexOf(listBox1.SelectedItems[i);
            }
        }
    }
}
