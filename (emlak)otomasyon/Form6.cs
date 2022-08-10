using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient; //Sql bağlantısı için ekliyoruz.
namespace _emlak_otomasyon
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-RPMKNHR;Initial Catalog=ZMD_EMLAK;Integrated Security=True");

        public void verilerigöster()
        {
            baglan.Open();
            SqlCommand komut = new SqlCommand("Select*from kullanicilar", baglan);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string message = "Ana Menüye Dönmek İstediğinize Emin Misiniz?";
            string title = "Uyarı";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                Form2 frm2 = new Form2();
                frm2.Show();
                this.Hide();
            }
            else
            {

            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
          if (baglan.State==ConnectionState.Closed) 
                baglan.Open();
                String kayit = "insert into kullanicilar(ad,soyad,tel_no,tc_kimlik,e_posta,kul_no,konut_no)" +
                    "values(@ad,@soyad,@tel_no,@tc_kimlik,@e_posta,@kul_no,@konut_no)";
                SqlCommand komut = new SqlCommand(kayit, baglan);
                komut.Parameters.AddWithValue("@ad", txtAd);
                komut.Parameters.AddWithValue("@soyad", txtSoyad);
                komut.Parameters.AddWithValue("@tel_no", txtTelno);
                komut.Parameters.AddWithValue("@tc_kimlik", txtTcKimlik);
                komut.Parameters.AddWithValue("@e_posta", txtEposta);
                komut.Parameters.AddWithValue("@kul_no", txtKulno);
                komut.Parameters.AddWithValue("@konut_no", txtKonutno);
                komut.ExecuteNonQuery();
               
                MessageBox.Show("Kayıt eklendi");
            baglan.Close();

        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    TextBox tbox = (TextBox)item;
                    tbox.Clear();
                }
            }
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtAdSoyad_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEPosta_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSifre_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnYeni_Click(object sender, EventArgs e)
        {

        }

        private void cbKullaniciAdi_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label5_Click_1(object sender, EventArgs e)
        {

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand güncelle = new SqlCommand("Update kullanicilar set ad=" + txtAd + ",soyad=" + txtSoyad +
                "tel_no=" + txtTelno + "tc_kimlik=" + txtTcKimlik + "e_posta=" + txtEposta + "where kul_no=" + txtKonutno, baglan);
            güncelle.ExecuteNonQuery();
            baglan.Close();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand silme = new SqlCommand("Delete From kullanicilar where kul_no=" + txtKonutno, baglan);
            silme.ExecuteNonQuery();
            baglan.Close();
        }
    }
}
