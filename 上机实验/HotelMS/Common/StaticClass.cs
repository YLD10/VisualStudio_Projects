using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Maticsoft.Common
{
    public class StaticClass
    {
        public static string _userType = "";
        public static string _userName = "";
        public static string _userID = "";
        public static string choose1 = "";
        public static string choose2 = "";

        public static string userType
        {
            get
            {
                return _userType;
            }
            set
            {
                _userType = value;
            }
        }

        public static string userName
        {
            get
            {
                return _userName;
            }
            set
            {
                _userName = value;
            }
        }

        public static string userID
        {
            get
            {
                return _userID;
            }
            set
            {
                _userID = value;
            }
        }
    }
}
