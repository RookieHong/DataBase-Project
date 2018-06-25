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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void login_Load(object sender, EventArgs e)
        {
            identity.SelectedIndex = 0; //初始一个默认项
        }

        private void confirm_Click(object sender, EventArgs e)
        {
            switch(identity.SelectedIndex)
            {
                case 0:
                    Data.identity = loginStatus.Admin;
                    break;
                case 1:
                    Data.identity = loginStatus.Reader;
                    break;
            }

            main mainForm = new main();
            mainForm.Show();
        }

        private void register_Click(object sender, EventArgs e)
        {
            register registerForm = new register();
            registerForm.Show();
        }
    }
}
