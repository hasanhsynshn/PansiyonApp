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
    public partial class FrmAdminGiris : Form
    {
        public FrmAdminGiris()
        {
            InitializeComponent();
        }
        SqlConnection _connection = new SqlConnection("Server=localhost;database=Pansiyon; Integrated Security=true");
        private void BtnGirisYap_Click(object sender, EventArgs e)
        {
            try
            {
                _connection.Open();
                string sql = "select * from AdminGiris where Kullanici=@KullaniciAdi AND Sifre=@Sifre";
                SqlParameter prm = new SqlParameter("KullaniciAdi",TxtKullaniciAdi.Text.Trim());
                SqlParameter prm2 = new SqlParameter("Sifre",TxtSifre.Text.Trim());
                SqlCommand command = new SqlCommand(sql, _connection);
                command.Parameters.Add(prm);
                command.Parameters.Add(prm2);

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(command);
                da.Fill(dt);
                if (dt.Rows.Count>0)
                {
                    FrmAnaForm fr = new FrmAnaForm();
                    fr.Show();
                }

            }
            catch (Exception)
            {

                MessageBox.Show("Hatalı Giriş.");
            }
        }
    }
}
