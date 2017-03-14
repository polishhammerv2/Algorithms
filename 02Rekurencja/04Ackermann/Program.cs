using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04Ackermann {
    class Program {
        public static long Ackermann(long m, long n) {
            if(m > 0) {
                if(n > 0)
                    return Ackermann(m - 1, Ackermann(m, n - 1));
                else if(n == 0)
                    return Ackermann(m - 1, 1);
            } else if(m == 0) {
                if(n >= 0)
                    return n + 1;
            }
            throw new System.ArgumentOutOfRangeException();
        }
        static void Main(string[] args) {
            Stopwatch sw = new Stopwatch();
            long res;

            for(long m = 0; m <= 3; ++m) {
                for(long n = 0; n <= 6; ++n) {
                    sw.Reset();
                    sw.Start();
                    res = Ackermann(m, n);
                    sw.Stop();
                    Console.Write("Ackermann({0}, {1}) = {2} ", m, n, res);
                    Console.WriteLine("{0:F5} ", sw.Elapsed.TotalMilliseconds);
                }
            }

        }
    }
}
