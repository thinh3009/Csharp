namespace winformbai9
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
            this.cboADD = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnselectindex = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnCOunt = new System.Windows.Forms.Button();
            this.btnAddRange = new System.Windows.Forms.Button();
            this.btnremove = new System.Windows.Forms.Button();
            this.removeAt = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cboADD
            // 
            this.cboADD.FormattingEnabled = true;
            this.cboADD.Items.AddRange(new object[] {
            "com ",
            "cut",
            "cut com"});
            this.cboADD.Location = new System.Drawing.Point(313, 80);
            this.cboADD.Name = "cboADD";
            this.cboADD.Size = new System.Drawing.Size(121, 24);
            this.cboADD.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(313, 142);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(313, 204);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(75, 23);
            this.btnInsert.TabIndex = 2;
            this.btnInsert.Text = "insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnselectindex
            // 
            this.btnselectindex.Location = new System.Drawing.Point(428, 142);
            this.btnselectindex.Name = "btnselectindex";
            this.btnselectindex.Size = new System.Drawing.Size(101, 23);
            this.btnselectindex.TabIndex = 3;
            this.btnselectindex.Text = "selectedIndex";
            this.btnselectindex.UseVisualStyleBackColor = true;
            this.btnselectindex.Click += new System.EventHandler(this.btnselectindex_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(428, 204);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "selectedItem";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCOunt
            // 
            this.btnCOunt.Location = new System.Drawing.Point(313, 254);
            this.btnCOunt.Name = "btnCOunt";
            this.btnCOunt.Size = new System.Drawing.Size(101, 23);
            this.btnCOunt.TabIndex = 5;
            this.btnCOunt.Text = "Count";
            this.btnCOunt.UseVisualStyleBackColor = true;
            this.btnCOunt.Click += new System.EventHandler(this.btnCOunt_Click);
            // 
            // btnAddRange
            // 
            this.btnAddRange.Location = new System.Drawing.Point(428, 254);
            this.btnAddRange.Name = "btnAddRange";
            this.btnAddRange.Size = new System.Drawing.Size(111, 33);
            this.btnAddRange.TabIndex = 6;
            this.btnAddRange.Text = "Add range";
            this.btnAddRange.UseVisualStyleBackColor = true;
            this.btnAddRange.Click += new System.EventHandler(this.btnAddRange_Click);
            // 
            // btnremove
            // 
            this.btnremove.Location = new System.Drawing.Point(313, 308);
            this.btnremove.Name = "btnremove";
            this.btnremove.Size = new System.Drawing.Size(111, 33);
            this.btnremove.TabIndex = 7;
            this.btnremove.Text = "remove";
            this.btnremove.UseVisualStyleBackColor = true;
            this.btnremove.Click += new System.EventHandler(this.btnremove_Click);
            // 
            // removeAt
            // 
            this.removeAt.Location = new System.Drawing.Point(453, 308);
            this.removeAt.Name = "removeAt";
            this.removeAt.Size = new System.Drawing.Size(111, 33);
            this.removeAt.TabIndex = 8;
            this.removeAt.Text = "remove At";
            this.removeAt.UseVisualStyleBackColor = true;
            this.removeAt.Click += new System.EventHandler(this.removeAt_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(313, 370);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(111, 33);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.removeAt);
            this.Controls.Add(this.btnremove);
            this.Controls.Add(this.btnAddRange);
            this.Controls.Add(this.btnCOunt);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnselectindex);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cboADD);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cboADD;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnselectindex;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnCOunt;
        private System.Windows.Forms.Button btnAddRange;
        private System.Windows.Forms.Button btnremove;
        private System.Windows.Forms.Button removeAt;
        private System.Windows.Forms.Button btnClear;
    }
}

