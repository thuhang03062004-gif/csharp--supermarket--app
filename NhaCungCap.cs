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
    public partial class NhaCungCap : Form
    {
        public NhaCungCap()
        {
            InitializeComponent();
        }

        private void NhaCungCap_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'northWindDataSet1.Suppliers' table. You can move, or remove it, as needed.
            this.suppliersTableAdapter1.Fill(this.northWindDataSet1.Suppliers);
            // TODO: This line of code loads data into the 'northWindDataSet2.Suppliers' table. You can move, or remove it, as needed.
            this.suppliersTableAdapter.Fill(this.northWindDataSet2.Suppliers);

        }

        public void loadncc()
        {
            //1.Tao ket noi
            string connect = "Server = 192.168.31.131 ; Database = NorthWind; User ID = SA; Password = MyStrongPass123";
            SqlConnection conn = new SqlConnection(connect);
            conn.Open();

            //2.Tao truy van
            string truyvan = "select * from Suppliers";
            SqlCommand mycm = new SqlCommand(truyvan, conn);
            SqlDataAdapter da = new SqlDataAdapter(mycm);
            DataTable dt = new DataTable("Suppliers");
            da.Fill(dt);
            //3.Lay du lieu
            dataGridView1.DataSource = dt;
            textBoxID.Text = "";
            textBoxTenCT.Text = "";
            textBoxFax.Text = "";
            textBoxNDD.Text = "";
            textBoxSDT.Text = "";
            da.Dispose();
            conn.Close();
        }
        public void themncc()
        {
            //1.Tao ket noi
            string connect = "Server = 192.168.31.131 ; Database = NorthWind; User ID = SA; Password = MyStrongPass123";
            SqlConnection conn = new SqlConnection(connect);
            conn.Open();

            //2.Tao truy van
            string truyvan = "exec themncc @compname, @contactname, @add, @phone, @fax ";
            SqlCommand mycm = new SqlCommand(truyvan, conn);
            mycm.Parameters.Add("@compname", SqlDbType.NVarChar, 40).Value = textBoxTenCT.Text;
            mycm.Parameters.Add("@contactname", SqlDbType.NVarChar, 30).Value = textBoxNDD.Text;
            mycm.Parameters.Add("@add", SqlDbType.NVarChar, 60).Value = textBoxDC.Text;
            mycm.Parameters.Add("@phone", SqlDbType.NVarChar, 24).Value = textBoxSDT.Text;
            mycm.Parameters.Add("@fax", SqlDbType.NVarChar, 24).Value = textBoxFax.Text;
            SqlDataAdapter da = new SqlDataAdapter(mycm);
            DataTable dt = new DataTable("Suppliers");
            da.Fill(dt);
            //3.Lay du lieu
            dataGridView1.DataSource = dt;
            textBoxID.Text = "";
            textBoxTenCT.Text = "";
            textBoxFax.Text = "";
            textBoxNDD.Text = "";
            textBoxSDT.Text = "";
            MessageBox.Show("Thêm mới thành công!");
            da.Dispose();
            conn.Close();
        }

        public void capnhat()
        {
            //1.Tao ket noi
            string connect = "Server = 192.168.31.131 ; Database = NorthWind; User ID = SA; Password = MyStrongPass123";
            SqlConnection conn = new SqlConnection(connect);
            conn.Open();

            //2.Tao truy van
            string truyvan = "exec capnhatncc @ID, @compname, @contactname, @add, @phone, @fax ";
            SqlCommand mycm = new SqlCommand(truyvan, conn);
            mycm.Parameters.Add("@ID", SqlDbType.Int).Value = textBoxID.Text;
            mycm.Parameters.Add("@compname", SqlDbType.NVarChar, 40).Value = textBoxTenCT.Text;
            mycm.Parameters.Add("@contactname", SqlDbType.NVarChar, 30).Value = textBoxNDD.Text;
            mycm.Parameters.Add("@add", SqlDbType.NVarChar, 60).Value = textBoxDC.Text;
            mycm.Parameters.Add("@phone", SqlDbType.NVarChar, 24).Value = textBoxSDT.Text;
            mycm.Parameters.Add("@fax", SqlDbType.NVarChar, 24).Value = textBoxFax.Text;
            SqlDataAdapter da = new SqlDataAdapter(mycm);
            DataTable dt = new DataTable("Suppliers");
            da.Fill(dt);
            //3.Lay du lieu
            dataGridView1.DataSource = dt;
            textBoxID.Text = "";
            textBoxTenCT.Text = "";
            textBoxFax.Text = "";
            textBoxNDD.Text = "";
            textBoxSDT.Text = "";
            MessageBox.Show("Cập nhật thành công!");
            da.Dispose();
            conn.Close();
        }
        public void xoa()
        {
            //1.Tao ket noi
            string connect = "Server = 192.168.31.131 ; Database = NorthWind; User ID = SA; Password = MyStrongPass123";
            SqlConnection conn = new SqlConnection(connect);
            conn.Open();

            //2.Tao truy van
            string truyvan = "delete from Suppliers where SupplierID = N'"+textBoxID.Text+"'";
            SqlCommand mycm = new SqlCommand(truyvan, conn);
            SqlDataAdapter da = new SqlDataAdapter(mycm);
            DataTable dt = new DataTable("Suppliers");
            da.Fill(dt);
            //3.Lay du lieu
            dataGridView1.DataSource = dt;
            MessageBox.Show("Xóa thành công!");
            conn.Close();
        }
        private void buttonThem_Click(object sender, EventArgs e)
        {
            themncc();
            loadncc();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            if(dataGridView1 != null)
            {
                textBoxID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                textBoxTenCT.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                textBoxNDD.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                textBoxDC.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                textBoxSDT.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                textBoxFax.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            }    
        }

        private void buttonXoa_Click(object sender, EventArgs e)
        {
            xoa();
            loadncc() ;
        }

        private void buttonCapnhat_Click(object sender, EventArgs e)
        {
            capnhat();
            loadncc() ;
        }

        private void buttonDS_Click(object sender, EventArgs e)
        {
            loadncc();
        }

        private void sảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(textBoxID.Text != null)
            {
                DSSPtheoNCC dSSPtheoNCC = new DSSPtheoNCC();
                dSSPtheoNCC.loadProductTheoncc(Convert.ToInt32(textBoxID.Text.ToString()));
                dSSPtheoNCC.Show(this);
            }    
        }
    }
}
