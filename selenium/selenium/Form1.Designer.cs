namespace selenium
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
            this.btnbroew2 = new System.Windows.Forms.Button();
            this.btnbrowser1 = new System.Windows.Forms.Button();
            this.txturl = new System.Windows.Forms.TextBox();
            this.lblnhap = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnbroew2
            // 
            this.btnbroew2.Location = new System.Drawing.Point(393, 199);
            this.btnbroew2.Name = "btnbroew2";
            this.btnbroew2.Size = new System.Drawing.Size(109, 79);
            this.btnbroew2.TabIndex = 0;
            this.btnbroew2.Text = "browser2";
            this.btnbroew2.UseVisualStyleBackColor = true;
            this.btnbroew2.Click += new System.EventHandler(this.btnbroew2_Click);
            // 
            // btnbrowser1
            // 
            this.btnbrowser1.Location = new System.Drawing.Point(194, 199);
            this.btnbrowser1.Name = "btnbrowser1";
            this.btnbrowser1.Size = new System.Drawing.Size(112, 79);
            this.btnbrowser1.TabIndex = 1;
            this.btnbrowser1.Text = "open browser";
            this.btnbrowser1.UseVisualStyleBackColor = true;
            this.btnbrowser1.Click += new System.EventHandler(this.btnbrowser1_Click);
            // 
            // txturl
            // 
            this.txturl.Location = new System.Drawing.Point(194, 311);
            this.txturl.Name = "txturl";
            this.txturl.Size = new System.Drawing.Size(327, 20);
            this.txturl.TabIndex = 2;
            // 
            // lblnhap
            // 
            this.lblnhap.AutoSize = true;
            this.lblnhap.Location = new System.Drawing.Point(70, 318);
            this.lblnhap.Name = "lblnhap";
            this.lblnhap.Size = new System.Drawing.Size(52, 13);
            this.lblnhap.TabIndex = 3;
            this.lblnhap.Text = "Nhap link";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblnhap);
            this.Controls.Add(this.txturl);
            this.Controls.Add(this.btnbrowser1);
            this.Controls.Add(this.btnbroew2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnbroew2;
        private System.Windows.Forms.Button btnbrowser1;
        private System.Windows.Forms.TextBox txturl;
        private System.Windows.Forms.Label lblnhap;
    }
}

