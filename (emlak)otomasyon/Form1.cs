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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void girisYap_Click(object sender, EventArgs e)
        {
            if (kullaniciAdi.Text == "" || sifre.Text == "")
            {
                MessageBox.Show("Kullanıcı adı ve/veya şifre boş geçilemez.", "Uyarı");
            }
            else
            {
                if (kullaniciAdi.Text == "admin" && sifre.Text == "123456" || kullaniciAdi.Text == "Admin" && sifre.Text == "123456")
                {
                    Form2 frm2 = new Form2();
                    frm2.Show();
                    this.Hide();
                }
                else
                {

                    MessageBox.Show("Kullanıcı Adı: admin Şifre: 123456    ||   Kullanıcı Adı: Admin olabilir.", "İpucu");

                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            sifre.PasswordChar = '*';

        }
    }
}

