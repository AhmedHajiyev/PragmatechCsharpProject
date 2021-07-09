using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            string surName = textBox2.Text;
            string phoneNumber = maskedTextBox1.Text;
            string birthDate = dateTimePicker1.Text;
            ListViewItem item = new ListViewItem();
            item.Text = name;
            item.SubItems.Add(surName);
            item.SubItems.Add(phoneNumber);
            item.SubItems.Add(birthDate);

            listView1.Items.Add(item);

           

        }

        
    }
}
