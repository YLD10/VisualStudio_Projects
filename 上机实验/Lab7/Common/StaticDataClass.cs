using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Maticsoft.Common
{
    public sealed class StaticDataClass
    {
        private static string _userType = null;
        private static string _loginStudentID = null;
        private static string _loginTeacherID = null;
        private static Maticsoft.Model.Administrators _admin = new Maticsoft.Model.Administrators();
        private static Maticsoft.Model.Students _student = new Maticsoft.Model.Students();
        private static Maticsoft.Model.Teachers _teacher = new Maticsoft.Model.Teachers();
        private static Maticsoft.Model.Courses _course = new Maticsoft.Model.Courses();
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
        public static string loginStudentID
        {
            get
            {
                return _loginStudentID;
            }
            set
            {
                _loginStudentID = value;
            }
        }
        public static string loginTeacherID
        {
            get
            {
                return _loginTeacherID;
            }
            set
            {
                _loginTeacherID = value;
            }
        }
        public static Maticsoft.Model.Administrators admin
        {
            get
            {
                return _admin;
            }
            set
            {
                _admin = value;
            }
        }
        public static Maticsoft.Model.Students student
        {
            get
            {
                return _student;
            }
            set
            {
                _student = value;
            }
        }
        public static Maticsoft.Model.Teachers teacher
        {
            get
            {
                return _teacher;
            }
            set
            {
                _teacher = value;
            }
        }
        public static Maticsoft.Model.Courses course
        {
            get
            {
                return _course;
            }
            set
            {
                _course = value;
            }
        }
    }
}
