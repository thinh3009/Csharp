namespace winformbai10
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
            this.chklb = new System.Windows.Forms.CheckedListBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnAddRange = new System.Windows.Forms.Button();
            this.btnCount = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnRemoveAt = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnCheckedIndices = new System.Windows.Forms.Button();
            this.btnCheckedItems = new System.Windows.Forms.Button();
            this.btnGetitemCheck = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // chklb
            // 
            this.chklb.CheckOnClick = true;
            this.chklb.FormattingEnabled = true;
            this.chklb.Items.AddRange(new object[] {
            "ditme",
            "ok",
            "ohno",
            "baibai"});
            this.chklb.Location = new System.Drawing.Point(77, 79);
            this.chklb.Name = "chklb";
            this.chklb.Size = new System.Drawing.Size(317, 106);
            this.chklb.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(508, 110);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(508, 162);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(75, 23);
            this.btnInsert.TabIndex = 2;
            this.btnInsert.Text = "insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnAddRange
            // 
            this.btnAddRange.Location = new System.Drawing.Point(508, 207);
            this.btnAddRange.Name = "btnAddRange";
            this.btnAddRange.Size = new System.Drawing.Size(136, 23);
            this.btnAddRange.TabIndex = 3;
            this.btnAddRange.Text = "add range";
            this.btnAddRange.UseVisualStyleBackColor = true;
            this.btnAddRange.Click += new System.EventHandler(this.btnAddRange_Click);
            // 
            // btnCount
            // 
            this.btnCount.Location = new System.Drawing.Point(508, 253);
            this.btnCount.Name = "btnCount";
            this.btnCount.Size = new System.Drawing.Size(136, 23);
            this.btnCount.TabIndex = 4;
            this.btnCount.Text = "Count";
            this.btnCount.UseVisualStyleBackColor = true;
            this.btnCount.Click += new System.EventHandler(this.btnCount_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(508, 306);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(136, 23);
            this.btnRemove.TabIndex = 5;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnRemoveAt
            // 
            this.btnRemoveAt.Location = new System.Drawing.Point(508, 355);
            this.btnRemoveAt.Name = "btnRemoveAt";
            this.btnRemoveAt.Size = new System.Drawing.Size(136, 23);
            this.btnRemoveAt.TabIndex = 6;
            this.btnRemoveAt.Text = "Remove At";
            this.btnRemoveAt.UseVisualStyleBackColor = true;
            this.btnRemoveAt.Click += new System.EventHandler(this.btnRemoveAt_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(631, 110);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(136, 23);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnCheckedIndices
            // 
            this.btnCheckedIndices.Location = new System.Drawing.Point(77, 207);
            this.btnCheckedIndices.Name = "btnCheckedIndices";
            this.btnCheckedIndices.Size = new System.Drawing.Size(136, 23);
            this.btnCheckedIndices.TabIndex = 8;
            this.btnCheckedIndices.Text = "CheckedIndices";
            this.btnCheckedIndices.UseVisualStyleBackColor = true;
            this.btnCheckedIndices.Click += new System.EventHandler(this.btnCheckedIndices_Click);
            // 
            // btnCheckedItems
            // 
            this.btnCheckedItems.Location = new System.Drawing.Point(77, 253);
            this.btnCheckedItems.Name = "btnCheckedItems";
            this.btnCheckedItems.Size = new System.Drawing.Size(136, 23);
            this.btnCheckedItems.TabIndex = 9;
            this.btnCheckedItems.Text = "CheckedItems";
            this.btnCheckedItems.UseVisualStyleBackColor = true;
            this.btnCheckedItems.Click += new System.EventHandler(this.btnCheckedItems_Click);
            // 
            // btnGetitemCheck
            // 
            this.btnGetitemCheck.Location = new System.Drawing.Point(77, 306);
            this.btnGetitemCheck.Name = "btnGetitemCheck";
            this.btnGetitemCheck.Size = new System.Drawing.Size(156, 42);
            this.btnGetitemCheck.TabIndex = 10;
            this.btnGetitemCheck.Text = "Get Items checked";
            this.btnGetitemCheck.UseVisualStyleBackColor = true;
            this.btnGetitemCheck.Click += new System.EventHandler(this.btnGetitemCheck_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnGetitemCheck);
            this.Controls.Add(this.btnCheckedItems);
            this.Controls.Add(this.btnCheckedIndices);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnRemoveAt);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnCount);
            this.Controls.Add(this.btnAddRange);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.chklb);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox chklb;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnAddRange;
        private System.Windows.Forms.Button btnCount;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnRemoveAt;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnCheckedIndices;
        private System.Windows.Forms.Button btnCheckedItems;
        private System.Windows.Forms.Button btnGetitemCheck;
    }
}

