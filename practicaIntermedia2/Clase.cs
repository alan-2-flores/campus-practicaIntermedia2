using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practicaIntermedia2
{
    public class Clase
    {
        public int K { get; set; }
        public string Name { get; set; }
        public string Pass { get; set; }

        public Clase(int k, string name, string pass)
        {
            K = k;
            Name = name;
            Pass = pass;
        }
    }
}
