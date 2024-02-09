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

namespace QLQuanCaPhe
{
    public partial class Form_ChangeAcc : Form
    {
        public Form_ChangeAcc()
        {
            InitializeComponent();
            this.AcceptButton = btnChange;
        }

        private void Form_ChangeAcc_Load(object sender, EventArgs e)
        {

        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            if (tbMKmoi.Text != tbXacNhan.Text)
            {
                MessageBox.Show("Xác nhận mật khẩu không chính xác, vui lòng nhập lại.", "Lỗi");
                tbXacNhan.Focus();
                return;
            }
            string connectionString = "Data Source=VIENHS;database=QLQuanCaPhe;user id = sa; password = 1111";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string sql = "SELECT COUNT(*) FROM NhanVien WHERE MaNV = @ma AND MatKhau = @mkcu";

                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@ma", tbMa.Text);
                    command.Parameters.AddWithValue("@mkcu", tbMKcu.Text);

                    int count = (int)command.ExecuteScalar();

                    if (count == 0)
                    {
                        MessageBox.Show("Mã nhân viên và mật khẩu không chính xác.", "Lỗi");
                        tbMa.Focus();
                        return;
                    }
                }
                sql = "UPDATE NhanVien SET MatKhau = @mkmoi WHERE MaNV = @ma";

                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@ma", tbMa.Text);
                    command.Parameters.AddWithValue("@mkmoi", tbMKmoi.Text);
                    command.ExecuteNonQuery();
                }
            }
            tbMa.Clear();
            tbMKcu.Clear();
            tbMKmoi.Clear();
            tbXacNhan.Clear();

            MessageBox.Show("Thay đổi mật khẩu thành công.", "Thông báo");
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Xác nhận thoát cửa sổ thay đổi tài khoản?", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (dr == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void btnThoat_Click_1(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void cbHien_CheckedChanged(object sender, EventArgs e)
        {
            if (cbHien.Checked)
            {
                tbMKmoi.PasswordChar = '\0';
                tbXacNhan.PasswordChar = '\0';
            }
        }

        private void tbMKmoi_TextChanged(object sender, EventArgs e)
        {
            tbMKmoi.PasswordChar = '*';
            cbHien.Checked = false;
        }

        private void tbXacNhan_TextChanged(object sender, EventArgs e)
        {
            tbXacNhan.PasswordChar = '*';
            cbHien.Checked = false;
        }
    }
}
