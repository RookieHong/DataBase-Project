using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase_Project
{
    public enum loginStatus { Reader, Admin, Unlogin };
    class Data
    {
        public static loginStatus identity = loginStatus.Unlogin;
    }
}
