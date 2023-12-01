namespace winformbai8
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
            this.lstDS = new System.Windows.Forms.ListBox();
            this.btnadd = new System.Windows.Forms.Button();
            this.btnCount = new System.Windows.Forms.Button();
            this.btnindex = new System.Windows.Forms.Button();
            this.btnremoveAt = new System.Windows.Forms.Button();
            this.selectedindice = new System.Windows.Forms.Button();
            this.bntGan = new System.Windows.Forms.Button();
            this.btnSelectedIndex = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstDS
            // 
            this.lstDS.FormattingEnabled = true;
            this.lstDS.ItemHeight = 16;
            this.lstDS.Items.AddRange(new object[] {
            "itemm 1",
            "2 ",
            "3",
            "4",
            "5"});
            this.lstDS.Location = new System.Drawing.Point(106, 142);
            this.lstDS.Name = "lstDS";
            this.lstDS.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstDS.Size = new System.Drawing.Size(377, 148);
            this.lstDS.TabIndex = 0;
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(567, 170);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(75, 23);
            this.btnadd.TabIndex = 1;
            this.btnadd.Text = "add";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btnCount
            // 
            this.btnCount.Location = new System.Drawing.Point(567, 215);
            this.btnCount.Name = "btnCount";
            this.btnCount.Size = new System.Drawing.Size(75, 23);
            this.btnCount.TabIndex = 2;
            this.btnCount.Text = "count";
            this.btnCount.UseVisualStyleBackColor = true;
            this.btnCount.Click += new System.EventHandler(this.btnCount_Click);
            // 
            // btnindex
            // 
            this.btnindex.Location = new System.Drawing.Point(567, 267);
            this.btnindex.Name = "btnindex";
            this.btnindex.Size = new System.Drawing.Size(107, 46);
            this.btnindex.TabIndex = 3;
            this.btnindex.Text = "find index";
            this.btnindex.UseVisualStyleBackColor = true;
            this.btnindex.Click += new System.EventHandler(this.btnindex_Click);
            // 
            // btnremoveAt
            // 
            this.btnremoveAt.Location = new System.Drawing.Point(567, 340);
            this.btnremoveAt.Name = "btnremoveAt";
            this.btnremoveAt.Size = new System.Drawing.Size(75, 23);
            this.btnremoveAt.TabIndex = 4;
            this.btnremoveAt.Text = "RemoveAt";
            this.btnremoveAt.UseVisualStyleBackColor = true;
            this.btnremoveAt.Click += new System.EventHandler(this.btnremoveAt_Click);
            // 
            // selectedindice
            // 
            this.selectedindice.Location = new System.Drawing.Point(688, 170);
            this.selectedindice.Name = "selectedindice";
            this.selectedindice.Size = new System.Drawing.Size(110, 23);
            this.selectedindice.TabIndex = 5;
            this.selectedindice.Text = "SelectedIndie";
            this.selectedindice.UseVisualStyleBackColor = true;
            this.selectedindice.Click += new System.EventHandler(this.selectedindice_Click);
            // 
            // bntGan
            // 
            this.bntGan.Location = new System.Drawing.Point(688, 215);
            this.bntGan.Name = "bntGan";
            this.bntGan.Size = new System.Drawing.Size(75, 23);
            this.bntGan.TabIndex = 6;
            this.bntGan.Text = "Gan";
            this.bntGan.UseVisualStyleBackColor = true;
            this.bntGan.Click += new System.EventHandler(this.bntGan_Click);
            // 
            // btnSelectedIndex
            // 
            this.btnSelectedIndex.Location = new System.Drawing.Point(688, 279);
            this.btnSelectedIndex.Name = "btnSelectedIndex";
            this.btnSelectedIndex.Size = new System.Drawing.Size(110, 23);
            this.btnSelectedIndex.TabIndex = 7;
            this.btnSelectedIndex.Text = "selectedIndex";
            this.btnSelectedIndex.UseVisualStyleBackColor = true;
            this.btnSelectedIndex.Click += new System.EventHandler(this.btnSelectedIndex_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 459);
            this.Controls.Add(this.btnSelectedIndex);
            this.Controls.Add(this.bntGan);
            this.Controls.Add(this.selectedindice);
            this.Controls.Add(this.btnremoveAt);
            this.Controls.Add(this.btnindex);
            this.Controls.Add(this.btnCount);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.lstDS);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstDS;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btnCount;
        private System.Windows.Forms.Button btnindex;
        private System.Windows.Forms.Button btnremoveAt;
        private System.Windows.Forms.Button selectedindice;
        private System.Windows.Forms.Button bntGan;
        private System.Windows.Forms.Button btnSelectedIndex;
    }
}

