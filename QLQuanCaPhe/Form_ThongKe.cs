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
    public partial class Form_ThongKe : Form
    {
        string cs = "Data source = VIENHS; Database = QLQuanCaPhe; User Id = sa; Password = 1111";
        public Form_ThongKe()
        {
            InitializeComponent();
        }

        private void lvThongKe_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form_ThongKe_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LoadData()
        {
            SqlConnection conn = new SqlConnection(cs);
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT CAST(NgayXuat AS DATE) AS Ngay, SUM(ThanhToan) AS TongDoanhThu FROM PhieuXuat GROUP BY CAST(NgayXuat AS DATE)", conn);

            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                ListViewItem item = new ListViewItem(reader["Ngay"].ToString());
                item.SubItems.Add(reader["TongDoanhThu"].ToString());

                lvThongKe.Items.Add(item);
            }

            // Đóng kết nối
            conn.Close();
        }
    }
}
