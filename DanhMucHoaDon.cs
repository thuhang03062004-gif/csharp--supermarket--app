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

namespace QLSieuThi
{
    public partial class DanhMucHoaDon : Form
    {
        public DanhMucHoaDon()
        {
            InitializeComponent();
        }

        public void loadngayhd(string customerID)
        {
            //1.Tao ket noi
            string connect = "Server = 192.168.31.131 ; Database = NorthWind; " +
                                "User ID = SA; Password = MyStrongPass123";
            SqlConnection conn = new SqlConnection(connect);
            conn.Open();
            SqlCommand mycm = conn.CreateCommand();
            mycm.CommandText = "exec LoadNgayHD @cusID";
            mycm.Parameters.Add("@cusID", SqlDbType.NChar, 5).Value = customerID;
            SqlDataAdapter da = new SqlDataAdapter(mycm);
            DataTable dt = new DataTable();
            da.Fill(dt);
            NgayLapHoaDon.DataSource = dt;
            NgayLapHoaDon.DisplayMember = "OrderDate";
            NgayLapHoaDon.ValueMember = "OrderID";
            conn.Close();
        }

        public void cthd(int orID)
        {

            string connect = "Server = 192.168.31.131 ; Database = NorthWind; " +
                                "User ID = SA; Password = MyStrongPass123";
            SqlConnection conn = new SqlConnection(connect);
            conn.Open();
            SqlCommand mycm = conn.CreateCommand();
            mycm.CommandText = "exec LoadCTHD @orID";
            mycm.Parameters.Add("@orID", SqlDbType.Int).Value = orID;
            SqlDataAdapter da = new SqlDataAdapter(mycm);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            da.Dispose();
            conn.Close();

        }
        private void NgayLapHoaDon_Click(object sender, EventArgs e)
        {
            if (NgayLapHoaDon.SelectedValue != null)
            {
                int ID = (int)NgayLapHoaDon.SelectedValue;
                cthd(ID);
            }
        }

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}
	}
}
