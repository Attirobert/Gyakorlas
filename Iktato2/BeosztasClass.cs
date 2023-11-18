using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iktato2
{
    internal class BeosztasClass
    {
        public int Beosztas_Id { get; set; }
        public string Beosztas { get; set; }

        public BeosztasClass(int beosztas_Id, string beosztas)
        {
            Beosztas_Id = beosztas_Id;
            Beosztas = beosztas;
        }
    }
}
