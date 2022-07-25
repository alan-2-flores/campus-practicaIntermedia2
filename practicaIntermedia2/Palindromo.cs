using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practicaIntermedia2
{
    public class Palindromo
    {
        public bool EsPalindromo(string palabra) {
            Stack<char> stack = new Stack<char>(palabra.ToLower());
            string palabraReversed = "";

            foreach (char letra in stack)
            {
                palabraReversed = palabraReversed + letra;
            }

            if (palabra.ToLower()==palabraReversed)
                return true;

            return false;
        }
    }
}
