namespace THITHU
{
    partial class NhanVien
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
            this.lbText = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.lbID = new System.Windows.Forms.Label();
            this.txtHovaTen = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lbChucVu = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lbluongcoban = new System.Windows.Forms.Label();
            this.txtluongcoban = new System.Windows.Forms.TextBox();
            this.btNhap = new System.Windows.Forms.Button();
            this.btXoa = new System.Windows.Forms.Button();
            this.btSua = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lbTeamSize = new System.Windows.Forms.Label();
            this.txtTeamSize = new System.Windows.Forms.TextBox();
            this.btTim = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbText
            // 
            this.lbText.AutoSize = true;
            this.lbText.Location = new System.Drawing.Point(280, 20);
            this.lbText.Name = "lbText";
            this.lbText.Size = new System.Drawing.Size(88, 13);
            this.lbText.TabIndex = 0;
            this.lbText.Text = "Nhận Thông Tin ";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(23, 65);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(68, 13);
            this.lbName.TabIndex = 1;
            this.lbName.Text = "Họ Và Tên : ";
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Location = new System.Drawing.Point(23, 112);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(84, 13);
            this.lbID.TabIndex = 2;
            this.lbID.Text = "Mã Nhân Viên : ";
            // 
            // txtHovaTen
            // 
            this.txtHovaTen.Location = new System.Drawing.Point(153, 65);
            this.txtHovaTen.Name = "txtHovaTen";
            this.txtHovaTen.Size = new System.Drawing.Size(100, 20);
            this.txtHovaTen.TabIndex = 3;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(155, 110);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 20);
            this.txtID.TabIndex = 4;
            // 
            // lbChucVu
            // 
            this.lbChucVu.AutoSize = true;
            this.lbChucVu.Location = new System.Drawing.Point(38, 158);
            this.lbChucVu.Name = "lbChucVu";
            this.lbChucVu.Size = new System.Drawing.Size(51, 13);
            this.lbChucVu.TabIndex = 5;
            this.lbChucVu.Text = "Chức Vụ ";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(153, 150);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 6;
            // 
            // lbluongcoban
            // 
            this.lbluongcoban.AutoSize = true;
            this.lbluongcoban.Location = new System.Drawing.Point(40, 197);
            this.lbluongcoban.Name = "lbluongcoban";
            this.lbluongcoban.Size = new System.Drawing.Size(78, 13);
            this.lbluongcoban.TabIndex = 7;
            this.lbluongcoban.Text = "Lương Cơ Bản ";
            // 
            // txtluongcoban
            // 
            this.txtluongcoban.Location = new System.Drawing.Point(154, 193);
            this.txtluongcoban.Name = "txtluongcoban";
            this.txtluongcoban.Size = new System.Drawing.Size(100, 20);
            this.txtluongcoban.TabIndex = 8;
            // 
            // btNhap
            // 
            this.btNhap.Location = new System.Drawing.Point(26, 269);
            this.btNhap.Name = "btNhap";
            this.btNhap.Size = new System.Drawing.Size(75, 23);
            this.btNhap.TabIndex = 9;
            this.btNhap.Text = "Nhập ";
            this.btNhap.UseVisualStyleBackColor = true;
            this.btNhap.Click += new System.EventHandler(this.btNhap_Click);
            // 
            // btXoa
            // 
            this.btXoa.Location = new System.Drawing.Point(142, 272);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(75, 23);
            this.btXoa.TabIndex = 10;
            this.btXoa.Text = "Xóa ";
            this.btXoa.UseVisualStyleBackColor = true;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // btSua
            // 
            this.btSua.Location = new System.Drawing.Point(253, 273);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(75, 23);
            this.btSua.TabIndex = 11;
            this.btSua.Text = "Sửa";
            this.btSua.UseVisualStyleBackColor = true;
            this.btSua.Click += new System.EventHandler(this.btSua_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(359, 55);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(441, 294);
            this.dataGridView1.TabIndex = 12;
            // 
            // lbTeamSize
            // 
            this.lbTeamSize.AutoSize = true;
            this.lbTeamSize.Location = new System.Drawing.Point(51, 234);
            this.lbTeamSize.Name = "lbTeamSize";
            this.lbTeamSize.Size = new System.Drawing.Size(54, 13);
            this.lbTeamSize.TabIndex = 13;
            this.lbTeamSize.Text = "TeamSize";
            // 
            // txtTeamSize
            // 
            this.txtTeamSize.Location = new System.Drawing.Point(157, 231);
            this.txtTeamSize.Name = "txtTeamSize";
            this.txtTeamSize.Size = new System.Drawing.Size(100, 20);
            this.txtTeamSize.TabIndex = 14;
            // 
            // btTim
            // 
            this.btTim.Location = new System.Drawing.Point(142, 326);
            this.btTim.Name = "btTim";
            this.btTim.Size = new System.Drawing.Size(75, 23);
            this.btTim.TabIndex = 15;
            this.btTim.Text = "Tìm";
            this.btTim.UseVisualStyleBackColor = true;
            this.btTim.Click += new System.EventHandler(this.btTim_Click);
            // 
            // NhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btTim);
            this.Controls.Add(this.txtTeamSize);
            this.Controls.Add(this.lbTeamSize);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btSua);
            this.Controls.Add(this.btXoa);
            this.Controls.Add(this.btNhap);
            this.Controls.Add(this.txtluongcoban);
            this.Controls.Add(this.lbluongcoban);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lbChucVu);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.txtHovaTen);
            this.Controls.Add(this.lbID);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.lbText);
            this.Name = "NhanVien";
            this.Text = "NhanVien";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbText;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.TextBox txtHovaTen;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lbChucVu;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lbluongcoban;
        private System.Windows.Forms.TextBox txtluongcoban;
        private System.Windows.Forms.Button btNhap;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Button btSua;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lbTeamSize;
        private System.Windows.Forms.TextBox txtTeamSize;
        private System.Windows.Forms.Button btTim;
    }
}