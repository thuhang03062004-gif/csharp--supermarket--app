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
    public partial class HoaDon : Form
    {
        public HoaDon()
        {
            InitializeComponent();
        }

        void LoadEmployees()
        {
            string connect = "Server = 192.168.31.131 ; Database = NorthWind; User ID = SA; Password = MyStrongPass123";
            SqlConnection conn = new SqlConnection(connect);
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT EmployeeID, LastName + ' ' + FirstName AS FullName FROM Employees", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);

            cboNV.DataSource = dt;
            cboNV.ValueMember = "EmployeeID";
            cboNV.DisplayMember = "FullName";
            da.Dispose();
            conn.Close();
        }

        void LoadCustomers()
        {
            string connect = "Server = 192.168.31.131 ; Database = NorthWind; User ID = SA; Password = MyStrongPass123";
            SqlConnection conn = new SqlConnection(connect);
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT CustomerID, CompanyName FROM Customers", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);

            comboBoxKH.DataSource = dt;
            comboBoxKH.ValueMember = "CustomerID";
            comboBoxKH.DisplayMember = "CompanyName";
            da.Dispose();
            conn.Close();
        }

        void LoadProducts()
        {
            string connect = "Server = 192.168.31.131 ; Database = NorthWind; User ID = SA; Password = MyStrongPass123";
            SqlConnection conn = new SqlConnection(connect);
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT ProductID, ProductName, UnitPrice FROM Products", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);

            comboBoxSP.DataSource = dt;
            comboBoxSP.ValueMember = "ProductID";
            comboBoxSP.DisplayMember = "ProductName";
            da.Dispose();
            conn.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void HoaDon_Load(object sender, EventArgs e)
        {
            LoadEmployees();
            LoadCustomers();
            LoadProducts();
            dateTimePicker1.Value = DateTime.Now;
        }

        private void comboBoxSP_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxSP.SelectedValue != null)
            {
                if (comboBoxSP.SelectedItem == null) return;

                DataRowView row = comboBoxSP.SelectedItem as DataRowView;
                string id = row["ProductID"].ToString();
                string connect = "Server = 192.168.31.131 ; Database = NorthWind;" +
                                   " User ID = SA; Password = MyStrongPass123";
                SqlConnection conn = new SqlConnection(connect);
                SqlCommand cmd = new SqlCommand(
                    "SELECT UnitPrice FROM Products WHERE ProductID=@id", conn);
                cmd.Parameters.AddWithValue("@id",id);

                conn.Open();
                textBoxDG.Text = cmd.ExecuteScalar().ToString();
                conn.Close();
            }
        }

     
        private void TinhTongTien()
        {
            decimal tong = 0;

            foreach (DataGridViewRow r in dataGridView1.Rows)
            {
                if (r.Cells["ThanhTien"].Value != null)
                {
                    tong += Convert.ToDecimal(r.Cells["ThanhTien"].Value);
                }
            }

            labelTong.Text = tong.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBoxSP.SelectedItem == null)
            {
                MessageBox.Show("Chọn sản phẩm!");
                return;
            }
            if (string.IsNullOrWhiteSpace(textBoxSL.Text))
            {
                MessageBox.Show("Nhập số lượng!");
                return;
            }

            // Lấy thông tin sản phẩm từ combobox
            DataRowView row = comboBoxSP.SelectedItem as DataRowView;
            string maSP = row["ProductID"].ToString();
            string tenSP = row["ProductName"].ToString();

            int soLuong = int.Parse(textBoxSL.Text);
            decimal donGia = decimal.Parse(textBoxDG.Text);
            decimal thanhTien = soLuong * donGia;

            // Thêm vào DataGridView
            dataGridView1.Rows.Add(maSP, tenSP, soLuong, donGia, thanhTien);

            // Cập nhật tổng tiền
            TinhTongTien();

            textBoxDG.Text = "";
            textBoxSL.Text = "";
            comboBoxSP.Text = "";
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 2) // cột Số lượng
            {
                int sl = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[2].Value);
                decimal dg = Convert.ToDecimal(dataGridView1.Rows[e.RowIndex].Cells[3].Value);

               dataGridView1.Rows[e.RowIndex].Cells[4].Value = sl * dg;

                TinhTongTien();
            }
        }

        private void xóaSảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
                TinhTongTien();
            }
            else
            {
                MessageBox.Show("Chọn dòng cần xóa!");
            } 
                
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string connect = "Server = 192.168.31.131 ; Database = NorthWind; " +
                              "User ID = SA; Password = MyStrongPass123";
            SqlConnection conn = new SqlConnection(connect);
            conn.Open();
            // 1.Thêm hóa đơn vào bảng Orders
            SqlCommand cmd = new SqlCommand(
            "INSERT INTO Orders(CustomerID, EmployeeID, OrderDate) " +
            "VALUES (@cus, @emp, @date); SELECT SCOPE_IDENTITY();", conn);

            cmd.Parameters.AddWithValue("@cus", comboBoxKH.SelectedValue);
            cmd.Parameters.AddWithValue("@emp", cboNV.SelectedValue);
            cmd.Parameters.AddWithValue("@date", dateTimePicker1.Value);
            int orderID = Convert.ToInt32(cmd.ExecuteScalar());
            // 2. Thêm chi tiết hóa đơn vào Order Details
            foreach (DataGridViewRow r in dataGridView1.Rows)
            {
                if (r.IsNewRow) continue;
                SqlCommand c = new SqlCommand(
                    "INSERT INTO OrderDetails(OrderID, ProductID, UnitPrice, Quantity) " +
                    "VALUES (@id, @sp, @dg, @sl)", conn);

                c.Parameters.AddWithValue("@id", orderID);
                c.Parameters.AddWithValue("@sp", Convert.ToInt32(r.Cells[0].Value));
                c.Parameters.AddWithValue("@dg", Convert.ToInt32(r.Cells[3].Value));
                c.Parameters.AddWithValue("@sl", Convert.ToInt32(r.Cells[2].Value));

                c.ExecuteNonQuery();
            }
            MessageBox.Show("Lưu hóa đơn thành công!");
            dataGridView1.Rows.Clear();
        }
    }
}
