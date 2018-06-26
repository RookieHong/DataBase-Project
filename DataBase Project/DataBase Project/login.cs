using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DataBase_Project
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void login_Load(object sender, EventArgs e)
        {
            identity.SelectedIndex = 0; //初始一个默认项
        }

        private void confirm_Click(object sender, EventArgs e)
        {
            Data.currentConnection.ConnectionString = String.Format("server=localhost;database=Library;uid={0};pwd={1}", account.Text.Trim(), password.Text);
            try
            {
                Data.currentConnection.Open();
            }
            catch(InvalidOperationException exception)
            {
                if (MessageBox.Show(exception.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error) == DialogResult.OK)
                    return;
            }
            catch(SqlException exception)
            {
                if (MessageBox.Show(exception.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error) == DialogResult.OK)
                    return;
            }
            if (MessageBox.Show("登录成功！", "提示") == DialogResult.OK)
            {
                Data.currentAccount = account.Text.Trim();
                Data.currentPasswd = password.Text;

                switch (identity.SelectedIndex)
                {
                    case 0:
                        Data.identity = loginStatus.Admin;
                        break;
                    case 1:
                        Data.identity = loginStatus.Reader;
                        break;
                }

                main mainForm = new main();
                mainForm.Show(this);
                this.Hide();
            }
        }

        private void register_Click(object sender, EventArgs e)
        {
            register registerForm = new register();
            registerForm.Show();
        }
    }
}
