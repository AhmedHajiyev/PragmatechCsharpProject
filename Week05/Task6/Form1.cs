using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            string marka = comboBox1.Text;
            string model = comboBox7.Text;
            string banNovu = comboBox6.Text;
            string yanacaqNovu = comboBox5.Text;
            string suretlerQutusu = comboBox4.Text;
            string motorHecmi = comboBox3.Text;
            string buraxilisIli = dateTimePicker1.Text;

            ListViewItem item = new ListViewItem();
            item.Text = marka;
            item.SubItems.Add(model);
            item.SubItems.Add(banNovu);
            item.SubItems.Add(yanacaqNovu);
            item.SubItems.Add(suretlerQutusu);
            item.SubItems.Add(motorHecmi);
            item.UseItemStyleForSubItems = false;
            item.SubItems.Add(string.Empty).BackColor = button2.BackColor;
            item.SubItems.Add(buraxilisIli);

            listView1.Items.Add(item);

            comboBox1.SelectedIndex = -1;
            comboBox4.SelectedIndex = -1;
            comboBox3.SelectedIndex = -1;
            comboBox5.SelectedIndex = -1;
            comboBox6.SelectedIndex = -1;
            comboBox7.SelectedIndex = -1;
            dateTimePicker1.Value = DateTime.Now;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string marka = comboBox1.Text;
            comboBox7.Enabled = true;

            switch (marka)
            {
                case "BMW":
                    comboBox7.Items.Clear();
                    comboBox7.Items.Add("M3");
                    comboBox7.Items.Add("M5");
                    comboBox7.Items.Add("325i");
                    break;
                case "Abarth":
                    comboBox7.Items.Clear();
                    comboBox7.Items.Add("AbarthModel1");
                    comboBox7.Items.Add("AbarthModel2");
                    comboBox7.Items.Add("AbarthModel3");
                    break;
                case "Acura":
                    comboBox7.Items.Clear();
                    comboBox7.Items.Add("AcuraModel1");
                    comboBox7.Items.Add("AcuraModel2");
                    comboBox7.Items.Add("AcuraModel3");
                    break;
                default:
                    break;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (colorDialog1 = new ColorDialog())
            {
                if (colorDialog1.ShowDialog() == DialogResult.OK)
                {
                    btnColor.BackColor = colorDialog1.Color;
                }
            }
        }
    }
}
