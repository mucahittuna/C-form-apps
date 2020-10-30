using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace İstanbulKocaeliHattı
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox6.Items.Add("1");
            listBox1.Items.Add(textBox1.Text);
            listBox2.Items.Add(comboBox1.Text);
            listBox3.Items.Add(textBox2.Text);
            listBox5.Items.Add(comboBox2.Text);
            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            listBox4.Items.Add("BAY");
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            listBox4.Items.Add("BAYAN");
        }

        private void Form2_Load(object sender, EventArgs e)
        {
          
        }
    }
}
