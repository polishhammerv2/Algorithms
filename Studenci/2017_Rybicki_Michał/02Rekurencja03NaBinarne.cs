using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie3
{
    class Program
    {

        static void Binarny(int liczba)
        {
            if (liczba > 0)
            {
                if (liczba % 2 == 0)
                {
                    Console.WriteLine("0");
                    liczba = liczba / 2;
                }

                else
                {
                    Console.WriteLine("1");
                    liczba = liczba / 2;
                }
            }
            else
            {
                Console.WriteLine("0");
                liczba = liczba / 2;
            }

            if (liczba > 0)
                Binarny(liczba);
        }
        static void Main(string[] args)
        {
            //Napisz program, który zapisze podana liczbe dziesietna naturalna w systemie binarnym.Rozwiaz zadany problem rekurencyjnie.
            Binarny(237);
            Console.WriteLine("Najmniejsza wartość jest u góry, największa na dole");
        }
    }
}
