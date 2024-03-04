using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class kayıtekranı : Form
    {
        public kayıtekranı()
        {
            InitializeComponent();
        }

        sqlbaglantisi bglnt = new sqlbaglantisi();

        void listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from tblkullanıcı", bglnt.baglanti());
            da.Fill(dt);

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bglnt.baglanti();
            SqlCommand cmd = new SqlCommand("select * from tblkullanıcı where kullanıcı_adı=@p1 and kullanıcı_sifre=@p2 ", bglnt.baglanti());
            cmd.Parameters.AddWithValue("@p1", kullanıcı_adıgrs.Text);
            cmd.Parameters.AddWithValue("@p2", sifregrs.Text);
            SqlDataReader dr = cmd.ExecuteReader();


            if (dr.Read())
            {
                filmlistesi filmlistesi = new filmlistesi();
                filmlistesi.Show();
                this.Hide();
            }

            else if (kullanıcı_adıgrs.Text.ToLower() == "personelgiris" && sifregrs.Text.ToLower() == "1234")
            {
                personelekranı personel = new personelekranı();
                personel.Show();
                this.Hide();
            }
            
            else
            {
                MessageBox.Show("Giriş Yapılamadı!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (p4.Text.ToLower() == p5.Text.ToLower())
            {
                bglnt.baglanti();
                SqlCommand cmd = new SqlCommand("insert into tblkullanıcı(kullanıcı_AD,kullanıcı_SOYAD,kullanıcı_adı,kullanıcı_sifre) values (@p8,@p7,@p6,@p5)", bglnt.baglanti());
                cmd.Parameters.AddWithValue("@p8", p8.Text);
                cmd.Parameters.AddWithValue("@p7", p7.Text);
                cmd.Parameters.AddWithValue("@p6", p6.Text);
                cmd.Parameters.AddWithValue("@p5", p5.Text);
                cmd.ExecuteNonQuery();
                bglnt.baglanti().Close();
                MessageBox.Show("Kaydınız Gerçekleştirildi \n Giriş Yapınız!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Şifreler uyumlu degil!","Uyarı",MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            personelekranı personel = new personelekranı();
            personel.Show();
            this.Hide();
        }

        private void kayıtekranı_Load(object sender, EventArgs e)
        {
            
            label1.BackColor = Color.Transparent;

        }
    }
    }
