
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorymy_01
{
    class Program
    {
        static int silnia(int n)
        {
            if (n > 1) return silnia(n - 1) * n;
            else return 1 ;
        }

        static string binarnie(int n)
        {
            if (n > 0) return "" +binarnie(n / 2) + ""+ n%2;
            else return "";
        }

        static int suma(int n)
        {
            if (n > 0 && n<1020) return n % 10 + suma(n/10);
            else return 0;
        }


        static void Main(string[] args)
        {
            int N = 5;
            int N2 = 162;
            Console.WriteLine("Silnia: {1} = {0}",silnia(N),N);
            Console.WriteLine("Dziesietna na binarna: {1} =  {0}", binarnie(N),N);
            int sum = suma(N2);
            Console.WriteLine("Suma: {1} = {0}", sum, N2);
            
            Console.ReadLine();
        }
    }
}
