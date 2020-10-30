using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandomLigOyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random skor = new Random();
        int fb = 0;
        int gs = 0;
        int bjk = 0;
        int ts = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            int a = skor.Next(0, 5);
            label3.Text = a.ToString();
            int b = skor.Next(0, 5);
            label4.Text = b.ToString();
            int c = skor.Next(0, 5);
            label7.Text = c.ToString();
            int d = skor.Next(0, 5);
            label9.Text = d.ToString();
            if (a > b)
            {
                gs = gs + 3;
                label18.Text = gs.ToString();
            }
            if (b > a)
            {
                fb = fb + 3;
                label16.Text = fb.ToString();
            }
            if (a == b)
            {
                gs = gs + 1;
                label18.Text = gs.ToString();
                fb = fb + 1;
                label16.Text = fb.ToString();
            }
            if (c > d)
            {
                bjk = bjk + 3;
                label17.Text = bjk.ToString();
            }
            if (d > c)
            {
                ts = ts + 3;
                label15.Text = ts.ToString();
            }
            if (d == c)
            {
                ts = ts + 1;
                label15.Text = ts.ToString();
                bjk = bjk + 1;
                label17.Text = bjk.ToString();
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Enabled = false;
            int k = skor.Next(0, 5);
            label32.Text = k.ToString();
            int l = skor.Next(0, 5);
            label37.Text = l.ToString();
            int m = skor.Next(0, 5);
            label34.Text = m.ToString();
            int n = skor.Next(0, 5);
            label31.Text = n.ToString();
            if (k > l)
            {
                ts = ts + 3;
                label17.Text = ts.ToString();
        
            }
            if (l > k)
            {
                fb = fb + 3;
                label16.Text = fb.ToString();

            }
            if (k == l)
            {
                ts = ts + 1;
                label17.Text = ts.ToString();
                fb = fb + 1;
                label16.Text = fb.ToString();
            }
            if (m > n)
            {
                bjk = bjk + 3;
                label15.Text = bjk.ToString();
                
            }
            if (n > m)
            {
                gs = gs + 3;
                label18.Text = gs.ToString();
            }
            if (m == n)
            {
                bjk = bjk + 1;
                label15.Text = bjk.ToString();
                gs = gs + 1;
                label18.Text = gs.ToString();

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.Enabled = false;
            int x = skor.Next(0, 5);
            label27.Text = x.ToString();
            int y = skor.Next(0, 5);
            label22.Text = y.ToString();
            int z = skor.Next(0, 5);
            label24.Text = z.ToString();
            int t = skor.Next(0, 5);
            label21.Text = t.ToString();
            if (x > y)
            {
                bjk = bjk + 3;
                label15.Text = bjk.ToString();
            }
            if (y > x)
            {
                fb = fb + 3;
                label16.Text = fb.ToString();
            }
            if (x == y)
            {
                bjk = bjk + 1;
                label15.Text = bjk.ToString();
                fb = fb + 1;
                label16.Text = fb.ToString();
            }
            if (z > t)
            {
                gs = gs + 3;
                label18.Text = gs.ToString();
            }
            if (t > z)
            {
                ts = ts + 3;
                label17.Text = ts.ToString();
            }
            if (t == z)
            {
                gs = gs + 1;
                label18.Text = gs.ToString();
                ts = ts + 1;
                label17.Text = ts.ToString();
            }

            if (fb > ts && fb > gs && fb > bjk)
            {
                MessageBox.Show("ŞAMPİYON FENERBAHÇE!!!");
            }
            if (gs > fb && gs > bjk && gs > ts)
            {
                MessageBox.Show("ŞAMPİYON GALATASARAY!!!");
            }
            if (ts > gs && ts > bjk && ts > fb)
            {
                MessageBox.Show("ŞAMPİYON TRABZON!!!");
            }
            if (bjk > gs && bjk > ts && bjk > fb)
            {
                MessageBox.Show("ŞAMPİYON BEŞİKTAŞ!!!"); 
            }
        }
    }
}
