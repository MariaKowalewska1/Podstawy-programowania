using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_3
{
    class Program
    {
        static void Main(string[] args)
        {//Napisać program wczytujący z klawiatury liczbę całkowitą i wypisujący na ekranie sześcian wczytanej liczby.
            int a;
            Console.Write("Podaj liczbe calkowita: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("a^3={0} ", a*a*a);
            Console.ReadKey(true);


        }
    }
}
