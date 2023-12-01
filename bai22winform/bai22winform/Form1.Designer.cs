namespace bai22winform
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
            this.txtbrowser = new System.Windows.Forms.TextBox();
            this.btnrun = new System.Windows.Forms.Button();
            this.btnrun2 = new System.Windows.Forms.Button();
            this.btnbrowser = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.txtbower2 = new System.Windows.Forms.TextBox();
            this.txtbower3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "nhap duong dan";
            // 
            // txtbrowser
            // 
            this.txtbrowser.Location = new System.Drawing.Point(75, 38);
            this.txtbrowser.Name = "txtbrowser";
            this.txtbrowser.Size = new System.Drawing.Size(440, 20);
            this.txtbrowser.TabIndex = 1;
            // 
            // btnrun
            // 
            this.btnrun.Location = new System.Drawing.Point(82, 155);
            this.btnrun.Name = "btnrun";
            this.btnrun.Size = new System.Drawing.Size(75, 23);
            this.btnrun.TabIndex = 2;
            this.btnrun.Text = "run1";
            this.btnrun.UseVisualStyleBackColor = true;
            this.btnrun.Click += new System.EventHandler(this.btnrun_Click);
            // 
            // btnrun2
            // 
            this.btnrun2.Location = new System.Drawing.Point(185, 155);
            this.btnrun2.Name = "btnrun2";
            this.btnrun2.Size = new System.Drawing.Size(75, 23);
            this.btnrun2.TabIndex = 3;
            this.btnrun2.Text = "run2";
            this.btnrun2.UseVisualStyleBackColor = true;
            this.btnrun2.Click += new System.EventHandler(this.btnrun2_Click);
            // 
            // btnbrowser
            // 
            this.btnbrowser.Location = new System.Drawing.Point(460, 155);
            this.btnbrowser.Name = "btnbrowser";
            this.btnbrowser.Size = new System.Drawing.Size(75, 23);
            this.btnbrowser.TabIndex = 4;
            this.btnbrowser.Text = "brower";
            this.btnbrowser.UseVisualStyleBackColor = true;
            this.btnbrowser.Click += new System.EventHandler(this.btnbrowser_Click);
            // 
            // txtbower2
            // 
            this.txtbower2.Location = new System.Drawing.Point(75, 83);
            this.txtbower2.Name = "txtbower2";
            this.txtbower2.Size = new System.Drawing.Size(185, 20);
            this.txtbower2.TabIndex = 5;
            // 
            // txtbower3
            // 
            this.txtbower3.Location = new System.Drawing.Point(330, 83);
            this.txtbower3.Name = "txtbower3";
            this.txtbower3.Size = new System.Drawing.Size(185, 20);
            this.txtbower3.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 260);
            this.Controls.Add(this.txtbower3);
            this.Controls.Add(this.txtbower2);
            this.Controls.Add(this.btnbrowser);
            this.Controls.Add(this.btnrun2);
            this.Controls.Add(this.btnrun);
            this.Controls.Add(this.txtbrowser);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbrowser;
        private System.Windows.Forms.Button btnrun;
        private System.Windows.Forms.Button btnrun2;
        private System.Windows.Forms.Button btnbrowser;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.TextBox txtbower2;
        private System.Windows.Forms.TextBox txtbower3;
    }
}

