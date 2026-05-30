using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSieuThi
{
    public partial class SieuThi : Form
    {
        public SieuThi()
        {
            InitializeComponent();
        }

        private void OpenChildForm(Form con)
        {
            //Xóa form cũ
            panelMain.Controls.Clear();
            //Form con
            con.TopLevel = false;
            con.FormBorderStyle = FormBorderStyle.None; //bỏ viền
            con.Dock = DockStyle.Fill;
            //Thêm vào panel
            panelMain.Controls.Add(con);
            panelMain.Tag = con;
            //Hiển thị
            con.Show();
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Sanpham());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();
            panelMain.Controls.Add(pictureBox1);
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenChildForm(new KhachHang());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenChildForm(new NhaCungCap());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            OpenChildForm(new NhanVien());
        }

        private void button6_Click(object sender, EventArgs e)
        {
            OpenChildForm(new HoaDon());
        }
    }
}
