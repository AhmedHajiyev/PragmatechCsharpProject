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

        public class Click
        {
            public string category { get; set; }
            public string product { get; set; }
            public string weight { get; set; }
            public string delivery { get; set; }
            public string price { get; set; }
            public DateTime orderedDate { get; set; }
            
        }

        public Click ClickCreate()
        {
            Click e = new Click
            {
                category = comboBox1.Text,
                product = comboBox2.Text,
                weight = Convert.ToString(numericUpDown1.Value),
                delivery = comboBox3.Text,
                price = Convert.ToString(numericUpDown2.Value),
                orderedDate = dateTimePicker1.Value

            };
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
           
            
        }

    }
}
