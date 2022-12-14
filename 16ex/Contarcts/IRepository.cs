using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16ex.Contarcts
{
    internal interface IRepository
    {
        void Getter();

        void SetConnection(IConnection con);
    }
}
