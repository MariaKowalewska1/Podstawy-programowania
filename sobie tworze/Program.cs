using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sobie_tworze
{
    class Program
    {
        static void Main(string[] args)
        {
            Double a;
            Console.Write("podaj liczbe: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("reszta z dzielenia na 2 wynosi={0} ", a % 2);

        }
    }
}
