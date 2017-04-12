using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie2
{
    class Program
    {
        static double a(int n)
        {
            if (n == 0)
                return 1;
            else if (n == 1)
                return 0.5;
            else if (n < 0)
                return a(n / 2);

            return -a(n - 1) * a(n - 2);
        }
        static void Main(string[] args)
        {
            /*           Poniżej zdefiniowany jest pewien ciąg, którego kolejne wyrazy generowane są w sposób rekurencyjny:

           a(n) =
               a(n / 2) dla n < 0

               1  dla n = 0

               0.5 dla n = 1
               - a(n - 1) * a(n - 2) dla n > 1

           Napisz program, który znajdzie wartość n - tego wyrazu ciągu.*/
            int x = 0;
            do { 
                Console.WriteLine(a(x));
                x++;
            }while (x<15);

        }
    }
}
