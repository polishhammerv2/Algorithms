using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static long a(int n)
        {
            if (n > 1)
                return n * a(n - 1);

             return 1;
        }

        
        static void Main(string[] args)
        {
            int n = 5;
            Console.WriteLine("Silnia({0}) = {1}", n, a(n));

            Console.ReadKey();
        }
    }
}
