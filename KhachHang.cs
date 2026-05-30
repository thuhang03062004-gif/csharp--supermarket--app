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
    public partial class KhachHang : Form
    {
        public KhachHang()
        {
            InitializeComponent();
        }

        private void KhachHang_Load(object sender, EventArgs e)
        {
            
            // TODO: This line of code loads data into the 'northWindDataSet1.Customers' table. You can move, or remove it, as needed.
            this.customersTableAdapter2.Fill(this.northWindDataSet1.Customers);
            // TODO: This line of code loads data into the 'northWindDataSet2.Customers' table. You can move, or remove it, as needed.
            this.customersTableAdapter1.Fill(this.northWindDataSet2.Customers);
            // TODO: This line of code loads data into the 'northWindDataSet.Customers' table. You can move, or remove it, as needed.
            this.customersTableAdapter.Fill(this.northWindDataSet.Customers);
            
        }

        public void loadkh()
        {
            //1.Tao ket noi
            string connect = "Server = 192.168.31.131 ; Database = NorthWind; User ID = SA; Password = MyStrongPass123";
            SqlConnection conn = new SqlConnection(connect);
            conn.Open();
            SqlCommand mycm = conn.CreateCommand();
            mycm.CommandText = "exec XemKH";
            SqlDataAdapter da = new SqlDataAdapter(mycm);
            DataTable dt = new DataTable("Customers");
            da.Fill(dt);
            //3.Lay du lieu
            dataGridView1.DataSource = dt;
            da.Dispose();
            conn.Close();
        }

        public void themkh()
        {
            //1.Tao ket noi
            string connect = "Server = 192.168.31.131 ; Database = NorthWind; User ID = SA; Password = MyStrongPass123";
            SqlConnection conn = new SqlConnection(connect);
            conn.Open();
            SqlCommand mycm = conn.CreateCommand();
            mycm.CommandText = "exec ThemKH @cusID, @compName, @sdt , @DC";
            mycm.Parameters.Add("@cusID", SqlDbType.NChar, 5).Value = textBoxID.Text;
            mycm.Parameters.Add("@compName", SqlDbType.NVarChar, 40).Value = textBoxTenKH.Text;
            mycm.Parameters.Add("@sdt",SqlDbType.NVarChar,15).Value= textBoxSDT.Text;
            mycm.Parameters.Add("@DC", SqlDbType.NVarChar, 60).Value = textBoxDChi.Text;
            SqlDataAdapter da = new SqlDataAdapter(mycm);
            DataTable dt = new DataTable("Customers");
            da.Fill(dt);
            MessageBox.Show("Them moi thanh cong!");
            textBoxID.Text = "";
            textBoxTenKH.Text = "";
            textBoxSDT.Text ="";
            textBoxDChi.Text = "";
            da.Dispose();
            conn.Close();
        }

        public void capnhat()
        {
            //1.Tao ket noi
            string connect = "Server = 192.168.31.131 ; Database = NorthWind; User ID = SA; Password = MyStrongPass123";
            SqlConnection conn = new SqlConnection(connect);
            conn.Open();

            SqlCommand mycm = conn.CreateCommand();
            mycm.CommandText = "exec CapnhatKH @cusID, @compName, @DC";
            mycm.Parameters.Add("@cusID", SqlDbType.NChar, 5).Value = textBoxID.Text;
            mycm.Parameters.Add("@commpName", SqlDbType.NVarChar, 40).Value = textBoxTenKH.Text;
            mycm.Parameters.Add("@sdt", SqlDbType.NVarChar, 15).Value= textBoxSDT.Text;
            mycm.Parameters.Add("@DC", SqlDbType.NVarChar, 60).Value = textBoxDChi;
            SqlDataAdapter da = new SqlDataAdapter(mycm);
            DataTable dt = new DataTable("Customers");
            da.Fill(dt);
            //3.Lay du lieu
            //dataGridView1.DataSource = dt;
            MessageBox.Show("Cap nhat thanh cong!");
            textBoxID.Text = "";
            textBoxTenKH.Text = "";
            textBoxSDT.Text ="";
            textBoxDChi.Text = "";
            da.Dispose();
            conn.Close();
        }

        public void xoa()
        {
            //1.Tao ket noi
            string connect = "Server = 192.168.31.131 ; Database = NorthWind; User ID = SA; Password = MyStrongPass123";
            SqlConnection conn = new SqlConnection(connect);
            conn.Open();
            SqlCommand mycm = conn.CreateCommand();
            mycm.CommandText = "exec XoaKH @cusID";
            mycm.Parameters.Add("@cusID", SqlDbType.NChar, 5).Value = textBoxID.Text;
            SqlDataAdapter da = new SqlDataAdapter(mycm);
            DataTable dt = new DataTable("Customers");
            da.Fill(dt);
            //3.Lay du lieu
            //dataGridView1.DataSource = dt;
            MessageBox.Show("Xoa thanh cong!");
            textBoxID.Text = "";
            textBoxTenKH.Text = "";
            textBoxSDT.Text ="";
            textBoxDChi.Text = "";
            da.Dispose();
            conn.Close();
        }
        private void buttonThem_Click(object sender, EventArgs e)
        {
            themkh();
            loadkh();
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            if (dataGridView1 != null)
            {
                textBoxID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                textBoxTenKH.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                textBoxSDT.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                textBoxDChi.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
              
            }
        }

        private void buttonXoa_Click(object sender, EventArgs e)
        {
            xoa();
            loadkh();
        }

        private void xemNhậtKýMuaHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (textBoxID.Text != null)
            {
                NhatKy nhatky = new NhatKy();
                nhatky.loadnhatky(textBoxID.Text.ToString());
                nhatky.Show(this);
            }
        }

        private void xemDanhMụcHóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (textBoxID.Text != "")
            {
                DanhMucHoaDon a = new DanhMucHoaDon();
                a.loadngayhd(textBoxID.Text);
                a.Show(this);
            }
        }

        private void button_Click(object sender, EventArgs e)
        {
            loadkh();
        }

        private void buttonSua_Click(object sender, EventArgs e)
        {
            capnhat();
            loadkh();
        }
    }
}
