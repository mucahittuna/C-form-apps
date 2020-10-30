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

namespace KütüohaneProgramı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-R2H0HJO;Initial Catalog=library;Integrated Security=True");
        public void ShowData(string veri)
        {
            SqlDataAdapter da = new SqlDataAdapter(veri, con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];

        }
        private void button1_Click(object sender, EventArgs e)
        {
            ShowData("select *from books");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into books (ad,yazar,sayfano,basımevi,tur)values(@ad,@yazar,@sayfano,@basımevi,@tur)", con);
            cmd.Parameters.AddWithValue("@ad",textBox1.Text);
            cmd.Parameters.AddWithValue("@yazar", textBox2.Text);
            cmd.Parameters.AddWithValue("@sayfano", textBox3.Text);
            cmd.Parameters.AddWithValue("@basımevi", textBox4.Text);
            cmd.Parameters.AddWithValue("@tur", comboBox1.Text);
            cmd.ExecuteNonQuery();
            ShowData("select *from books");
            con.Close();
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox1.Focus();
            

        }

        private void button3_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("delete from books where ad=@ad",con);
            cmd.Parameters.AddWithValue("@ad", textBox5.Text);
            cmd.ExecuteNonQuery();
            ShowData("select *from books");
            
            con.Close();
            textBox5.Clear();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select *from books where ad like '%" + textBox6.Text + "%'", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            con.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int x = dataGridView1.SelectedCells[0].RowIndex;
            string ad = dataGridView1.Rows[x].Cells[0].Value.ToString();
            string yazar = dataGridView1.Rows[x].Cells[1].Value.ToString();
            string sayfano = dataGridView1.Rows[x].Cells[2].Value.ToString();
            string basımevi = dataGridView1.Rows[x].Cells[3].Value.ToString();
            string tur = dataGridView1.Rows[x].Cells[4].Value.ToString();
            textBox1.Text = ad;
            textBox2.Text = yazar;
            textBox3.Text = sayfano;
            textBox4.Text = basımevi;
            comboBox1.Text = tur;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("update books set yazar=@yazar,sayfano=@sayfano,basımevi=@basımevi,tur=@tur where ad=@ad",con);
            cmd.Parameters.AddWithValue("@ad", textBox1.Text);
            cmd.Parameters.AddWithValue("@yazar", textBox2.Text);
            cmd.Parameters.AddWithValue("@sayfano", textBox3.Text);
            cmd.Parameters.AddWithValue("@basımevi", textBox4.Text);
            cmd.Parameters.AddWithValue("@tur", comboBox1.Text);
            cmd.ExecuteNonQuery();
            ShowData("select *from books");
            con.Close();
        }
    }
}
