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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QLSieuThi
{
    public partial class DSSPtheoNCC : Form
    {
        public DSSPtheoNCC()
        {
            InitializeComponent();
        }

        public void loadProductTheoncc(int @suppID)
        {
            //1.Tao ket noi
            string connect = "Server = 192.168.31.131 ; Database = NorthWind;" +
                " User ID = SA; Password = MyStrongPass123";
            SqlConnection conn = new SqlConnection(connect);
            conn.Open();
            //2.Tao truy van
            SqlCommand mycm = conn.CreateCommand();
            mycm.CommandText = "exec LoadProduct_theoncc N'"+@suppID+"'";
            SqlDataAdapter da = new SqlDataAdapter(mycm);
            DataTable dt = new DataTable("Products");
            da.Fill(dt);

            dataGridView1.DataSource = dt;
            da.Dispose();
            conn.Close();
        }
        private void DSSPtheoNCC_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'northWindDataSet1.Products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.northWindDataSet1.Products);

        }
    }
}
