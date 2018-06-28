namespace DataBase_Project
{
    partial class ReaderEdit
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
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.account = new System.Windows.Forms.TextBox();
            this.dept = new System.Windows.Forms.TextBox();
            this.phone = new System.Windows.Forms.TextBox();
            this.job = new System.Windows.Forms.TextBox();
            this.rBorrowedNum = new System.Windows.Forms.TextBox();
            this.rname = new System.Windows.Forms.TextBox();
            this.rCurNum = new System.Windows.Forms.TextBox();
            this.borrowid = new System.Windows.Forms.TextBox();
            this.sex = new System.Windows.Forms.ComboBox();
            this.confirm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "借书证号";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "姓名";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "职称";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "部门";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 219);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "性别";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(235, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 5;
            this.label6.Text = "可借数量";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(235, 111);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 6;
            this.label7.Text = "已借数量";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(235, 148);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 12);
            this.label8.TabIndex = 7;
            this.label8.Text = "电话";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(235, 182);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 12);
            this.label9.TabIndex = 8;
            this.label9.Text = "账号";
            // 
            // account
            // 
            this.account.Location = new System.Drawing.Point(313, 182);
            this.account.Name = "account";
            this.account.Size = new System.Drawing.Size(107, 21);
            this.account.TabIndex = 8;
            // 
            // dept
            // 
            this.dept.Location = new System.Drawing.Point(108, 176);
            this.dept.Name = "dept";
            this.dept.Size = new System.Drawing.Size(107, 21);
            this.dept.TabIndex = 3;
            // 
            // phone
            // 
            this.phone.Location = new System.Drawing.Point(313, 148);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(107, 21);
            this.phone.TabIndex = 7;
            this.phone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numberInputOnly);
            // 
            // job
            // 
            this.job.Location = new System.Drawing.Point(108, 142);
            this.job.Name = "job";
            this.job.Size = new System.Drawing.Size(107, 21);
            this.job.TabIndex = 2;
            // 
            // rBorrowedNum
            // 
            this.rBorrowedNum.Location = new System.Drawing.Point(313, 111);
            this.rBorrowedNum.Name = "rBorrowedNum";
            this.rBorrowedNum.Size = new System.Drawing.Size(107, 21);
            this.rBorrowedNum.TabIndex = 6;
            this.rBorrowedNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numberInputOnly);
            // 
            // rname
            // 
            this.rname.Location = new System.Drawing.Point(108, 105);
            this.rname.Name = "rname";
            this.rname.Size = new System.Drawing.Size(107, 21);
            this.rname.TabIndex = 1;
            // 
            // rCurNum
            // 
            this.rCurNum.Location = new System.Drawing.Point(313, 74);
            this.rCurNum.Name = "rCurNum";
            this.rCurNum.Size = new System.Drawing.Size(107, 21);
            this.rCurNum.TabIndex = 5;
            this.rCurNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numberInputOnly);
            // 
            // borrowid
            // 
            this.borrowid.Location = new System.Drawing.Point(108, 71);
            this.borrowid.Name = "borrowid";
            this.borrowid.Size = new System.Drawing.Size(107, 21);
            this.borrowid.TabIndex = 0;
            // 
            // sex
            // 
            this.sex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sex.FormattingEnabled = true;
            this.sex.Items.AddRange(new object[] {
            "男",
            "女"});
            this.sex.Location = new System.Drawing.Point(108, 216);
            this.sex.Name = "sex";
            this.sex.Size = new System.Drawing.Size(107, 20);
            this.sex.TabIndex = 4;
            // 
            // confirm
            // 
            this.confirm.Location = new System.Drawing.Point(189, 276);
            this.confirm.Name = "confirm";
            this.confirm.Size = new System.Drawing.Size(75, 23);
            this.confirm.TabIndex = 18;
            this.confirm.Text = "确认";
            this.confirm.UseVisualStyleBackColor = true;
            this.confirm.Click += new System.EventHandler(this.confirm_Click);
            // 
            // ReaderEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 355);
            this.Controls.Add(this.confirm);
            this.Controls.Add(this.sex);
            this.Controls.Add(this.borrowid);
            this.Controls.Add(this.rCurNum);
            this.Controls.Add(this.rname);
            this.Controls.Add(this.rBorrowedNum);
            this.Controls.Add(this.job);
            this.Controls.Add(this.phone);
            this.Controls.Add(this.dept);
            this.Controls.Add(this.account);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ReaderEdit";
            this.Text = "读者编辑";
            this.Load += new System.EventHandler(this.ReaderEdit_Load);
            this.Shown += new System.EventHandler(this.ReaderEdit_Shown);
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
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox account;
        private System.Windows.Forms.TextBox dept;
        private System.Windows.Forms.TextBox phone;
        private System.Windows.Forms.TextBox job;
        private System.Windows.Forms.TextBox rBorrowedNum;
        private System.Windows.Forms.TextBox rname;
        private System.Windows.Forms.TextBox rCurNum;
        private System.Windows.Forms.TextBox borrowid;
        private System.Windows.Forms.ComboBox sex;
        private System.Windows.Forms.Button confirm;
    }
}