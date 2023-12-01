namespace winformbai21
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
            this.lblchon = new System.Windows.Forms.Label();
            this.btnbrower = new System.Windows.Forms.Button();
            this.txtthumuc = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // lblchon
            // 
            this.lblchon.AutoSize = true;
            this.lblchon.Location = new System.Drawing.Point(13, 26);
            this.lblchon.Name = "lblchon";
            this.lblchon.Size = new System.Drawing.Size(72, 13);
            this.lblchon.TabIndex = 0;
            this.lblchon.Text = "chon thu muc";
            // 
            // btnbrower
            // 
            this.btnbrower.Location = new System.Drawing.Point(197, 88);
            this.btnbrower.Name = "btnbrower";
            this.btnbrower.Size = new System.Drawing.Size(75, 23);
            this.btnbrower.TabIndex = 1;
            this.btnbrower.Text = "browers";
            this.btnbrower.UseVisualStyleBackColor = true;
            this.btnbrower.Click += new System.EventHandler(this.btnbrower_Click);
            // 
            // txtthumuc
            // 
            this.txtthumuc.Location = new System.Drawing.Point(16, 54);
            this.txtthumuc.Name = "txtthumuc";
            this.txtthumuc.Size = new System.Drawing.Size(256, 20);
            this.txtthumuc.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 172);
            this.Controls.Add(this.txtthumuc);
            this.Controls.Add(this.btnbrower);
            this.Controls.Add(this.lblchon);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblchon;
        private System.Windows.Forms.Button btnbrower;
        private System.Windows.Forms.TextBox txtthumuc;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}

