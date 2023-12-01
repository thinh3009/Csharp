namespace winformbai7
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
            this.components = new System.ComponentModel.Container();
            this.grbDK = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnDK = new System.Windows.Forms.Button();
            this.txtphone = new System.Windows.Forms.TextBox();
            this.txtage = new System.Windows.Forms.TextBox();
            this.dtpDK = new System.Windows.Forms.DateTimePicker();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.grbDK.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // grbDK
            // 
            this.grbDK.Controls.Add(this.dtpDK);
            this.grbDK.Controls.Add(this.txtage);
            this.grbDK.Controls.Add(this.txtphone);
            this.grbDK.Controls.Add(this.btnDK);
            this.grbDK.Controls.Add(this.label3);
            this.grbDK.Controls.Add(this.label2);
            this.grbDK.Controls.Add(this.label1);
            this.grbDK.Location = new System.Drawing.Point(168, 108);
            this.grbDK.Name = "grbDK";
            this.grbDK.Size = new System.Drawing.Size(464, 271);
            this.grbDK.TabIndex = 0;
            this.grbDK.TabStop = false;
            this.grbDK.Text = "thong tin dang ky";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "phone";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "age";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(65, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "date";
            // 
            // btnDK
            // 
            this.btnDK.Location = new System.Drawing.Point(362, 218);
            this.btnDK.Name = "btnDK";
            this.btnDK.Size = new System.Drawing.Size(75, 23);
            this.btnDK.TabIndex = 3;
            this.btnDK.Text = "Dang ky";
            this.btnDK.UseVisualStyleBackColor = true;
            this.btnDK.Click += new System.EventHandler(this.btnDK_Click);
            // 
            // txtphone
            // 
            this.txtphone.Location = new System.Drawing.Point(148, 67);
            this.txtphone.Name = "txtphone";
            this.txtphone.Size = new System.Drawing.Size(165, 22);
            this.txtphone.TabIndex = 4;
            // 
            // txtage
            // 
            this.txtage.Location = new System.Drawing.Point(148, 119);
            this.txtage.Name = "txtage";
            this.txtage.Size = new System.Drawing.Size(165, 22);
            this.txtage.TabIndex = 5;
            // 
            // dtpDK
            // 
            this.dtpDK.Cursor = System.Windows.Forms.Cursors.No;
            this.dtpDK.CustomFormat = "dd/MM/yyyy";
            this.dtpDK.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDK.Location = new System.Drawing.Point(148, 177);
            this.dtpDK.Name = "dtpDK";
            this.dtpDK.Size = new System.Drawing.Size(200, 22);
            this.dtpDK.TabIndex = 6;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grbDK);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.grbDK.ResumeLayout(false);
            this.grbDK.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbDK;
        private System.Windows.Forms.DateTimePicker dtpDK;
        private System.Windows.Forms.TextBox txtage;
        private System.Windows.Forms.TextBox txtphone;
        private System.Windows.Forms.Button btnDK;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

