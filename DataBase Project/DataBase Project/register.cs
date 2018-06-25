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

        private void confirm_Click(object sender, EventArgs e)
        {
            string connectionString = "server=localhost;database=Library;uid=sa;pwd=123456";
            SqlConnection con = new SqlConnection(connectionString);

            string inputAccount = account.Text;
            string inputPassword = password.Text;
            int inputIdentity = (identity.Text == "管理员") ? 0 : 1;

            string addLoginSql = "create login " + inputAccount + " with password='" + inputPassword + "', default_database=Library";
            string addUserSql = "EXEC sp_grantdbaccess '" + inputAccount + "','" + inputAccount + "'";
            string addRoleSql = "EXEC sp_addrolemember ";
            if (inputIdentity == 0) addRoleSql += "'admin'";
            else addRoleSql += "'reader'";
            addRoleSql = addRoleSql + ",'" + inputAccount + "'";

            SqlCommand addLoginCmd = new SqlCommand(addLoginSql, con);
            SqlCommand addUserCmd = new SqlCommand(addUserSql, con);
            SqlCommand addRoleCmd = new SqlCommand(addRoleSql, con);

            string result = "注册成功！";

            try
            {
                con.Open();
                addLoginCmd.ExecuteNonQuery();
                addUserCmd.ExecuteNonQuery();
                addRoleCmd.ExecuteNonQuery();

            }
            catch (SqlException exception)
            {
                //throw new Exception(exception.Message);
                result = exception.Message;
            }
            finally
            {
                addLoginCmd.Dispose();//对SqlCommand进行处理，回收
                addUserCmd.Dispose();//对SqlCommand进行处理，回收
                addRoleCmd.Dispose();//对SqlCommand进行处理，回收
                con.Close();//连接关闭
                if (MessageBox.Show(result, "提示") == DialogResult.OK) this.Close();
            }
        }
    }
}
