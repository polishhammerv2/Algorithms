using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static int konwerter(int n, ref string wynik)
        {
            if (n % 2 == 0) {
                wynik = "0" + wynik;
            }
            else {
                wynik = "1" + wynik;
            }

            if (n > 1) {
                return konwerter(n / 2, ref wynik);
            }

            return 1;           
        }


        static void Main(string[] args) {

            for (int i = 0; i < 10; i++) {
                string wynik = "";
                konwerter(i, ref wynik);

                Console.WriteLine("a({0}) = {1}", i, wynik);
            }
        

            Console.ReadKey();
        }
    }
}
