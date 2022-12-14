using _16ex.Contarcts;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16ex.SQLConnection
{
    internal class sqlConnect:IConnection
    {
        private static SqlConnection sqlconnection = new SqlConnection(@"Data Source=DESKTOP-F67DKTK\ROSTIK;Initial Catalog=16oop;Integrated Security=true");

        public sqlConnect()
        {
            OpenConnection();
        }

        public void OpenConnection()
        {
            if (sqlconnection.State == ConnectionState.Closed)
            {
                try
                {
                    sqlconnection.Open();
                }
                catch (Exception)
                {
                    Console.WriteLine("4toto ne to");
                }
            }
        }

        public void CloseConnection()
        {
            if (sqlconnection.State == ConnectionState.Open)
            {
                try
                {
                    sqlconnection.Close();
                }
                catch (Exception)
                {
                    Console.WriteLine("4toto ne to");
                }
            }
        }
        public SqlConnection Sqlconnection()
        {
            return sqlconnection;
        }
    }
}
