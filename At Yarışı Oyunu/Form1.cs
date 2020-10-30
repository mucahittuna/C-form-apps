using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AtYarışı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }
      

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int num1des = pictureBox1.Left;
            int num2des = pictureBox2.Left;
            int num3des = pictureBox3.Left;
            int num1width = pictureBox1.Width;
            int num2width = pictureBox2.Width;
            int num3width = pictureBox3.Width;
            pictureBox1.Left += rastgele.Next(0, 20);
            pictureBox2.Left += rastgele.Next(0, 20);
            pictureBox3.Left += rastgele.Next(0,20);
            int finish = label5.Left;
            
            if (num1des + num1width > num2des + num2width && num1des + num1width > num3des + num3width)
            {
                label6.Text = "1 numaralı YAĞMUR MUHTEŞEMM GİDİYORR";
            }
            if (num2des + num2width > num1des + num1width && num2des + num2width > num3des + num3width)
            {
                label6.Text = "2. KULVARDA AYKIZ BASTIRDI ŞİMDİİ";
            }
            if (num3des + num3width > num2des + num2width && num3des + num3width > num1des + num1width)
            {
                label6.Text = "3 NUMARADA ATakan YARDIRDI GEÇTİ";
            }
            if (finish <= num1des + num1width)
            {
                timer1.Enabled = false;
                MessageBox.Show("1.HORSE WON!!!");
            }
            if (finish <= num2des + num2width)
            {
                timer1.Enabled = false;
                MessageBox.Show("2.HORSE WON!!!");
            }
            if (finish <= num3des + num3width)
            {
                timer1.Enabled = false;
                MessageBox.Show("3.HORSE WON!!!");
            }
        }

        Random rastgele = new Random();
        private void Form1_Load(object sender, EventArgs e)
        {
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            pictureBox1.Left = 0;
            pictureBox2.Left = 0;
            pictureBox3.Left = 0;
            label6.Text = "TAM AT YARIŞLIK BİR GÜN..";
        }
    }
}
