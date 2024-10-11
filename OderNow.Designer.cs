namespace THITHU
{
    partial class OderNow
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
            this.lbMaDonHang = new System.Windows.Forms.Label();
            this.txtMaDonHang = new System.Windows.Forms.TextBox();
            this.lbTenKhachHang = new System.Windows.Forms.Label();
            this.txtTenKhachHang = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lbDate = new System.Windows.Forms.Label();
            this.lbSoLuongSanPham = new System.Windows.Forms.Label();
            this.txtSoLuongSanpham = new System.Windows.Forms.TextBox();
            this.lbDongia = new System.Windows.Forms.Label();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.btNhap = new System.Windows.Forms.Button();
            this.btSum = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lbSanPham = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lbDiscount = new System.Windows.Forms.Label();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbMaDonHang
            // 
            this.lbMaDonHang.AutoSize = true;
            this.lbMaDonHang.Location = new System.Drawing.Point(36, 26);
            this.lbMaDonHang.Name = "lbMaDonHang";
            this.lbMaDonHang.Size = new System.Drawing.Size(71, 13);
            this.lbMaDonHang.TabIndex = 0;
            this.lbMaDonHang.Text = "Mã đơn hàng";
            // 
            // txtMaDonHang
            // 
            this.txtMaDonHang.Location = new System.Drawing.Point(144, 25);
            this.txtMaDonHang.Name = "txtMaDonHang";
            this.txtMaDonHang.Size = new System.Drawing.Size(100, 20);
            this.txtMaDonHang.TabIndex = 1;
            // 
            // lbTenKhachHang
            // 
            this.lbTenKhachHang.AutoSize = true;
            this.lbTenKhachHang.Location = new System.Drawing.Point(41, 63);
            this.lbTenKhachHang.Name = "lbTenKhachHang";
            this.lbTenKhachHang.Size = new System.Drawing.Size(86, 13);
            this.lbTenKhachHang.TabIndex = 2;
            this.lbTenKhachHang.Text = "Tên khách hàng";
            // 
            // txtTenKhachHang
            // 
            this.txtTenKhachHang.Location = new System.Drawing.Point(144, 63);
            this.txtTenKhachHang.Name = "txtTenKhachHang";
            this.txtTenKhachHang.Size = new System.Drawing.Size(100, 20);
            this.txtTenKhachHang.TabIndex = 3;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(149, 118);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // lbDate
            // 
            this.lbDate.AutoSize = true;
            this.lbDate.Location = new System.Drawing.Point(44, 114);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(78, 13);
            this.lbDate.TabIndex = 5;
            this.lbDate.Text = "Ngày đặt hàng";
            // 
            // lbSoLuongSanPham
            // 
            this.lbSoLuongSanPham.AutoSize = true;
            this.lbSoLuongSanPham.Location = new System.Drawing.Point(51, 175);
            this.lbSoLuongSanPham.Name = "lbSoLuongSanPham";
            this.lbSoLuongSanPham.Size = new System.Drawing.Size(98, 13);
            this.lbSoLuongSanPham.TabIndex = 6;
            this.lbSoLuongSanPham.Text = "Số lượng sản phẩm";
            // 
            // txtSoLuongSanpham
            // 
            this.txtSoLuongSanpham.Location = new System.Drawing.Point(176, 177);
            this.txtSoLuongSanpham.Name = "txtSoLuongSanpham";
            this.txtSoLuongSanpham.Size = new System.Drawing.Size(100, 20);
            this.txtSoLuongSanpham.TabIndex = 7;
            // 
            // lbDongia
            // 
            this.lbDongia.AutoSize = true;
            this.lbDongia.Location = new System.Drawing.Point(56, 223);
            this.lbDongia.Name = "lbDongia";
            this.lbDongia.Size = new System.Drawing.Size(44, 13);
            this.lbDongia.TabIndex = 8;
            this.lbDongia.Text = "Đơn giá";
            // 
            // txtDonGia
            // 
            this.txtDonGia.Location = new System.Drawing.Point(149, 223);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(127, 20);
            this.txtDonGia.TabIndex = 9;
            // 
            // btNhap
            // 
            this.btNhap.Location = new System.Drawing.Point(88, 300);
            this.btNhap.Name = "btNhap";
            this.btNhap.Size = new System.Drawing.Size(75, 23);
            this.btNhap.TabIndex = 10;
            this.btNhap.Text = "Save";
            this.btNhap.UseVisualStyleBackColor = true;
            this.btNhap.Click += new System.EventHandler(this.btNhap_Click);
            // 
            // btSum
            // 
            this.btSum.Location = new System.Drawing.Point(233, 301);
            this.btSum.Name = "btSum";
            this.btSum.Size = new System.Drawing.Size(75, 23);
            this.btSum.TabIndex = 11;
            this.btSum.Text = "Sum";
            this.btSum.UseVisualStyleBackColor = true;
            this.btSum.Click += new System.EventHandler(this.btSum_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(411, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(377, 410);
            this.dataGridView1.TabIndex = 12;
            // 
            // lbSanPham
            // 
            this.lbSanPham.AutoSize = true;
            this.lbSanPham.Location = new System.Drawing.Point(66, 145);
            this.lbSanPham.Name = "lbSanPham";
            this.lbSanPham.Size = new System.Drawing.Size(59, 13);
            this.lbSanPham.TabIndex = 13;
            this.lbSanPham.Text = "Sản Phẩm ";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(164, 150);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 14;
            // 
            // lbDiscount
            // 
            this.lbDiscount.AutoSize = true;
            this.lbDiscount.Location = new System.Drawing.Point(59, 267);
            this.lbDiscount.Name = "lbDiscount";
            this.lbDiscount.Size = new System.Drawing.Size(63, 13);
            this.lbDiscount.TabIndex = 15;
            this.lbDiscount.Text = "Khuyến Mãi";
            // 
            // txtDiscount
            // 
            this.txtDiscount.Location = new System.Drawing.Point(158, 269);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(100, 20);
            this.txtDiscount.TabIndex = 16;
            // 
            // OderNow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtDiscount);
            this.Controls.Add(this.lbDiscount);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lbSanPham);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btSum);
            this.Controls.Add(this.btNhap);
            this.Controls.Add(this.txtDonGia);
            this.Controls.Add(this.lbDongia);
            this.Controls.Add(this.txtSoLuongSanpham);
            this.Controls.Add(this.lbSoLuongSanPham);
            this.Controls.Add(this.lbDate);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.txtTenKhachHang);
            this.Controls.Add(this.lbTenKhachHang);
            this.Controls.Add(this.txtMaDonHang);
            this.Controls.Add(this.lbMaDonHang);
            this.Name = "OderNow";
            this.Text = "OderNow";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbMaDonHang;
        private System.Windows.Forms.TextBox txtMaDonHang;
        private System.Windows.Forms.Label lbTenKhachHang;
        private System.Windows.Forms.TextBox txtTenKhachHang;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lbDate;
        private System.Windows.Forms.Label lbSoLuongSanPham;
        private System.Windows.Forms.TextBox txtSoLuongSanpham;
        private System.Windows.Forms.Label lbDongia;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.Button btNhap;
        private System.Windows.Forms.Button btSum;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lbSanPham;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lbDiscount;
        private System.Windows.Forms.TextBox txtDiscount;
    }
}