using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03Fibonacci {
    class Program {
        public static long fib_rek(long n) {
            if((n == 0) || (n == 1)) return n;
            else return fib_rek(n - 1) + fib_rek(n - 2);
        }

        public static long fib_iter(long n) {
            int i, w = 0, f0 = 0, f1 = 1;

            for(i = 2; i < n + 1; i++) {
                w = f0 + f1;
                f0 = f1;
                f1 = w;
            }
            return w;
        }

        static void Main(string[] args) {
            int N_start = 20, N_stop = 35;

            Stopwatch sw = new Stopwatch();
            for(int i = N_start; i < N_stop; i++) {
                sw.Reset();
                sw.Start();
                Console.Write("Fib_rek({0}) = {1}", i, fib_rek(i));
                sw.Stop();
                Console.WriteLine("\t {0}", sw.Elapsed.TotalMilliseconds);
                sw.Reset();
                sw.Start();
                Console.Write("Fib_itr({0}) = {1}", i, fib_iter(i));
                sw.Stop();
                Console.WriteLine("\t {0}", sw.Elapsed.TotalMilliseconds);
            }
        }
    }
}
