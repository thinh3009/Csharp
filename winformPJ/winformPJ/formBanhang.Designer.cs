namespace winformPJ
{
    partial class frmBanHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBanHang));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.grbChinhsua = new System.Windows.Forms.GroupBox();
            this.txtthanhtien = new System.Windows.Forms.TextBox();
            this.txtdongia = new System.Windows.Forms.TextBox();
            this.txtsoluong = new System.Windows.Forms.TextBox();
            this.txtTensp = new System.Windows.Forms.TextBox();
            this.txtMasp = new System.Windows.Forms.TextBox();
            this.lblthanhtien = new System.Windows.Forms.Label();
            this.lbldongia = new System.Windows.Forms.Label();
            this.lblsoluong = new System.Windows.Forms.Label();
            this.lbltensp = new System.Windows.Forms.Label();
            this.lblmasp = new System.Windows.Forms.Label();
            this.grbThongtin = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.lblBanHang = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnreset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.grbChinhsua.SuspendLayout();
            this.grbThongtin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(101, 91);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // grbChinhsua
            // 
            this.grbChinhsua.Controls.Add(this.txtthanhtien);
            this.grbChinhsua.Controls.Add(this.txtdongia);
            this.grbChinhsua.Controls.Add(this.txtsoluong);
            this.grbChinhsua.Controls.Add(this.txtTensp);
            this.grbChinhsua.Controls.Add(this.txtMasp);
            this.grbChinhsua.Controls.Add(this.lblthanhtien);
            this.grbChinhsua.Controls.Add(this.lbldongia);
            this.grbChinhsua.Controls.Add(this.lblsoluong);
            this.grbChinhsua.Controls.Add(this.lbltensp);
            this.grbChinhsua.Controls.Add(this.lblmasp);
            this.grbChinhsua.Location = new System.Drawing.Point(769, 121);
            this.grbChinhsua.Name = "grbChinhsua";
            this.grbChinhsua.Size = new System.Drawing.Size(354, 420);
            this.grbChinhsua.TabIndex = 10;
            this.grbChinhsua.TabStop = false;
            this.grbChinhsua.Text = "Chinh sua";
            // 
            // txtthanhtien
            // 
            this.txtthanhtien.Location = new System.Drawing.Point(150, 308);
            this.txtthanhtien.Name = "txtthanhtien";
            this.txtthanhtien.Size = new System.Drawing.Size(198, 22);
            this.txtthanhtien.TabIndex = 9;
            // 
            // txtdongia
            // 
            this.txtdongia.Location = new System.Drawing.Point(150, 253);
            this.txtdongia.Name = "txtdongia";
            this.txtdongia.Size = new System.Drawing.Size(198, 22);
            this.txtdongia.TabIndex = 8;
            // 
            // txtsoluong
            // 
            this.txtsoluong.Location = new System.Drawing.Point(150, 188);
            this.txtsoluong.Name = "txtsoluong";
            this.txtsoluong.Size = new System.Drawing.Size(198, 22);
            this.txtsoluong.TabIndex = 7;
            // 
            // txtTensp
            // 
            this.txtTensp.Location = new System.Drawing.Point(150, 131);
            this.txtTensp.Name = "txtTensp";
            this.txtTensp.Size = new System.Drawing.Size(198, 22);
            this.txtTensp.TabIndex = 6;
            // 
            // txtMasp
            // 
            this.txtMasp.Location = new System.Drawing.Point(150, 67);
            this.txtMasp.Name = "txtMasp";
            this.txtMasp.Size = new System.Drawing.Size(198, 22);
            this.txtMasp.TabIndex = 5;
            // 
            // lblthanhtien
            // 
            this.lblthanhtien.AutoSize = true;
            this.lblthanhtien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblthanhtien.Location = new System.Drawing.Point(34, 304);
            this.lblthanhtien.Name = "lblthanhtien";
            this.lblthanhtien.Size = new System.Drawing.Size(107, 25);
            this.lblthanhtien.TabIndex = 4;
            this.lblthanhtien.Text = "thanh tien";
            // 
            // lbldongia
            // 
            this.lbldongia.AutoSize = true;
            this.lbldongia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldongia.Location = new System.Drawing.Point(34, 249);
            this.lbldongia.Name = "lbldongia";
            this.lbldongia.Size = new System.Drawing.Size(83, 25);
            this.lbldongia.TabIndex = 3;
            this.lbldongia.Text = "don gia";
            // 
            // lblsoluong
            // 
            this.lblsoluong.AutoSize = true;
            this.lblsoluong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsoluong.Location = new System.Drawing.Point(34, 184);
            this.lblsoluong.Name = "lblsoluong";
            this.lblsoluong.Size = new System.Drawing.Size(94, 25);
            this.lblsoluong.TabIndex = 2;
            this.lblsoluong.Text = "so luong";
            // 
            // lbltensp
            // 
            this.lbltensp.AutoSize = true;
            this.lbltensp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltensp.Location = new System.Drawing.Point(34, 127);
            this.lbltensp.Name = "lbltensp";
            this.lbltensp.Size = new System.Drawing.Size(71, 25);
            this.lbltensp.TabIndex = 1;
            this.lbltensp.Text = "ten sp";
            // 
            // lblmasp
            // 
            this.lblmasp.AutoSize = true;
            this.lblmasp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmasp.Location = new System.Drawing.Point(34, 67);
            this.lblmasp.Name = "lblmasp";
            this.lblmasp.Size = new System.Drawing.Size(71, 25);
            this.lblmasp.TabIndex = 0;
            this.lblmasp.Text = "Ma sp";
            // 
            // grbThongtin
            // 
            this.grbThongtin.Controls.Add(this.btnreset);
            this.grbThongtin.Controls.Add(this.btnThoat);
            this.grbThongtin.Controls.Add(this.dataGridView1);
            this.grbThongtin.Controls.Add(this.btnSua);
            this.grbThongtin.Controls.Add(this.btnXoa);
            this.grbThongtin.Controls.Add(this.btnThem);
            this.grbThongtin.Location = new System.Drawing.Point(45, 121);
            this.grbThongtin.Name = "grbThongtin";
            this.grbThongtin.Size = new System.Drawing.Size(675, 420);
            this.grbThongtin.TabIndex = 9;
            this.grbThongtin.TabStop = false;
            this.grbThongtin.Text = "Thong tin";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(19, 53);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(496, 337);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(553, 202);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(109, 48);
            this.btnSua.TabIndex = 5;
            this.btnSua.Text = "Sua";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(553, 62);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(109, 48);
            this.btnXoa.TabIndex = 4;
            this.btnXoa.Text = "Xoa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(553, 138);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(109, 48);
            this.btnThem.TabIndex = 3;
            this.btnThem.Text = "Them data";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // lblBanHang
            // 
            this.lblBanHang.AutoSize = true;
            this.lblBanHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBanHang.Location = new System.Drawing.Point(389, 24);
            this.lblBanHang.Name = "lblBanHang";
            this.lblBanHang.Size = new System.Drawing.Size(405, 46);
            this.lblBanHang.TabIndex = 8;
            this.lblBanHang.Text = "Phan mem ban hang";
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(553, 342);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(109, 48);
            this.btnThoat.TabIndex = 6;
            this.btnThoat.Text = "Thoat";
            this.btnThoat.UseVisualStyleBackColor = true;
            // 
            // btnreset
            // 
            this.btnreset.Location = new System.Drawing.Point(553, 268);
            this.btnreset.Name = "btnreset";
            this.btnreset.Size = new System.Drawing.Size(109, 48);
            this.btnreset.TabIndex = 7;
            this.btnreset.Text = "reset";
            this.btnreset.UseVisualStyleBackColor = true;
            this.btnreset.Click += new System.EventHandler(this.btnreset_Click);
            // 
            // frmBanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1171, 574);
            this.Controls.Add(this.grbChinhsua);
            this.Controls.Add(this.grbThongtin);
            this.Controls.Add(this.lblBanHang);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmBanHang";
            this.Text = "formBanhang";
            this.Load += new System.EventHandler(this.frmBanHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.grbChinhsua.ResumeLayout(false);
            this.grbChinhsua.PerformLayout();
            this.grbThongtin.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox grbChinhsua;
        private System.Windows.Forms.TextBox txtthanhtien;
        private System.Windows.Forms.TextBox txtdongia;
        private System.Windows.Forms.TextBox txtsoluong;
        private System.Windows.Forms.TextBox txtTensp;
        private System.Windows.Forms.TextBox txtMasp;
        private System.Windows.Forms.Label lblthanhtien;
        private System.Windows.Forms.Label lbldongia;
        private System.Windows.Forms.Label lblsoluong;
        private System.Windows.Forms.Label lbltensp;
        private System.Windows.Forms.Label lblmasp;
        private System.Windows.Forms.GroupBox grbThongtin;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label lblBanHang;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnreset;
    }
}