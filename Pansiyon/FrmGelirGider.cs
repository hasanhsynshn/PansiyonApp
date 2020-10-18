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
    public partial class FrmGelirGider : Form
    {
        public FrmGelirGider()
        {
            InitializeComponent();
        }
        SqlConnection _connection = new SqlConnection("server=localhost;database=Pansiyon;Integrated security=true");
        private void btnHesapla_Click(object sender, EventArgs e)
        {
            int personel;


          
                personel = Convert.ToInt32(textBox1.Text);
                lblPersonelMaas.Text = (personel * 1500).ToString();
 
          
               
            int sonuc;
            sonuc = Convert.ToInt32(lblKasaToplam.Text) - (Convert.ToInt32(lblPersonelMaas.Text)+Convert.ToInt32(lblAlınanUrunlerınTutarı.Text)+Convert.ToInt32(lblAlinan2.Text)+Convert.ToInt32(lblAlinan3.Text)+Convert.ToInt32(lblFaturalar1.Text)+Convert.ToInt32(lblFaturalar2.Text)+Convert.ToInt32(lblFaturalar3.Text));
            Sonuc.Text = sonuc.ToString();
        }

        private void FrmGelirGider_Load(object sender, EventArgs e)
        {

            _connection.Open();
            SqlCommand command = new SqlCommand("Select sum(Ücret) as toplam from MüsteriEkle", _connection);

            SqlDataReader read = command.ExecuteReader();
            while (read.Read())
            {
                lblKasaToplam.Text = read["toplam"].ToString();

            }
            _connection.Close();
            //Gıdalar 
            _connection.Open();
            SqlCommand command2 = new SqlCommand("Select sum(Gıda) as toplam1 from Stoklar" ,_connection);

            SqlDataReader read2 = command2.ExecuteReader();
            while (read2.Read())
            {
               lblAlınanUrunlerınTutarı.Text = read2["toplam1"].ToString();

            }
            _connection.Close();
            _connection.Open();
            SqlCommand command3 = new SqlCommand("Select sum(İcecek) as toplam3 from Stoklar", _connection);

            SqlDataReader read3 = command3.ExecuteReader();
            while (read3.Read())
            {
                lblAlinan2.Text = read3["toplam3"].ToString();

            }
            _connection.Close();
            _connection.Open();
            SqlCommand command4 = new SqlCommand("Select sum(Cerezler) as toplam4 from Stoklar", _connection);

            SqlDataReader read4 = command4.ExecuteReader();
            while (read4.Read())
            {
                lblAlinan3.Text = read4["toplam4"].ToString();

            }
            _connection.Close();
            //ELektrik
            _connection.Open();
            SqlCommand command5 = new SqlCommand("Select sum(Elektrik) as toplam5 from Faturalar", _connection);

            SqlDataReader read5 = command5.ExecuteReader();
            while (read5.Read())
            {
                lblFaturalar1.Text = read5["toplam5"].ToString();

            }
            _connection.Close();
            _connection.Open();
            SqlCommand command6 = new SqlCommand("Select sum(Su) as toplam6 from Faturalar", _connection);

            SqlDataReader read6 = command6.ExecuteReader();
            while (read6.Read())
            {
                lblFaturalar2.Text = read6["toplam6"].ToString();

            }
            _connection.Close();

            _connection.Open();
            SqlCommand command7 = new SqlCommand("Select sum(İnternet) as toplam7 from Faturalar", _connection);

            SqlDataReader read7 = command7.ExecuteReader();
            while (read7.Read())
            {
                lblFaturalar3.Text = read7["toplam7"].ToString();

            }
            _connection.Close();





           
                
            
           
        }

        
    }
}
