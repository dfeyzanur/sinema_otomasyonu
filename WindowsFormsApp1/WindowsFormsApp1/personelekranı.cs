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
using static System.Net.WebRequestMethods;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class personelekranı : Form
    {
        public personelekranı()
        {
            InitializeComponent();
        }
        string resimAdresi;

        public void DialogHazirla()
        {
            openFileDialog1.Title = "Film Posterini seç.";
            openFileDialog1.Filter = "Jpeg Dosyalari(*.jpg)|*.jpg|Gif dosyalari(*.gif)|*.gif";
        }

        sqlbaglantisi bglnt = new sqlbaglantisi();

        void listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from yenifilmlist" +
                "", bglnt.baglanti());
            da.Fill(dt);
                    

        }
        void ekle()
        {
            bglnt.baglanti();
            SqlCommand cmd = new SqlCommand("insert into yenifilmlist(film_AD,film_DAKİKA,film_TÜR,film_YÖNETMEN,film_OYUNCU,film_KONU,tarih,film_AFİŞİ) " +
                "values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8)", bglnt.baglanti());
            cmd.Parameters.AddWithValue("@p1", filmad.Text);
            cmd.Parameters.AddWithValue("@p2", dakika.Text);
            cmd.Parameters.AddWithValue("@p3", tür.Text);
            cmd.Parameters.AddWithValue("@p7", tarih.Text);

            cmd.Parameters.AddWithValue("@p4", yönetmen.Text);
            cmd.Parameters.AddWithValue("@p5", oyuncu.Text);
            cmd.Parameters.AddWithValue("@p6", konu.Text);
            cmd.Parameters.AddWithValue("@p8", bglnt.resimdenbyte(pictureBox1.Image));
            cmd.ExecuteNonQuery();
            bglnt.baglanti().Close();
            MessageBox.Show("Kaydedildi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }
       

        
        private void button2_Click(object sender, EventArgs e)
        {
            kayıtekranı f = new kayıtekranı();
            f.Show();
            this.Hide();
        }

        

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void propertyGrid1_Click(object sender, EventArgs e)
        {
            
        }

        private void personelekranı_Load(object sender, EventArgs e)
        {
            DialogHazirla();

            SqlCommand cmd = new SqlCommand("SELECT * from salontbl", bglnt.baglanti());
            SqlDataReader dr;

            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                
                comboBox2.Items.Add(dr["Salon"]);
            }
            bglnt.baglanti().Close();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = System.Drawing.Image.FromFile(openFileDialog1.FileName); /* Drawing isim uzayinda yer alan Image sinifinin 
                                                                                   * FromFile metodunu kullanarak belirtilen adresteki dosya PictureBox kontrolü içine çizilir. */
                label11.Text = openFileDialog1.FileName.ToString();
                resimAdresi = openFileDialog1.FileName.ToString();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            
            ekle();

            }

        private void button3_Click(object sender, EventArgs e)
        {
            bglnt.baglanti();
            string komut = "insert into kontrol_tbl(film_AD,salon,seans)values(@p1,@p2,@p3)";
            SqlCommand komutt=new SqlCommand(komut,bglnt.baglanti());


                komutt.Parameters.AddWithValue("@p1", filmad.Text);
                komutt.Parameters.AddWithValue("@p2", Convert.ToInt16(comboBox2.Text));
                komutt.Parameters.AddWithValue("@p3", comboBox1.Text);
            
            
           

            komutt.ExecuteNonQuery();
            bglnt.baglanti().Close();
            MessageBox.Show("Kaydedildi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
