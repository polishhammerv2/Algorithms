using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static double a(int n) {

            if (n < 0)
                return a(n / 2);
            if (n == 0)
                return 1;
            if (n == 1)
                return 0.5;
            
            return -a(n - 1) * a(n - 2);
        }

        static void Main(string[] args) {

            for (int i = 0; i < 10; i++) {
                Console.WriteLine("a({0}) = {1}", i, a(i));
            }
        

            Console.ReadKey();
        }
    }
}
