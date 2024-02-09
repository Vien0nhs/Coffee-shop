namespace QLQuanCaPhe
{
    partial class Order
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lvDanhSachTrangThaiBan = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.groupBox1.Controls.Add(this.lvDanhSachTrangThaiBan);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1062, 668);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách trạng thái bàn";
            // 
            // lvDanhSachTrangThaiBan
            // 
            this.lvDanhSachTrangThaiBan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lvDanhSachTrangThaiBan.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lvDanhSachTrangThaiBan.ForeColor = System.Drawing.Color.White;
            this.lvDanhSachTrangThaiBan.FullRowSelect = true;
            this.lvDanhSachTrangThaiBan.HideSelection = false;
            this.lvDanhSachTrangThaiBan.Location = new System.Drawing.Point(6, 72);
            this.lvDanhSachTrangThaiBan.Name = "lvDanhSachTrangThaiBan";
            this.lvDanhSachTrangThaiBan.Size = new System.Drawing.Size(1050, 590);
            this.lvDanhSachTrangThaiBan.TabIndex = 0;
            this.lvDanhSachTrangThaiBan.UseCompatibleStateImageBehavior = false;
            this.lvDanhSachTrangThaiBan.View = System.Windows.Forms.View.Details;
            this.lvDanhSachTrangThaiBan.ItemActivate += new System.EventHandler(this.lvDanhSachTrangThaiBan_ItemActivate);
            this.lvDanhSachTrangThaiBan.SelectedIndexChanged += new System.EventHandler(this.lvDanhSachTrangThaiBan_SelectedIndexChanged);
            this.lvDanhSachTrangThaiBan.MouseHover += new System.EventHandler(this.lvDanhSachTrangThaiBan_MouseHover);
            this.lvDanhSachTrangThaiBan.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lvDanhSachTrangThaiBan_MouseMove);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã";
            this.columnHeader1.Width = 200;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tên";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 200;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Khu vực";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 200;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Trạng thái";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 200;
            // 
            // toolTip1
            // 
            this.toolTip1.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTip1_Popup);
            // 
            // Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1086, 767);
            this.Controls.Add(this.groupBox1);
            this.Name = "Order";
            this.Text = "Xem bàn";
            this.Load += new System.EventHandler(this.Order_Load);
            this.MouseHover += new System.EventHandler(this.Order_MouseHover);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView lvDanhSachTrangThaiBan;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}