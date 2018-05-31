namespace DataBase_Project
{
    partial class borrow_return
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
            this.label3 = new System.Windows.Forms.Label();
            this.confirm = new System.Windows.Forms.Button();
            this.bookNumber = new System.Windows.Forms.TextBox();
            this.type = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "书号";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "借还书";
            // 
            // confirm
            // 
            this.confirm.Location = new System.Drawing.Point(103, 195);
            this.confirm.Name = "confirm";
            this.confirm.Size = new System.Drawing.Size(75, 23);
            this.confirm.TabIndex = 4;
            this.confirm.Text = "确认";
            this.confirm.UseVisualStyleBackColor = true;
            // 
            // bookNumber
            // 
            this.bookNumber.Location = new System.Drawing.Point(139, 46);
            this.bookNumber.Name = "bookNumber";
            this.bookNumber.Size = new System.Drawing.Size(100, 21);
            this.bookNumber.TabIndex = 5;
            // 
            // type
            // 
            this.type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.type.FormattingEnabled = true;
            this.type.Items.AddRange(new object[] {
            "借书",
            "还书"});
            this.type.Location = new System.Drawing.Point(139, 130);
            this.type.Name = "type";
            this.type.Size = new System.Drawing.Size(100, 20);
            this.type.TabIndex = 6;
            // 
            // borrow_return
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 261);
            this.Controls.Add(this.type);
            this.Controls.Add(this.bookNumber);
            this.Controls.Add(this.confirm);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "borrow_return";
            this.Text = "借还书操作界面";
            this.Load += new System.EventHandler(this.borrow_return_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button confirm;
        private System.Windows.Forms.TextBox bookNumber;
        private System.Windows.Forms.ComboBox type;
    }
}