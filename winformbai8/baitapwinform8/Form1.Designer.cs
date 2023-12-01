namespace baitapwinform8
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
            this.lblSo = new System.Windows.Forms.Label();
            this.txtSo = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.grbDS = new System.Windows.Forms.GroupBox();
            this.grbChucNang = new System.Windows.Forms.GroupBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.lstSo = new System.Windows.Forms.ListBox();
            this.btnTong = new System.Windows.Forms.Button();
            this.btnXoapt = new System.Windows.Forms.Button();
            this.btnSoLe = new System.Windows.Forms.Button();
            this.btnTanglen2 = new System.Windows.Forms.Button();
            this.btnBinhPhuong = new System.Windows.Forms.Button();
            this.btnSoChan = new System.Windows.Forms.Button();
            this.btnxoaDaucuoi = new System.Windows.Forms.Button();
            this.grbDS.SuspendLayout();
            this.grbChucNang.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSo
            // 
            this.lblSo.AutoSize = true;
            this.lblSo.Location = new System.Drawing.Point(42, 48);
            this.lblSo.Name = "lblSo";
            this.lblSo.Size = new System.Drawing.Size(58, 16);
            this.lblSo.TabIndex = 0;
            this.lblSo.Text = "nhap so ";
            // 
            // txtSo
            // 
            this.txtSo.Location = new System.Drawing.Point(123, 45);
            this.txtSo.Name = "txtSo";
            this.txtSo.Size = new System.Drawing.Size(423, 22);
            this.txtSo.TabIndex = 1;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(612, 48);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // grbDS
            // 
            this.grbDS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.grbDS.Controls.Add(this.lstSo);
            this.grbDS.Location = new System.Drawing.Point(75, 126);
            this.grbDS.Name = "grbDS";
            this.grbDS.Size = new System.Drawing.Size(200, 235);
            this.grbDS.TabIndex = 3;
            this.grbDS.TabStop = false;
            this.grbDS.Text = "danh sach so";
            // 
            // grbChucNang
            // 
            this.grbChucNang.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.grbChucNang.Controls.Add(this.btnxoaDaucuoi);
            this.grbChucNang.Controls.Add(this.btnSoChan);
            this.grbChucNang.Controls.Add(this.btnBinhPhuong);
            this.grbChucNang.Controls.Add(this.btnTanglen2);
            this.grbChucNang.Controls.Add(this.btnSoLe);
            this.grbChucNang.Controls.Add(this.btnXoapt);
            this.grbChucNang.Controls.Add(this.btnTong);
            this.grbChucNang.Location = new System.Drawing.Point(351, 126);
            this.grbChucNang.Name = "grbChucNang";
            this.grbChucNang.Size = new System.Drawing.Size(393, 235);
            this.grbChucNang.TabIndex = 4;
            this.grbChucNang.TabStop = false;
            this.grbChucNang.Text = "chuc nang";
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(75, 384);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(103, 39);
            this.btnThoat.TabIndex = 5;
            this.btnThoat.Text = "thoat";
            this.btnThoat.UseVisualStyleBackColor = true;
            // 
            // lstSo
            // 
            this.lstSo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstSo.FormattingEnabled = true;
            this.lstSo.ItemHeight = 16;
            this.lstSo.Location = new System.Drawing.Point(3, 18);
            this.lstSo.Name = "lstSo";
            this.lstSo.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstSo.Size = new System.Drawing.Size(194, 214);
            this.lstSo.TabIndex = 0;
            // 
            // btnTong
            // 
            this.btnTong.Location = new System.Drawing.Point(11, 23);
            this.btnTong.Name = "btnTong";
            this.btnTong.Size = new System.Drawing.Size(149, 40);
            this.btnTong.TabIndex = 0;
            this.btnTong.Text = "Tong";
            this.btnTong.UseVisualStyleBackColor = true;
            this.btnTong.Click += new System.EventHandler(this.btnTong_Click);
            // 
            // btnXoapt
            // 
            this.btnXoapt.Location = new System.Drawing.Point(181, 115);
            this.btnXoapt.Name = "btnXoapt";
            this.btnXoapt.Size = new System.Drawing.Size(182, 40);
            this.btnXoapt.TabIndex = 3;
            this.btnXoapt.Text = "xoa phan tu dang chon";
            this.btnXoapt.UseVisualStyleBackColor = true;
            this.btnXoapt.Click += new System.EventHandler(this.btnXoapt_Click);
            // 
            // btnSoLe
            // 
            this.btnSoLe.Location = new System.Drawing.Point(11, 115);
            this.btnSoLe.Name = "btnSoLe";
            this.btnSoLe.Size = new System.Drawing.Size(149, 40);
            this.btnSoLe.TabIndex = 4;
            this.btnSoLe.Text = "chon so le";
            this.btnSoLe.UseVisualStyleBackColor = true;
            this.btnSoLe.Click += new System.EventHandler(this.btnSoLe_Click);
            // 
            // btnTanglen2
            // 
            this.btnTanglen2.Location = new System.Drawing.Point(95, 174);
            this.btnTanglen2.Name = "btnTanglen2";
            this.btnTanglen2.Size = new System.Drawing.Size(149, 40);
            this.btnTanglen2.TabIndex = 5;
            this.btnTanglen2.Text = "tang 1 pt len 2";
            this.btnTanglen2.UseVisualStyleBackColor = true;
            this.btnTanglen2.Click += new System.EventHandler(this.btnTanglen2_Click);
            // 
            // btnBinhPhuong
            // 
            this.btnBinhPhuong.Location = new System.Drawing.Point(181, 23);
            this.btnBinhPhuong.Name = "btnBinhPhuong";
            this.btnBinhPhuong.Size = new System.Drawing.Size(182, 40);
            this.btnBinhPhuong.TabIndex = 6;
            this.btnBinhPhuong.Text = "thay bang binh phuong";
            this.btnBinhPhuong.UseVisualStyleBackColor = true;
            this.btnBinhPhuong.Click += new System.EventHandler(this.btnBinhPhuong_Click);
            // 
            // btnSoChan
            // 
            this.btnSoChan.Location = new System.Drawing.Point(181, 69);
            this.btnSoChan.Name = "btnSoChan";
            this.btnSoChan.Size = new System.Drawing.Size(149, 40);
            this.btnSoChan.TabIndex = 7;
            this.btnSoChan.Text = "chon so chan";
            this.btnSoChan.UseVisualStyleBackColor = true;
            this.btnSoChan.Click += new System.EventHandler(this.btnSoChan_Click);
            // 
            // btnxoaDaucuoi
            // 
            this.btnxoaDaucuoi.Location = new System.Drawing.Point(11, 69);
            this.btnxoaDaucuoi.Name = "btnxoaDaucuoi";
            this.btnxoaDaucuoi.Size = new System.Drawing.Size(149, 40);
            this.btnxoaDaucuoi.TabIndex = 8;
            this.btnxoaDaucuoi.Text = "xoa dau cuoi";
            this.btnxoaDaucuoi.UseVisualStyleBackColor = true;
            this.btnxoaDaucuoi.Click += new System.EventHandler(this.btnxoaDaucuoi_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.grbChucNang);
            this.Controls.Add(this.grbDS);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txtSo);
            this.Controls.Add(this.lblSo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grbDS.ResumeLayout(false);
            this.grbChucNang.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSo;
        private System.Windows.Forms.TextBox txtSo;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.GroupBox grbDS;
        private System.Windows.Forms.GroupBox grbChucNang;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.ListBox lstSo;
        private System.Windows.Forms.Button btnxoaDaucuoi;
        private System.Windows.Forms.Button btnSoChan;
        private System.Windows.Forms.Button btnBinhPhuong;
        private System.Windows.Forms.Button btnTanglen2;
        private System.Windows.Forms.Button btnSoLe;
        private System.Windows.Forms.Button btnXoapt;
        private System.Windows.Forms.Button btnTong;
    }
}

