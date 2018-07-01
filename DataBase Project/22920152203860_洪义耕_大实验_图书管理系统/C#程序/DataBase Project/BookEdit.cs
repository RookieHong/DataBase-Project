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
    public partial class BookEdit : Form
    {
        public BookEdit()
        {
            InitializeComponent();
        }

        public main main
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public DbHelperSQL DbHelperSQL
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public string bookid;
        public string Optype;

        private void BookEdit_Load(object sender, EventArgs e)
        {
            this.available.SelectedItem = "是";//默认当前下拉框选项
            if (Optype.Equals("EDIT"))
            {
                getbookinfo(bookid);
            }
        }
        private void getbookinfo(string bookid)
        {
            string sql = "SELECT isbn,bname,pub,author,storeNum,bCurNum,available FROM books "
                + " WHERE isbn='" + bookid + "'";
            DataSet dataSet = DbHelperSQL.Query(sql);
            if (dataSet != null && dataSet.Tables[0].Rows.Count > 0)
            {
                this.isbn.Text = dataSet.Tables[0].Rows[0]["isbn"].ToString();
                this.bname.Text = dataSet.Tables[0].Rows[0]["bname"].ToString();
                this.pub.Text = dataSet.Tables[0].Rows[0]["pub"].ToString();
                this.author.Text = dataSet.Tables[0].Rows[0]["author"].ToString();
                this.storeNum.Text = dataSet.Tables[0].Rows[0]["storeNum"].ToString();
                this.bCurNum.Text = dataSet.Tables[0].Rows[0]["bCurNum"].ToString();
                this.available.SelectedItem = dataSet.Tables[0].Rows[0]["available"];
            }
        }

        private void booksubmit_Click(object sender, EventArgs e)
        {
            string sql = string.Empty;
            //this.available.SelectedIndex = 0;
            try
            {
                //新增调用
                if (Optype.Equals("ADD"))
                {
                    sql = "INSERT INTO [books]([isbn],[bname],[pub],[author],[storeNum],[bCurNum],[available]) VALUES(";
                    if (string.IsNullOrEmpty(this.isbn.Text.ToString()))
                    {
                        MessageBox.Show("书号不能为空");
                        return;
                    }
                    else
                    {
                        sql += "'" + this.isbn.Text.ToString() + "',";
                    }
                    if (string.IsNullOrEmpty(this.bname.Text.ToString()))
                    {
                        MessageBox.Show("书名不能为空");
                        return;
                    }
                    else
                    {
                        sql += "'" + this.bname.Text.ToString() + "',";
                    }
                    sql += "'" + this.pub.Text.ToString() + "',";
                    sql += "'" + this.author.Text.ToString() + "',";
                    //转换数值不加引号，待定
                    sql += this.storeNum.Text.ToString() + ",";
                    sql += this.bCurNum.Text.ToString() + ",";
                    sql += "'" + this.available.SelectedItem.ToString() + "'";
                    sql += ")";
                    DbHelperSQL.ExecuteSql(sql);
                }
                else
                //编辑调用
                {
                    sql = "UPDATE [books] SET ";
                    sql += "[isbn]='" + this.isbn.Text.ToString() + "',";
                    sql += "[bname]='" + this.bname.Text.ToString() + "',";
                    sql += "[pub]='" + this.pub.Text.ToString() + "',";
                    sql += "[author]='" + this.author.Text.ToString() + "',";
                    sql += "[storeNum]=" + this.storeNum.Text.ToString() + ",";
                    sql += "[bCurNum]=" + this.bCurNum.Text.ToString() + ",";
                    sql += "[available]='" + this.available.SelectedItem.ToString() + "'";
                    sql += " WHERE [isbn]='" + bookid + "'";
                    DbHelperSQL.ExecuteSql(sql);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            this.Close();
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

        private void BookEdit_Shown(object sender, EventArgs e)
        {
            if(Optype=="EDIT")
            {
                isbn.ReadOnly = true;
            }
        }
    }
}
