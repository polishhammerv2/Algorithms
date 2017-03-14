using System;
using System.Diagnostics;
using System.Numerics;

namespace _03Fibonacci {
    class Program {
        public static long fib_rek(long n) {
            if((n == 0) || (n == 1)) return n;
            else return fib_rek(n - 1) + fib_rek(n - 2);
        }

        public static BigInteger fib_iter(long n) {
            int i;
            BigInteger w = 0, f0 = 0, f1 = 1;

            for(i = 2; i < n + 1; i++) {
                w = f0 + f1;
                f0 = f1;
                f1 = w;
            }
            return w;
        }

        static BigInteger[,] multiply(BigInteger[,] a, BigInteger[,] b) {
            BigInteger[,] result = new BigInteger[2, 2];
            result[0, 0] = BigInteger.Add(BigInteger.Multiply(a[0, 0], b[0, 0]), BigInteger.Multiply(a[0, 1], b[1, 0]));
            result[0, 1] = BigInteger.Add(BigInteger.Multiply(a[0, 0], b[0, 1]), BigInteger.Multiply(a[0, 1], b[1, 1]));
            result[1, 0] = BigInteger.Add(BigInteger.Multiply(a[1, 0], b[0, 0]), BigInteger.Multiply(a[1, 1], b[1, 0]));
            result[1, 1] = BigInteger.Add(BigInteger.Multiply(a[1, 0], b[0, 1]), BigInteger.Multiply(a[1, 1], b[1, 1]));
            return result;
        }

        static BigInteger[,] fibMatrixPower(BigInteger[,] m, int n) {
            if(n == 1) return m;
            else if(n % 2 == 0) return fibMatrixPower(multiply(m, m), n / 2);
            else return multiply(fibMatrixPower(multiply(m, m), (n - 1) / 2), m);
        }

        public static BigInteger fibobacciFast(int n) {
            BigInteger[,] result = new BigInteger[2, 2] { { 1, 1 }, { 1, 0 } };
            return fibMatrixPower(result, n)[0, 1];
        }

        static void Main(string[] args) {
            int N_start = 1000, N_stop = 1010;
            BigInteger res;
            Stopwatch sw = new Stopwatch();
            for(int i = N_start; i < N_stop; i++) {
                //sw.Reset();
                //sw.Start();
                //Console.Write("rek({0:G3}) = {1:G7} ", i, fib_rek(i));
                //sw.Stop();
                //Console.Write("{0:F5} ", sw.Elapsed.TotalMilliseconds);
                sw.Reset();
                sw.Start();
                res = fib_iter(i);
                sw.Stop();
                Console.Write("itr({0:G3}) = {1:G7} ", i, res);
                Console.WriteLine("{0:F5} ", sw.Elapsed.TotalMilliseconds);
                sw.Reset();
                sw.Start();
                res = fibobacciFast(i);
                sw.Stop();
                Console.Write("fast({0:G3}) = {1} ", i, res);
                Console.WriteLine("{0:F5}", sw.Elapsed.TotalMilliseconds);
            }
        }
    }
}
