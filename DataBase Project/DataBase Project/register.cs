using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace DataBase_Project
{
    public partial class register : Form
    {
        public register()
        {
            InitializeComponent();
        }

        private void register_Load(object sender, EventArgs e)
        {
            identity.SelectedIndex = 0;//初始一个默认项
        }

        private void confirm_Click(object sender, EventArgs e)
        {
            string inputAccount = account.Text.Trim();
            string inputPassword = password.Text;
            int inputIdentity = (identity.Text == "管理员") ? 0 : 1;

            if(String.IsNullOrEmpty(inputAccount)||String.IsNullOrEmpty(inputPassword))
            {
                if (MessageBox.Show("请先把信息填写完整！", "提示") == DialogResult.OK)
                    return;
            }

            string connectionString = "server=localhost;database=Library;uid=sa;pwd=123456";
            SqlConnection con = new SqlConnection(connectionString);

            //string addLoginSql = "create login " + inputAccount + " with password='" + inputPassword + "', default_database=Library";
            string addLoginSql = String.Format("create login {0} with password='{1}',default_database=Library",inputAccount,inputPassword);
            //string addUserSql = "EXEC sp_grantdbaccess '" + inputAccount + "','" + inputAccount + "'";
            string addUserSql = String.Format("EXEC sp_grantdbaccess '{0}','{1}'", inputAccount, inputAccount);
            string addRoleSql = "EXEC sp_addrolemember ";
            if (inputIdentity == 0) addRoleSql += "'admin'";
            else addRoleSql += "'reader'";
            addRoleSql = addRoleSql + ",'" + inputAccount + "'";
            string insertUserSql = String.Format("insert into users values('{0}','{1}','{2}')", inputAccount, inputPassword, identity.Text);

            SqlCommand addLoginCmd = new SqlCommand(addLoginSql, con);
            SqlCommand addUserCmd = new SqlCommand(addUserSql, con);
            SqlCommand addRoleCmd = new SqlCommand(addRoleSql, con);
            SqlCommand insertUserCmd = new SqlCommand(insertUserSql, con);

            string result = "注册成功！";

            try
            {
                con.Open();
                addLoginCmd.ExecuteNonQuery();
                addUserCmd.ExecuteNonQuery();
                addRoleCmd.ExecuteNonQuery();
                insertUserCmd.ExecuteNonQuery();
            }
            catch (SqlException exception)
            {
                //throw new Exception(exception.Message);
                result = exception.Message;
            }
            finally
            {
                addLoginCmd.Dispose();//对SqlCommand进行处理，回收
                addUserCmd.Dispose();
                addRoleCmd.Dispose();
                insertUserCmd.Dispose();
                con.Close();//连接关闭
                if (MessageBox.Show(result, "提示") == DialogResult.OK) this.Close();
            }
        }
    }
}
