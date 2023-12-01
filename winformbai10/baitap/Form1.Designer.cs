namespace baitap
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
            this.chklbTrai = new System.Windows.Forms.CheckedListBox();
            this.chklbPhai = new System.Windows.Forms.CheckedListBox();
            this.btnTrai = new System.Windows.Forms.Button();
            this.btnTrai2 = new System.Windows.Forms.Button();
            this.btnPhai = new System.Windows.Forms.Button();
            this.btnPhai2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // chklbTrai
            // 
            this.chklbTrai.CheckOnClick = true;
            this.chklbTrai.FormattingEnabled = true;
            this.chklbTrai.Items.AddRange(new object[] {
            "thuoc la",
            "ma tuy",
            "tra dao",
            "tra chanh"});
            this.chklbTrai.Location = new System.Drawing.Point(60, 183);
            this.chklbTrai.Name = "chklbTrai";
            this.chklbTrai.Size = new System.Drawing.Size(250, 140);
            this.chklbTrai.TabIndex = 0;
            // 
            // chklbPhai
            // 
            this.chklbPhai.CheckOnClick = true;
            this.chklbPhai.FormattingEnabled = true;
            this.chklbPhai.Location = new System.Drawing.Point(521, 183);
            this.chklbPhai.Name = "chklbPhai";
            this.chklbPhai.Size = new System.Drawing.Size(250, 140);
            this.chklbPhai.TabIndex = 1;
            // 
            // btnTrai
            // 
            this.btnTrai.Location = new System.Drawing.Point(380, 183);
            this.btnTrai.Name = "btnTrai";
            this.btnTrai.Size = new System.Drawing.Size(75, 23);
            this.btnTrai.TabIndex = 2;
            this.btnTrai.Text = ">";
            this.btnTrai.UseVisualStyleBackColor = true;
            this.btnTrai.Click += new System.EventHandler(this.btnTrai_Click);
            // 
            // btnTrai2
            // 
            this.btnTrai2.Location = new System.Drawing.Point(380, 234);
            this.btnTrai2.Name = "btnTrai2";
            this.btnTrai2.Size = new System.Drawing.Size(75, 23);
            this.btnTrai2.TabIndex = 3;
            this.btnTrai2.Text = ">>";
            this.btnTrai2.UseVisualStyleBackColor = true;
            this.btnTrai2.Click += new System.EventHandler(this.btnTrai2_Click);
            // 
            // btnPhai
            // 
            this.btnPhai.Location = new System.Drawing.Point(380, 288);
            this.btnPhai.Name = "btnPhai";
            this.btnPhai.Size = new System.Drawing.Size(75, 23);
            this.btnPhai.TabIndex = 4;
            this.btnPhai.Text = "<";
            this.btnPhai.UseVisualStyleBackColor = true;
            this.btnPhai.Click += new System.EventHandler(this.btnPhai_Click);
            // 
            // btnPhai2
            // 
            this.btnPhai2.Location = new System.Drawing.Point(380, 335);
            this.btnPhai2.Name = "btnPhai2";
            this.btnPhai2.Size = new System.Drawing.Size(75, 23);
            this.btnPhai2.TabIndex = 5;
            this.btnPhai2.Text = "<<";
            this.btnPhai2.UseVisualStyleBackColor = true;
            this.btnPhai2.Click += new System.EventHandler(this.btnPhai2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPhai2);
            this.Controls.Add(this.btnPhai);
            this.Controls.Add(this.btnTrai2);
            this.Controls.Add(this.btnTrai);
            this.Controls.Add(this.chklbPhai);
            this.Controls.Add(this.chklbTrai);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox chklbTrai;
        private System.Windows.Forms.CheckedListBox chklbPhai;
        private System.Windows.Forms.Button btnTrai;
        private System.Windows.Forms.Button btnTrai2;
        private System.Windows.Forms.Button btnPhai;
        private System.Windows.Forms.Button btnPhai2;
    }
}

