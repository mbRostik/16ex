using _16ex.Contarcts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16ex.Models.Action
{
    internal class A134:IModel
    {
        private int id { get; set; }
        private string Country { get; set; }
        private DateTime DateStart { get; set; }
        private DateTime DateEnd { get; set; }

        public void Getter()
        {
            Console.WriteLine(id+" "+Country+" "+DateStart+" "+DateEnd);
        }
    }
}
