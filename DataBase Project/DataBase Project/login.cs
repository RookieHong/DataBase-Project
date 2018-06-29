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
using static DataBase_Project.PubConstant;

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
            
        }

        private void confirm_Click(object sender, EventArgs e)
        {
            PubConstant.currentConnection.ConnectionString = String.Format("server=localhost;database=Library;uid={0};pwd={1}", account.Text.Trim(), password.Text);
            try
            {
                PubConstant.currentConnection.Open();
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
            string sql = String.Format("select id from users where account='{0}'", account.Text.Trim());
            DataSet result = DbHelperSQL.Query(sql);
            string loginId = result.Tables["ds"].Rows[0]["id"].ToString();
            if (MessageBox.Show("登录成功！", "提示") == DialogResult.OK)
            {
                PubConstant.currentAccount = account.Text.Trim();
                PubConstant.currentPasswd = password.Text;

                switch (loginId)
                {
                    case "管理员":
                        PubConstant.identity = loginStatus.Admin;
                        break;
                    case "读者":
                        PubConstant.identity = loginStatus.Reader;
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
