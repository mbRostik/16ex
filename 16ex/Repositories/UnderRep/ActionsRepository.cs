using _16ex.Contarcts;
using _16ex.Models.Rozdilu;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using _16ex.Models.Action;

namespace _16ex.Repositories.UnderRep
{
    internal class ActionsRepository : IRepository
    {
        private IEnumerable<IModel> actions;

        private static SqlConnection sqlconnection;


        public ActionsRepository(IConnection smth)
        {
            SetConnection(smth);
        }
        public void Getter()
        {

            actions = T134();
            Console.WriteLine("\n\nT134\n");
            GetActions();



            Console.WriteLine("\n\nT143\n");
            actions = T143();
            
            GetActions();

        }

        private void GetActions()
        {
            foreach (IModel model in actions)
            {
                model.Getter();
            }
        }

        public void SetConnection(IConnection con)
        {
            sqlconnection = con.Sqlconnection();
        }

        private static IEnumerable<A134> T134()
        {

            var temp = sqlconnection.Query<A134>(@"SELECT * FROM actions");

            return temp;

        }

        private static IEnumerable<IModel> T143()
        {
            Console.WriteLine("Vvedit Country (Actions): ");
            var name = Console.ReadLine();
            var temp = sqlconnection.Query<A134>(@"SELECT * FROM actions WHERE Country=@name", new { name });

            return temp;

        }
    }
}
