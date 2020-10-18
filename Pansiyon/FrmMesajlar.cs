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
    public partial class FrmMesajlar : Form
    {
        public FrmMesajlar()
        {
            InitializeComponent();
        }
        SqlConnection _connection = new SqlConnection("Server=localhost;Database=Pansiyon; Integrated Security=true");

        private void verilergoster()
        {
            //Verileri göster butonuna tıklandıgında tekrar aynı verileri yazdırmaması gerekiyor.
            listView1.Items.Clear();
            _connection.Open();
            SqlCommand command = new SqlCommand("select * from Mesajlar", _connection);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = reader["MesajId"].ToString();
                ekle.SubItems.Add(reader["AdSoyad"].ToString());
                ekle.SubItems.Add(reader["Mesaj"].ToString());


                listView1.Items.Add(ekle);



            }
            _connection.Close();
        }
            private void btnKaydet_Click(object sender, EventArgs e)
        {
            _connection.Open();
            SqlCommand command = new SqlCommand("Insert into Mesajlar values (@adSoyad,@mesaj)",_connection);
            command.Parameters.AddWithValue("@adSoyad", textBox1.Text);
            command.Parameters.AddWithValue("@mesaj", richTextBox1.Text);
            command.ExecuteNonQuery();
            _connection.Close();
            verilergoster();
        }

        private void FrmMesajlar_Load(object sender, EventArgs e)
        {
            verilergoster();
        }
        int id = 0;
        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            textBox1.Text = listView1.SelectedItems[0].SubItems[1].Text;
            richTextBox1.Text = listView1.SelectedItems[0].SubItems[2].Text;
        }
    }
}
