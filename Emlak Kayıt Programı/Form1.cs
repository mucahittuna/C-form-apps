using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace EmlakProgramı
{
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-R2H0HJO;Initial Catalog=EmlakKayıt;Integrated Security=True");
        private void VerileriGoster()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Select *from sitebilgi", con);
            SqlDataReader oku = cmd.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = (oku["id"].ToString());
                ekle.SubItems.Add(oku["site"].ToString());
                ekle.SubItems.Add(oku["durum"].ToString());
                ekle.SubItems.Add(oku["odasayi"].ToString());
                ekle.SubItems.Add(oku["alan"].ToString());
                ekle.SubItems.Add(oku["fiyat"].ToString());
                ekle.SubItems.Add(oku["blok"].ToString());
                ekle.SubItems.Add(oku["no"].ToString());
                ekle.SubItems.Add(oku["isim"].ToString());
                ekle.SubItems.Add(oku["telno"].ToString());
                ekle.SubItems.Add(oku["not"].ToString());
                
                listView1.Items.Add(ekle);
            }
            con.Close();
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            VerileriGoster();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Insert Into sitebilgi (id,site,durum,odasayi,alan,fiyat,blok,no,isim,telno,[not]) values ('"+textBox6.Text.ToString()+"','" + comboBox1.Text.ToString() + "','"+ comboBox2.Text.ToString() + "','"+ comboBox3.Text.ToString() + "','"+ textBox4.Text.ToString() + "','"+ textBox5.Text.ToString() + "','"+ comboBox4.Text.ToString() + "','"+ comboBox5.Text.ToString() + "','"+ textBox2.Text.ToString() + "','"+ textBox3.Text.ToString() + "','"+ textBox1.Text.ToString() + "')", con);
            cmd.ExecuteNonQuery();
            con.Close();
            /*SqlCommand cmd = new SqlCommand("insert into [sitebilgi](site,durum,odasayi,alan,fiyat,blok,no,isim,telno,[not]) values (@site,@durum,@odasayi,@alan,@fiyat,@blok,@no,@isim,@telno,@[not])");
            cmd.Parameters.AddWithValue("@site", comboBox1.Text.ToString());
            cmd.Parameters.AddWithValue("@durum", comboBox2.Text.ToString());
            cmd.Parameters.AddWithValue("@odasayi", comboBox3.Text.ToString());
            cmd.Parameters.AddWithValue("@alan", textBox4.Text.ToString());
            cmd.Parameters.AddWithValue("@fiyat", textBox5.Text.ToString());
            cmd.Parameters.AddWithValue("@blok", comboBox4.Text.ToString());
            cmd.Parameters.AddWithValue("@no", comboBox5.Text.ToString());
            cmd.Parameters.AddWithValue("@isim", textBox2.Text.ToString());
            cmd.Parameters.AddWithValue("@telno", textBox3.Text.ToString());
            cmd.Parameters.AddWithValue("@[not]", textBox1.Text.ToString());
            cmd.ExecuteNonQuery();
            con.Close();
            */
            
            
        }
        int id = 0;
        private void button3_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd2 = new SqlCommand("delete from sitebilgi where id=(" + id + ")",con);
            cmd2.ExecuteNonQuery();
            con.Close();
        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            textBox6.Text = listView1.SelectedItems[0].SubItems[0].Text;
            comboBox1.Text = listView1.SelectedItems[0].SubItems[1].Text;
            comboBox2.Text = listView1.SelectedItems[0].SubItems[2].Text;
            comboBox3.Text = listView1.SelectedItems[0].SubItems[3].Text;
            textBox4.Text = listView1.SelectedItems[0].SubItems[4].Text;
            textBox5.Text = listView1.SelectedItems[0].SubItems[5].Text;
            comboBox4.Text = listView1.SelectedItems[0].SubItems[6].Text;
            comboBox5.Text = listView1.SelectedItems[0].SubItems[7].Text;
            textBox2.Text = listView1.SelectedItems[0].SubItems[8].Text;
            textBox3.Text = listView1.SelectedItems[0].SubItems[9].Text;
            textBox1.Text = listView1.SelectedItems[0].SubItems[10].Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            con.Open();
            //string deneme = "update sitebilgi set site=@site,durum=@durum,odasayi=@odasayi,alan=@alan,fiyat=@fiyat,blok=@blok,no=@no,isim=@isim,telno=@telno,[not]=@[not] where id=@id";
            SqlCommand cmd = new SqlCommand("update sitebilgi set id='" + textBox6.Text.ToString() + "',site='" + comboBox1.Text.ToString() + "',durum='" + comboBox2.Text.ToString() + "',odasayi='" + comboBox3.Text.ToString() + "',alan='" + textBox4.Text.ToString() + "',fiyat='" + textBox5.Text.ToString() + "',blok='" + comboBox4.Text.ToString() + "',no='" + comboBox5.Text.ToString() + "',isim='" + textBox2.Text.ToString() + "',telno='" + textBox3.Text.ToString() + "',[not]='" + textBox1.Text.ToString() + "'where id="+id+"",con);
            cmd.ExecuteNonQuery();
            con.Close();
            //SqlCommand cmd = new SqlCommand(deneme, con);
            /*cmd.Parameters.AddWithValue("@site", comboBox1.Text);
            cmd.Parameters.AddWithValue("@durum", comboBox2.Text);
            cmd.Parameters.AddWithValue("@odasayi", comboBox3.Text);
            cmd.Parameters.AddWithValue("@alan", textBox4.Text);
            cmd.Parameters.AddWithValue("@fiyat", textBox5.Text);
            cmd.Parameters.AddWithValue("@blok", comboBox4.Text);
            cmd.Parameters.AddWithValue("@no", comboBox5.Text);
            cmd.Parameters.AddWithValue("@isim", textBox2.Text);
            cmd.Parameters.AddWithValue("@telno", textBox3.Text);
            cmd.Parameters.AddWithValue("@[not]", textBox1.Text);
            cmd.Parameters.AddWithValue("@id", textBox6.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            */
        }
    }
}
