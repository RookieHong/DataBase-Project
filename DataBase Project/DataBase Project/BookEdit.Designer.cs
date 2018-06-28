namespace DataBase_Project
{
    partial class BookEdit
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.bname = new System.Windows.Forms.TextBox();
            this.isbn = new System.Windows.Forms.TextBox();
            this.author = new System.Windows.Forms.TextBox();
            this.pub = new System.Windows.Forms.TextBox();
            this.bCurNum = new System.Windows.Forms.TextBox();
            this.storeNum = new System.Windows.Forms.TextBox();
            this.available = new System.Windows.Forms.ComboBox();
            this.booksubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(43, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "ISBN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(272, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "书名";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 9F);
            this.label3.Location = new System.Drawing.Point(43, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "出版社";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 9F);
            this.label4.Location = new System.Drawing.Point(272, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "作者";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 9F);
            this.label5.Location = new System.Drawing.Point(43, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "馆藏数量";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 9F);
            this.label6.Location = new System.Drawing.Point(272, 139);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 5;
            this.label6.Text = "可借数量";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("宋体", 9F);
            this.label7.Location = new System.Drawing.Point(43, 187);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 6;
            this.label7.Text = "是否可借";
            // 
            // bname
            // 
            this.bname.Location = new System.Drawing.Point(339, 56);
            this.bname.Name = "bname";
            this.bname.Size = new System.Drawing.Size(121, 21);
            this.bname.TabIndex = 1;
            // 
            // isbn
            // 
            this.isbn.Location = new System.Drawing.Point(106, 56);
            this.isbn.Name = "isbn";
            this.isbn.Size = new System.Drawing.Size(121, 21);
            this.isbn.TabIndex = 0;
            // 
            // author
            // 
            this.author.Location = new System.Drawing.Point(339, 93);
            this.author.Name = "author";
            this.author.Size = new System.Drawing.Size(121, 21);
            this.author.TabIndex = 3;
            // 
            // pub
            // 
            this.pub.Location = new System.Drawing.Point(106, 93);
            this.pub.Name = "pub";
            this.pub.Size = new System.Drawing.Size(121, 21);
            this.pub.TabIndex = 2;
            // 
            // bCurNum
            // 
            this.bCurNum.Location = new System.Drawing.Point(339, 134);
            this.bCurNum.Name = "bCurNum";
            this.bCurNum.Size = new System.Drawing.Size(121, 21);
            this.bCurNum.TabIndex = 5;
            this.bCurNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numberInputOnly);
            // 
            // storeNum
            // 
            this.storeNum.Location = new System.Drawing.Point(106, 138);
            this.storeNum.Name = "storeNum";
            this.storeNum.Size = new System.Drawing.Size(121, 21);
            this.storeNum.TabIndex = 4;
            this.storeNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numberInputOnly);
            // 
            // available
            // 
            this.available.BackColor = System.Drawing.SystemColors.Window;
            this.available.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.available.FormattingEnabled = true;
            this.available.Items.AddRange(new object[] {
            "是",
            "否"});
            this.available.Location = new System.Drawing.Point(106, 183);
            this.available.Name = "available";
            this.available.Size = new System.Drawing.Size(121, 20);
            this.available.TabIndex = 13;
            // 
            // booksubmit
            // 
            this.booksubmit.Location = new System.Drawing.Point(205, 236);
            this.booksubmit.Name = "booksubmit";
            this.booksubmit.Size = new System.Drawing.Size(75, 23);
            this.booksubmit.TabIndex = 14;
            this.booksubmit.Text = "确定";
            this.booksubmit.UseVisualStyleBackColor = true;
            this.booksubmit.Click += new System.EventHandler(this.booksubmit_Click);
            // 
            // BookEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 315);
            this.Controls.Add(this.booksubmit);
            this.Controls.Add(this.available);
            this.Controls.Add(this.storeNum);
            this.Controls.Add(this.bCurNum);
            this.Controls.Add(this.pub);
            this.Controls.Add(this.author);
            this.Controls.Add(this.isbn);
            this.Controls.Add(this.bname);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "BookEdit";
            this.Text = "图书信息";
            this.Load += new System.EventHandler(this.BookEdit_Load);
            this.Shown += new System.EventHandler(this.BookEdit_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox bname;
        private System.Windows.Forms.TextBox isbn;
        private System.Windows.Forms.TextBox author;
        private System.Windows.Forms.TextBox pub;
        private System.Windows.Forms.TextBox bCurNum;
        private System.Windows.Forms.TextBox storeNum;
        private System.Windows.Forms.ComboBox available;
        private System.Windows.Forms.Button booksubmit;
    }
}