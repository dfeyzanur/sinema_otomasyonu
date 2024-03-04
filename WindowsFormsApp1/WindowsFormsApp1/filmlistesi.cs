using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class filmlistesi : Form
    {
        public filmlistesi()
        {

            InitializeComponent();
        }

        sqlbaglantisi bglnt = new sqlbaglantisi();

        void koltukayir()
        {
            listBox1.Items.Clear();

            string no ="";
            string[] sec;
            no = lblgelenkoltuk.Text.ToString();
            sec=no.Split(',');
            foreach (string bulunan in sec)
            {
                listBox1.Items.Add(bulunan);
            }

        }
        void koltuk()
        {
            
            bglnt.baglanti();
            string komut = "select * from kontrol_tbl inner join salontbl on kontrol_tbl.salon=salontbl.Salon where kontrol_tbl.seans=@seans and kontrol_tbl.salon=@p2  ";
            
            SqlCommand komutt=new SqlCommand(komut,bglnt.baglanti());
            komutt.Parameters.AddWithValue("@seans", label7.Text);
            komutt.Parameters.AddWithValue("@p2", Convert.ToInt16(label5.Text));
            
            
            SqlDataReader reader = komutt.ExecuteReader();
            while (reader.Read())
            {
                label6.Text=reader["Koltuk_Sayısı"].ToString();
            }
        }

        void koltukgetir()
        {
            lblgelenkoltuk.Text = "";
            string sorgu = "select * from sonkayıt where film_AD=@p1 and tarih=@p2 and seans=@p3";
            SqlCommand komut= new SqlCommand(sorgu,bglnt.baglanti());
            komut.Parameters.AddWithValue("@p1", comboBox1.Text);
            komut.Parameters.AddWithValue("@p2",tarihsecim.Text);
            komut.Parameters.AddWithValue("@p3", comboBox2.Text);
            SqlDataReader oku= komut.ExecuteReader();
            while (oku.Read())
            {
                lblgelenkoltuk.Text += "," + oku["koltuk"];
            }

            koltukayir();
        }
        void listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select* from yenifilmlist ", bglnt.baglanti());
           
            
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Columns[0].Visible=true;
            dataGridView1.Columns[4].Visible = false;
            dataGridView1.Columns[6].Visible = false;
            dataGridView1.Columns[7].Visible = false;
            dataGridView1.Columns[8].Visible = false;
           





        }
        DataTable tarihegore()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select* from yenifilmlist where tarih between @p1 and @p2 ", bglnt.baglanti());
            string yenitarih = tarihsecim.Value.AddDays(-5).ToString();
            da.SelectCommand.Parameters.Add("@p1",SqlDbType.Date).Value=yenitarih;
            
            da.SelectCommand.Parameters.Add("@p2",SqlDbType.Date).Value = tarihsecim.Text;


            da.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Columns[0].Visible = true;
            dataGridView1.Columns[3].Visible = false;
            dataGridView1.Columns[4].Visible = false;
            dataGridView1.Columns[5].Visible=true;
            dataGridView1.Columns[6].Visible = false;
            dataGridView1.Columns[7].Visible = false;
            dataGridView1.Columns[8].Visible = false;
            
            return dt;


        }



        private void filmlistesi_Load(object sender, EventArgs e)
        {
            label3.Text = (tarihsecim.Text+" Tarihinde");
            
           panel3.AutoScroll = true;
           

            listele();


        }

       

      
       

        private void tarihsecim_ValueChanged(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            comboBox2.Items.Clear();
            tarihegore();
            label3.Text = (tarihsecim.Text + " Tarihinde");


            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select* from yenifilmlist where tarih between @p1 and @p2 ", bglnt.baglanti());
            string yenitarih = tarihsecim.Value.AddDays(-5).ToString();
            da.SelectCommand.Parameters.Add("@p1", SqlDbType.Date).Value = yenitarih;

            da.SelectCommand.Parameters.Add("@p2", SqlDbType.Date).Value = tarihsecim.Text;


            SqlDataReader dr;

            dr = da.SelectCommand.ExecuteReader();

            while (dr.Read())
            {
                comboBox1.Items.Add(dr["film_AD"]);
            }
            bglnt.baglanti().Close();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            bglnt.baglanti();
            string komut = "select * from kontrol_tbl inner join yenifilmlist on yenifilmlist.film_AD=kontrol_tbl.film_AD where kontrol_tbl.film_AD=@p1 ";

            SqlCommand cmd = new SqlCommand(komut, bglnt.baglanti());
            cmd.Parameters.Add("@p1", SqlDbType.VarChar).Value =comboBox1.Text ;
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                comboBox2.Items.Add(reader["seans"]);

                label5.Text = (reader["salon"].ToString());
                
               
            }
            koltuk();
            
            bglnt.baglanti().Close();

            koltukgetir();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string komut = "insert into sonkayıt (film_AD,salon,seans,tarih,koltuk)values(@p1,@p2,@p3,@p4,@p5)";
            SqlCommand cmd = new SqlCommand(komut,bglnt.baglanti());
            cmd.Parameters.AddWithValue("@p1",comboBox1.Text);
            cmd.Parameters.AddWithValue("@p2", Convert.ToInt32(label5.Text));
            cmd.Parameters.AddWithValue("@p3", comboBox2.Text);
            cmd.Parameters.AddWithValue("@p4", tarihsecim.Text);
            cmd.Parameters.AddWithValue("@p5",txtkoltuklar.Text);
            
            SqlDataReader reader = cmd.ExecuteReader();

            if (textBox1.Text.Length != 16)
            {
                MessageBox.Show("Kart Numaranızı Yanlış Girdiniz");
            }
            else if (textBox2.Text.Length != 4)
            {
                MessageBox.Show("Şifrenizi Yanlış Girdiniz");
            }
            else
            {
                MessageBox.Show("ödeme yapılmıştır!\n İyi Seyirler dileriz!");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            kayıtekranı kayıtekranı =new kayıtekranı();
            kayıtekranı.Show();
            this.Hide();    
        }

        private void button3_Click(object sender, EventArgs e)
        {

            listBox1.Items.Clear();
            lblbelirlenenkoltuk.Items.Clear();
            panel3.Controls.Clear();
            koltukgetir();
            koltukayir();
            
            int sira = Convert.ToInt32(label6.Text);

            ;
            for (int i = 1; i <= sira / 10; i++)
            {

                for (int j = 0; j < 10; j++)
                {
                    Button button = new Button();
                    button.Location = new Point(55 * j, 55 * i);
                    if (i == 1)
                    {
                        button.Text = "A" + (j + 1).ToString();
                        button.Name = "A" + (j + 1).ToString();
                    }
                    else if (i == 2)
                    {
                        button.Text = "B" + (j + 1).ToString();
                        button.Name = "B" + (j + 1).ToString();
                    }
                    else if (i == 3)
                    {
                        button.Text = "C" + (j + 1).ToString();
                        button.Name = "C" + (j + 1).ToString();
                    }
                    else if (i == 4)
                    {
                        button.Text = "D" + (j + 1).ToString();
                        button.Name = "D" + (j + 1).ToString();
                    }
                    else if (i == 5)
                    {
                        button.Text = "E" + (j + 1).ToString();
                        button.Name = "E" + (j + 1).ToString();
                    }
                    else if (i == 6)
                    {
                        button.Text = "F" + (j + 1).ToString();
                        button.Name = "F" + (j + 1).ToString();
                    }


                    button.Width = 50;
                    button.Height = 50;
                    button.FlatStyle = FlatStyle.Flat;
                    button.FlatAppearance.BorderSize = 0;
                    button.Font = new System.Drawing.Font("Times New Roman", 12);
                    button.BackColor = Color.Red;
                    button.ForeColor = Color.White;
                    button.Click += button_Click;

                    if (listBox1.Items.Contains(button.Text))
                    {
                        
                        button.BackColor= Color.Blue;
                        button.ForeColor= Color.Violet;
                    }
                    else
                    {
                       
                        button.BackColor=Color.Red;
                        button.ForeColor= Color.White;
                    }

                    panel3.Controls.Add(button);

                }

            }
        }

        void butonoluştur()
        {
            txtkoltuklar.Text ="";
            foreach (var item in lblbelirlenenkoltuk.Items)
            {
                txtkoltuklar.Text += " ," + item;
            }
            if(txtkoltuklar.Text.Length > 2) 
            {
                txtkoltuklar.Text = txtkoltuklar.Text.Substring(2);
            }
        }
        private void button_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (button.ForeColor == Color.Violet)
            {
                MessageBox.Show("DOLU");
            }
            else
            {
                if (button.BackColor == Color.Red)
                {
                    label9.Text=button.Text;
                    button.BackColor = Color.Yellow;
                    lblbelirlenenkoltuk.Items.Add(button.Text);
                    butonoluştur();
                    if (lblbelirlenenkoltuk.Items.Count > 1)
                    {
                        MessageBox.Show("Sadece Bir Koltuk Seçebilirsiniz!");
                    }
                }
                else
                {
                    button.BackColor =Color.Red;
                    lblbelirlenenkoltuk.Items.Remove(button.Text);
                    butonoluştur();
                    if (lblbelirlenenkoltuk.Items.Count > 1)
                    {
                        MessageBox.Show("Sadece Bir Koltuk Seçebilirsiniz!");
                    }
                }
            }

        }
        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            label7.Text = comboBox2.Text.ToString();
            koltuk();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            butonoluştur();
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            
            filmbilgisiveödeme filmbilgisiveödeme=new filmbilgisiveödeme(comboBox1.Text.ToString(),tarihsecim.Text.ToString(),label9.Text);
            filmbilgisiveödeme.Show();
            this.Hide();
        }
    }
}
