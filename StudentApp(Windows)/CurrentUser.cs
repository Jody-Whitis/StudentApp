using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentApp_Windows_
{
    public static class CurrentUser
    {
        public static int sid;
        public static string lName;
        public static string fName;
        public static string username;
        public static string password;

        public static string Fname {
            get
            {
                return fName;
            }
            set
            {
                fName = value;
            }
        }



        public static string Lname { get; set; }

        public static string Password { get; set; }

        public static int Sid { get; set; }
        
        public static string Place { get; set; }



        public static int NewPort
        {
            get;set;
        }
    }
}
