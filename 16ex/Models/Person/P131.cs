using _16ex.Contarcts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16ex.Models.Rozdilu
{
    internal class P131:IModel
    {
        private int ID { get; set; }
        private string Name { get; set; }
        private DateTime DataOfBith { get; set; }
        private string email { get; set; }
        private string Country { get; set; }
        private string Town { get; set; }

        public void Getter()
        {
            Console.WriteLine(ID+" "+Name+" "+DataOfBith+" "+email+" "+Country+" "+Town);
        }
    }
}
