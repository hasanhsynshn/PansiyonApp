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
    public partial class FrmOdalar : Form
    {
        public FrmOdalar()
        {
            InitializeComponent();
        }
        SqlConnection _connection = new SqlConnection("Server=localhost; database=Pansiyon; Integrated Security=true");

        private void FrmOdalar_Load(object sender, EventArgs e)
        {
            _connection.Open();
            SqlCommand command = new SqlCommand("Select * from Oda11",_connection);
            SqlDataReader read = command.ExecuteReader();
            while (read.Read())
            {
                BtnOda101.Text = read["Adi"].ToString()+read["SoyAdi"].ToString();
            }
            _connection.Close();
            if (BtnOda101.Text !="101")
            {
                BtnOda101.BackColor = Color.Red;
            }
        }
    }
}
