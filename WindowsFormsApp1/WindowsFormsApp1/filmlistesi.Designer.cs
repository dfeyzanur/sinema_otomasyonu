namespace WindowsFormsApp1
{
    partial class filmlistesi
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tarih = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tarihsecim = new System.Windows.Forms.DateTimePicker();
            this.geri = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblgelenkoltuk = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.olustur = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.salon = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.sec = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lblbelirlenenkoltuk = new System.Windows.Forms.ListBox();
            this.txtkoltuklar = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tarih
            // 
            this.tarih.AutoSize = true;
            this.tarih.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tarih.Location = new System.Drawing.Point(764, 91);
            this.tarih.Name = "tarih";
            this.tarih.Size = new System.Drawing.Size(0, 22);
            this.tarih.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.WindowText;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.geri);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tarihsecim);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1282, 106);
            this.panel1.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Brown;
            this.label3.Location = new System.Drawing.Point(12, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "label3";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Brown;
            this.label1.Location = new System.Drawing.Point(12, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "VİZYONDAKİ FİLMLER";
            // 
            // tarihsecim
            // 
            this.tarihsecim.CalendarMonthBackground = System.Drawing.SystemColors.Menu;
            this.tarihsecim.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.tarihsecim.Location = new System.Drawing.Point(731, 55);
            this.tarihsecim.Name = "tarihsecim";
            this.tarihsecim.Size = new System.Drawing.Size(200, 22);
            this.tarihsecim.TabIndex = 1;
            this.tarihsecim.ValueChanged += new System.EventHandler(this.tarihsecim_ValueChanged);
            // 
            // geri
            // 
            this.geri.BackColor = System.Drawing.Color.Black;
            this.geri.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.Ekran_görüntüsü_2024_01_02_142052;
            this.geri.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.geri.Location = new System.Drawing.Point(3, 0);
            this.geri.Name = "geri";
            this.geri.Size = new System.Drawing.Size(40, 40);
            this.geri.TabIndex = 5;
            this.geri.UseVisualStyleBackColor = false;
            this.geri.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Brown;
            this.panel2.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.indir__2_;
            this.panel2.Controls.Add(this.textBox2);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.txtkoltuklar);
            this.panel2.Controls.Add(this.lblbelirlenenkoltuk);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.comboBox2);
            this.panel2.Controls.Add(this.listBox1);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.lblgelenkoltuk);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.olustur);
            this.panel2.Controls.Add(this.salon);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.sec);
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1282, 653);
            this.panel2.TabIndex = 6;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(1011, 147);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(232, 180);
            this.listBox1.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(501, 347);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "label6";
            // 
            // lblgelenkoltuk
            // 
            this.lblgelenkoltuk.AutoSize = true;
            this.lblgelenkoltuk.Location = new System.Drawing.Point(1014, 128);
            this.lblgelenkoltuk.Name = "lblgelenkoltuk";
            this.lblgelenkoltuk.Size = new System.Drawing.Size(44, 16);
            this.lblgelenkoltuk.TabIndex = 12;
            this.lblgelenkoltuk.Text = "label6";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(386, 348);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "label5";
            // 
            // olustur
            // 
            this.olustur.Location = new System.Drawing.Point(471, 393);
            this.olustur.Name = "olustur";
            this.olustur.Size = new System.Drawing.Size(75, 23);
            this.olustur.TabIndex = 10;
            this.olustur.Text = "oluştur";
            this.olustur.UseVisualStyleBackColor = true;
            this.olustur.Click += new System.EventHandler(this.button3_Click);
            // 
            // panel3
            // 
            this.panel3.AllowDrop = true;
            this.panel3.Location = new System.Drawing.Point(596, 120);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(661, 501);
            this.panel3.TabIndex = 8;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // salon
            // 
            this.salon.AutoSize = true;
            this.salon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.salon.Location = new System.Drawing.Point(316, 341);
            this.salon.Name = "salon";
            this.salon.Size = new System.Drawing.Size(63, 25);
            this.salon.TabIndex = 7;
            this.salon.Text = "Salon";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(316, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "Seans Seçimi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(311, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Film Seçimi";
            // 
            // sec
            // 
            this.sec.BackColor = System.Drawing.Color.Brown;
            this.sec.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.sec.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sec.ForeColor = System.Drawing.Color.Black;
            this.sec.Location = new System.Drawing.Point(316, 552);
            this.sec.Name = "sec";
            this.sec.Size = new System.Drawing.Size(231, 78);
            this.sec.TabIndex = 4;
            this.sec.Text = "SEÇ";
            this.sec.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.sec.UseVisualStyleBackColor = false;
            this.sec.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(316, 174);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(231, 24);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Silver;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView1.Location = new System.Drawing.Point(0, 101);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(305, 529);
            this.dataGridView1.TabIndex = 0;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(316, 271);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(231, 24);
            this.comboBox2.TabIndex = 16;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(486, 261);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 16);
            this.label7.TabIndex = 17;
            this.label7.Text = "label7";
            // 
            // lblbelirlenenkoltuk
            // 
            this.lblbelirlenenkoltuk.FormattingEnabled = true;
            this.lblbelirlenenkoltuk.ItemHeight = 16;
            this.lblbelirlenenkoltuk.Location = new System.Drawing.Point(1011, 322);
            this.lblbelirlenenkoltuk.Name = "lblbelirlenenkoltuk";
            this.lblbelirlenenkoltuk.Size = new System.Drawing.Size(232, 180);
            this.lblbelirlenenkoltuk.TabIndex = 18;
            // 
            // txtkoltuklar
            // 
            this.txtkoltuklar.Location = new System.Drawing.Point(995, 583);
            this.txtkoltuklar.Name = "txtkoltuklar";
            this.txtkoltuklar.Size = new System.Drawing.Size(262, 22);
            this.txtkoltuklar.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(995, 552);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(158, 25);
            this.label8.TabIndex = 20;
            this.label8.Text = "Seçilen Koltuklar";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1098, 23);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(159, 42);
            this.button1.TabIndex = 6;
            this.button1.Text = "ileri";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(633, 628);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 16);
            this.label9.TabIndex = 0;
            this.label9.Text = "label9";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(316, 433);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(84, 25);
            this.label10.TabIndex = 21;
            this.label10.Text = "Kart No:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(406, 437);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(156, 22);
            this.textBox1.TabIndex = 22;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(301, 486);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(99, 25);
            this.label11.TabIndex = 23;
            this.label11.Text = "Kart Şifre:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(406, 490);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(169, 22);
            this.textBox2.TabIndex = 24;
            // 
            // filmlistesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1282, 653);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tarih);
            this.Controls.Add(this.panel2);
            this.Name = "filmlistesi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "filmlistesi";
            this.Load += new System.EventHandler(this.filmlistesi_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label tarih;
        private System.Windows.Forms.Button sec;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker tarihsecim;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button geri;
        
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label salon;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button olustur;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblgelenkoltuk;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox lblbelirlenenkoltuk;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtkoltuklar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox1;
    }
}