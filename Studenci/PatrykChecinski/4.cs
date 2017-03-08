using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static int suma(int n)
        {
            if(n > 10)
                return n % 10 + suma(n / 10);

            return n;
        }


        static void Main(string[] args) {

            for (int i = 23; i < 475; i+=1) {
                Console.WriteLine("a({0}) = {1}", i, suma(i));

            }
        

            Console.ReadKey();
        }
    }
}
