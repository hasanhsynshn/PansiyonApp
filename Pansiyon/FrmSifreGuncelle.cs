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
    public partial class FrmSifreGuncelle : Form
    {
        public FrmSifreGuncelle()
        {
            InitializeComponent();
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection("server=localhost;database=Pansiyon;Integrated Security=true");
            connection.Open();
            SqlCommand command = new SqlCommand("Update AdminGiris set Kullanici=@kullanici,Sifre=@sifre",connection);
            command.Parameters.AddWithValue("@kullanici", TxtKullaniciAdi.Text);
            command.Parameters.AddWithValue("@sifre",TxtSifre.Text);
            command.ExecuteNonQuery();
            connection.Close();
        
        }
    }
}
