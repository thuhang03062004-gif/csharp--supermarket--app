using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QLSieuThi
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }



        private void buttonlogin_Click(object sender, EventArgs e)
        {
            string connect = "Server=192.168.31.131;Database=Northwind;User ID=SA;Password=MyStrongPass123";
            try
            {
                SqlConnection conn = new SqlConnection(connect);
                conn.Open();

                // 2. Câu lệnh kiểm tra xem có tài khoản nào khớp không
                // Ta lấy về Title (chức vụ) để sau này phân quyền
                string sql = "SELECT Title FROM Employees WHERE Username = @user AND Pass = @pass";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@user",textBoxten.Text);
                cmd.Parameters.AddWithValue("@pass", textBoxMK.Text);

                // 3. Thực thi
                object ketQua = cmd.ExecuteScalar(); // Lấy về giá trị đầu tiên tìm thấy

                if (ketQua != null) // Nếu tìm thấy (Đăng nhập thành công)
                {
                    MessageBox.Show("Đăng nhập thành công! Xin chào " + textBoxten.Text);

                    // Ẩn form đăng nhập đi
                    this.Hide();

                    // Mở form Trang chủ (SieuThi) lên
                    SieuThi f = new SieuThi();
                    f.ShowDialog(); // Dùng ShowDialog để khi tắt Form chính thì chương trình dừng hẳn

                    // Khi form chính tắt thì đóng luôn ứng dụng
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối: " + ex.Message);
            }

        }

        private void buttonexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
