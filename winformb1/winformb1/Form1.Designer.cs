namespace winformb1
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
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnHieu = new System.Windows.Forms.Button();
            this.txtSoNguyena = new System.Windows.Forms.TextBox();
            this.txtSoNguyenb = new System.Windows.Forms.TextBox();
            this.lblSoNguyena = new System.Windows.Forms.Label();
            this.lblSoNguyenb = new System.Windows.Forms.Label();
            this.lblKetQua = new System.Windows.Forms.Label();
            this.btnTong = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnThoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnThoat.Location = new System.Drawing.Point(446, 207);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(112, 33);
            this.btnThoat.TabIndex = 3;
            this.btnThoat.Text = "Th&oat";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnHieu
            // 
            this.btnHieu.BackColor = System.Drawing.Color.Lime;
            this.btnHieu.Location = new System.Drawing.Point(145, 207);
            this.btnHieu.Name = "btnHieu";
            this.btnHieu.Size = new System.Drawing.Size(112, 33);
            this.btnHieu.TabIndex = 2;
            this.btnHieu.Text = "&Hieu";
            this.btnHieu.UseVisualStyleBackColor = false;
            this.btnHieu.Click += new System.EventHandler(this.btnHieu_Click);
            // 
            // txtSoNguyena
            // 
            this.txtSoNguyena.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoNguyena.Location = new System.Drawing.Point(225, 78);
            this.txtSoNguyena.Name = "txtSoNguyena";
            this.txtSoNguyena.Size = new System.Drawing.Size(180, 28);
            this.txtSoNguyena.TabIndex = 0;
            // 
            // txtSoNguyenb
            // 
            this.txtSoNguyenb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoNguyenb.Location = new System.Drawing.Point(225, 135);
            this.txtSoNguyenb.Name = "txtSoNguyenb";
            this.txtSoNguyenb.Size = new System.Drawing.Size(180, 28);
            this.txtSoNguyenb.TabIndex = 1;
            // 
            // lblSoNguyena
            // 
            this.lblSoNguyena.AutoSize = true;
            this.lblSoNguyena.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblSoNguyena.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoNguyena.ForeColor = System.Drawing.Color.IndianRed;
            this.lblSoNguyena.Location = new System.Drawing.Point(46, 78);
            this.lblSoNguyena.Name = "lblSoNguyena";
            this.lblSoNguyena.Size = new System.Drawing.Size(122, 22);
            this.lblSoNguyena.TabIndex = 4;
            this.lblSoNguyena.Text = "So nguyen a";
            this.lblSoNguyena.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblSoNguyenb
            // 
            this.lblSoNguyenb.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblSoNguyenb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoNguyenb.ForeColor = System.Drawing.Color.IndianRed;
            this.lblSoNguyenb.Location = new System.Drawing.Point(48, 135);
            this.lblSoNguyenb.Name = "lblSoNguyenb";
            this.lblSoNguyenb.Size = new System.Drawing.Size(120, 34);
            this.lblSoNguyenb.TabIndex = 5;
            this.lblSoNguyenb.Text = "so nguyen b";
            // 
            // lblKetQua
            // 
            this.lblKetQua.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblKetQua.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblKetQua.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKetQua.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblKetQua.Location = new System.Drawing.Point(0, 0);
            this.lblKetQua.Name = "lblKetQua";
            this.lblKetQua.Size = new System.Drawing.Size(612, 63);
            this.lblKetQua.TabIndex = 6;
            this.lblKetQua.Text = "Ket qua";
            this.lblKetQua.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnTong
            // 
            this.btnTong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnTong.Location = new System.Drawing.Point(12, 207);
            this.btnTong.Name = "btnTong";
            this.btnTong.Size = new System.Drawing.Size(112, 33);
            this.btnTong.TabIndex = 7;
            this.btnTong.Text = "&Tong";
            this.btnTong.UseVisualStyleBackColor = false;
            this.btnTong.Click += new System.EventHandler(this.btnTong_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.Yellow;
            this.btnReset.Location = new System.Drawing.Point(293, 207);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(112, 33);
            this.btnReset.TabIndex = 8;
            this.btnReset.Text = "&Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.CancelButton = this.btnThoat;
            this.ClientSize = new System.Drawing.Size(612, 328);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnTong);
            this.Controls.Add(this.lblKetQua);
            this.Controls.Add(this.lblSoNguyenb);
            this.Controls.Add(this.lblSoNguyena);
            this.Controls.Add(this.txtSoNguyenb);
            this.Controls.Add(this.txtSoNguyena);
            this.Controls.Add(this.btnHieu);
            this.Controls.Add(this.btnThoat);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "game24h";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnHieu;
        private System.Windows.Forms.TextBox txtSoNguyena;
        private System.Windows.Forms.TextBox txtSoNguyenb;
        private System.Windows.Forms.Label lblSoNguyena;
        private System.Windows.Forms.Label lblSoNguyenb;
        private System.Windows.Forms.Label lblKetQua;
        private System.Windows.Forms.Button btnTong;
        private System.Windows.Forms.Button btnReset;
    }
}

