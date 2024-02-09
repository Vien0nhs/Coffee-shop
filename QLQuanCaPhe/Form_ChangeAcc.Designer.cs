namespace QLQuanCaPhe
{
    partial class Form_ChangeAcc
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbMa = new System.Windows.Forms.TextBox();
            this.tbMKcu = new System.Windows.Forms.TextBox();
            this.tbMKmoi = new System.Windows.Forms.TextBox();
            this.tbXacNhan = new System.Windows.Forms.TextBox();
            this.btnChange = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.cbHien = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã nhân viên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 32);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mật khẩu cũ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(183, 32);
            this.label4.TabIndex = 3;
            this.label4.Text = "Mật khẩu mới";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 263);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(310, 32);
            this.label5.TabIndex = 4;
            this.label5.Text = "Xác nhận mật khẩu mới";
            // 
            // tbMa
            // 
            this.tbMa.Location = new System.Drawing.Point(334, 83);
            this.tbMa.Name = "tbMa";
            this.tbMa.Size = new System.Drawing.Size(355, 22);
            this.tbMa.TabIndex = 5;
            // 
            // tbMKcu
            // 
            this.tbMKcu.Location = new System.Drawing.Point(334, 146);
            this.tbMKcu.Name = "tbMKcu";
            this.tbMKcu.Size = new System.Drawing.Size(355, 22);
            this.tbMKcu.TabIndex = 6;
            // 
            // tbMKmoi
            // 
            this.tbMKmoi.Location = new System.Drawing.Point(334, 208);
            this.tbMKmoi.Name = "tbMKmoi";
            this.tbMKmoi.Size = new System.Drawing.Size(355, 22);
            this.tbMKmoi.TabIndex = 7;
            this.tbMKmoi.TextChanged += new System.EventHandler(this.tbMKmoi_TextChanged);
            // 
            // tbXacNhan
            // 
            this.tbXacNhan.Location = new System.Drawing.Point(334, 273);
            this.tbXacNhan.Name = "tbXacNhan";
            this.tbXacNhan.Size = new System.Drawing.Size(355, 22);
            this.tbXacNhan.TabIndex = 8;
            this.tbXacNhan.TextChanged += new System.EventHandler(this.tbXacNhan_TextChanged);
            // 
            // btnChange
            // 
            this.btnChange.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnChange.Location = new System.Drawing.Point(334, 330);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(117, 52);
            this.btnChange.TabIndex = 9;
            this.btnChange.Text = "Thay đổi";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnThoat.Location = new System.Drawing.Point(731, 386);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(117, 52);
            this.btnThoat.TabIndex = 11;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click_1);
            // 
            // cbHien
            // 
            this.cbHien.AutoSize = true;
            this.cbHien.Location = new System.Drawing.Point(709, 244);
            this.cbHien.Name = "cbHien";
            this.cbHien.Size = new System.Drawing.Size(114, 20);
            this.cbHien.TabIndex = 12;
            this.cbHien.Text = "Hiện mật khẩu";
            this.cbHien.UseVisualStyleBackColor = true;
            this.cbHien.CheckedChanged += new System.EventHandler(this.cbHien_CheckedChanged);
            // 
            // Form_ChangeAcc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(860, 450);
            this.Controls.Add(this.cbHien);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.tbXacNhan);
            this.Controls.Add(this.tbMKmoi);
            this.Controls.Add(this.tbMKcu);
            this.Controls.Add(this.tbMa);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "Form_ChangeAcc";
            this.Text = "Thay đổi mật khẩu";
            this.Load += new System.EventHandler(this.Form_ChangeAcc_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbMa;
        private System.Windows.Forms.TextBox tbMKcu;
        private System.Windows.Forms.TextBox tbMKmoi;
        private System.Windows.Forms.TextBox tbXacNhan;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.CheckBox cbHien;
    }
}