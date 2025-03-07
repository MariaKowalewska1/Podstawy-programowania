using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_7
{
    class Program
    {
        static void Main(string[] args)
        {
            //Napisać program wczytujący dwie liczby całkowite i wypisujący na ekranie iloraz tych liczb z uwzględnieniem części całkowitej i reszty z dzielenia.
            Double a, b;
            Console.Write("Podaj liczbe a: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Podaj liczbe b:");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Iloraz liczb z uwzglednieniem czesci calkowitej wynosi: ={0}", a * b);
            Console.WriteLine("Iloraz liczb z uwzglednieniem reszty z dzielenia wynosi: ={0}", a % b);
        }
    }
}
