using _16ex.Contarcts;
using _16ex.Models.Person;
using _16ex.Models.Rozdilu;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _16ex.Repositories.UnderRep
{
    internal class PersonRepository : IRepository
    {
        private IEnumerable<IModel> all;

        private static SqlConnection sqlconnection;


        public PersonRepository(IConnection smth)
        {
            SetConnection(smth);
        }
        public void Getter()
        {
            all = T131();
            Console.WriteLine("T131\n");
            GetPersons();

            all = T132();
            Console.WriteLine("\n\nT132\n");
            GetPersons();

            all = T135();
            Console.WriteLine("\n\nT135\n");
            GetPersons();

            Console.WriteLine("\n\nT141\n");
            all = T141();
            GetPersons();

            Console.WriteLine("\n\nT142\n");
            all = T142();
            GetPersons();


            Console.WriteLine("\n\nT211\n");
            T211();

            Console.WriteLine("\n\nT212\n");
            T212();

            Console.WriteLine("\n\nT213\n");
            T213();



            Console.WriteLine("\n\nT224\n");
            T224();


            Console.WriteLine("\n\nT231\n");
            T231();

            Console.WriteLine("\n\nT231\n");
            T232();

            Console.WriteLine("\n\nT233\n");
            T233();

            Console.WriteLine("\n\nT234\n");
            T234();
        }

        private void GetPersons()
        {
            foreach (IModel model in all)
            {
                model.Getter();
            }
        }
        public void SetConnection(IConnection con)
        {
            sqlconnection = con.Sqlconnection();
        }




        private static IEnumerable<IModel> T131()
        {

            var temp = sqlconnection.Query<P131>(@"SELECT* FROM person");

            return temp;

        }

        private static IEnumerable<IModel> T132()
        {

            var temp = sqlconnection.Query<P132>(@"SELECT email FROM person");

            return temp;

        }

        private static IEnumerable<IModel> T135()
        {

            var temp = sqlconnection.Query<P135>(@"SELECT Town FROM person GROUP BY Town");

            return temp;

        }


        private static IEnumerable<IModel> T141()
        {
            Console.WriteLine("Vvedit town: ");
            var name = Console.ReadLine();
            var temp = sqlconnection.Query<P131>(@"SELECT * FROM person WHERE Town=@name", new { name });

            return temp;

        }

        private static IEnumerable<IModel> T142()
        {
            Console.WriteLine("Vvedit Country: ");
            var name = Console.ReadLine();
            var temp = sqlconnection.Query<P131>(@"SELECT * FROM person WHERE Country=@name", new { name });

            return temp;

        }


        private static void T211()
        {
            SqlCommand command = new SqlCommand("sp_211", sqlconnection);

            command.CommandType = System.Data.CommandType.StoredProcedure;


            ForSecPart(command);


        }

        private static void T212()
        {
            SqlCommand command = new SqlCommand("sp_212", sqlconnection);

            command.CommandType = System.Data.CommandType.StoredProcedure;

            ForSecPart(command);

        }

        private static void T213()
        {
            SqlCommand command = new SqlCommand("sp_213", sqlconnection);

            command.CommandType = System.Data.CommandType.StoredProcedure;

            ForSecPart(command);

        }


        private static void T224()
        {
            SqlCommand command = new SqlCommand("sp_224", sqlconnection);

            command.CommandType = System.Data.CommandType.StoredProcedure;

            string name = Console.ReadLine();
            SqlParameter nameParam = new SqlParameter
            {
                ParameterName = "@name",
                Value = name
            };

            command.Parameters.Add(nameParam);

            ForSecPart(command);

        }

        private static void T231()
        {
            SqlCommand command = new SqlCommand("sp_231", sqlconnection);

            command.CommandType = System.Data.CommandType.StoredProcedure;


            ForSecPart(command);

        }

        private static void T232()
        {
            SqlCommand command = new SqlCommand("sp_232", sqlconnection);

            command.CommandType = System.Data.CommandType.StoredProcedure;


            ForSecPart(command);

        }

        private static void T233()
        {
            SqlCommand command = new SqlCommand("sp_233", sqlconnection);

            command.CommandType = System.Data.CommandType.StoredProcedure;


            ForSecPart(command);

        }

        private static void T234()
        {
            SqlCommand command = new SqlCommand("sp_234", sqlconnection);

            command.CommandType = System.Data.CommandType.StoredProcedure;


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