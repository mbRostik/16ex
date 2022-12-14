using _16ex.Contarcts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16ex.Models.Rozdilu
{
    internal class P132 : IModel
    {
        public string email { get; set; } 
        public void Getter()
        {
            Console.WriteLine(email);
        }
    }
}
