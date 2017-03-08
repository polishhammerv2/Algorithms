using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static string konwerter(int n)
        {
            if (n < 1)
                return "";

            if (n % 2 == 0)
                return konwerter(n / 2) + "0";

            else
                return konwerter(n / 2) + "1";

            
        }


        static void Main(string[] args) {

            for (int i = 0; i < 10; i++) {
                Console.WriteLine("a({0}) = {1}", i, konwerter(i));
            }
        

            Console.ReadKey();
        }
    }
}
