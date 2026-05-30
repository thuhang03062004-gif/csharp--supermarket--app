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
    public partial class NhatKy : Form
    {
        public NhatKy()
        {
            InitializeComponent();
        }

        public void loadnhatky(string cusID)
        {
            string connect = "Server = 192.168.31.131 ; Database = NorthWind;" +
                                " User ID = SA; Password = MyStrongPass123";
            SqlConnection conn = new SqlConnection(connect);
            conn.Open();

            SqlCommand mycm = conn.CreateCommand();
            mycm.CommandText = "exec NhatKy @cusID";
            mycm.Parameters.Add("@cusID", SqlDbType.NChar, 5).Value = cusID;
            SqlDataAdapter da = new SqlDataAdapter(mycm);
            DataTable dt = new DataTable("nhatky");
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            da.Dispose();
            conn.Close();
        }
    }
}
