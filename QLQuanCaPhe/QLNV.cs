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

namespace QLQuanCaPhe
{
    public partial class QLNV : Form
    {
        public QLNV()
        {
            InitializeComponent();
        }

        private void QLNV_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LoadData()
        {
            string ConnectionString = "Data Source = VIENHS; Database = QLQuanCaPhe; User Id = sa; Password = 1111";
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("SELECT * FROM NhanVien", connection))
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ListViewItem item = new ListViewItem(reader[0].ToString());

                        for (int i = 1; i < reader.FieldCount; i++)
                        {
                            item.SubItems.Add(reader[i].ToString());
                        }
                        lvDanhSachNhanVien.Items.Add(item);
                    }
                }
            }
        }

        private void btnTaoMoi_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbMa.Text) && string.IsNullOrWhiteSpace(tbTen.Text) && string.IsNullOrWhiteSpace(tbDiachi.Text) && string.IsNullOrWhiteSpace(tbSDT.Text) && string.IsNullOrWhiteSpace(tbMatKhau.Text) && string.IsNullOrWhiteSpace(tbXacNhan.Text))
            {
                MessageBox.Show("Vui lòng nhập tên người dùng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbMa.Focus();
                return;
            }
            foreach (ListViewItem item in lvDanhSachNhanVien.Items)
            {
                if (item.SubItems[0].Text == tbMa.Text)
                {
                    MessageBox.Show("Mã nhân viên đã trùng với các nhân viên khác, vui lòng tạo mới mã.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    tbMa.Focus();
                    return;
                }
            }
            string cs = "Data Source=VIENHS;database=QLQuanCaPhe;user id = sa; password = 1111";
            using (SqlConnection connection = new SqlConnection(cs))
            {
                connection.Open();
                string sql = "SELECT COUNT(*) FROM NhanVien WHERE MaNV = @MaNV";
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@MaNV", tbMa.Text);
                    int count = (int)command.ExecuteScalar();
                    if (count > 0)
                    {
                        MessageBox.Show("Mã nhân viên đã trùng với các nhân viên khác, vui lòng tạo mới mã.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        tbMa.Focus();
                        return;
                    }
                }
            }
            if (tbMatKhau.Text != tbXacNhan.Text)
            {
                MessageBox.Show("Xác nhận mật khẩu không chính xác.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Question);
                tbXacNhan.Focus();
            }
            else
            {
                ListViewItem item = new ListViewItem(tbMa.Text);
                item.SubItems.Add(tbTen.Text);
                item.SubItems.Add(dtpNgaySinh.Value.ToString("yyyy-MM-dd"));
                item.SubItems.Add(tbDiachi.Text);
                item.SubItems.Add(tbSDT.Text);
                item.SubItems.Add(tbMatKhau.Text);

                lvDanhSachNhanVien.Items.Add(item);

                string connectionString = "Data Source=VIENHS;DATABASE=QLQuanCaPhe;USER ID = sa; password = 1111";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string sql = "INSERT INTO NhanVien(MaNV, TenNV, NgaySinh, DiaChi, SDTNV, MatKhau) VALUES (@MaNV, @TenNV, @NgaySinh, @DiaChi, @SDTNV, @MatKhau)";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@MaNV", tbMa.Text);
                        command.Parameters.AddWithValue("@TenNV", tbTen.Text);
                        command.Parameters.AddWithValue("@NgaySinh", dtpNgaySinh.Value);
                        command.Parameters.AddWithValue("@DiaChi", tbDiachi.Text);
                        command.Parameters.AddWithValue("@SDTNV", tbSDT.Text);
                        command.Parameters.AddWithValue("@MatKhau", tbMatKhau.Text);

                        command.ExecuteNonQuery();
                    }

                    connection.Close();
                }
                MessageBox.Show("Thêm thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbMa.Clear();
                tbTen.Clear();
                dtpNgaySinh.Value = DateTime.Now;
                tbDiachi.Clear();
                tbSDT.Clear();
                tbMatKhau.Clear();

            }
                
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (lvDanhSachNhanVien.SelectedItems.Count > 0)
            {
                ListViewItem item = lvDanhSachNhanVien.SelectedItems[0];
                item.SubItems[0].Text = tbMa.Text;
                item.SubItems[1].Text = tbTen.Text;
                item.SubItems[2].Text = dtpNgaySinh.Value.ToString("yyyy-MM-dd");
                item.SubItems[3].Text = tbDiachi.Text;
                item.SubItems[4].Text = tbSDT.Text;
                item.SubItems[5].Text = tbMatKhau.Text;

                string connectionString = "Data Source=VIENHS;database=QLQuanCaPhe;user id = sa; password = 1111";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string sql = "UPDATE NhanVien SET MaNV = @MaNV, TenNV = @TenNV, NgaySinh = @NgaySinh, DiaChi = @DiaChi, SDTNV = @SDTNV, MatKhau = @MatKhau WHERE MaNV = @MaNV";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@MaNV", tbMa.Text);
                        command.Parameters.AddWithValue("@TenNV", tbTen.Text);
                        command.Parameters.AddWithValue("@NgaySinh", dtpNgaySinh.Value);
                        command.Parameters.AddWithValue("@DiaChi", tbDiachi.Text);
                        command.Parameters.AddWithValue("@SDTNV", tbSDT.Text);
                        command.Parameters.AddWithValue("@MatKhau", tbMatKhau.Text);
                        command.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Lưu thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void lvDanhSachNhanVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lvDanhSachNhanVien.SelectedItems.Count > 0)
            {
                ListViewItem item = lvDanhSachNhanVien.SelectedItems[0];
                tbMa.Text = item.SubItems[0].Text;
                tbTen.Text = item.SubItems[1].Text;
                dtpNgaySinh.Value = DateTime.Parse(item.SubItems[2].Text);
                tbDiachi.Text = item.SubItems[3].Text;
                tbSDT.Text = item.SubItems[4].Text;
                tbMatKhau.Text = item.SubItems[5].Text;

            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (lvDanhSachNhanVien.SelectedItems.Count > 0)
            {
                ListViewItem item = lvDanhSachNhanVien.SelectedItems[0];
                string ma = item.SubItems[0].Text;

                lvDanhSachNhanVien.Items.Remove(item);

                string connectionString = "Data Source=VIENHS;database=QLQuanCaPhe;user id = sa; password = 1111";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string sql = "DELETE FROM NhanVien WHERE MaNV = @MaNV";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@MaNV", ma);

                        command.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Xoá thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void tbMatKhau_TextChanged(object sender, EventArgs e)
        {
            tbMatKhau.PasswordChar = '*';
        }

        private void tbXacNhan_TextChanged(object sender, EventArgs e)
        {
            tbXacNhan.PasswordChar = '*';
        }
    }
}
