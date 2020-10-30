using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebTarayıcı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(textBox1.Text);
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("www.google.com");
        }

       

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongDateString();
            label2.Text = DateTime.Now.ToLongTimeString();
        }

        private void dövizToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void wwwhaberlercomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("www.sozcu.com");
        }

        private void milliyetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("www.milliyet.com");
        }

        private void sabahToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("www.sabah.com");
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel2.Text = webBrowser1.StatusText;
            
        }

        private void webBrowser1_ProgressChanged(object sender, WebBrowserProgressChangedEventArgs e)
        {
            try
            {
                toolStripProgressBar1.Maximum = Convert.ToInt32(e.MaximumProgress);
                toolStripProgressBar1.Value = Convert.ToInt32(e.CurrentProgress);
            }
            catch (Exception)
            {
                toolStripProgressBar1.Minimum = 0;
                
            }
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            gecmis();
        }
        private void gecmis()
        {
            listBox1.Items.Clear();
            StreamReader dosya = new StreamReader("gecmis.txt");
            while (!dosya.EndOfStream)
            {
                listBox1.Items.Add(dosya.ReadLine());
            }
            dosya.Close();
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            FileStream g = new FileStream("gecmis.txt", FileMode.Append);
            StreamWriter yaz = new StreamWriter(g);
            yaz.WriteLine(webBrowser1.Url);
            yaz.Close();
            

        }

        private void button7_Click(object sender, EventArgs e)
        {
            StreamWriter dosya = new StreamWriter("gecmis.txt");
            dosya.Write("");
            dosya.Close();
            gecmis();
        }
    }
}
