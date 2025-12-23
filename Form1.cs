using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SQLite;

namespace SporSalonu
{
    public partial class Form1 : Form
    {
        [cite_start]// Veritabanı bağlantı cümlesi 
        string baglantiCumlesi = "Data Source=spor_merkezi.db;Version=3;";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            VeritabaniniKur();
            Listele();
        }

        void VeritabaniniKur()
        {
            using (SQLiteConnection baglanti = new SQLiteConnection(baglantiCumlesi))
            {
                baglanti.Open();
                [cite_start]// Tablo oluşturma sorgusu 
                string sorgu = "CREATE TABLE IF NOT EXISTS Uyeler (UyeNo INTEGER PRIMARY KEY, AdSoyad TEXT, Telefon TEXT, KayitTarihi TEXT, AyrilmaTarihi TEXT, Program TEXT, AylikOdeme INTEGER)";
                using (SQLiteCommand komut = new SQLiteCommand(sorgu, baglanti))
                {
                    komut.ExecuteNonQuery();
                }
            }
        }

        void Listele()
        {
            using (SQLiteConnection baglanti = new SQLiteConnection(baglantiCumlesi))
            {
                SQLiteDataAdapter da = new SQLiteDataAdapter("SELECT * FROM Uyeler", baglanti);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        [cite_start]// GÜVENLİ ÜYE EKLEME (Parametreli Sorgu) 
        private void btnEkle_Click(object sender, EventArgs e)
        {
            using (SQLiteConnection baglanti = new SQLiteConnection(baglantiCumlesi))
            {
                baglanti.Open();
                string sorgu = "INSERT INTO Uyeler (UyeNo, AdSoyad, Telefon, KayitTarihi, AyrilmaTarihi, Program, AylikOdeme) " +
                               "VALUES (@no, @ad, @tel, @kayit, @ayrilma, @prog, @odeme)";

                using (SQLiteCommand komut = new SQLiteCommand(sorgu, baglanti))
                {
                    // Değerler doğrudan SQL içine gömülmez, parametre olarak eklenir.
                    komut.Parameters.AddWithValue("@no", txtUyeNo.Text);
                    komut.Parameters.AddWithValue("@ad", txtAdSoyad.Text);
                    komut.Parameters.AddWithValue("@tel", txtTelefon.Text);
                    komut.Parameters.AddWithValue("@kayit", dtpKayit.Value.ToShortDateString());
                    komut.Parameters.AddWithValue("@ayrilma", dtpAyrilma.Value.ToShortDateString());
                    komut.Parameters.AddWithValue("@prog", txtProgram.Text);
                    komut.Parameters.AddWithValue("@odeme", txtOdeme.Text);

                    komut.ExecuteNonQuery();
                }
            }
            Listele();
            MessageBox.Show("Üye güvenli bir şekilde eklendi.");
        }

        [cite_start]// GÜVENLİ ÜYE SİLME 
        private void btnSil_Click(object sender, EventArgs e)
        {
            using (SQLiteConnection baglanti = new SQLiteConnection(baglantiCumlesi))
            {
                baglanti.Open();
                string sorgu = "DELETE FROM Uyeler WHERE UyeNo = @no";
                using (SQLiteCommand komut = new SQLiteCommand(sorgu, baglanti))
                {
                    komut.Parameters.AddWithValue("@no", txtUyeNo.Text);
                    komut.ExecuteNonQuery();
                }
            }
            Listele();
            MessageBox.Show("Üye silindi.");
        }

        [cite_start]// GÜVENLİ ÜYE SORGULAMA 
        private void btnSorgula_Click(object sender, EventArgs e)
        {
            using (SQLiteConnection baglanti = new SQLiteConnection(baglantiCumlesi))
            {
                // LIKE operatörü ile parametre kullanımı
                string sorgu = "SELECT * FROM Uyeler WHERE AdSoyad LIKE @ad";
                using (SQLiteDataAdapter da = new SQLiteDataAdapter(sorgu, baglanti))
                {
                    da.SelectCommand.Parameters.AddWithValue("@ad", "%" + txtAdSoyad.Text + "%");
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
            }
        }

        [cite_start]// GÜVENLİ ÖDEME SORGULAMA 
        private void btnOdemeSorgu_Click(object sender, EventArgs e)
        {
            using (SQLiteConnection baglanti = new SQLiteConnection(baglantiCumlesi))
            {
                string sorgu = "SELECT * FROM Uyeler WHERE AylikOdeme = @odeme";
                using (SQLiteDataAdapter da = new SQLiteDataAdapter(sorgu, baglanti))
                {
                    da.SelectCommand.Parameters.AddWithValue("@odeme", txtOdeme.Text);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
            }
        }

        [cite_start]// GÜVENLİ ÜYE GÜNCELLEME 
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            using (SQLiteConnection baglanti = new SQLiteConnection(baglantiCumlesi))
            {
                baglanti.Open();
                string sorgu = "UPDATE Uyeler SET AdSoyad=@ad, Telefon=@tel, KayitTarihi=@kayit, " +
                               "AyrilmaTarihi=@ayrilma, Program=@prog, AylikOdeme=@odeme WHERE UyeNo=@no";

                using (SQLiteCommand komut = new SQLiteCommand(sorgu, baglanti))
                {
                    komut.Parameters.AddWithValue("@ad", txtAdSoyad.Text);
                    komut.Parameters.AddWithValue("@tel", txtTelefon.Text);
                    komut.Parameters.AddWithValue("@kayit", dtpKayit.Value.ToShortDateString());
                    komut.Parameters.AddWithValue("@ayrilma", dtpAyrilma.Value.ToShortDateString());
                    komut.Parameters.AddWithValue("@prog", txtProgram.Text);
                    komut.Parameters.AddWithValue("@odeme", txtOdeme.Text);
                    komut.Parameters.AddWithValue("@no", txtUyeNo.Text);

                    komut.ExecuteNonQuery();
                }
            }
            Listele();
            MessageBox.Show("Üye bilgileri güncellendi.");
        }
    }
}