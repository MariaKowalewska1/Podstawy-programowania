using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_4
{
    class Program
    {
        static void Main(string[] args)
        {//Napisać program wczytujący boki prostokąta i wypisujący na ekranie jego pole i obwód
            Double a,b
            Console.Write("Podaj długosc pierwszego boku: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Podaj długosc drugiego boku: ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Pole prostokąta={0}", a * b);


        }
    }
}
