namespace THITHU
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.lbHangXe = new System.Windows.Forms.Label();
            this.txthangXe = new System.Windows.Forms.TextBox();
            this.lbBienSo = new System.Windows.Forms.Label();
            this.txtBienSo = new System.Windows.Forms.TextBox();
            this.lnNamSanXuat = new System.Windows.Forms.Label();
            this.txtNamSanXuat = new System.Windows.Forms.TextBox();
            this.lbGiaBan = new System.Windows.Forms.Label();
            this.txtGiaBan = new System.Windows.Forms.TextBox();
            this.btThem = new System.Windows.Forms.Button();
            this.btXoa = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lbDungLuongPin = new System.Windows.Forms.Label();
            this.txtDLP = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(286, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập Thông Tin ";
            // 
            // lbHangXe
            // 
            this.lbHangXe.AutoSize = true;
            this.lbHangXe.Location = new System.Drawing.Point(85, 80);
            this.lbHangXe.Name = "lbHangXe";
            this.lbHangXe.Size = new System.Drawing.Size(52, 13);
            this.lbHangXe.TabIndex = 1;
            this.lbHangXe.Text = "Hãng Xe ";
            // 
            // txthangXe
            // 
            this.txthangXe.Location = new System.Drawing.Point(226, 77);
            this.txthangXe.Name = "txthangXe";
            this.txthangXe.Size = new System.Drawing.Size(100, 20);
            this.txthangXe.TabIndex = 2;
            // 
            // lbBienSo
            // 
            this.lbBienSo.AutoSize = true;
            this.lbBienSo.Location = new System.Drawing.Point(90, 127);
            this.lbBienSo.Name = "lbBienSo";
            this.lbBienSo.Size = new System.Drawing.Size(44, 13);
            this.lbBienSo.TabIndex = 3;
            this.lbBienSo.Text = "Biển Số";
            // 
            // txtBienSo
            // 
            this.txtBienSo.Location = new System.Drawing.Point(226, 120);
            this.txtBienSo.Name = "txtBienSo";
            this.txtBienSo.Size = new System.Drawing.Size(100, 20);
            this.txtBienSo.TabIndex = 5;
            // 
            // lnNamSanXuat
            // 
            this.lnNamSanXuat.AutoSize = true;
            this.lnNamSanXuat.Location = new System.Drawing.Point(97, 173);
            this.lnNamSanXuat.Name = "lnNamSanXuat";
            this.lnNamSanXuat.Size = new System.Drawing.Size(79, 13);
            this.lnNamSanXuat.TabIndex = 6;
            this.lnNamSanXuat.Text = "Năm Sản Xuất ";
            // 
            // txtNamSanXuat
            // 
            this.txtNamSanXuat.Location = new System.Drawing.Point(226, 166);
            this.txtNamSanXuat.Name = "txtNamSanXuat";
            this.txtNamSanXuat.Size = new System.Drawing.Size(100, 20);
            this.txtNamSanXuat.TabIndex = 7;
            // 
            // lbGiaBan
            // 
            this.lbGiaBan.AutoSize = true;
            this.lbGiaBan.Location = new System.Drawing.Point(97, 211);
            this.lbGiaBan.Name = "lbGiaBan";
            this.lbGiaBan.Size = new System.Drawing.Size(48, 13);
            this.lbGiaBan.TabIndex = 8;
            this.lbGiaBan.Text = "Giá Bán ";
            // 
            // txtGiaBan
            // 
            this.txtGiaBan.Location = new System.Drawing.Point(226, 208);
            this.txtGiaBan.Name = "txtGiaBan";
            this.txtGiaBan.Size = new System.Drawing.Size(100, 20);
            this.txtGiaBan.TabIndex = 9;
            // 
            // btThem
            // 
            this.btThem.Location = new System.Drawing.Point(142, 279);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(75, 23);
            this.btThem.TabIndex = 10;
            this.btThem.Text = "Thêm ";
            this.btThem.UseVisualStyleBackColor = true;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // btXoa
            // 
            this.btXoa.Location = new System.Drawing.Point(291, 280);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(75, 23);
            this.btXoa.TabIndex = 11;
            this.btXoa.Text = "Xóa";
            this.btXoa.UseVisualStyleBackColor = true;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(394, 73);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 12;
            // 
            // lbDungLuongPin
            // 
            this.lbDungLuongPin.AutoSize = true;
            this.lbDungLuongPin.Location = new System.Drawing.Point(103, 240);
            this.lbDungLuongPin.Name = "lbDungLuongPin";
            this.lbDungLuongPin.Size = new System.Drawing.Size(87, 13);
            this.lbDungLuongPin.TabIndex = 13;
            this.lbDungLuongPin.Text = "Dung Lượng PIN";
            // 
            // txtDLP
            // 
            this.txtDLP.Location = new System.Drawing.Point(228, 247);
            this.txtDLP.Name = "txtDLP";
            this.txtDLP.Size = new System.Drawing.Size(100, 20);
            this.txtDLP.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtDLP);
            this.Controls.Add(this.lbDungLuongPin);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btXoa);
            this.Controls.Add(this.btThem);
            this.Controls.Add(this.txtGiaBan);
            this.Controls.Add(this.lbGiaBan);
            this.Controls.Add(this.txtNamSanXuat);
            this.Controls.Add(this.lnNamSanXuat);
            this.Controls.Add(this.txtBienSo);
            this.Controls.Add(this.lbBienSo);
            this.Controls.Add(this.txthangXe);
            this.Controls.Add(this.lbHangXe);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbHangXe;
        private System.Windows.Forms.TextBox txthangXe;
        private System.Windows.Forms.Label lbBienSo;
        private System.Windows.Forms.TextBox txtBienSo;
        private System.Windows.Forms.Label lnNamSanXuat;
        private System.Windows.Forms.TextBox txtNamSanXuat;
        private System.Windows.Forms.Label lbGiaBan;
        private System.Windows.Forms.TextBox txtGiaBan;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lbDungLuongPin;
        private System.Windows.Forms.TextBox txtDLP;
    }
}

