using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class filmbilgisiveödeme : Form
    {
        string film;
        string tarih;
        string koltuk;
        public filmbilgisiveödeme(string film_adi,string tarih,string koltuk)
        {
            this.koltuk = koltuk;
            this.tarih = tarih;
            this.film = film_adi;
            InitializeComponent();
        }

        sqlbaglantisi baglanti=new sqlbaglantisi();

        void yerbilgisi()
        {
            baglanti.baglanti();
            string komut = "select * from sonkayıt where film_AD=@p1 and koltuk=@p2";
            SqlCommand komt = new SqlCommand(komut,baglanti.baglanti());
            komt.Parameters.AddWithValue("@p1", film);
            komt.Parameters.AddWithValue("@p2", koltuk);
            SqlDataReader reader = komt.ExecuteReader();
            while (reader.Read())
            {
                label12.Text = "Salon" + reader["salon"];
                label13.Text = "Seans: " + reader["seans"];
                label14.Text = "Koltuk" + reader["koltuk"];
            }
        }
        
        
        private void filmbilgisiveödeme_Load(object sender, EventArgs e)
        {
            label9.Text = tarih;
            SqlCommand sqlCommand = new SqlCommand("SELECT * from yenifilmlist where film_AD=@p1", baglanti.baglanti());
            sqlCommand.Parameters.AddWithValue("@p1", film);
            SqlDataReader reader = sqlCommand.ExecuteReader();

            while(reader.Read())
            {
                
              
                label1.Text = reader["film_AD"].ToString();
                label2.Text = "Tür: " + reader["film_TÜR"];
                label3.Text = "Yönetmen: " + reader["film_YÖNETMEN"];
                label4.Text = "Oyuncular: " + reader["film_OYUNCU"];
                label5.Text = "Konu: " + reader["film_KONU"];
                pictureBox1.Image = baglanti.bytedanresime((byte[]) reader["film_AFİŞİ"]);
               
            }
            baglanti.baglanti().Close();

            yerbilgisi();

           

        }

        private void button1_Click(object sender, EventArgs e)
        {
            filmlistesi film = new filmlistesi();
            film.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            filmlistesi filmlistesi = new filmlistesi();
            filmlistesi.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
           
        }

        private void button1_Click_3(object sender, EventArgs e)
        {
            MessageBox.Show("çıkış yapıldı");
            this.Close();
            
        }
    }
}
