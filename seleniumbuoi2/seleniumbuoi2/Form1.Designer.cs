namespace seleniumbuoi2
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
            this.btnClick = new System.Windows.Forms.Button();
            this.txtOut = new System.Windows.Forms.TextBox();
            this.btnbai3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnClick
            // 
            this.btnClick.Location = new System.Drawing.Point(173, 193);
            this.btnClick.Name = "btnClick";
            this.btnClick.Size = new System.Drawing.Size(134, 58);
            this.btnClick.TabIndex = 0;
            this.btnClick.Text = "click";
            this.btnClick.UseVisualStyleBackColor = true;
            this.btnClick.Click += new System.EventHandler(this.btnClick_Click);
            // 
            // txtOut
            // 
            this.txtOut.Location = new System.Drawing.Point(348, 230);
            this.txtOut.Name = "txtOut";
            this.txtOut.Size = new System.Drawing.Size(223, 20);
            this.txtOut.TabIndex = 1;
            // 
            // btnbai3
            // 
            this.btnbai3.Location = new System.Drawing.Point(173, 283);
            this.btnbai3.Name = "btnbai3";
            this.btnbai3.Size = new System.Drawing.Size(134, 58);
            this.btnbai3.TabIndex = 2;
            this.btnbai3.Text = "bai3 button";
            this.btnbai3.UseVisualStyleBackColor = true;
            this.btnbai3.Click += new System.EventHandler(this.btnbai3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnbai3);
            this.Controls.Add(this.txtOut);
            this.Controls.Add(this.btnClick);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClick;
        private System.Windows.Forms.TextBox txtOut;
        private System.Windows.Forms.Button btnbai3;
    }
}

