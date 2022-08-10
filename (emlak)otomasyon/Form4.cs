using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient; //Sql bağlantısı için ekliyoruz.

namespace _emlak_otomasyon
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-RPMKNHR;Initial Catalog=ZMD_EMLAK;Integrated Security=True");

        public void verilerigöster()
        {
            baglan.Open();
            SqlCommand komut = new SqlCommand("Select*from evOzellikleri", baglan);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {

            }
        }
        string Dirpath;
        int imgindex;
        private void gbDisCepheOzellikleri_Enter(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
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

        private void btnFotografEkle_Click(object sender, EventArgs e)
        {
            DialogResult dr = folderBrowserDialog1.ShowDialog();
            if (dr != DialogResult.Cancel)
            {
                listBox1.Items.Clear();
                Dirpath = folderBrowserDialog1.SelectedPath;
                string[] files = Directory.GetFiles(Dirpath, "*.Jpg");
                foreach (string file in files)
                {
                    int pos = file.LastIndexOf("||");
                    string FName = file.Substring(pos + 1);
                    listBox1.Items.Add(FName);
                }
                listBox1.SelectedIndex = imgindex = 0;
                btnonceki.Enabled = true;
                btnsonraki.Enabled = btnshow.Enabled = true;
            }
        }

        private void btnonceki_Click(object sender, EventArgs e)
        {
            imgindex -= 1;
            if (imgindex == 0)
            {
                btnonceki.Enabled = false;
            }
            if (imgindex < listBox1.Items.Count - 1)
                btnsonraki.Enabled = true;
            listBox1.SelectedIndex = imgindex;
        }

        private void btnsonraki_Click(object sender, EventArgs e)
        {
            if (imgindex < listBox1.Items.Count - 1)
            {
                imgindex += 1;
                if (imgindex == listBox1.Items.Count - 1)
                    btnsonraki.Enabled = false;
                if (imgindex > 0)
                    btnonceki.Enabled = true;
                listBox1.SelectedIndex = imgindex;
            }
        }

        private void btnshow_Click(object sender, EventArgs e)
        {
            if (btnshow.Text == "Slide Başlat")
            {
                btnshow.Text = "Durdur";
                timer1.Interval = int.Parse(comboBox1.Text) * 1000;
                timer1.Start();

            }
            else
            {
                timer1.Stop();
                btnshow.Text = "Slide Başlat";
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            pictureBox11.ImageLocation = listBox1.SelectedItem.ToString();
            string ad = listBox1.SelectedItem.ToString();
            string[] parcalar = ad.Split('\\');
            label2.Text = "Gösterilen Resim " + parcalar[parcalar.Count() - 1].ToString();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            for (int i = 1; i < 10; i++)
            {
                comboBox1.Items.Add(i);
                comboBox1.SelectedIndex = 0;
            }
            label33.Text = "Görüntülenen Resim";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            btnsonraki.PerformClick();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (baglan.State == ConnectionState.Closed)
                baglan.Open();
            String kayit = "insert into evOzellikleri(ilan_no,fiyat,emlak_tipi,metrekare,oda_salon,)" +
           "(dask,il,ilce,adres,emlak_sahibi,aidat,banyo,binadaki_kat,bina_yasi,bulundugu_kat," +
           "kullanım_durumu,tapu_durumu,balkon_sayisi,isitma,aciklama)" +
           "values(@ilan_no,@fiyat,@emlak_tipi,@metrekare,@oda_salon,@dask,@il,@ilce,@adres,@emlak_sahibi," +
           "@aidat,@banyo,@binadaki_kat,@bina_yasi,@bulundugu_kat,@kullanım_durumu,@tapu_durumu,@balkon_sayisi,@isitma,@aciklama)";
            SqlCommand komut = new SqlCommand(kayit, baglan);
            komut.Parameters.AddWithValue("@ilan_no", txtno);
            komut.Parameters.AddWithValue("@fiyat", txtFiyat);
            komut.Parameters.AddWithValue("@emlak_tipi", cbEmlakTipi);
            komut.Parameters.AddWithValue("@metrekare", txtMetrekare);
            komut.Parameters.AddWithValue("@oda_salon", cbOdaSalon);
            komut.Parameters.AddWithValue("@dask", cbDask);
            komut.Parameters.AddWithValue("@il", cbIl);
            komut.Parameters.AddWithValue("@ilce", txtIlce);
            komut.Parameters.AddWithValue("@adres", txtAdres);
            komut.Parameters.AddWithValue("@emlak_sahibi", txtEmlakSahibi);
            komut.Parameters.AddWithValue("@aidat", txtAidatTutari);
            komut.Parameters.AddWithValue("@banyo", cbBanyoSayisi);
            komut.Parameters.AddWithValue("@binadaki_kat", cbBinadakiKatSayisi);
            komut.Parameters.AddWithValue("@bulundugu_kat", cbBulunduguKat);
            komut.Parameters.AddWithValue("@kullanım_durumu", cbKullanimDurumu);
            komut.Parameters.AddWithValue("@tapu_durumu", cbTapuDurumu);
            komut.Parameters.AddWithValue("@balkon_sayisi", cbBalkonSayisi);
            komut.Parameters.AddWithValue("@isitma", cbIsitma);
            komut.Parameters.AddWithValue("@aciklama", txtAciklama);


            komut.ExecuteNonQuery();
            baglan.Close();
            MessageBox.Show("Kayıt eklendi");
        }
    }
}