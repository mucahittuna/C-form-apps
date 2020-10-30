using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace VeriTabanlıBilgiYarışması
{
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-R2H0HJO;Initial Catalog=BilgiYarismasi;Integrated Security=True");
        public Form1()
        {
            InitializeComponent();
        }
        int sayac = 0;
        int puan = 0;
        int zaman = 20;
        private void button5_Click(object sender, EventArgs e)
        {
            zaman = 20;
            timer1.Enabled = true;
            
            
            label3.Visible = false;
            button5.Text = "İLERİ";
            sayac++;
            label5.Text = sayac.ToString();
            if (sayac == 1)
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select *from sorular order by NEWID()", con);
                SqlDataReader oku = cmd.ExecuteReader();
                while (oku.Read())
                {
                    button1.Text = (oku["a"].ToString());
                    button2.Text = (oku["b"].ToString());
                    button3.Text = (oku["c"].ToString());
                    button4.Text = (oku["d"].ToString());
                    richTextBox1.Text = (oku["soru"].ToString());
                    label3.Text = (oku["dogru"].ToString());
                }
                con.Close();
            }
            if (sayac == 2)
            {
                button1.BackColor = Color.White;
                button2.BackColor = Color.White;
                button3.BackColor = Color.White;
                button4.BackColor = Color.White;
                button1.Enabled = true;
                button2.Enabled = true;
                button3.Enabled = true;
                button4.Enabled = true;
                con.Open();
                SqlCommand cmd2 = new SqlCommand("select *from sorular2 order by NEWID()", con);
                SqlDataReader oku2 = cmd2.ExecuteReader();
                while (oku2.Read())
                {
                    button1.Text = (oku2["a"].ToString());
                    button2.Text = (oku2["b"].ToString());
                    button3.Text = (oku2["c"].ToString());
                    button4.Text = (oku2["d"].ToString());
                    richTextBox1.Text = (oku2["soru"].ToString());
                    label3.Text = (oku2["dogru"].ToString());
                }
                con.Close();
            }
            if (sayac == 3)
            {
                button5.Text = "BİTİR";
                button1.BackColor = Color.White;
                button2.BackColor = Color.White;
                button3.BackColor = Color.White;
                button4.BackColor = Color.White;
                button1.Enabled = true;
                button2.Enabled = true;
                button3.Enabled = true;
                button4.Enabled = true;
                con.Open();
                SqlCommand cmd2 = new SqlCommand("select *from sorular3 order by NEWID()", con);
                SqlDataReader oku2 = cmd2.ExecuteReader();
                while (oku2.Read())
                {
                    button1.Text = (oku2["a"].ToString());
                    button2.Text = (oku2["b"].ToString());
                    button3.Text = (oku2["c"].ToString());
                    button4.Text = (oku2["d"].ToString());
                    richTextBox1.Text = (oku2["soru"].ToString());
                    label3.Text = (oku2["dogru"].ToString());
                }
                con.Close();
            }
            if (sayac == 4)
            {
                label5.Visible = false;
               
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (sayac == 1)
            {
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                if (button1.Text == label3.Text)
                {
                    button1.BackColor = Color.Green;
                    puan = puan + 10;
                    label1.Text = puan.ToString();
                }
                else
                    button1.BackColor = Color.Red;
                
            }
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;

            if (sayac == 2)
            {
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                if (button1.Text == label3.Text)
                {
                    button1.BackColor = Color.Green;
                    puan = puan + 10;
                    label1.Text = puan.ToString();
                }
                else
                    button1.BackColor = Color.Red;

            }
            if (sayac == 3)
            {
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                if (button1.Text == label3.Text)
                {
                    button1.BackColor = Color.Green;
                    puan = puan + 10;
                    label1.Text = puan.ToString();
                }
                else
                    button1.BackColor = Color.Red;

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (sayac == 1)
            {
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                if (button2.Text == label3.Text)
                {
                    button2.BackColor = Color.Green;
                    puan = puan + 10;
                    label1.Text = puan.ToString();
                }
                else
                    button2.BackColor = Color.Red;
            }
            if (sayac == 2)
            {
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                if (button2.Text == label3.Text)
                {
                    button2.BackColor = Color.Green;
                    puan = puan + 10;
                    label1.Text = puan.ToString();
                }
                else
                    button2.BackColor = Color.Red;
            }
            if (sayac == 3)
            {
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                if (button2.Text == label3.Text)
                {
                    button2.BackColor = Color.Green;
                    puan = puan + 10;
                    label1.Text = puan.ToString();
                }
                else
                    button2.BackColor = Color.Red;
            }


        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (sayac == 1)
            {
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                if (button3.Text == label3.Text)
                {
                    button3.BackColor = Color.Green;
                    puan = puan + 10;
                    label1.Text = puan.ToString();
                }
                else
                    button3.BackColor = Color.Red;
            }
            if (sayac == 2)
            {
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                if (button1.Text == label3.Text)
                {
                    button3.BackColor = Color.Green;
                    puan = puan + 10;
                    label1.Text = puan.ToString();
                }
                else
                    button3.BackColor = Color.Red;
            }
            if (sayac == 3)
            {
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                if (button3.Text == label3.Text)
                {
                    button3.BackColor = Color.Green;
                    puan = puan + 10;
                    label1.Text = puan.ToString();
                }
                else
                    button3.BackColor = Color.Red;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (sayac == 1)
            {
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                if (button4.Text == label3.Text)
                {
                    button4.BackColor = Color.Green;
                    puan = puan + 10;
                    label1.Text = puan.ToString();
                }
                else
                    button4.BackColor = Color.Red;
            }
            if (sayac == 2)
            {
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                if (button1.Text == label3.Text)
                {
                    button4.BackColor = Color.Green;
                    puan = puan + 10;
                    label1.Text = puan.ToString();
                }
                else
                    button4.BackColor = Color.Red;
            }
            if (sayac == 3)
            {
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                if (button4.Text == label3.Text)
                {
                    button4.BackColor = Color.Green;
                    puan = puan + 10;
                    label1.Text = puan.ToString();
                }
                else
                    button4.BackColor = Color.Red;
            }

        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            zaman = zaman - 1;
            label6.Text = zaman.ToString();
            if (zaman == 0)
            {
                timer1.Enabled = false;
                MessageBox.Show("SÜRE DOLDU");
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
            }

        }
    }
}
