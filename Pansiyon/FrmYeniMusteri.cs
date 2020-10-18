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

namespace Pansiyon
{
    public partial class FrmYeniMusteri : Form
    {
        public FrmYeniMusteri()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection("Server=localhost;Database=Pansiyon; Integrated Security=true");

        private void BtnOda101_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "101";
            connection.Open();
            SqlCommand command = new SqlCommand("Insert into Oda101 values(@adi,@soyAdi)", connection);
            command.Parameters.AddWithValue("@adi", TxtAdi.Text);
            command.Parameters.AddWithValue("@soyAdi", TxtSoyAdi.Text);
            command.ExecuteNonQuery();
            connection.Close();
        }

        private void BtnOda102_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "102";
        }

        private void BtnOda103_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "103";
        }

        private void BtnOda104_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "104";
        }

        private void BtnOda105_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "105";
        }

        private void BtnOda106_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "106";
        }

        private void BtnOda107_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "107";
        }

        private void BtnOda108_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "108";
        }

        private void BtnOda109_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "109";
        }

        private void BtnDoluOda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kırmızı Dolu Odalar");
        }

        private void BtnBosOda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Boş Odalar.");
        }

        private void DtpCikisTarihi_ValueChanged(object sender, EventArgs e)
        {
            int ucret;
            DateTime KucukTarih = Convert.ToDateTime(DtpGirisTarihi.Text);
            DateTime BuyukTarih = Convert.ToDateTime(DtpCikisTarihi.Text);
            //TimeSpan iki tarih arasındaki gün ay yıl saat farklarını almak için kullanılır
            TimeSpan sonuc = BuyukTarih - KucukTarih;
            label10.Text = sonuc.TotalDays.ToString();
            
            ucret = Convert.ToInt32(label10.Text) * 50;
            TxtUcret.Text = ucret.ToString();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("Insert into MüsteriEkle (Adi,Soyadi,Cinsiyet,Telefon,Mail,TC,OdaNo,Ücret,GirisTarihi,CikisTarihi) values('" + TxtAdi.Text + "','" + TxtSoyAdi.Text + "','" + comboBox1.Text + "','" + MskTxtTelefon.Text + "','" + TxtMail.Text + "','" + TxtTcNo.Text + "','" + TxtOdaNo.Text + "','" + TxtUcret.Text + "','" + DtpGirisTarihi.Value.ToString("yyyy-MM-dd") + "','" + DtpCikisTarihi.Value.ToString("yyyy-MM-dd") + "')", connection) ;
            command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Müşteri Kaydı Yapıldı.");
        }

        private void FrmYeniMusteri_Load(object sender, EventArgs e)
        {

        }
    }
}
