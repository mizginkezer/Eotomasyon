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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection("Data Source=.;Initial Catalog=ZMD_EMLAK;Integrated Security=SSPI");


        DataTable listele()
        {
            baglan.Open();
            SqlCommand komut = new SqlCommand("Select*from filtrele", baglan);
            SqlDataAdapter Da = new SqlDataAdapter("Select*from filtrele", baglan);
            DataTable tablo = new DataTable();
            Da.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglan.Close();
            return tablo;

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

        private void Form3_Load(object sender, EventArgs e)
        {
           
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            string maxfiyat, minfiyat, emlek_tipi, metrekare, isitma, satilik, kiralik;
            maxfiyat = dataGridView1.CurrentRow.Cells[txtMaxFiyat].Value.ToString;
            minfiyat = dataGridView1.CurrentRow.Cells[txtMinFiyat].Value.ToString;
            emlak_tipi = dataGridView1.CurrentRow.Cells[cbEmlakTipi].Value.ToString;
            isitma = dataGridView1.CurrentRow.Cells[cbIsitma].Value.ToString;
            satilik = dataGridView1.CurrentRow.Cells[rbtnSatilikKonut].Value.ToString;
            kiralik = dataGridView1.CurrentRow.Cells[rbtnKiralikKonut].Value.ToString;
          
        }
    }
}
