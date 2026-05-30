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
    public partial class NhanVien : Form
    {
        public NhanVien()
        {
            InitializeComponent();
        }
        
        public void loadnv()
        {
            //1.Tao ket noi
            string connect = "Server = 192.168.31.131 ; Database = NorthWind; User ID = SA; Password = MyStrongPass123";
            SqlConnection conn = new SqlConnection(connect);
            conn.Open();

            //2.Tao truy van
            string truyvan = "select * from Employees";
            SqlCommand mycm = new SqlCommand(truyvan, conn);
            SqlDataAdapter da = new SqlDataAdapter(mycm);
            DataTable dt = new DataTable("Employees");
            da.Fill(dt);
            //3.Lay du lieu
            dataGridView1.DataSource = dt;
            textBoxID.Text = "";
            textBoxHo.Text = "";
            textBoxTen.Text = "";
            textBoxNote.Text = "";
            textBoxSDT.Text = "";
            textBoxDC.Text = "";
            da.Dispose();
            conn.Close();
        }
        public void themnv()
        {
            //1.Tao ket noi
            string connect = "Server = 192.168.31.131 ; Database = NorthWind; User ID = SA; Password = MyStrongPass123";
            SqlConnection conn = new SqlConnection(connect);
            conn.Open();

            //2.Tao truy van
            string truyvan = "exec ThemNV @ho, @ten, @add, @phone, @note ";
            SqlCommand mycm = new SqlCommand(truyvan, conn);
            mycm.Parameters.Add("@ho", SqlDbType.NVarChar, 40).Value = textBoxHo.Text;
            mycm.Parameters.Add("@ten", SqlDbType.NVarChar, 30).Value = textBoxTen.Text;
            mycm.Parameters.Add("@add", SqlDbType.NVarChar, 60).Value = textBoxDC.Text;
            mycm.Parameters.Add("@phone", SqlDbType.NVarChar, 24).Value = textBoxSDT.Text;
            mycm.Parameters.Add("@note", SqlDbType.NText).Value = textBoxNote.Text;
            SqlDataAdapter da = new SqlDataAdapter(mycm);
            DataTable dt = new DataTable("Employees");
            da.Fill(dt);
            //3.Lay du lieu
            dataGridView1.DataSource = dt;
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
            string truyvan = "exec capnhatnv @ID, @ho, @ten, @add, @phone, @note ";
			SqlCommand mycm = new SqlCommand(truyvan, conn);
            mycm.Parameters.Add("@ID", SqlDbType.Int).Value = textBoxID.Text;
			mycm.Parameters.Add("@ho", SqlDbType.NVarChar, 40).Value = textBoxHo.Text;
			mycm.Parameters.Add("@ten", SqlDbType.NVarChar, 30).Value = textBoxTen.Text;
			mycm.Parameters.Add("@add", SqlDbType.NVarChar, 60).Value = textBoxDC.Text;
			mycm.Parameters.Add("@phone", SqlDbType.NVarChar, 24).Value = textBoxSDT.Text;
			mycm.Parameters.Add("@note", SqlDbType.NText).Value = textBoxNote.Text;
			SqlDataAdapter da = new SqlDataAdapter(mycm);
			DataTable dt = new DataTable("Suppliers");
            da.Fill(dt);
            //3.Lay du lieu
            dataGridView1.DataSource = dt;
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
            string truyvan = "delete from Employees where EmployeeID = N'" + textBoxID.Text + "'";
            SqlCommand mycm = new SqlCommand(truyvan, conn);
            SqlDataAdapter da = new SqlDataAdapter(mycm);
            DataTable dt = new DataTable("Employees");
            da.Fill(dt);
            //3.Lay du lieu
            dataGridView1.DataSource = dt;
            MessageBox.Show("Xóa thành công!");
            conn.Close();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void NhanVien_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'northWindDataSet1.Employees' table. You can move, or remove it, as needed.
            this.employeesTableAdapter.Fill(this.northWindDataSet1.Employees);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            themnv();
            loadnv();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            capnhat();
            loadnv() ;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            xoa();
            loadnv();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            loadnv();
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
			if (dataGridView1 != null)
			{
				textBoxID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
				textBoxHo.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
				textBoxTen.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
				textBoxDC.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
				textBoxSDT.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
				textBoxNote.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
			}
		}
    }
}
