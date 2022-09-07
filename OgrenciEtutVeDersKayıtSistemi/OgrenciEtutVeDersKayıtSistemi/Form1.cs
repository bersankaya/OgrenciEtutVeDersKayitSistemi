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
using System.IO;
namespace OgrenciEtutVeDersKayıtSistemi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Data Source=LAPTOP-AGQ4V6UP;Initial Catalog=OgrenciEtut&DersKayıtSistemi;Integrated Security=True");
        
        void ogretmen()
        {
            SqlDataAdapter dt1 = new SqlDataAdapter("SELECT * FROM TBLOGRETMEN", conn);
            DataTable da1 = new DataTable();
            dt1.Fill(da1);
            dataGridView1.DataSource = da1;
        }
        void ogrenci()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from TBLOGRENCI", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        void dersbilgi()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * from TBLDERSLER", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        void DersListesi()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * from TBLDERSLER", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            CmbDers.ValueMember = "DERSID";
            CmbDers.DisplayMember = "DERSAD";
            CmbDers.DataSource = dt;
        }
        //Etüt Listesi
        void EtutListesi()
        {
            SqlDataAdapter da = new SqlDataAdapter("execute etut", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                bool durum = Convert.ToBoolean(dt.Rows[i]["DURUM"]);
                if (durum==true)
                {
                    dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                }
                else
                {
                    dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Green;
                }
            }
        }
        bool durum;
        void MukerrerKayit()
        {
            conn.Open();
            SqlCommand komut = new SqlCommand("select * from TBLDERSLER where DERSAD=@p1", conn);
            komut.Parameters.AddWithValue("@p1", TxtDersAd.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                durum = false;
            }
            else
            {
                durum = true;
            }
            conn.Close();
        }
        void temizle()
        {
            CmbDers.Text = "";
            CmbOgretmen.Text = "";
            MskTarih.Text = "";
            MskSaat.Text = "";
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            DersListesi();
            EtutListesi();
            temizle();
        }
       
        private void CmbDers_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlDataAdapter da1 = new SqlDataAdapter("select * from TBLOGRETMEN where BRANSID="+CmbDers.SelectedValue, conn);
            DataTable dt1 = new DataTable();
            da1.Fill(dt1);
            CmbOgretmen.ValueMember = "OGRTID";
            CmbOgretmen.DisplayMember = "AD";
            CmbOgretmen.DataSource = dt1;
        }

        private void BtnEtutOlustur_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand komut = new SqlCommand("insert into TBLETUT (DERSID,OGRETMENID,TARIH,SAAT) values (@p1,@p2,@p3,@p4)",conn);
            komut.Parameters.AddWithValue("@p1", CmbDers.SelectedValue);
            komut.Parameters.AddWithValue("@p2", CmbOgretmen.SelectedValue);
            komut.Parameters.AddWithValue("@p3", MskTarih.Text);
            komut.Parameters.AddWithValue("@p4", MskSaat.Text);
            komut.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Etüt Oluşturuldu", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            temizle();
            EtutListesi();

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txtEtutId.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            
        }

        private void BtnEtutDetay_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand komut = new SqlCommand("update TBLETUT set OGRENCIID=@p1,DURUM=@p2 where ID=@p3", conn);
            komut.Parameters.AddWithValue("@p1", TxtOgrenci.Text);
            komut.Parameters.AddWithValue("@p2", "True");
            komut.Parameters.AddWithValue("@p3", txtEtutId.Text);
            komut.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Etüt Öğrenciye Verildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            EtutListesi();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pictureBox1.ImageLocation = openFileDialog1.FileName;
        }

        private void BtnOgrenciEkle_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand komut = new SqlCommand("insert into TBLOGRENCI (AD,SOYAD,FOTOGRAF,SINIF,TELEFON,MAIL) values (@p1,@p2,@p3,@p4,@p5,@p6)", conn);
            komut.Parameters.AddWithValue("@p1", TxtAd.Text);
            komut.Parameters.AddWithValue("@p2", TxtSoyad.Text);
            komut.Parameters.AddWithValue("@p3", pictureBox1.ImageLocation);
            komut.Parameters.AddWithValue("@p4", TxtSinif.Text);
            komut.Parameters.AddWithValue("@p5", MskTelefon.Text);
            komut.Parameters.AddWithValue("@p6", TxtMail.Text);
            komut.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Öğrenci Eklendi", "Bilgi", MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void BtnDersEkle_Click(object sender, EventArgs e)
        {
            MukerrerKayit();
            if (durum==true)
            {
                conn.Open();
                SqlCommand komut = new SqlCommand("insert into TBLDERSLER (DERSAD) values (@p1)", conn);
                komut.Parameters.AddWithValue("@p1", TxtDersAd.Text);
                komut.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Ders Sisteme Eklendi");
                DersListesi();
            }
            else
            {
                MessageBox.Show(TxtDersAd.Text + " İsimli Ders Sistemde Zaten Var");
            }
            
        }

        private void BtnOgretmenEkle_Click(object sender, EventArgs e)
        {
           
            conn.Open();
            SqlCommand komut = new SqlCommand("insert into TBLOGRETMEN (AD,SOYAD,BRANSID) values (@p1,@p2,@p3)",conn);
            komut.Parameters.AddWithValue("@p1", TxtOgrtAd.Text);
            komut.Parameters.AddWithValue("@p2", TxtOgrtSoyad.Text);
            komut.Parameters.AddWithValue("@p3", txtbrans.Text);
            komut.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Öğretmen Sisteme Kaydedildi");
            ogretmen();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            EtutListesi();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            ogrenci();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            dersbilgi();
        }

      
    }
}
