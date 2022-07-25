using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practicaIntermedia2
{
    public class Ordenamiento
    {
        public int[] ReverseWithQueue(int[] enteros) {
            Queue<int>queue=new Queue<int>(enteros);
            return queue.Reverse().ToArray();
        }

        public int[] ReverseWithList(int[] enteros)
        {
            List<int> list = new List<int>(enteros);
            list.Reverse();
            return list.ToArray();
        }

        public int[] ReverseWithDict(int[] enteros)
        {
            Dictionary<int, int> dictionary = new Dictionary<int, int>();
            foreach (var valor in enteros)
            {
                dictionary.Add(valor, valor);
            }
            return dictionary.Values.Reverse().ToArray();
        }
    }
}
