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
    public partial class FrmMusteriler : Form
    {
        public FrmMusteriler()
        {
            InitializeComponent();
        }

        SqlConnection _connection = new SqlConnection("Server=localhost;Database=Pansiyon; Integrated Security=true");


        private void verilergoster()
        {
            //Verileri göster butonuna tıklandıgında tekrar aynı verileri yazdırmaması gerekiyor.
            listView1.Items.Clear();
            _connection.Open();
            SqlCommand command = new SqlCommand("select * from MüsteriEkle", _connection);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = reader["MusteriId"].ToString();
                ekle.SubItems.Add(reader["Adi"].ToString());
                ekle.SubItems.Add(reader["SoyAdi"].ToString());

                ekle.SubItems.Add(reader["Cinsiyet"].ToString());

                ekle.SubItems.Add(reader["Telefon"].ToString());

                ekle.SubItems.Add(reader["Mail"].ToString());

                ekle.SubItems.Add(reader["TC"].ToString());

                ekle.SubItems.Add(reader["OdaNo"].ToString());

                ekle.SubItems.Add(reader["Ücret"].ToString());

                ekle.SubItems.Add(reader["GirisTarihi"].ToString());
                ekle.SubItems.Add(reader["CikisTarihi"].ToString());
                listView1.Items.Add(ekle);



            }
            _connection.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            verilergoster();
        }


        int id = 0;
        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            TxtAdi.Text = listView1.SelectedItems[0].SubItems[1].Text;
            TxtSoyAdi.Text = listView1.SelectedItems[0].SubItems[2].Text;

            comboBox1.Text = listView1.SelectedItems[0].SubItems[3].Text;
            MskTxtTelefon.Text = listView1.SelectedItems[0].SubItems[4].Text;

            TxtMail.Text = listView1.SelectedItems[0].SubItems[5].Text;
            TxtTcNo.Text = listView1.SelectedItems[0].SubItems[6].Text;

            TxtOdaNo.Text = listView1.SelectedItems[0].SubItems[7].Text;

            TxtUcret.Text = listView1.SelectedItems[0].SubItems[8].Text;
            DtpGirisTarihi.Text = listView1.SelectedItems[0].SubItems[9].Text;
            DtpCikisTarihi.Text = listView1.SelectedItems[0].SubItems[10].Text;


        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            _connection.Open();
            SqlCommand command = new SqlCommand("delete from MüsteriEkle where Musteriid=("+id+")",_connection);
            command.ExecuteNonQuery();
            _connection.Close();
            verilergoster();
        
        }

        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            TxtAdi.Clear();
            TxtSoyAdi.Clear();
            comboBox1.Text = "";
            MskTxtTelefon.Clear();
            TxtMail.Text = "";
            TxtTcNo.Clear();
            TxtOdaNo.Clear();
            TxtUcret.Clear();
            DtpGirisTarihi.Text = "";
            DtpCikisTarihi.Text = "";

        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
           
            _connection.Open();
            
            SqlCommand command = new SqlCommand("Update MüsteriEkle set Adi=@adi,SoyAdi=@soyAdi,Cinsiyet=@cinsiyet,Telefon=@telefon,Mail=@mail,TC=@tc,OdaNo=@odaNo,Ücret=@ucret,GirisTarihi=@girisTarihi,CikisTarihi=@cikisTarihi where MusteriId="+id+"",_connection);
            command.Parameters.AddWithValue("@adi", TxtAdi.Text);
            command.Parameters.AddWithValue("@soyAdi", TxtSoyAdi.Text);
            command.Parameters.AddWithValue("@cinsiyet", textBox1.Text);
            command.Parameters.AddWithValue("@telefon", MskTxtTelefon.Text);
            command.Parameters.AddWithValue("@mail", TxtMail.Text);
            command.Parameters.AddWithValue("@tc", TxtTcNo.Text);
            command.Parameters.AddWithValue("@odaNo", TxtOdaNo.Text);
            command.Parameters.AddWithValue("@ucret", TxtUcret.Text);
            command.Parameters.AddWithValue("@girisTarihi", DtpGirisTarihi.Value.ToString("yyyy-MM-dd"));
            command.Parameters.AddWithValue("@cikisTarihi", DtpCikisTarihi.Value.ToString("yyyy-MM-dd"));
            command.ExecuteNonQuery();
            _connection.Close();
            verilergoster();
        }

        private void BtnAra_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            _connection.Open();
            SqlCommand command = new SqlCommand("select * from MüsteriEkle where Adi like '%"+textBox1.Text+"%'", _connection);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = reader["MusteriId"].ToString();
                ekle.SubItems.Add(reader["Adi"].ToString());
                ekle.SubItems.Add(reader["SoyAdi"].ToString());

                ekle.SubItems.Add(reader["Cinsiyet"].ToString());

                ekle.SubItems.Add(reader["Telefon"].ToString());

                ekle.SubItems.Add(reader["Mail"].ToString());

                ekle.SubItems.Add(reader["TC"].ToString());

                ekle.SubItems.Add(reader["OdaNo"].ToString());

                ekle.SubItems.Add(reader["Ücret"].ToString());

                ekle.SubItems.Add(reader["GirisTarihi"].ToString());
                ekle.SubItems.Add(reader["CikisTarihi"].ToString());
                listView1.Items.Add(ekle);



            }
            _connection.Close();
        }

        private void FrmMusteriler_Load(object sender, EventArgs e)
        {

        }
    }
}
