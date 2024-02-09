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
    public partial class SanPham : Form
    {
        public SanPham()
        {
            InitializeComponent();
        }

        private void SanPham_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LoadData()
        {
            string ConnectionString = "Data Source = VIENHS; Database = QLQuanCaPhe; User Id = sa; Password = 1111";
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("SELECT * FROM SanPham", connection))
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ListViewItem item = new ListViewItem(reader[0].ToString());

                        for (int i = 1; i < reader.FieldCount; i++)
                        {
                            item.SubItems.Add(reader[i].ToString());
                        }

                        lvDanhSachSanPham.Items.Add(item);
                    }
                }
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item1 in lvDanhSachSanPham.Items)
            {
                if (item1.SubItems[0].Text == tbMa.Text)
                {
                    MessageBox.Show("Mã Sản phẩm đã trùng với các Sản phẩm khác, vui lòng tạo mới mã.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    tbMa.Focus();
                    return;
                }
            }
            string cs = "Data Source=VIENHS;database=QLQuanCaPhe;user id = sa; password = 1111";
            using (SqlConnection connection = new SqlConnection(cs))
            {
                connection.Open();
                string sql = "SELECT COUNT(*) FROM SanPham WHERE MaSP = @MaSP";
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@MaSP", tbMa.Text);
                    int count = (int)command.ExecuteScalar();
                    if (count > 0)
                    {
                        MessageBox.Show("Mã Sản phẩm đã trùng với các Sản phẩm khác, vui lòng tạo mới mã.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        tbMa.Focus();
                        return;
                    }
                }
            }
            ListViewItem item = new ListViewItem(tbMa.Text);
            item.SubItems.Add(tbTen.Text);
            item.SubItems.Add(cbbLoai.Text);
            item.SubItems.Add(tbGia.Text);
            item.SubItems.Add(tbDVT.Text);

            lvDanhSachSanPham.Items.Add(item);

            string connectionString = "Data Source=VIENHS;DATABASE=QLQuanCaPhe;USER ID = sa; password = 1111";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string sql = "INSERT INTO SanPham(MaSp, TenSP, LoaiSP, DonGia, DVT) VALUES (@MaSp, @TenSP, @LoaiSP, @DonGia, @DVT)";

                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@MaSp", tbMa.Text);
                    command.Parameters.AddWithValue("@TenSP", tbTen.Text);
                    command.Parameters.AddWithValue("@LoaiSP", cbbLoai.Text);
                    if (string.IsNullOrWhiteSpace(tbGia.Text))
                    {
                        MessageBox.Show("Vui lòng nhập vào giá.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    decimal DonGia = decimal.Parse(tbGia.Text);
                    command.Parameters.AddWithValue("@DonGia", DonGia);
                    command.Parameters.AddWithValue("@DVT", tbDVT.Text);

                    command.ExecuteNonQuery();
                }

                connection.Close();
            }
            MessageBox.Show("Thêm thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            tbMa.Clear();
            tbTen.Clear();
            cbbLoai.SelectedItem = null;
            tbGia.Clear();
            tbDVT.Clear();
            tbMa.Focus();
        }

        private void lvDanhSachSanPham_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvDanhSachSanPham.SelectedItems.Count > 0)
            {
                ListViewItem item = lvDanhSachSanPham.SelectedItems[0];
                tbMa.Text = item.SubItems[0].Text;
                tbTen.Text = item.SubItems[1].Text;
                cbbLoai.SelectedItem = item.SubItems[2].Text;
                tbGia.Text = item.SubItems[3].Text;
                tbDVT.Text = item.SubItems[4].Text;
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (lvDanhSachSanPham.SelectedItems.Count > 0)
            {
                ListViewItem item = lvDanhSachSanPham.SelectedItems[0];
                item.SubItems[0].Text = tbMa.Text;
                item.SubItems[1].Text = tbTen.Text;
                item.SubItems[2].Text = cbbLoai.Text;
                item.SubItems[3].Text = tbGia.Text;
                item.SubItems[4].Text = tbDVT.Text;

                string connectionString = "Data Source=VIENHS;database=QLQuanCaPhe;user id = sa; password = 1111";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string sql = "UPDATE SanPham SET MaSp = @MaSp, TenSP = @TenSP, LoaiSP = @LoaiSP, DonGia = @DonGia, DVT = @DVT WHERE MaSp = @MaSp";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@MaSp", tbMa.Text);
                        command.Parameters.AddWithValue("@TenSP", tbTen.Text);
                        decimal DonGia = decimal.Parse(tbGia.Text);
                        command.Parameters.AddWithValue("@LoaiSP", cbbLoai.Text);
                        command.Parameters.AddWithValue("@DonGia", DonGia);
                        command.Parameters.AddWithValue("@DVT", tbDVT.Text);
                        command.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Lưu thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbMa.Clear();
                tbTen.Clear();
                cbbLoai.SelectedItem = null;
                tbGia.Clear();
                tbDVT.Clear();
                tbMa.Focus();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (lvDanhSachSanPham.SelectedItems.Count > 0)
            {
                ListViewItem item = lvDanhSachSanPham.SelectedItems[0];
                string ma = item.SubItems[0].Text;

                lvDanhSachSanPham.Items.Remove(item);

                string connectionString = "Data Source=VIENHS;database=QLQuanCaPhe;user id = sa; password = 1111";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string sql = "DELETE FROM SanPham WHERE MaSp = @MaSp";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@MaSp", ma);

                        command.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Xoá thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbMa.Clear();
                tbTen.Clear();
                cbbLoai.SelectedItem = null;
                tbGia.Clear();
                tbDVT.Clear();
            }
        }
    }
}
