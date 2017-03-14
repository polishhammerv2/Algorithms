using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02Euklides {
    class Program {
        static int Euklides(int a, int b) {
            if(a <= b) return Euklides(b, a);
            else
                if(b == 0) return a;
                else return Euklides(b, a % b);
        }
        static void Main(string[] args) {
            Console.WriteLine(Euklides(12, 9));
            Console.WriteLine(Euklides(1024, 256*3));
        }
    }
}
