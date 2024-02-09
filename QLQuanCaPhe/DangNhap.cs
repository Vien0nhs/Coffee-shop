using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace QLQuanCaPhe
{
    public partial class DangNhap : Form
    {
        public static class global
        {
            public static User u {  get; set; }
            public static string MaBan {  get; set; }
            public static int mpncount {  get; set; }
            public static int mpxcount {  get; set; }
        }
        public DangNhap()
        {
            InitializeComponent();
            this.AcceptButton = btnDangNhap;
            global.u = new User();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void DangNhap_Load(object sender, EventArgs e)
        {

        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string ui = "Admin";
            string up = "Admin123";
            string MaNV = tbMa.Text;
            string MatKhau = tbMKNV.Text;

            if (ui == MaNV && up == MatKhau)
            {
                MessageBox.Show("Chào mừng bạn, người quản lý đáng mến.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                global.u.MaNV = tbMa.Text;
                Form_MainUI fm = new Form_MainUI();
                fm.Show();
            }
            else
            {
                string cs = "Data source = VIENHS; Database = QLQuanCaPhe; User Id = sa; Password = 1111";
                using (SqlConnection conn = new SqlConnection(cs))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("select * from NhanVien where MaNV = @username and MatKhau = @password", conn))
                    {
                        cmd.Parameters.AddWithValue("@username", tbMa.Text);
                        cmd.Parameters.AddWithValue("password", tbMKNV.Text);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                this.Hide();
                                Form_MainUI fm = new Form_MainUI();
                                fm.Show();
                                fm.gettsqlnv().Enabled = false;
                                fm.gettsqlsp().Enabled = false;
                                global.u.MaNV = tbMa.Text;
                                MessageBox.Show("Chào mừng bạn, nhân viên đáng mến.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không chính xác.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                }
            }
            
        }

        private void tbMa_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbMKNV_TextChanged(object sender, EventArgs e)
        {
            tbMKNV.PasswordChar = '*';
            cbHien.Checked = false;
        }

        private void llQuenMatKhau_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Vui lòng liên hệ với người quản lý để cập nhật.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void cbHien_CheckedChanged(object sender, EventArgs e)
        {
            if(cbHien.Checked)
            {
                tbMKNV.PasswordChar = '\0';
            }
        }

        private void DangNhap_FormClosed(object sender, FormClosedEventArgs e)
        {
        }
    }
}
