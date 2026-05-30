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
    public partial class Sanpham : Form
    {
        public Sanpham()
        {
            InitializeComponent();
        }

       public void loadProductTheonhom()
        {
            //1.Tao ket noi
            string connect = "Server = 192.168.31.131 ; Database = NorthWind; User ID = SA; Password = MyStrongPass123";
            SqlConnection conn = new SqlConnection(connect);
            conn.Open();
            //2.Tao truy van
            SqlCommand mycm = conn.CreateCommand();
            mycm.CommandText = "exec LoadProduct_theonhom @cateID";
            mycm.Parameters.Add("@cateID", SqlDbType.Int);
            //Kiểm tra trước khi truyền giá trị
            if (comboBox1.SelectedValue is DataRowView)
            {
                DataRowView dong = comboBox1.SelectedValue as DataRowView;
                mycm.Parameters["@cateID"].Value = dong["CategoryID"];
            }
            else mycm.Parameters["@cateID"].Value = comboBox1.SelectedValue;

            SqlDataAdapter da = new SqlDataAdapter(mycm);
            DataTable dt = new DataTable("Products");
            da.Fill(dt);

            dataGridView1.DataSource = dt;
            da.Dispose();
            conn.Close();
        }
        /*
       public void capnhat()
       {
           //1.Tao ket noi
           string connect = "Server = 192.168.31.131 ; Database = NorthWind; User ID = SA; Password = MyStrongPass123";
           SqlConnection conn = new SqlConnection(connect);
           conn.Open();

           //2.Tao truy van
           string truyvan = "update Products set ProductName =N'" + textBoxTen.Text + "', Discontinued = N'" + textBoxTT.Text + "' " +
               " where ProductID = N'" + textBoxID.Text + "'";
           SqlCommand mycm = new SqlCommand(truyvan, conn);
           SqlDataAdapter da = new SqlDataAdapter(mycm);
           DataTable dt = new DataTable("Products");
           da.Fill(dt);
           //3.Lay du lieu
           dataGridView1.DataSource = dt;
           MessageBox.Show("Cap nhat thanh cong!");
           da.Dispose();
           conn.Close();
       }
}*/

        public void loadsp()
        {
            //1.Tao ket noi
            string connect = "Server = 192.168.31.131 ; Database = NorthWind; User ID = SA; Password = MyStrongPass123";
            SqlConnection conn = new SqlConnection(connect);
            conn.Open();

            //2.Tao truy van
            string truyvan = "select * from Products";
            SqlCommand mycm = new SqlCommand(truyvan, conn);
            SqlDataAdapter da = new SqlDataAdapter(mycm);
            DataTable dt = new DataTable("Products");
            da.Fill(dt);
            //3.Lay du lieu
            dataGridView1.DataSource = dt;
            textBoxID.Text = "";
            textBoxTen.Text = "";
            comboBox1.Text = "";
            comboBox2.Text = "";
            textBoxDgia.Text= "";
            da.Dispose();
            conn.Close();
        }

        public void themsp()
        {
            //1.Tao ket noi
            string connect = "Server = 192.168.31.131 ; Database = NorthWind; User ID = SA; Password = MyStrongPass123";
            SqlConnection conn = new SqlConnection(connect);
            conn.Open();

            //2.Tao truy van
            string truyvan = "insert into Products( ProductName, CategoryID, SupplierID, UnitPrice) " +
                "values(N'" + textBoxTen.Text + "',N'" + comboBox1.SelectedValue.ToString() + "' ,N'" + comboBox2.SelectedValue.ToString() + "' ,N'" + textBoxDgia.Text + "')";
            SqlCommand mycm = new SqlCommand(truyvan, conn);
            SqlDataAdapter da = new SqlDataAdapter(mycm);
            DataTable dt = new DataTable("Products");
            da.Fill(dt);
            //3.Lay du lieu
            dataGridView1.DataSource = dt;
            textBoxID.Text = "";
            textBoxTen.Text = "";
            comboBox1.Text = "";
            comboBox2.Text = "";
            textBoxDgia.Text= "";
            MessageBox.Show("Them moi thanh cong!");
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
            string truyvan = "update Products set CategoryID = "+comboBox1.SelectedValue.ToString()+", " +
                "ProductName =N'" + textBoxTen.Text + "', SupplierID = " + comboBox2.SelectedValue.ToString() + " , UnitPrice = "+textBoxDgia.Text+"" +
                " where ProductID = " + textBoxID.Text + "";
            SqlCommand mycm = new SqlCommand(truyvan, conn);
            SqlDataAdapter da = new SqlDataAdapter(mycm);
            DataTable dt = new DataTable("Products");
            da.Fill(dt);
            //3.Lay du lieu
            dataGridView1.DataSource = dt;
            textBoxID.Text = "";
            textBoxTen.Text = "";
            comboBox1.Text = "";
            comboBox2.Text = "";
            textBoxDgia.Text= "";
            MessageBox.Show("Cap nhat thanh cong!");
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
            string truyvan = "delete from Products where ProductID = N'" + textBoxID.Text + "'";
            SqlCommand mycm = new SqlCommand(truyvan, conn);
            SqlDataAdapter da = new SqlDataAdapter(mycm);
            DataTable dt = new DataTable("Products");
            da.Fill(dt);
            //3.Lay du lieu
            dataGridView1.DataSource = dt;
            textBoxID.Text = "";
            textBoxTen.Text = "";
            comboBox1.Text = "";
            comboBox2.Text = "";
            textBoxDgia.Text= "";
            MessageBox.Show("Xoa thanh cong!");
            da.Dispose();
            conn.Close();
        }

        public void loadcate()
        {
            //1.Tao ket noi
            string connect = "Server = 192.168.31.131 ; Database = NorthWind; User ID = SA; Password = MyStrongPass123";
            SqlConnection conn = new SqlConnection(connect);
            conn.Open();
            string truyvan = "select * from Categories";
            SqlCommand mycm = new SqlCommand(truyvan, conn);
            SqlDataAdapter da = new SqlDataAdapter(mycm);
            DataTable dt = new DataTable("Categories");
            da.Fill(dt);
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "CategoryName";
            comboBox1.ValueMember = "CategoryID";
            da.Dispose();
            conn.Close();
        }

        public void loadsupp()
        {
            //1.Tao ket noi
            string connect = "Server = 192.168.31.131 ; Database = NorthWind; User ID = SA; Password = MyStrongPass123";
            SqlConnection conn = new SqlConnection(connect);
            conn.Open();
            string truyvan = "select * from Suppliers";
            SqlCommand mycm = new SqlCommand(truyvan, conn);
            SqlDataAdapter da = new SqlDataAdapter(mycm);
            DataTable dt = new DataTable("Suppliers");
            da.Fill(dt);
            comboBox2.DataSource = dt;
            comboBox2.DisplayMember = "CompanyName";
            comboBox2.ValueMember = "SupplierID";
            da.Dispose();
            conn.Close();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1 != null)
            {
                textBoxID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                textBoxTen.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                comboBox2.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                textBoxDgia.Text= dataGridView1.CurrentRow.Cells[4].Value.ToString();
            }
        }

        private void XemSP_Click(object sender, EventArgs e)
        {
            loadsp();
        }

        private void buttonThem_Click(object sender, EventArgs e)
        {
            themsp();
            loadsp();
        }

        private void buttoncapnhat_Click(object sender, EventArgs e)
        {
            capnhat();
            loadsp();
        }

        private void buttonxoa_Click(object sender, EventArgs e)
        {
            xoa();
            loadsp();
        }

        private void Sanpham_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'northWindDataSet1.Products' table. You can move, or remove it, as needed.
            this.productsTableAdapter2.Fill(this.northWindDataSet1.Products);
            // TODO: This line of code loads data into the 'northWindDataSet2.Products' table. You can move, or remove it, as needed.
            this.productsTableAdapter1.Fill(this.northWindDataSet2.Products);
            // TODO: This line of code loads data into the 'northWindDataSet.Products' table. You can move, or remove it, as needed.
            //this.productsTableAdapter.Fill(this.northWindDataSet.Products);
            loadcate();
            loadsupp();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            if (dataGridView1 != null)
            {
                textBoxID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                textBoxTen.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                comboBox1.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                comboBox2.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                textBoxDgia.Text= dataGridView1.CurrentRow.Cells[4].Value.ToString();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void buttonnhom_Click(object sender, EventArgs e)
        {
            loadProductTheonhom();
        }

        public void TinhSLSP()
        {
			//1.Tao ket noi
			string connect = "Server = 192.168.31.131 ; Database = NorthWind; " +
                "User ID = SA; Password = MyStrongPass123";
			SqlConnection conn = new SqlConnection(connect);
			SqlCommand cmd = conn.CreateCommand();
			cmd.CommandText = @"
                 select @tong = sum(Quantity) 
                 from OrderDetails
                 where ProductID = @proID";
			if (dataGridView1.SelectedRows.Count > 0)
			{
				DataGridViewRow row = dataGridView1.SelectedRows[0];
				DataRowView rowView = row.DataBoundItem as DataRowView;
				cmd.Parameters.Add("@proID", SqlDbType.Int);
				cmd.Parameters["@proID"].Value = rowView["ProductID"];
				cmd.Parameters.Add("@tong", SqlDbType.Int);
				cmd.Parameters["@tong"].Direction = ParameterDirection.Output;
				conn.Open();
				cmd.ExecuteNonQuery();
				string kq = cmd.Parameters["@tong"].Value.ToString();
				MessageBox.Show("Tổng số lượng sản phẩm " + rowView["ProductName"] + " đã bán là " + kq);
				conn.Close();
			}
			cmd.Dispose();
			conn.Dispose();

		}
		private void tToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			if (dataGridView1.CurrentRow == null) return;
			string idnhom = dataGridView1.CurrentRow.Cells["Nhom"].Value.ToString();
			string idncc = dataGridView1.CurrentRow.Cells["NCC"].Value.ToString();
			string tennhom = layten("select CategoryName from Categories where CategoryID =" + idnhom);
			string tenNCC = layten("select CompanyName from Suppliers where SupplierID =" + idncc);
			MessageBox.Show($"Thông tin chi tiết \n - Nhóm sản phẩm : {tennhom}\n - Tên nhà cung cấp : {tenNCC}");

		}
		private void tToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TinhSLSP();
		}

        private string layten(string sql)
        {
            string kq = "";
            string connect = "Server = 192.168.31.131 ; Database = NorthWind; " +
                "User ID = SA; Password = MyStrongPass123";
            SqlConnection conn = new SqlConnection(connect);
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            object a = cmd.ExecuteScalar();
            if (a != null)
            {
                kq = a.ToString();
            }
            return kq;
        }
        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {}

      
    }
}
