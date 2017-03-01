using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01Pomiary {

    class Program {
        static long mnozenieMacierzy(int n) {
            Stopwatch stopwatch = new Stopwatch();
            long czas;
            double[,] m1 = new double[n, n];
            double[,] m2 = new double[n, n];
            Random randNum = new Random();
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++) {
                    m1[i, j] = randNum.NextDouble();
                    m2[i, j] = randNum.NextDouble();
                }
            double[,] wynik = new double[n, n];
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++) {
                    wynik[i, j] = 0;
                }

            stopwatch.Start();
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                    for (int k = 0; k < n; k++) {
                        wynik[i, j] += m1[i, k] * m2[j, k];
                    }
            stopwatch.Stop();
            czas = stopwatch.ElapsedMilliseconds;
            stopwatch.Reset();
            return czas;
        }
        static double benchmarkSzesc(long n) {
            return (n + 7) / 5650.0;
        }

        static double mnozenieWektorow(int n) {
            double[] w1, w2;
            double result = 0;
            Random randNum = new Random();

            w1 = new double[n];
            w2 = new double[n];
            for (int i = 0; i < w1.Length; i++) w1[i] = randNum.NextDouble();
            for (int i = 0; i < w2.Length; i++) w2[i] = randNum.NextDouble();

            for (int i = 0; i < w1.Length; i++)
                result += w1[i] * w2[i];
            return result;
        }

        static double benchmarkLin(long n) {
            return (n + 7) / 5650.0;
        }

        static double mnozenieKwadrat(int n) {
            double[] w1, w2;
            double result = 0;
            Random randNum = new Random();

            w1 = new double[n];
            w2 = new double[n];
            for (int i = 0; i < w1.Length; i++) w1[i] = randNum.NextDouble();
            for (int i = 0; i < w2.Length; i++) w2[i] = randNum.NextDouble();

            for (int i = 0; i < w1.Length; i++)
                for (int j = 0; j < w2.Length; j++)
                    result += w1[i] * w2[j];
            return result;
        }
        static double benchmarkKw(long n) {
            return (n * n / (100.0) + n) / 650;
        }

        static void testAlgorithm(Func<int, long> myFunc, Func<long, double> myBench,
            int n_start, int n_stop, int step) {
            long czas;

            for (int i = n_start; i <= n_stop; i += step) {
                czas = myFunc(i);
                Console.WriteLine("{0}: {1}: {2}", i, czas,
                ((double)myBench(i)) / czas);
            }

        }
        static void Main(string[] args) {
            //testAlgorithm(mnozenieWektorow, benchmarkLin, 1000 * 1000, 100 * 1000 * 1000, 1000 * 1000);
            //testAlgorithm(mnozenieKwadrat, benchmarkKw, 1000, 100 * 1000, 300);
            testAlgorithm(mnozenieMacierzy, benchmarkSzesc, 100, 10 * 1000, 20);
        }
    }
}
