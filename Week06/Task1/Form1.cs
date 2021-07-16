using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace Task1
{


    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public class Click
        {
            public string category;
            public string product;
            public string weight;
            public string delivery;
            public string price;
            public string orderedDate;
        }


        public Click Sifaris()
        {
            Click e = new Click
            {
                category = comboBox1.Text,
                product = comboBox2.Text,
                weight = Convert.ToString(numericUpDown1.Value),
                delivery = comboBox3.Text,
                price = Convert.ToString(numericUpDown2.Value),
                orderedDate = dateTimePicker1.Value.ToShortDateString()

            };
            return e;
        }

       

        


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string marka = comboBox1.Text;
            comboBox2.Enabled = true;

            switch (marka)
            {
                case "A":
                    comboBox2.Items.Clear();
                    comboBox2.Items.Add("Kateqoriya A M1");
                    comboBox2.Items.Add("Kateqoriya A M2");
                    comboBox2.Items.Add("Kateqoriya A M3");
                    break;
                case "B":
                    comboBox2.Items.Clear();
                    comboBox2.Items.Add("Kateqoriya B M1");
                    comboBox2.Items.Add("Kateqoriya B M2");
                    comboBox2.Items.Add("Kateqoriya B M3");
                    break;
                case "C":
                    comboBox2.Items.Clear();
                    comboBox2.Items.Add("Kateqoriya C M1");
                    comboBox2.Items.Add("Kateqoriya C M2");
                    comboBox2.Items.Add("Kateqoriya C M3");
                    break;
                case "D":
                    comboBox2.Items.Clear();
                    comboBox2.Items.Add("Kateqoriya D M1");
                    comboBox2.Items.Add("Kateqoriya D M2");
                    comboBox2.Items.Add("Kateqoriya D M3");
                    break;
                case "E":
                    comboBox2.Items.Clear();
                    comboBox2.Items.Add("Kateqoriya E M1");
                    comboBox2.Items.Add("Kateqoriya E M2");
                    comboBox2.Items.Add("Kateqoriya E M3");
                    break;
                default:
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Click newSifaris = Sifaris();
            ListViewItem item = new ListViewItem();
            item.Text = newSifaris.category;
            item.SubItems.Add(newSifaris.product);
            item.SubItems.Add(newSifaris.weight);
            item.SubItems.Add(newSifaris.delivery);
            item.SubItems.Add(newSifaris.price);
            item.SubItems.Add(newSifaris.orderedDate);

            if (newSifaris.category != null && newSifaris.product != null && newSifaris.weight != "0" && newSifaris.delivery != null && newSifaris.price != "0")
            {
                listView1.Items.Add(item);
                comboBox1.SelectedIndex = -1;
                comboBox2.SelectedIndex = -1 ;
                comboBox3.SelectedIndex = -1;
                numericUpDown1.Value = 0;
                numericUpDown2.Value = 0;
                dateTimePicker1.Value = DateTime.Now;
            }
            else
            {
                MessageBox.Show("Xanalari doldurun");
            }


            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string search = textBox1.Text.Trim();
            textBox1.Clear();
            var arlist = new ArrayList();
            arlist.Add(listView1);

            for (int i = 0; i < listView1.Items.Count; i++)
            {
                if (listView1.Items[i].SubItems[1].Text == search )
                {
                    //for (int a = listView1.Items.Count - 1; a > 0; a--)
                    //{
                       //if (!listView1.Items[i].ToString().Contains(search))
                        //{
                            //listView1.Items.Remove(listView1.Items[a]);
                            MessageBox.Show("Bu mehsul var");

                            
                            
                        //}
                    //}

                }
                else
                {
                    MessageBox.Show("Bu mehsul yoxdur");
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            for (int i = listView1.SelectedItems.Count-1; i >= 0; i--)
            {
                listView1.Items[i].Remove();
            }
        }

        
    }
}
