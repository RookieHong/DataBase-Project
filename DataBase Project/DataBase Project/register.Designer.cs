using System;

namespace DataBase_Project
{
    partial class register
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
            this.account = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.identity = new System.Windows.Forms.ComboBox();
            this.confirm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(121, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "账号";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(121, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "密码";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(121, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "身份";
            // 
            // account
            // 
            this.account.Location = new System.Drawing.Point(243, 47);
            this.account.Name = "account";
            this.account.Size = new System.Drawing.Size(100, 21);
            this.account.TabIndex = 3;
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(243, 96);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(100, 21);
            this.password.TabIndex = 4;
            this.password.UseSystemPasswordChar = true;
            // 
            // identity
            // 
            this.identity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.identity.FormattingEnabled = true;
            this.identity.Items.AddRange(new object[] {
            "管理员",
            "读者"});
            this.identity.Location = new System.Drawing.Point(243, 141);
            this.identity.Name = "identity";
            this.identity.Size = new System.Drawing.Size(121, 20);
            this.identity.TabIndex = 5;
            // 
            // confirm
            // 
            this.confirm.Location = new System.Drawing.Point(176, 196);
            this.confirm.Name = "confirm";
            this.confirm.Size = new System.Drawing.Size(75, 23);
            this.confirm.TabIndex = 6;
            this.confirm.Text = "注册";
            this.confirm.UseVisualStyleBackColor = true;
            this.confirm.Click += new System.EventHandler(this.confirm_Click);
            // 
            // register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 272);
            this.Controls.Add(this.confirm);
            this.Controls.Add(this.identity);
            this.Controls.Add(this.password);
            this.Controls.Add(this.account);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "register";
            this.Text = "注册";
            this.Load += new System.EventHandler(this.register_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox account;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.ComboBox identity;
        private System.Windows.Forms.Button confirm;
    }
}