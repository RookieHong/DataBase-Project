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
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        private void main_Load(object sender, EventArgs e)
        {
            //初始化comboBox的选项
            sex.SelectedIndex = 0;
            borrowable.SelectedIndex = 0;

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
    }
}
