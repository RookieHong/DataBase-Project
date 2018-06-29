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
                string deleteReaderSql = String.Format(@"exec sp_droplogin '{0}' 
                                    exec sp_dropuser '{1}'
                                    delete from users where account='{2}'", account, account, account);
                if (DialogResult.Yes == MessageBox.Show("确定要删除该记录", "警告", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1))
                {
                    //SQL删除语句字符串
                    if (DbHelperSQL.ExecuteSql(deleteReaderSql) > 0) //向源数据库传递SQL命令字符串，得到删除结果
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
            ReaderEdit readerEditForm = new ReaderEdit();
            readerEditForm.Text = "读者信息添加";
            readerEditForm.opType = "ADD";
            readerEditForm.ShowDialog();
            readerEditForm.Dispose();

            //刷新读者查询的结果
            string readerSearchSql =
            String.Format("select * from readers where borrowid like '%{0}%' and rname like '%{1}%' and sex='{2}' and job like '%{3}%' and rCurNum>={4} and rBorrowedNum>={5} and dept like '%{6}%' and phone like '%{7}%'",
                            borrowid.Text, rname.Text, sex.Text, job.Text, rCurNum.Text, rBorrowedNum.Text, dept.Text, phone.Text);
            DataSet result = DbHelperSQL.Query(readerSearchSql);

            this.readerSearchResult.DataSource = result.Tables["ds"];
        }

        private void addBook_Click(object sender, EventArgs e)
        {
            BookEdit formEdit = new BookEdit();
            formEdit.Text = "图书信息添加";
            formEdit.Optype = "ADD";
            formEdit.ShowDialog();
            formEdit.Dispose();
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
            formEdit.Dispose();
            //查询语句
            string bookSearchSql =
                String.Format("select * from books where isbn like '%{0}%' and bname like '%{1}%' and pub like '%{2}%' and author like '%{3}%' and bCurNum>={4} and storeNum>={5} and available='{6}'",
                                bookID.Text, bookName.Text, press.Text, author.Text, bookBorrowCount.Text, bookTotalCount.Text, borrowable.Text);
            DataSet result = DbHelperSQL.Query(bookSearchSql);

            this.bookSearchResult.DataSource = result.Tables["ds"];
        }

        private void editReader_Click(object sender, EventArgs e)
        {
            try
            {
                int index = readerSearchResult.CurrentRow.Index;
                string inputborrowid = readerSearchResult.Rows[index].Cells[0].Value.ToString().Trim();
                string inputrname = readerSearchResult.Rows[index].Cells[1].Value.ToString().Trim();
                string inputsex = readerSearchResult.Rows[index].Cells[2].Value.ToString().Trim();
                string inputjob = readerSearchResult.Rows[index].Cells[3].Value.ToString().Trim();
                string inputrCurNum = readerSearchResult.Rows[index].Cells[4].Value.ToString().Trim();
                string inputrBorrowedNum = readerSearchResult.Rows[index].Cells[5].Value.ToString().Trim();
                string inputdept = readerSearchResult.Rows[index].Cells[6].Value.ToString().Trim();
                string inputphone = readerSearchResult.Rows[index].Cells[7].Value.ToString().Trim();
                string inputaccount = readerSearchResult.Rows[index].Cells[8].Value.ToString().Trim();

                ReaderEdit readerEditForm = new ReaderEdit(inputborrowid,inputrname,inputrCurNum,inputrBorrowedNum,inputjob,inputphone,inputdept,inputaccount,inputsex);
                readerEditForm.Text = "读者信息编辑";
                readerEditForm.opType = "EDIT";
                readerEditForm.ShowDialog();
                readerEditForm.Dispose();

                //刷新读者查询的结果
                string readerSearchSql =
                String.Format("select * from readers where borrowid like '%{0}%' and rname like '%{1}%' and sex='{2}' and job like '%{3}%' and rCurNum>={4} and rBorrowedNum>={5} and dept like '%{6}%' and phone like '%{7}%'",
                                borrowid.Text, rname.Text, sex.Text, job.Text, rCurNum.Text, rBorrowedNum.Text, dept.Text, phone.Text);
                DataSet result = DbHelperSQL.Query(readerSearchSql);

                this.readerSearchResult.DataSource = result.Tables["ds"];
            }
            catch (NullReferenceException exception)
            {
                MessageBox.Show("请先选中一行！");
                return;
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

        private void borrowBook_Click(object sender, EventArgs e)
        {
            string sql, readerID;
            sql = String.Format("select borrowid from readers where account='{0}'", PubConstant.currentAccount);
            DataSet result = DbHelperSQL.Query(sql);
            readerID = result.Tables["ds"].Rows[0]["borrowid"].ToString();
            try
            {
                int index = bookSearchResult.CurrentRow.Index;
                string inputIsbn = bookSearchResult.Rows[index].Cells[0].Value.ToString().Trim();

                sql = String.Format("insert into rb values('{0}','{1}','{2}',{3},'{4}',{5})", 
                                    readerID, inputIsbn, DateTime.Now.ToString("yyyy-MM-dd"), 30, DateTime.Now.AddDays(30).ToString("yyyy-MM-dd"), 30);

                if (DialogResult.Yes == MessageBox.Show("确定借书？", "警告", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1))
                {
                    //SQL借书语句字符串
                    if (DbHelperSQL.ExecuteSql(sql) > 0) //向源数据库传递SQL命令字符串，得到借书结果
                    {
                        MessageBox.Show("借书成功");

                        //查询语句
                        string bookSearchSql =
                            String.Format("select * from books where isbn like '%{0}%' and bname like '%{1}%' and pub like '%{2}%' and author like '%{3}%' and bCurNum>={4} and storeNum>={5} and available='{6}'",
                                            bookID.Text, bookName.Text, press.Text, author.Text, bookBorrowCount.Text, bookTotalCount.Text, borrowable.Text);
                        result = DbHelperSQL.Query(bookSearchSql);

                        this.bookSearchResult.DataSource = result.Tables["ds"];
                    }
                    else
                    {
                        MessageBox.Show("借书失败");
                    }
                }
            }
            catch (NullReferenceException exception)
            {
                MessageBox.Show("请先选中一行！");
                return;
            }
            catch(Exception exception)
            {
                MessageBox.Show(exception.Message);
                if(exception.Message== "该读者当前还有未还书籍，不能借书!")
                {
                    sql = String.Format(@"select bname,sum(fine) fineSum 
                                        from books,rb 
                                        where returnDate<'{0}' and borrowid='{1}' 
                                        group by borrowid,bname",
                                        DateTime.Now.ToString("yyyy-MM-dd"), readerID);
                    result = DbHelperSQL.Query(sql);
                    string message = "您当前未还的书籍有：\r\n";
                    int fineSum = 0;
                    foreach(DataRow row in result.Tables["ds"].Rows)
                    {
                        message += row["bname"].ToString() + "\r\n";
                        fineSum += int.Parse(row["fineSum"].ToString());
                    }
                    if (DialogResult.Yes == MessageBox.Show(message + "为这些书籍交纳罚款？\r\n罚款总和为：" + fineSum.ToString(), "警告", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1))
                    {
                        sql = String.Format(@"delete from rb
                                            where returnDate<'{0}' and borrowid='{1}'",
                                            DateTime.Now.ToString("yyyy-MM-dd"), readerID);
                        if (DbHelperSQL.ExecuteSql(sql) > 0)
                        {
                            MessageBox.Show("交纳罚款成功！");
                        }
                        else
                        {
                            MessageBox.Show("交纳罚款失败！");
                        }
                    }
                }
                return;
            }
        }

        private void returnBook_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = String.Format("select borrowid from readers where account='{0}'", PubConstant.currentAccount);
                DataSet result = DbHelperSQL.Query(sql);
                string readerID = result.Tables["ds"].Rows[0]["borrowid"].ToString();

                int index = bookSearchResult.CurrentRow.Index;
                string inputIsbn = bookSearchResult.Rows[index].Cells[0].Value.ToString().Trim();

                sql = String.Format("delete from rb where borrowid='{0}' and isbn='{1}'", readerID, inputIsbn);

                if (DialogResult.Yes == MessageBox.Show("确定借书？", "警告", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1))
                {
                    //SQL还书语句字符串
                    if (DbHelperSQL.ExecuteSql(sql) > 0) //向源数据库传递SQL命令字符串，得到还书结果
                    {
                        MessageBox.Show("还书成功");

                        //查询语句
                        string bookSearchSql =
                            String.Format("select * from books where isbn like '%{0}%' and bname like '%{1}%' and pub like '%{2}%' and author like '%{3}%' and bCurNum>={4} and storeNum>={5} and available='{6}'",
                                            bookID.Text, bookName.Text, press.Text, author.Text, bookBorrowCount.Text, bookTotalCount.Text, borrowable.Text);
                        result = DbHelperSQL.Query(bookSearchSql);

                        this.bookSearchResult.DataSource = result.Tables["ds"];
                    }
                    else
                    {
                        MessageBox.Show("你没有借过这本书！");
                    }
                }
            }
            catch (NullReferenceException exception)
            {
                MessageBox.Show("请先选中一行！");
                return;
            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.Message);
                return;
            }
        }

        private void delayedBookSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = string.Format("select * from rb where returnDate<'{0}'", DateTime.Now.ToString("yyyy-MM-dd"));
                DataSet result = DbHelperSQL.Query(sql);
                this.delayedbookSearchResult.DataSource = result.Tables["ds"];
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }
    }
}
