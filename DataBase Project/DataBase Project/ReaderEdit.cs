using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBase_Project
{
    public partial class ReaderEdit : Form
    {
        public string opType;
        public ReaderEdit()
        {
            InitializeComponent();
        }

        public ReaderEdit(string inputborrowid,string inputrname,string inputrCurNum, string inputrBorrowedNum, string inputjob, string inputphone, string inputdept, 
                            string inputaccount, string inputsex)
        {
            InitializeComponent();

            //获取在main中选中的各字段信息显示在文本框中
            borrowid.Text = inputborrowid;
            rname.Text = inputrname;
            rCurNum.Text = inputrCurNum;
            rBorrowedNum.Text = inputrBorrowedNum;
            job.Text = inputjob;
            phone.Text = inputphone;
            dept.Text = inputdept;
            account.Text = inputaccount;
            sex.Text = inputsex;
        }

        private void ReaderEdit_Load(object sender, EventArgs e)
        {
            sex.SelectedIndex = 0;
        }

        private void confirm_Click(object sender, EventArgs e)
        {
            string sql = "";
            try
            {
                if(opType=="EDIT")
                {
                    sql = String.Format(@"update readers 
                                        set rname='{0}',rCurNum={1},rBorrowedNum={2},job='{3}',phone='{4}',dept='{5}',account='{6}',sex='{7}'
                                        where borrowid='{8}'",
                                        rname.Text.Trim(), rCurNum.Text, rBorrowedNum.Text, job.Text, phone.Text, dept.Text.Trim(), account.Text.Trim(),
                                        sex.Text, borrowid.Text);
                    DbHelperSQL.ExecuteSql(sql);
                }
                else
                {
                    sql = String.Format(@"insert into readers 
                                        values('{0}','{1}','{2}','{3}',{4},{5},'{6}','{7}','{8}')",
                                        borrowid.Text.Trim(), rname.Text.Trim(), sex.Text, job.Text.Trim(), rCurNum.Text, rBorrowedNum.Text, dept.Text, phone.Text.Trim(), 
                                        account.Text.Trim());
                    DbHelperSQL.ExecuteSql(sql);
                }
            }
            catch(Exception exception)
            {
                MessageBox.Show(exception.Message);
                return;
            }
            this.Close();
        }

        private void ReaderEdit_Shown(object sender, EventArgs e)
        {
            if(opType=="EDIT")
            {
                borrowid.ReadOnly = true;
            }
        }

        private void numberInputOnly(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar) || e.KeyChar == 8)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
    }
}
