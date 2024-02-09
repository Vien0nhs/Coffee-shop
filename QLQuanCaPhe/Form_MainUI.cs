using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLQuanCaPhe
{
    public partial class Form_MainUI : Form
    {
        public User u { get; set; }

        public ToolStripDropDownButton gettsqlnv()
        {
            return tsqlnv;
        }
        public ToolStripDropDownButton gettsqlsp()
        {
            return toolStripDropDownButton2;
        }
        public Form_MainUI()
        {
            InitializeComponent();
            
        }

        private void Form_MainUI_Load(object sender, EventArgs e)
        {

        }

        private void tsqlnv_Click(object sender, EventArgs e)
        {

        }

        private void tsChange_Click(object sender, EventArgs e)
        {
            this.Close();
            DangNhap dn = new DangNhap();
            dn.ShowDialog();
        }

        private void QLNV_Click(object sender, EventArgs e)
        {
            QLNV qlnv = new QLNV();
            qlnv.ShowDialog();
        }

        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_ChangeAcc fc = new Form_ChangeAcc();
            fc.ShowDialog();
        }

        private void sảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SanPham sp = new SanPham();
            sp.ShowDialog();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bànToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ban ban = new Ban();
            ban.ShowDialog();
        }

        private void toolStripDropDownButton3_Click(object sender, EventArgs e)
        {

        }

        private void Order_Click(object sender, EventArgs e)
        {
            Order od = new Order();
            od.ShowDialog();
        }

        private void xemHoáĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_XemHoaDon form_XemHoaDon = new Form_XemHoaDon();
            form_XemHoaDon.ShowDialog();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Form_ThongKe form_ThongKe = new Form_ThongKe();
            form_ThongKe.ShowDialog();
        }
    }
}
