using _16ex.Contarcts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16ex.Models.Person
{
    internal class P135:IModel
    {
        private string Town { get; set; }

        public void Getter()
        {
            Console.WriteLine(Town);
        }
    }
}
