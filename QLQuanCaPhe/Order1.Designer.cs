namespace QLQuanCaPhe
{
    partial class Order1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Order1));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbTenSanPham = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.cbbGiaNhap = new System.Windows.Forms.ComboBox();
            this.cbbMaSanPham = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbSoluong = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbGhiChu = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpNgayNhap = new System.Windows.Forms.DateTimePicker();
            this.tbPhieuNhapMaNhanVien = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbMaPhieuNhap = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.gbHoaDon = new System.Windows.Forms.GroupBox();
            this.tbPhieuXuatGhiChu = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.tbTienDu = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.tbTienKhachTra = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.tbThanhToan = new System.Windows.Forms.TextBox();
            this.tbMaBan = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.tbMaKhachHang = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.dtpNgayXuat = new System.Windows.Forms.DateTimePicker();
            this.tbPhieuXuatMaNhanVien = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tbMaPhieuXuat = new System.Windows.Forms.TextBox();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnXoaBan = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lvDanhSachMon = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnThemMon = new System.Windows.Forms.Button();
            this.btnXoaMon = new System.Windows.Forms.Button();
            this.btnXuatHoaDon = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.gbHoaDon.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(489, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Order";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.groupBox1.Controls.Add(this.tbTenSanPham);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.cbbGiaNhap);
            this.groupBox1.Controls.Add(this.cbbMaSanPham);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.tbSoluong);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(916, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(996, 163);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Đặt món";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // tbTenSanPham
            // 
            this.tbTenSanPham.Enabled = false;
            this.tbTenSanPham.Location = new System.Drawing.Point(602, 65);
            this.tbTenSanPham.Name = "tbTenSanPham";
            this.tbTenSanPham.Size = new System.Drawing.Size(388, 38);
            this.tbTenSanPham.TabIndex = 9;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(408, 65);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(194, 32);
            this.label18.TabIndex = 8;
            this.label18.Text = "Tên sản phẩm";
            // 
            // cbbGiaNhap
            // 
            this.cbbGiaNhap.Enabled = false;
            this.cbbGiaNhap.FormattingEnabled = true;
            this.cbbGiaNhap.Items.AddRange(new object[] {
            "12,500",
            "15,500",
            "20,500",
            "25,500",
            "30,500"});
            this.cbbGiaNhap.Location = new System.Drawing.Point(196, 110);
            this.cbbGiaNhap.Name = "cbbGiaNhap";
            this.cbbGiaNhap.Size = new System.Drawing.Size(187, 39);
            this.cbbGiaNhap.TabIndex = 7;
            // 
            // cbbMaSanPham
            // 
            this.cbbMaSanPham.FormattingEnabled = true;
            this.cbbMaSanPham.Items.AddRange(new object[] {
            "B1",
            "BHuc1",
            "CP1",
            "CP2",
            "ST1",
            "T1",
            "TS1",
            "TS2"});
            this.cbbMaSanPham.Location = new System.Drawing.Point(196, 58);
            this.cbbMaSanPham.Name = "cbbMaSanPham";
            this.cbbMaSanPham.Size = new System.Drawing.Size(187, 39);
            this.cbbMaSanPham.TabIndex = 1;
            this.cbbMaSanPham.SelectedIndexChanged += new System.EventHandler(this.cbbMaSanPham_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 117);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(130, 32);
            this.label9.TabIndex = 6;
            this.label9.Text = "Giá nhập";
            // 
            // tbSoluong
            // 
            this.tbSoluong.Location = new System.Drawing.Point(602, 114);
            this.tbSoluong.Name = "tbSoluong";
            this.tbSoluong.Size = new System.Drawing.Size(187, 38);
            this.tbSoluong.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(408, 117);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(127, 32);
            this.label8.TabIndex = 4;
            this.label8.Text = "Số lượng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(184, 32);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mã sản phẩm";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.groupBox2.Controls.Add(this.tbGhiChu);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.dtpNgayNhap);
            this.groupBox2.Controls.Add(this.tbPhieuNhapMaNhanVien);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.tbMaPhieuNhap);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(12, 54);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(898, 163);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Nhân viên order";
            // 
            // tbGhiChu
            // 
            this.tbGhiChu.Location = new System.Drawing.Point(564, 104);
            this.tbGhiChu.Name = "tbGhiChu";
            this.tbGhiChu.Size = new System.Drawing.Size(322, 38);
            this.tbGhiChu.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(407, 107);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 32);
            this.label7.TabIndex = 7;
            this.label7.Text = "Ghi chú";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 107);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(184, 32);
            this.label6.TabIndex = 3;
            this.label6.Text = "Mã nhân viên";
            // 
            // dtpNgayNhap
            // 
            this.dtpNgayNhap.Enabled = false;
            this.dtpNgayNhap.Location = new System.Drawing.Point(564, 55);
            this.dtpNgayNhap.Name = "dtpNgayNhap";
            this.dtpNgayNhap.Size = new System.Drawing.Size(322, 38);
            this.dtpNgayNhap.TabIndex = 6;
            // 
            // tbPhieuNhapMaNhanVien
            // 
            this.tbPhieuNhapMaNhanVien.Enabled = false;
            this.tbPhieuNhapMaNhanVien.Location = new System.Drawing.Point(214, 101);
            this.tbPhieuNhapMaNhanVien.Name = "tbPhieuNhapMaNhanVien";
            this.tbPhieuNhapMaNhanVien.ReadOnly = true;
            this.tbPhieuNhapMaNhanVien.Size = new System.Drawing.Size(187, 38);
            this.tbPhieuNhapMaNhanVien.TabIndex = 5;
            this.tbPhieuNhapMaNhanVien.TextChanged += new System.EventHandler(this.tbMaNhanVien_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(407, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(151, 32);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ngày nhập";
            // 
            // tbMaPhieuNhap
            // 
            this.tbMaPhieuNhap.Enabled = false;
            this.tbMaPhieuNhap.Location = new System.Drawing.Point(214, 49);
            this.tbMaPhieuNhap.Name = "tbMaPhieuNhap";
            this.tbMaPhieuNhap.ReadOnly = true;
            this.tbMaPhieuNhap.Size = new System.Drawing.Size(187, 38);
            this.tbMaPhieuNhap.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(202, 32);
            this.label4.TabIndex = 3;
            this.label4.Text = "Mã phiếu nhập";
            // 
            // gbHoaDon
            // 
            this.gbHoaDon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.gbHoaDon.Controls.Add(this.tbPhieuXuatGhiChu);
            this.gbHoaDon.Controls.Add(this.label17);
            this.gbHoaDon.Controls.Add(this.tbTienDu);
            this.gbHoaDon.Controls.Add(this.label16);
            this.gbHoaDon.Controls.Add(this.tbTienKhachTra);
            this.gbHoaDon.Controls.Add(this.label15);
            this.gbHoaDon.Controls.Add(this.tbThanhToan);
            this.gbHoaDon.Controls.Add(this.tbMaBan);
            this.gbHoaDon.Controls.Add(this.label14);
            this.gbHoaDon.Controls.Add(this.label13);
            this.gbHoaDon.Controls.Add(this.tbMaKhachHang);
            this.gbHoaDon.Controls.Add(this.label12);
            this.gbHoaDon.Controls.Add(this.label11);
            this.gbHoaDon.Controls.Add(this.dtpNgayXuat);
            this.gbHoaDon.Controls.Add(this.tbPhieuXuatMaNhanVien);
            this.gbHoaDon.Controls.Add(this.label2);
            this.gbHoaDon.Controls.Add(this.label10);
            this.gbHoaDon.Controls.Add(this.tbMaPhieuXuat);
            this.gbHoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbHoaDon.ForeColor = System.Drawing.Color.White;
            this.gbHoaDon.Location = new System.Drawing.Point(12, 357);
            this.gbHoaDon.Name = "gbHoaDon";
            this.gbHoaDon.Size = new System.Drawing.Size(928, 629);
            this.gbHoaDon.TabIndex = 10;
            this.gbHoaDon.TabStop = false;
            this.gbHoaDon.Text = "Hoá đơn";
            // 
            // tbPhieuXuatGhiChu
            // 
            this.tbPhieuXuatGhiChu.Location = new System.Drawing.Point(333, 578);
            this.tbPhieuXuatGhiChu.Name = "tbPhieuXuatGhiChu";
            this.tbPhieuXuatGhiChu.Size = new System.Drawing.Size(581, 38);
            this.tbPhieuXuatGhiChu.TabIndex = 27;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(8, 578);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(112, 32);
            this.label17.TabIndex = 26;
            this.label17.Text = "Ghi chú";
            // 
            // tbTienDu
            // 
            this.tbTienDu.Location = new System.Drawing.Point(333, 520);
            this.tbTienDu.Name = "tbTienDu";
            this.tbTienDu.Size = new System.Drawing.Size(581, 38);
            this.tbTienDu.TabIndex = 25;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(6, 398);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(158, 32);
            this.label16.TabIndex = 24;
            this.label16.Text = "Thanh toán";
            // 
            // tbTienKhachTra
            // 
            this.tbTienKhachTra.Location = new System.Drawing.Point(333, 462);
            this.tbTienKhachTra.Name = "tbTienKhachTra";
            this.tbTienKhachTra.Size = new System.Drawing.Size(581, 38);
            this.tbTienKhachTra.TabIndex = 23;
            this.tbTienKhachTra.TextChanged += new System.EventHandler(this.tbTienKhachTra_TextChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(8, 523);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(109, 32);
            this.label15.TabIndex = 22;
            this.label15.Text = "Tiền dư";
            // 
            // tbThanhToan
            // 
            this.tbThanhToan.Location = new System.Drawing.Point(333, 392);
            this.tbThanhToan.Name = "tbThanhToan";
            this.tbThanhToan.Size = new System.Drawing.Size(581, 38);
            this.tbThanhToan.TabIndex = 21;
            this.tbThanhToan.TextChanged += new System.EventHandler(this.tbThanhToan_TextChanged);
            // 
            // tbMaBan
            // 
            this.tbMaBan.Enabled = false;
            this.tbMaBan.Location = new System.Drawing.Point(333, 326);
            this.tbMaBan.Name = "tbMaBan";
            this.tbMaBan.Size = new System.Drawing.Size(581, 38);
            this.tbMaBan.TabIndex = 20;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 468);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(193, 32);
            this.label14.TabIndex = 19;
            this.label14.Text = "Tiền khách trả";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 332);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(111, 32);
            this.label13.TabIndex = 18;
            this.label13.Text = "Mã Bàn";
            // 
            // tbMaKhachHang
            // 
            this.tbMaKhachHang.Location = new System.Drawing.Point(333, 260);
            this.tbMaKhachHang.Name = "tbMaKhachHang";
            this.tbMaKhachHang.Size = new System.Drawing.Size(581, 38);
            this.tbMaKhachHang.TabIndex = 17;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 266);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(207, 32);
            this.label12.TabIndex = 16;
            this.label12.Text = "Mã khách hàng";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 200);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(193, 32);
            this.label11.TabIndex = 15;
            this.label11.Text = "Mã Nhân Viên";
            // 
            // dtpNgayXuat
            // 
            this.dtpNgayXuat.Enabled = false;
            this.dtpNgayXuat.Location = new System.Drawing.Point(333, 126);
            this.dtpNgayXuat.Name = "dtpNgayXuat";
            this.dtpNgayXuat.Size = new System.Drawing.Size(581, 38);
            this.dtpNgayXuat.TabIndex = 14;
            // 
            // tbPhieuXuatMaNhanVien
            // 
            this.tbPhieuXuatMaNhanVien.Enabled = false;
            this.tbPhieuXuatMaNhanVien.Location = new System.Drawing.Point(333, 197);
            this.tbPhieuXuatMaNhanVien.Name = "tbPhieuXuatMaNhanVien";
            this.tbPhieuXuatMaNhanVien.ReadOnly = true;
            this.tbPhieuXuatMaNhanVien.Size = new System.Drawing.Size(581, 38);
            this.tbPhieuXuatMaNhanVien.TabIndex = 13;
            this.tbPhieuXuatMaNhanVien.TextChanged += new System.EventHandler(this.tbPhieuXuatMaNhanVien_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 32);
            this.label2.TabIndex = 12;
            this.label2.Text = "Ngày xuất";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 66);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(192, 32);
            this.label10.TabIndex = 11;
            this.label10.Text = "Mã phiếu xuất";
            // 
            // tbMaPhieuXuat
            // 
            this.tbMaPhieuXuat.Enabled = false;
            this.tbMaPhieuXuat.Location = new System.Drawing.Point(333, 60);
            this.tbMaPhieuXuat.Name = "tbMaPhieuXuat";
            this.tbMaPhieuXuat.ReadOnly = true;
            this.tbMaPhieuXuat.Size = new System.Drawing.Size(581, 38);
            this.tbMaPhieuXuat.TabIndex = 10;
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnLuu.ForeColor = System.Drawing.Color.White;
            this.btnLuu.Location = new System.Drawing.Point(12, 223);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(111, 61);
            this.btnLuu.TabIndex = 11;
            this.btnLuu.Text = "Lưu phiếu nhập";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnXoaBan
            // 
            this.btnXoaBan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnXoaBan.ForeColor = System.Drawing.Color.White;
            this.btnXoaBan.Location = new System.Drawing.Point(576, 290);
            this.btnXoaBan.Name = "btnXoaBan";
            this.btnXoaBan.Size = new System.Drawing.Size(111, 61);
            this.btnXoaBan.TabIndex = 12;
            this.btnXoaBan.Text = "Xoá bàn";
            this.btnXoaBan.UseVisualStyleBackColor = false;
            this.btnXoaBan.Click += new System.EventHandler(this.btnXoaBan_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.groupBox3.Controls.Add(this.lvDanhSachMon);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(946, 357);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(966, 629);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Danh sách món";
            // 
            // lvDanhSachMon
            // 
            this.lvDanhSachMon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lvDanhSachMon.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.lvDanhSachMon.ForeColor = System.Drawing.Color.White;
            this.lvDanhSachMon.FullRowSelect = true;
            this.lvDanhSachMon.HideSelection = false;
            this.lvDanhSachMon.Location = new System.Drawing.Point(6, 42);
            this.lvDanhSachMon.Name = "lvDanhSachMon";
            this.lvDanhSachMon.Size = new System.Drawing.Size(954, 581);
            this.lvDanhSachMon.TabIndex = 0;
            this.lvDanhSachMon.UseCompatibleStateImageBehavior = false;
            this.lvDanhSachMon.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tên";
            this.columnHeader2.Width = 200;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Loại";
            this.columnHeader3.Width = 150;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Đơn giá";
            this.columnHeader4.Width = 150;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "DVT";
            this.columnHeader5.Width = 100;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Số lượng";
            this.columnHeader6.Width = 150;
            // 
            // btnThemMon
            // 
            this.btnThemMon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnThemMon.ForeColor = System.Drawing.Color.White;
            this.btnThemMon.Location = new System.Drawing.Point(1562, 223);
            this.btnThemMon.Name = "btnThemMon";
            this.btnThemMon.Size = new System.Drawing.Size(111, 61);
            this.btnThemMon.TabIndex = 14;
            this.btnThemMon.Text = "Thêm món";
            this.btnThemMon.UseVisualStyleBackColor = false;
            this.btnThemMon.Click += new System.EventHandler(this.btnThemMon_Click);
            // 
            // btnXoaMon
            // 
            this.btnXoaMon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnXoaMon.ForeColor = System.Drawing.Color.White;
            this.btnXoaMon.Location = new System.Drawing.Point(946, 223);
            this.btnXoaMon.Name = "btnXoaMon";
            this.btnXoaMon.Size = new System.Drawing.Size(111, 61);
            this.btnXoaMon.TabIndex = 15;
            this.btnXoaMon.Text = "Xoá món";
            this.btnXoaMon.UseVisualStyleBackColor = false;
            this.btnXoaMon.Click += new System.EventHandler(this.btnXoaMon_Click);
            // 
            // btnXuatHoaDon
            // 
            this.btnXuatHoaDon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnXuatHoaDon.ForeColor = System.Drawing.Color.White;
            this.btnXuatHoaDon.Location = new System.Drawing.Point(12, 290);
            this.btnXuatHoaDon.Name = "btnXuatHoaDon";
            this.btnXuatHoaDon.Size = new System.Drawing.Size(111, 61);
            this.btnXuatHoaDon.TabIndex = 17;
            this.btnXuatHoaDon.Text = "Xuất hoá đơn";
            this.btnXuatHoaDon.UseVisualStyleBackColor = false;
            this.btnXuatHoaDon.Click += new System.EventHandler(this.btnXuatHoaDon_Click);
            // 
            // Order1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.btnXuatHoaDon);
            this.Controls.Add(this.btnXoaMon);
            this.Controls.Add(this.btnThemMon);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnXoaBan);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.gbHoaDon);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Order1";
            this.Text = "Đặt món";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Order1_FormClosing);
            this.Load += new System.EventHandler(this.Order1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.gbHoaDon.ResumeLayout(false);
            this.gbHoaDon.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbMaPhieuNhap;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbSoluong;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbGhiChu;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpNgayNhap;
        private System.Windows.Forms.TextBox tbPhieuNhapMaNhanVien;
        private System.Windows.Forms.GroupBox gbHoaDon;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbMaPhieuXuat;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tbMaKhachHang;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dtpNgayXuat;
        private System.Windows.Forms.TextBox tbPhieuXuatMaNhanVien;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbThanhToan;
        private System.Windows.Forms.TextBox tbMaBan;
        private System.Windows.Forms.TextBox tbPhieuXuatGhiChu;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox tbTienDu;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox tbTienKhachTra;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnXoaBan;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListView lvDanhSachMon;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Button btnThemMon;
        private System.Windows.Forms.Button btnXoaMon;
        private System.Windows.Forms.ComboBox cbbGiaNhap;
        private System.Windows.Forms.ComboBox cbbMaSanPham;
        private System.Windows.Forms.Button btnXuatHoaDon;
        private System.Windows.Forms.TextBox tbTenSanPham;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ColumnHeader columnHeader6;
    }
}