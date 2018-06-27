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

            string registerTran = String.Format(@"begin tran 
                                    SET XACT_ABORT ON 
                                    create login {0} with password='{1}', default_database=Library 
                                    create user {2} for login {3} 
                                    exec sp_addrolemember 'db_accessadmin', '{4}' 
                                    exec sp_addrolemember 'admin', '{5}' 
                                    insert into users values('{6}', '{7}', '{8}') 
                                    commit tran", 
                                    inputAccount, inputPassword, inputAccount, inputAccount, inputAccount, inputAccount, inputAccount, inputPassword, identity.Text);
            //string addLoginSql = "create login " + inputAccount + " with password='" + inputPassword + "', default_database=Library";
            //string addLoginSql = String.Format("create login {0} with password='{1}',default_database=Library",inputAccount,inputPassword);
            //string addUserSql = "EXEC sp_grantdbaccess '" + inputAccount + "','" + inputAccount + "'";
            //string addUserSql = String.Format("EXEC sp_grantdbaccess '{0}','{1}'", inputAccount, inputAccount);
            //string addRoleSql = "EXEC sp_addrolemember ";
            //if (inputIdentity == 0) addRoleSql += "'admin'";
            //else addRoleSql += "'reader'";
            //addRoleSql = addRoleSql + ",'" + inputAccount + "'";
            

            SqlCommand registerCmd = new SqlCommand(registerTran, con);
            //SqlCommand addLoginCmd = new SqlCommand(addLoginSql, con);
            //SqlCommand addUserCmd = new SqlCommand(addUserSql, con);
            //SqlCommand addRoleCmd = new SqlCommand(addRoleSql, con);

            //string result = "注册成功！";

            try
            {
                con.Open();
                registerCmd.ExecuteNonQuery();
                //addLoginCmd.ExecuteNonQuery();
                //addUserCmd.ExecuteNonQuery();
                //addRoleCmd.ExecuteNonQuery();
                //insertUserCmd.ExecuteNonQuery();
            }
            catch (SqlException exception)
            {
                //throw new Exception(exception.Message);
                if (MessageBox.Show(exception.Message, "错误") == DialogResult.OK)
                {
                    con.Close();
                    registerCmd.Dispose();
                    return;
                }
            }
            finally
            {
                registerCmd.Dispose(); //对SqlCommand进行处理，回收
                //addLoginCmd.Dispose();
                //addUserCmd.Dispose();
                //addRoleCmd.Dispose();
                //insertUserCmd.Dispose();
                //con.Close();//连接关闭
                //if (MessageBox.Show(result, "提示") == DialogResult.OK) this.Close();
            }

            string addSrvRole = String.Format("exec sp_addsrvrolemember '{0}', 'securityadmin'", inputAccount);
            SqlCommand addSrvRoleCmd = new SqlCommand(addSrvRole, con);
            try
            {
                addSrvRoleCmd.ExecuteNonQuery();
            }
            catch(SqlException exception)
            {
                if (MessageBox.Show(exception.Message, "错误") == DialogResult.OK)
                {
                    con.Close();
                    addSrvRoleCmd.Dispose();
                    return;
                }
            }

            if (MessageBox.Show("注册成功！", "提示") == DialogResult.OK)
            {
                con.Close();
                addSrvRoleCmd.Dispose();
            }
        }
    }
}
