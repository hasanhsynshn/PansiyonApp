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
    public partial class FrmStoklar : Form
    {
        public FrmStoklar()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection("Server=localhost;database=Pansiyon;Integrated Security=true");

        private void veriler()
        {
            listView1.Items.Clear();
            connection.Open();
            SqlCommand command = new SqlCommand("select * from Stoklar", connection);
            SqlDataReader read = command.ExecuteReader();
            while (read.Read())
            {
                ListViewItem add = new ListViewItem();
                add.Text = read["Gıda"].ToString();
                add.SubItems.Add(read["İcecek"].ToString());
                add.SubItems.Add(read["Cerezler"].ToString());
                listView1.Items.Add(add);
                

            }
            connection.Close();
            

        }
        private void veriler2()
        {
            listView2.Items.Clear();
            connection.Open();
            SqlCommand command2 = new SqlCommand("select * from Faturalar", connection);
            SqlDataReader read2 = command2.ExecuteReader();
            while (read2.Read())
            {
                ListViewItem add = new ListViewItem();
                add.Text = read2["Elektrik"].ToString();
                add.SubItems.Add(read2["Su"].ToString());
                add.SubItems.Add(read2["İnternet"].ToString());
                listView1.Items.Add(add);


            }
            connection.Close();

        }
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            connection.Open();
            SqlCommand command = new SqlCommand("Insert into Stoklar values(@Gıda,@İcecekler,@Cerezler)",connection);
            command.Parameters.AddWithValue("@Gıda", txtGidalar.Text);
            command.Parameters.AddWithValue("@İcecekler", txtİcecekler.Text);
            command.Parameters.AddWithValue("@Cerezler", txtAtistirmaliklar.Text);
            command.ExecuteNonQuery();
            connection.Close();
            veriler();

        }


        private void FrmStoklar_Load(object sender, EventArgs e)
        {
            veriler();
            veriler2();
        }

        private void btnKaydet2_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("Insert into Faturalar values(@Elektrik,@Su,@İnternet)", connection);
            command.Parameters.AddWithValue("@Elektrik",txtElektrik.Text);
            command.Parameters.AddWithValue("@Su", txtSu.Text);
            command.Parameters.AddWithValue("@İnternet", txtİnternet.Text);
            command.ExecuteNonQuery();
            connection.Close();
            veriler();
            veriler2();
        }
    }
}
