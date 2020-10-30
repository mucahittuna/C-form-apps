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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "yonetici"&&textBox2.Text=="1234")
            {
                Form2 ekran = new Form2();
                ekran.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("HATALI GİRİŞ!!!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 ekran = new Form2();
            ekran.Show();
            this.Hide();
        }
    }
}
