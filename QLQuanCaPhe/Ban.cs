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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QLQuanCaPhe
{
    public partial class Ban : Form
    {
        public Ban()
        {
            InitializeComponent();
        }

        private void Ban_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        void LoadData()
        {
            string cs = "Data source = VIENHS; Database = QLQuanCaPhe; User id = sa; password = 1111";
            using (SqlConnection sc = new SqlConnection(cs))
            {
                sc.Open();
                using(SqlCommand cmd = new SqlCommand("select * from Ban", sc))
                using(SqlDataReader rd = cmd.ExecuteReader())
                {
                    while(rd.Read())
                    {
                        ListViewItem lvi = new ListViewItem(rd[0].ToString());
                        for (int i = 1; i < rd.FieldCount; i++)
                        {
                            lvi.SubItems.Add(rd[i].ToString());
                        }
                        lvDanhSachBan.Items.Add(lvi);
                    }
                }
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            foreach(ListViewItem lvi in lvDanhSachBan.Items)
            {
                if (lvi.SubItems[0].Text == tbMa.Text)
                {
                    MessageBox.Show("Mã bàn đã trùng với các bàn khác, vui lòng tạo mới mã", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    tbMa.Focus();
                    return;
                }
            }
            string cs = "Data Source=VIENHS;database=QLQuanCaPhe;user id = sa; password = 1111";
            using (SqlConnection connection = new SqlConnection(cs))
            {
                connection.Open();
                string sql = "SELECT COUNT(*) FROM Ban WHERE MaBan = @MaBan";
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@MaBan", tbMa.Text);
                    int count = (int)command.ExecuteScalar();
                    if (count > 0)
                    {
                        MessageBox.Show("Mã bàn đã trùng với các bàn khác, vui lòng tạo mới mã.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        tbMa.Focus();
                        return;
                    }
                }
                bool tt = false;
                ListViewItem item = new ListViewItem(tbMa.Text);
                item.SubItems.Add(tbTen.Text);
                item.SubItems.Add(tbKhuVuc.Text);

                lvDanhSachBan.Items.Add(item);

                string connectionString = "Data Source=VIENHS;DATABASE=QLQuanCaPhe;USER ID = sa; password = 1111";

                using (SqlConnection cn = new SqlConnection(connectionString))
                {
                    cn.Open();

                    string sc = "INSERT INTO Ban(MaBan, TenBan, KhuVuc, TrangThai) VALUES (@MaBan, @TenBan, @KhuVuc, @TrangThai)";

                    using (SqlCommand command = new SqlCommand(sc, connection))
                    {
                        command.Parameters.AddWithValue("@MaBan", tbMa.Text);
                        command.Parameters.AddWithValue("@TenBan", tbTen.Text);
                        command.Parameters.AddWithValue("@KhuVuc", tbKhuVuc.Text);
                        command.Parameters.AddWithValue("@TrangThai", tt);

                        command.ExecuteNonQuery();
                    }

                    connection.Close();
                }
                MessageBox.Show("Thêm thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbMa.Clear();
                tbTen.Clear();
                tbKhuVuc.Clear();
            }
        }

        private void lvDanhSachBan_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lvDanhSachBan.SelectedItems.Count > 0)
            {
                ListViewItem lvi = lvDanhSachBan.SelectedItems[0];
                tbMa.Text = lvi.SubItems[0].Text;
                tbTen.Text = lvi.SubItems[1].Text;
                tbKhuVuc.Text = lvi.SubItems[2].Text;
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {

            string currentMaBan = lvDanhSachBan.SelectedItems.Count > 0 ? lvDanhSachBan.SelectedItems[0].SubItems[0].Text : null;

            foreach (ListViewItem lvi in lvDanhSachBan.Items)
            {
                if (lvi.SubItems[0].Text == tbMa.Text && tbMa.Text != currentMaBan)
                {
                    MessageBox.Show("Mã bàn đã trùng với các bàn khác, vui lòng tạo mới mã", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    tbMa.Focus();
                    return;
                }
            }
            string connect = "Data Source=VIENHS;database=QLQuanCaPhe;user id = sa; password = 1111";
            using (SqlConnection connection = new SqlConnection(connect))
            {
                connection.Open();
                if (tbMa.Text != currentMaBan)
                {
                    string sqlqr = "SELECT COUNT(*) FROM Ban WHERE MaBan = @MaBan";
                    using (SqlCommand command = new SqlCommand(sqlqr, connection))
                    {
                        command.Parameters.AddWithValue("@MaBan", tbMa.Text);
                        int count = (int)command.ExecuteScalar();
                        if (count > 0)
                        {
                            MessageBox.Show("Mã bàn đã trùng với các bàn khác, vui lòng tạo mới mã.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            tbMa.Focus();
                            return;
                        }
                    }
                }
                if (lvDanhSachBan.SelectedItems.Count > 0)
                {
                    ListViewItem lvi = lvDanhSachBan.SelectedItems[0];
                    lvi.SubItems[0].Text = tbMa.Text;
                    lvi.SubItems[1].Text = tbTen.Text;
                    lvi.SubItems[2].Text = tbKhuVuc.Text;
                    string cs = "Data source = VIENHS; Database = QLQuanCaPhe; User Id = sa; Password = 1111";
                    using (SqlConnection conn = new SqlConnection(cs))
                    {
                        conn.Open();
                        string sql;
                        if (tbMa.Text == currentMaBan)
                        {
                            sql = "UPDATE Ban SET TenBan = @TenBan, KhuVuc = @KhuVuc WHERE MaBan = @MaBan";
                        }
                        else
                        {
                            sql = "INSERT INTO Ban(MaBan, TenBan, KhuVuc, TrangThai) VALUES (@MaBan, @TenBan, @KhuVuc, 'Trống')";
                        }
                        using (SqlCommand cmd = new SqlCommand(sql, conn))
                        {
                            cmd.Parameters.AddWithValue("@MaBan", tbMa.Text);
                            cmd.Parameters.AddWithValue("@TenBan", tbTen.Text);
                            cmd.Parameters.AddWithValue("@KhuVuc", tbKhuVuc.Text);
                            cmd.ExecuteNonQuery();
                        }
                        MessageBox.Show("Lưu thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (lvDanhSachBan.SelectedItems.Count > 0)
            {
                ListViewItem item = lvDanhSachBan.SelectedItems[0];
                string ma = item.SubItems[0].Text;

                lvDanhSachBan.Items.Remove(item);

                string connectionString = "Data Source=VIENHS;database=QLQuanCaPhe;user id = sa; password = 1111";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string sql = "DELETE FROM Ban WHERE MaBan = @MaBan";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@MaBan", ma);

                        command.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Xoá thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
