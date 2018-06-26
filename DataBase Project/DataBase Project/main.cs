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
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        private void main_Load(object sender, EventArgs e)
        {
            //初始化默认值
            sex.SelectedIndex = 0;
            borrowable.SelectedIndex = 0;
            rCurNum.Text = "0";
            rBorrowedNum.Text = "0";

            //根据登录的身份隐藏/显示按钮
            switch(Data.identity)
            {
                case loginStatus.Admin:
                    borrowBook.Visible = false;
                    returnBook.Visible = false;
                    break;
                case loginStatus.Reader:
                    addReader.Visible = false;
                    deleteReader.Visible = false;
                    editReader.Visible = false;
                    addBook.Visible = false;
                    deleteBook.Visible = false;
                    editBook.Visible = false;
                    break;
            }
        }

        //只能输入数字的事件
        private void numberInputOnly(object sender, KeyPressEventArgs e)
        {
            if(Char.IsNumber(e.KeyChar)||e.KeyChar == 8)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void main_FormClosed(object sender, FormClosedEventArgs e)
        {
            Data.identity = loginStatus.Unlogin;
            Data.currentAccount = "";
            Data.currentPasswd = "";
            Data.currentConnection.Close();
            this.Owner.Show();
        }

        private void readerSearch_Click(object sender, EventArgs e)
        {
            string readerSearchSql =
                String.Format("select * from readers where borrowid like '%{0}%' and rname like '%{1}%' and sex='{2}' and job like '%{3}%' and rCurNum>={4} and rBorrowedNum>={5} and dept like '%{6}%' and phone like '%{7}%'",
                                borrowid.Text, rname.Text, sex.Text, job.Text, rCurNum.Text, rBorrowedNum.Text, dept.Text, phone.Text);
            SqlDataAdapter sda = new SqlDataAdapter(readerSearchSql, Data.currentConnection);
            DataSet result = new DataSet();

            try
            {
                sda.Fill(result, "readers");
            }
            catch(SqlException exception)
            {
                if (MessageBox.Show(exception.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error) == DialogResult.OK)
                {
                    sda.Dispose();
                    return;
                }
            }

            this.readerSearchResult.DataSource = result.Tables["readers"];
        }
    }
}
