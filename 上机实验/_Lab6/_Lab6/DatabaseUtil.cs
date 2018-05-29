using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace _Lab6
{
    class DatabaseUtil
    {
        public SqlConnectionStringBuilder str;
        public SqlConnection conn;

        public SqlConnectionStringBuilder Str
        {
            get 
            {
                return str;    
            }
            set
            {
                if (value != null)
                    this.str = value;
                else
                    throw SqlException;
            }
        }

        public SqlConnection Conn
        {
            get
            {
                return conn;
            }
            set
            {
                if (value != null)
                    this.conn = value;
                else
                    throw SqlException;
            }
        }

        public DatabaseUtil()
        {

        }

    }
}
