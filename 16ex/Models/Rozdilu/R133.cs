using _16ex.Contarcts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16ex.Models.Rozdilu
{
    internal class R133 : IModel
    {
        public int ID { get; set; }
        private string Name { get; set; }

        public void Getter()
        {
            Console.WriteLine(ID+" "+Name);
        }
    }
}
