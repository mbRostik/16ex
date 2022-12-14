using _16ex.Contarcts;
using _16ex.Models;
using _16ex.Models.Rozdilu;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16ex.Repositories.UnderRep
{
    internal class RozdiluRepository : IRepository
    {
        private IEnumerable<IModel> rozdilu;

        private static SqlConnection sqlconnection;


        public RozdiluRepository (IConnection smth)
        {
            SetConnection(smth);
        }
        public void Getter()
        {


            rozdilu = T133();
            Console.WriteLine("\n\nT133\n");
            GetRozdil();



            Console.WriteLine("\n\nT221\n");
            T221();


            Console.WriteLine("\n\nT223\n");
            T223();
        }

        private void GetRozdil()
        {
            foreach (IModel model in rozdilu)
            {
                model.Getter();
            }
        }

        public void SetConnection(IConnection con)
        {
            sqlconnection = con.Sqlconnection();
        }

        private static IEnumerable<R133> T133()
        {

            var temp = sqlconnection.Query<R133>(@"SELECT * FROM rozdilu");

            return temp;

        }


        private static void T221()
        {
            SqlCommand command = new SqlCommand("sp_221", sqlconnection);

            command.CommandType = System.Data.CommandType.StoredProcedure;

            ForSecPart(command);

        }


        private static void T223()
        {
            SqlCommand command = new SqlCommand("sp_223", sqlconnection);

            command.CommandType = System.Data.CommandType.StoredProcedure;

            DateTime a = DateTime.Parse(Console.ReadLine());

            SqlParameter nameParam = new SqlParameter
            {
                ParameterName = "@timestart",
                Value = a
            };

            command.Parameters.Add(nameParam);

            a = DateTime.Parse(Console.ReadLine());

            SqlParameter nameParam2 = new SqlParameter
            {
                ParameterName = "@timeend",
                Value = a
            };
            Console.WriteLine();
            command.Parameters.Add(nameParam2);

            ForSecPart(command);

        }

        private static async Task ForSecPart(SqlCommand command)
        {
            var temp = command.ExecuteReader();

            while (temp.Read())
            {
                for (int i = 0; i != temp.FieldCount; i++)
                {
                    Console.Write(temp[i] + " ");
                }
                Console.WriteLine();
            }
            temp.Close();
        }
    }
}
