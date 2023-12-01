namespace bai6Winform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.picdau = new System.Windows.Forms.PictureBox();
            this.picthan = new System.Windows.Forms.PictureBox();
            this.lblName = new System.Windows.Forms.Label();
            this.btnclick = new System.Windows.Forms.Button();
            this.lblDesign = new System.Windows.Forms.Label();
            this.lblNam = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblKetqua = new System.Windows.Forms.Label();
            this.chkNhac = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.picdau)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picthan)).BeginInit();
            this.SuspendLayout();
            // 
            // picdau
            // 
            this.picdau.Image = ((System.Drawing.Image)(resources.GetObject("picdau.Image")));
            this.picdau.Location = new System.Drawing.Point(23, 100);
            this.picdau.Name = "picdau";
            this.picdau.Size = new System.Drawing.Size(292, 240);
            this.picdau.TabIndex = 0;
            this.picdau.TabStop = false;
            this.picdau.Visible = false;
            // 
            // picthan
            // 
            this.picthan.Image = ((System.Drawing.Image)(resources.GetObject("picthan.Image")));
            this.picthan.Location = new System.Drawing.Point(367, 100);
            this.picthan.Name = "picthan";
            this.picthan.Size = new System.Drawing.Size(165, 240);
            this.picthan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picthan.TabIndex = 1;
            this.picthan.TabStop = false;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(34, 56);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(58, 16);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "nhap ten";
            // 
            // btnclick
            // 
            this.btnclick.Location = new System.Drawing.Point(471, 346);
            this.btnclick.Name = "btnclick";
            this.btnclick.Size = new System.Drawing.Size(253, 40);
            this.btnclick.TabIndex = 3;
            this.btnclick.Text = "click";
            this.btnclick.UseVisualStyleBackColor = true;
            this.btnclick.Click += new System.EventHandler(this.btnclick_Click);
            // 
            // lblDesign
            // 
            this.lblDesign.AutoSize = true;
            this.lblDesign.Location = new System.Drawing.Point(34, 370);
            this.lblDesign.Name = "lblDesign";
            this.lblDesign.Size = new System.Drawing.Size(66, 16);
            this.lblDesign.TabIndex = 4;
            this.lblDesign.Text = "design by";
            // 
            // lblNam
            // 
            this.lblNam.AutoSize = true;
            this.lblNam.Location = new System.Drawing.Point(34, 396);
            this.lblNam.Name = "lblNam";
            this.lblNam.Size = new System.Drawing.Size(34, 16);
            this.lblNam.TabIndex = 5;
            this.lblNam.Text = "thinh";
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(471, 389);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 6;
            this.btnThoat.Text = "thoat";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(118, 56);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(358, 22);
            this.txtName.TabIndex = 7;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // lblKetqua
            // 
            this.lblKetqua.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblKetqua.Location = new System.Drawing.Point(147, 370);
            this.lblKetqua.Name = "lblKetqua";
            this.lblKetqua.Size = new System.Drawing.Size(281, 42);
            this.lblKetqua.TabIndex = 8;
            // 
            // chkNhac
            // 
            this.chkNhac.AutoSize = true;
            this.chkNhac.Location = new System.Drawing.Point(636, 51);
            this.chkNhac.Name = "chkNhac";
            this.chkNhac.Size = new System.Drawing.Size(88, 20);
            this.chkNhac.TabIndex = 9;
            this.chkNhac.Text = "Phat nhac";
            this.chkNhac.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chkNhac);
            this.Controls.Add(this.lblKetqua);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.lblNam);
            this.Controls.Add(this.lblDesign);
            this.Controls.Add(this.btnclick);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.picthan);
            this.Controls.Add(this.picdau);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picdau)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picthan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picdau;
        private System.Windows.Forms.PictureBox picthan;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnclick;
        private System.Windows.Forms.Label lblDesign;
        private System.Windows.Forms.Label lblNam;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblKetqua;
        private System.Windows.Forms.CheckBox chkNhac;
    }
}

