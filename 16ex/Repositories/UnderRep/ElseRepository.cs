using _16ex.Contarcts;
using _16ex.Models.Action;
using _16ex.Models.Else;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16ex.Repositories.UnderRep
{
    internal class ElseRepository : IRepository
    {
        private IEnumerable<IModel> something;

        private static SqlConnection sqlconnection;

        
        public ElseRepository(IConnection smth)
        {
            SetConnection(smth);
        }


        public void Getter()
        {

            something = E136();
            Console.WriteLine("\n\nT136\n");
            GetActions();

        }

        private void GetActions()
        {
            foreach (IModel model in something)
            {
                model.Getter();
            }
        }

        public void SetConnection(IConnection con)
        {
            sqlconnection = con.Sqlconnection();
        }

        private static IEnumerable<IModel> E136()
        {

            var temp = sqlconnection.Query<E136>(@"SELECT person.Country FROM person UNION SELECT actions.Country FROM actions");

            return temp;

        }

        
    }
}
