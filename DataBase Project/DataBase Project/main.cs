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
            bookBorrowCount.Text = "0";
            bookTotalCount.Text = "0";
            //根据登录的身份隐藏/显示按钮
            switch (PubConstant.identity)
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

        private void main_FormClosed(object sender, FormClosedEventArgs e)
        {
            PubConstant.identity = loginStatus.Unlogin;
            PubConstant.currentAccount = "";
            PubConstant.currentPasswd = "";
            PubConstant.currentConnection.Close();
            this.Owner.Show();
        }

        private void readerSearch_Click(object sender, EventArgs e)
        {
            string readerSearchSql =
                String.Format("select * from readers where borrowid like '%{0}%' and rname like '%{1}%' and sex='{2}' and job like '%{3}%' and rCurNum>={4} and rBorrowedNum>={5} and dept like '%{6}%' and phone like '%{7}%'",
                                borrowid.Text, rname.Text, sex.Text, job.Text, rCurNum.Text, rBorrowedNum.Text, dept.Text, phone.Text);
            DataSet result = DbHelperSQL.Query(readerSearchSql);

            this.readerSearchResult.DataSource = result.Tables["ds"];
        }

        private void bookSearch_Click(object sender, EventArgs e)
        {
            string bookSearchSql =
                String.Format("select * from books where isbn like '%{0}%' and bname like '%{1}%' and pub like '%{2}%' and author like '%{3}%' and bCurNum>={4} and storeNum>={5} and available='{6}'",
                                bookID.Text, bookName.Text, press.Text, author.Text, bookBorrowCount.Text, bookTotalCount.Text, borrowable.Text);
            DataSet result = DbHelperSQL.Query(bookSearchSql);

            this.bookSearchResult.DataSource = result.Tables["ds"];
        }

        private void deleteBook_Click(object sender, EventArgs e)
        {
            try
            {
                int index = bookSearchResult.CurrentRow.Index;//获取当前选中行
                //MessageBox.Show(a.ToString());
                string isbn = bookSearchResult.Rows[index].Cells[0].Value.ToString().Trim();
                //获取该行第0列数据
                string sql = "delete from books where isbn='" + isbn + "'";
                //确认是否删除
                if (DialogResult.Yes == MessageBox.Show("确定要删除该记录", "警告", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1))
                {
                    //SQL删除语句字符串
                    if (DbHelperSQL.ExecuteSql(sql) > 0) //向源数据库传递SQL命令字符串，得到删除结果
                    {
                        MessageBox.Show("删除成功");
                        bookSearchResult.Rows.RemoveAt(index);
                    }
                    else
                    {
                        MessageBox.Show("删除失败");
                    }
                }
            }
            catch (NullReferenceException exception)
            {
                MessageBox.Show("请先选中一行！");
                return;
            }
        }

        private void deleteReader_Click(object sender, EventArgs e)
        {
            try
            {
                int index = readerSearchResult.CurrentRow.Index;//获取当前选中行
                string account = readerSearchResult.Rows[index].Cells[8].Value.ToString().Trim();
                string deleteReaderTran = String.Format(@"exec sp_droplogin '{0}' 
                                    exec sp_dropuser '{1}'
                                    delete from users where account='{2}'", account, account, account);
                if (DialogResult.Yes == MessageBox.Show("确定要删除该记录", "警告", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1))
                {
                    //SQL删除语句字符串
                    if (DbHelperSQL.ExecuteSql(deleteReaderTran) > 0) //向源数据库传递SQL命令字符串，得到删除结果
                    {
                        MessageBox.Show("删除成功");
                        readerSearchResult.Rows.RemoveAt(index);
                    }
                    else
                    {
                        MessageBox.Show("删除失败");
                    }
                }
            }
            catch (NullReferenceException exception)
            {
                MessageBox.Show("请先选中一行！");
                return;
            }
        }

        private void addReader_Click(object sender, EventArgs e)
        {

        }

        private void addBook_Click(object sender, EventArgs e)
        {
            BookEdit formEdit = new BookEdit();
            formEdit.Text = "图书信息添加";
            formEdit.Optype = "ADD";
            formEdit.ShowDialog();
            //查询语句
            string bookSearchSql =
                String.Format("select * from books where isbn like '%{0}%' and bname like '%{1}%' and pub like '%{2}%' and author like '%{3}%' and bCurNum>={4} and storeNum>={5} and available='{6}'",
                                bookID.Text, bookName.Text, press.Text, author.Text, bookBorrowCount.Text, bookTotalCount.Text, borrowable.Text);
            DataSet result = DbHelperSQL.Query(bookSearchSql);

            this.bookSearchResult.DataSource = result.Tables["ds"];
        }

        private void editBook_Click(object sender, EventArgs e)
        {

            int index = -1;
            index = bookSearchResult.CurrentRow.Index;//获取当前选中行
            if (index == -1)
            {
                MessageBox.Show("请选择要编辑的行");
                return;
            }
            BookEdit formEdit = new BookEdit();
            formEdit.Text = "图书信息修改";
            formEdit.Optype = "EDIT";
            formEdit.bookid = bookSearchResult.Rows[index].Cells[0].Value.ToString().Trim();//获取第0列(isbn）数据
            formEdit.ShowDialog();
            //查询语句
            string bookSearchSql =
                String.Format("select * from books where isbn like '%{0}%' and bname like '%{1}%' and pub like '%{2}%' and author like '%{3}%' and bCurNum>={4} and storeNum>={5} and available='{6}'",
                                bookID.Text, bookName.Text, press.Text, author.Text, bookBorrowCount.Text, bookTotalCount.Text, borrowable.Text);
            DataSet result = DbHelperSQL.Query(bookSearchSql);

            this.bookSearchResult.DataSource = result.Tables["ds"];
        }
    }
}
