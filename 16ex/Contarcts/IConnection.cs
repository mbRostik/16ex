using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Reflection.Metadata.Ecma335;

namespace _16ex.Contarcts
{
    internal interface IConnection
    {

        SqlConnection Sqlconnection();

    }
}
