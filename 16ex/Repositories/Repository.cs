using _16ex.Contarcts;
using _16ex.Models.Rozdilu;
using _16ex.Repositories.UnderRep;
using _16ex.SQLConnection;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16ex.Repositories
{
    internal class Repository
    {
        private static sqlConnect ourcon=new sqlConnect();

        private PersonRepository persons=new PersonRepository(ourcon);
        
        private RozdiluRepository rozdils = new RozdiluRepository(ourcon);

        private ActionsRepository actions = new ActionsRepository(ourcon);

        private ElseRepository others = new ElseRepository(ourcon);
        public void Getter()
        {
            persons.Getter();

            rozdils.Getter();

            actions.Getter();

            others.Getter();
        }
    }
}
