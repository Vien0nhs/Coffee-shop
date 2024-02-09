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
using static QLQuanCaPhe.Order1;

namespace QLQuanCaPhe
{
    public partial class Order : Form
    {

        public Order()
        {
            InitializeComponent();
        }

        private void Order_Load(object sender, EventArgs e)
        {
            LoadData();
            DangNhap.global.mpncount = 0;
            DangNhap.global.mpxcount = 0;
        }
        string CS = "data source = VIENHS; database = QLQuanCaPhe; user id = sa; password = 1111";
        void LoadData()
        {
            using(SqlConnection conn = new SqlConnection(CS))
            {
                conn.Open();
                using(SqlCommand cmd = new SqlCommand("select * from Ban", conn))
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ListViewItem item = new ListViewItem(reader[0].ToString());
                        for (int i = 1; i < reader.FieldCount; i++)
                        {
                            if (reader.GetName(i) == "TrangThai")
                            {
                                item.SubItems.Add((bool)reader[i] ? "Đã đặt" : "Trống");
                            }
                            else
                            {
                                item.SubItems.Add(reader[i].ToString());
                            }
                        }
                        lvDanhSachTrangThaiBan.Items.Add(item);
                    }
                }
            }
        }
        private void Order1_OrderSaved(object sender, OrderSavedEventArgs e)
        {
            ListViewItem item = lvDanhSachTrangThaiBan.SelectedItems[0];
            item.SubItems[3].Text = e.TrangThai;
        }
        private void lvDanhSachTrangThaiBan_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvDanhSachTrangThaiBan.SelectedItems.Count > 0)
            {
                ListViewItem item = lvDanhSachTrangThaiBan.SelectedItems[0];
                Order1 order1 = new Order1();
                DangNhap.global.MaBan = item.SubItems[0].Text;
                order1.OrderSaved += Order1_OrderSaved;
                order1.ShowDialog();
            }
        }


        private void lvDanhSachTrangThaiBan_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void Order_MouseHover(object sender, EventArgs e)
        {

        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void lvDanhSachTrangThaiBan_MouseMove(object sender, MouseEventArgs e)
        {
            ListViewItem item = lvDanhSachTrangThaiBan.GetItemAt(e.X, e.Y);
            if (item != null && item.SubItems[3].Text == "Trống")
            {
                toolTip1.Show("Sẵn sàng để order, vui lòng nhấp vào", lvDanhSachTrangThaiBan, e.Location, 5000);
            }
            else
            {
                toolTip1.Hide(lvDanhSachTrangThaiBan);
            }
        }

        private void lvDanhSachTrangThaiBan_ItemActivate(object sender, EventArgs e)
        {
            
        }
    }
}
