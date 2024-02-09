using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using iTextSharp.text;
using iTextSharp.text.pdf;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace QLQuanCaPhe
{
    public partial class Order1 : Form
    {
        string cs = "Data source = VIENHS; Database = QLQuanCaPhe; User Id = sa; Password = 1111;";
        public class OrderSavedEventArgs : EventArgs
        {
            public string MaPhieuNhap { get; set; }
            public string TrangThai { get; set; }
        }
        public event EventHandler<OrderSavedEventArgs> OrderSaved;

        protected virtual void OnOrderSaved(OrderSavedEventArgs e)
        {
            OrderSaved?.Invoke(this, e);
        }
        public Order1()
        {
            InitializeComponent();
        }

        private void Order1_Load(object sender, EventArgs e)
        {
            tbPhieuNhapMaNhanVien.Text = DangNhap.global.u.MaNV;
            tbPhieuXuatMaNhanVien.Text = DangNhap.global.u.MaNV;
            tbMaBan.Text = DangNhap.global.MaBan;
            CapNhatCount();
            tbMaPhieuNhap.Text = DangNhap.global.mpncount.ToString();
            tbMaPhieuXuat.Text = DangNhap.global.mpxcount.ToString();
        }
        void CapNhatCount()
        {
            using (SqlConnection conn = new SqlConnection(cs))
            {
                conn.Open();

                string sql = "SELECT MAX(CAST(MaPhieuNhap AS INT)) FROM PhieuNhap";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    object result = cmd.ExecuteScalar();
                    DangNhap.global.mpncount = (result == DBNull.Value) ? 1 : (int)result + 1;
                }
                sql = "SELECT MAX(CAST(MaPhieuXuat AS INT)) FROM PhieuXuat";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    object result = cmd.ExecuteScalar();
                    DangNhap.global.mpxcount = (result == DBNull.Value) ? 1 : (int)result + 1;
                }
            }
        }



        private void Order1_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(cs))
            {
                conn.Open();
                string sql = "SELECT COUNT(*) FROM PhieuNhap WHERE MaPhieuNhap = @MaPhieuNhap";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@MaPhieuNhap", tbMaPhieuNhap.Text);
                    int count = (int)cmd.ExecuteScalar();
                    if (count > 0)
                    {
                        MessageBox.Show("Đã lưu bàn này. Vui lòng xoá bàn.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                }
            }
            using (SqlConnection conn = new SqlConnection(cs))
            {
                conn.Open();
                string sql = "SELECT TrangThai FROM Ban WHERE MaBan = @MaBan";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@MaBan", tbMaBan.Text);
                    var status = cmd.ExecuteScalar();
                    if (status != null && status.ToString() == "1")
                    {
                        MessageBox.Show("Bàn này đã được lưu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                }
            }
            

            if (string.IsNullOrEmpty(tbMaPhieuNhap.Text) ||
                string.IsNullOrEmpty(tbPhieuNhapMaNhanVien.Text) ||
                string.IsNullOrEmpty(cbbMaSanPham.Text) ||
                string.IsNullOrEmpty(tbSoluong.Text) ||
                string.IsNullOrEmpty(cbbGiaNhap.Text))
            {
                MessageBox.Show("Hãy nhập đầy đủ phiếu nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            using (SqlConnection connection = new SqlConnection(cs))
            {
                connection.Open();

                string sql = "INSERT INTO PhieuNhap(MaPhieuNhap, NgayNhap, MaNV, GhiChu) VALUES (@MaPhieuNhap, GETDATE(), @MaNV, @GhiChu);" +
                             "INSERT INTO ChiTietPhieuNhap(MaPhieuNhap, MaHang, SoLuong, GiaNhap) VALUES (@MaPhieuNhap, @MaHang, @SoLuong, @GiaNhap)";
                using (SqlCommand command = new SqlCommand(sql, connection))
                {

                    command.Parameters.AddWithValue("@MaPhieuNhap", tbMaPhieuNhap.Text);
                    command.Parameters.AddWithValue("@MaNV", tbPhieuNhapMaNhanVien.Text);
                    command.Parameters.AddWithValue("@GhiChu", tbGhiChu.Text);
                    command.Parameters.AddWithValue("@MaHang", cbbMaSanPham.Text);
                    command.Parameters.AddWithValue("@SoLuong", int.Parse(tbSoluong.Text));
                    command.Parameters.AddWithValue("@GiaNhap", decimal.Parse(cbbGiaNhap.Text));
                    command.ExecuteNonQuery();
                }

                tbMaPhieuNhap.Text = DangNhap.global.mpncount.ToString();
                tbMaPhieuXuat.Text = DangNhap.global.mpxcount.ToString();
                MessageBox.Show("Thêm bàn thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }


            using (SqlConnection conn = new SqlConnection(cs))
            {
                conn.Open();
                string sql = "UPDATE Ban SET TrangThai = 1 WHERE MaBan = @MaBan";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@MaBan", tbMaBan.Text);
                    cmd.ExecuteNonQuery();
                }
            }
            OnOrderSaved(new OrderSavedEventArgs { MaPhieuNhap = tbMaPhieuNhap.Text, TrangThai = "Đã đặt" });
            string maPhieuXuat = tbMaPhieuXuat.Text;
            DateTime ngayXuat = dtpNgayXuat.Value;
            string maNV = tbPhieuXuatMaNhanVien.Text;
            string maKH = tbMaKhachHang.Text;
            string maBan = tbMaBan.Text;
            decimal thanhToan = decimal.Parse(tbThanhToan.Text);
            if (string.IsNullOrWhiteSpace(tbTienKhachTra.Text))
            {
                MessageBox.Show("Vui lòng nhập vào tiền khách trả", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            decimal tienKhachTra = decimal.Parse(tbTienKhachTra.Text);
            decimal tienDu = decimal.Parse(tbTienDu.Text);
            string ghiChu = tbPhieuXuatGhiChu.Text;

            using (SqlConnection conn = new SqlConnection(cs))
            {
                conn.Open();
                string sql = "INSERT INTO PhieuXuat(MaPhieuXuat, NgayXuat, MaNV, MaKH, MaBan, TienTraKhach, TienDu, GhiChu, ThanhToan) VALUES (@MaPhieuXuat, @NgayXuat, @MaNV, @MaKH, @MaBan, @TienTraKhach, @TienDu, @GhiChu, @ThanhToan)";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@MaPhieuXuat", maPhieuXuat);
                    cmd.Parameters.AddWithValue("@NgayXuat", ngayXuat);
                    cmd.Parameters.AddWithValue("@MaNV", maNV);
                    cmd.Parameters.AddWithValue("@MaKH", maKH);
                    cmd.Parameters.AddWithValue("@MaBan", maBan);
                    cmd.Parameters.AddWithValue("@TienTraKhach", tienKhachTra);
                    cmd.Parameters.AddWithValue("@TienDu", tienDu);
                    cmd.Parameters.AddWithValue("@GhiChu", ghiChu);
                    cmd.Parameters.AddWithValue("@ThanhToan", thanhToan);

                    cmd.ExecuteNonQuery();
                }
            }
        }


        private void tbMaNhanVien_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbPhieuXuatMaNhanVien_TextChanged(object sender, EventArgs e)
        {

        }

        public void btnThemMon_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cbbMaSanPham.Text))
            {
                MessageBox.Show("Vui lòng nhập mã sản phẩm", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int sl;
            bool isNumeric = int.TryParse(tbSoluong.Text, out sl);
            if (!isNumeric)
            {
                sl = 1;
            }
            else if (sl == 0)
            {
                MessageBox.Show("Số lượng phải là một số khác 0", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                string maSanPham = cbbMaSanPham.Text;
                decimal giaNhap = decimal.Parse(cbbGiaNhap.Text);

                string connectionString = "Data Source=VIENHS;database=QLQuanCaPhe;user id = sa; password = 1111";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT * FROM SanPham WHERE MaSp = @MaSp";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@MaSp", maSanPham);

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        string tenSp = reader["TenSp"].ToString();
                        string loaiSp = reader["LoaiSp"].ToString();
                        decimal donGia = (decimal)reader["DonGia"];
                        string dvt = reader["DVT"].ToString();

                        ListViewItem item = new ListViewItem(maSanPham);
                        item.SubItems.Add(tenSp);
                        item.SubItems.Add(loaiSp);
                        item.SubItems.Add(donGia.ToString());
                        item.SubItems.Add(dvt);
                        item.SubItems.Add(sl.ToString());

                        lvDanhSachMon.Items.Add(item);
                    }

                    reader.Close();
                    cbbMaSanPham.Focus();
                }
            }
            CapNhatThanhToan();
        }


        void CapNhatThanhToan()
        {
            decimal tongTien = 0;
            foreach (ListViewItem item in lvDanhSachMon.Items)
            {
                decimal giaNhap = decimal.Parse(item.SubItems[3].Text);
                int soLuong = int.Parse(item.SubItems[5].Text);
                tongTien += giaNhap * soLuong;
            }
            tbThanhToan.Text = tongTien.ToString();
        }
        private void CapNhatComboBox()
        {
            string maSanPham = cbbMaSanPham.Text;
            SqlConnection conn = new SqlConnection("Data Source=VIENHS;database=QLQuanCaPhe;user id = sa; password = 1111");
            conn.Open();

            string sql = "SELECT DonGia FROM SanPham WHERE MaSp = @MaSp";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@MaSp", maSanPham);

            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                decimal donGia = decimal.Parse(reader["DonGia"].ToString());
                cbbGiaNhap.Text = donGia.ToString();
            }
            conn.Close();
        }


        private void btnXoaMon_Click(object sender, EventArgs e)
        {
            var selectedItems = lvDanhSachMon.SelectedItems;

            foreach (ListViewItem item in selectedItems)
            {
                lvDanhSachMon.Items.Remove(item);
            }
        }

        private void cbbMaSanPham_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbMaSanPham.SelectedItem != null)
            {
                CapNhatComboBox();
                string masanpham = cbbMaSanPham.SelectedItem.ToString();
                string cs = "Data source = VIENHS; Database = QLQuanCaPhe; User Id = sa; Password = 1111;";
                using (SqlConnection conn = new SqlConnection(cs))
                {
                    conn.Open();
                    string sql = "SELECT TenSP FROM SanPham WHERE MaSp = @MaSp";
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@MaSp", masanpham);
                        string tenSanPham = cmd.ExecuteScalar().ToString();
                        tbTenSanPham.Text = tenSanPham;
                    }
                }
            }
            
        }



        private void btnXoaBan_Click(object sender, EventArgs e)
        {
            string cs = "Data source = VIENHS; Database = QLQuanCaPhe; User Id = sa; Password = 1111;";
            using (SqlConnection conn = new SqlConnection(cs))
            {
                conn.Open();
                string sql = "UPDATE Ban SET TrangThai = 0 WHERE MaBan = @MaBan";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@MaBan", tbMaBan.Text);
                    cmd.ExecuteNonQuery();
                }
            }

            OnOrderSaved(new OrderSavedEventArgs { MaPhieuNhap = tbMaPhieuNhap.Text, TrangThai = "Trống" });
            MessageBox.Show("Đã xóa bàn thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void tbTienKhachTra_TextChanged(object sender, EventArgs e)
        {
            decimal tienKhachTra;
            bool isNumeric = decimal.TryParse(tbTienKhachTra.Text, out tienKhachTra);
            if (!isNumeric)
            {
                MessageBox.Show("Vui lòng nhập số tiền hợp lệ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                decimal tienThanhToan;
                if (!decimal.TryParse(tbThanhToan.Text, out tienThanhToan))
                {
                    MessageBox.Show("Số tiền thanh toán không hợp lệ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                decimal tienDu = tienKhachTra - tienThanhToan;
                tbTienDu.Text = tienDu.ToString();
            }
        }

        private void tbThanhToan_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnXuatHoaDon_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "PDF Document|*.pdf";
            saveFileDialog.Title = "Lưu hóa đơn";
            saveFileDialog.ShowDialog();

            if (saveFileDialog.FileName != "")
            {
                Document doc = new Document(iTextSharp.text.PageSize.LETTER, 10, 10, 42, 35);
                PdfWriter wri = PdfWriter.GetInstance(doc, new FileStream(saveFileDialog.FileName, FileMode.Create));
                doc.Open();

                doc.Add(new Paragraph("Mã Phiếu Xuất: " + tbMaPhieuXuat.Text));
                doc.Add(new Paragraph("Ngày Xuất: " + dtpNgayXuat.Text));
                doc.Add(new Paragraph("Mã Nhân Viên: " + tbPhieuXuatMaNhanVien.Text));
                doc.Add(new Paragraph("Mã Khách Hàng: " + tbMaKhachHang.Text));
                doc.Add(new Paragraph("Mã Bàn: " + tbMaBan.Text));
                doc.Add(new Paragraph("Thanh Toán: " + tbThanhToan.Text));
                doc.Add(new Paragraph("Tiền Khách Trả: " + tbTienKhachTra.Text));
                doc.Add(new Paragraph("Tiền Dư: " + tbTienDu.Text));
                doc.Add(new Paragraph("Ghi Chú: " + tbPhieuXuatGhiChu.Text));

                doc.Close();

                MessageBox.Show("Đã tạo xong hóa đơn!");
            }
        }

    }
}
