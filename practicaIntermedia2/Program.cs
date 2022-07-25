using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practicaIntermedia2
{
    internal class Program
    {
        static void Main()
        {
            //Parte 1
            List<Tuple<int,int>> listaEnteros = new List<Tuple<int,int>>();
            listaEnteros.Add(Tuple.Create(1,2));
            listaEnteros.Add(Tuple.Create(3,4));
            listaEnteros.Add(Tuple.Create(5,6));
            Console.WriteLine($"lista enteros {listaEnteros[0]} {listaEnteros[1]} {listaEnteros[2]}");

            List<(string Name, string Kind, int Replica, bool Run)> listaDatos = new List<(string Name, string Kind, int Replica, bool Run)>();
            listaDatos.Add(("Patrick","pinguino",2,false));
            listaDatos.Add(("Samsung","telefono",15000000,true));
            listaDatos.Add(("ThinkPad","computadora",2000000,true));
            Console.WriteLine($"lista datos {listaDatos[0]} {listaDatos[1]} {listaDatos[2]}");
            Console.ReadKey();

            //Parte 2
            Clase[] clases = new Clase[1000000];
            Structura[] structuras = new Structura[1000000];
            Stopwatch stopwatch = new Stopwatch();

            stopwatch.Start();
            for (int k = 0; k < 1000000; k++)
            {
                clases[k]= new Clase(k, "name", "pass");
            }
            stopwatch.Stop();
            Console.WriteLine($"Tiempo Class: {stopwatch.ElapsedMilliseconds} ms");

            stopwatch.Restart();
            for (int k = 0; k < 1000000; k++)
            {
                structuras[k] = new Structura(k, "name", "pass");
            }
            stopwatch.Stop();
            Console.WriteLine($"Tiempo Struct: {stopwatch.ElapsedMilliseconds} ms");

            Console.ReadKey();

            //Parte 3
            int[] enteros = new int[1000000];
            for (int i = 0; i < enteros.Length; i++)
            {
                enteros[i] = i;
            }
            Ordenamiento ordenamiento = new Ordenamiento();

            stopwatch.Restart();
            int[] ordenados = ordenamiento.ReverseWithQueue(enteros);
            stopwatch.Stop();
            Console.WriteLine($"tiempo de ordenamiento Queue: {stopwatch.ElapsedMilliseconds} ms {ordenados[0]}");

            stopwatch.Restart();
            ordenados = ordenamiento.ReverseWithList(enteros);
            stopwatch.Stop();
            Console.WriteLine($"tiempo de ordenamiento List: {stopwatch.ElapsedMilliseconds} ms {ordenados[0]}");

            stopwatch.Restart();
            ordenados = ordenamiento.ReverseWithDict(enteros);
            stopwatch.Stop();
            Console.WriteLine($"tiempo de ordenamiento Diccionario: {stopwatch.ElapsedMilliseconds} ms {ordenados[0]}");

            Console.ReadKey();

            //Parte 4
            Palindromo palindromo = new Palindromo();
            Console.WriteLine($"Es palindromo: {palindromo.EsPalindromo("Otto")}");
            Console.ReadKey();
        }
    }
}
