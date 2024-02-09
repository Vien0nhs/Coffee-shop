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
    public partial class Form_XemHoaDon : Form
    {
        string cs = "Data source = VIENHS; Database = QLQuanCaPhe; User Id = sa; Password = 1111";
        public Form_XemHoaDon()
        {
            InitializeComponent();
        }

        private void Form_XemHoaDon_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LoadData()
        {
            SqlConnection conn = new SqlConnection(cs);

            conn.Open();

            SqlCommand cmd = new SqlCommand("SELECT * FROM PhieuXuat", conn);

            SqlDataReader reader = cmd.ExecuteReader();

            int stt = 1;
            while (reader.Read())
            {
                ListViewItem item = new ListViewItem(stt.ToString());
                item.SubItems.Add(reader["MaPhieuXuat"].ToString());
                item.SubItems.Add(reader["MaNV"].ToString());
                item.SubItems.Add(reader["MaBan"].ToString());
                item.SubItems.Add(reader["ThanhToan"].ToString());
                item.SubItems.Add(reader["TienTraKhach"].ToString());
                item.SubItems.Add(reader["TienDu"].ToString());
                item.SubItems.Add(reader["GhiChu"].ToString());
                lvXemHoaDon.Items.Add(item);

                stt++;
            }

            conn.Close();
        }
    }
}
