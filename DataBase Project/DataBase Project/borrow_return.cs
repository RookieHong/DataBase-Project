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
    public partial class borrow_return : Form
    {
        public borrow_return()
        {
            InitializeComponent();
        }

        private void borrow_return_Load(object sender, EventArgs e)
        {
            type.SelectedIndex = 0;
        }
    }
}
