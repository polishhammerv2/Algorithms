using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01Pomiary {

    class Program {
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

        static long benchmarkLin(int n) {
            return n + 7;
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
        static long benchmarkKw(int n) {
            return  n * n - n + 7;
        }

        static void testAlgorithm(Func<int, double> myFunc, Func<int, long> myBench,
            int n_start, int n_stop, int step) {
            Stopwatch stopwatch = new Stopwatch();

            for (int i = n_start; i <= n_stop; i += step) {
                stopwatch.Start();
                myFunc(i);
                stopwatch.Stop();
                Console.WriteLine("{0}: {1}: {2}", i, stopwatch.ElapsedMilliseconds, ((double)myBench(i)) / stopwatch.ElapsedMilliseconds);
                stopwatch.Reset();
            }

        }
        static void Main(string[] args) {
            //testAlgorithm(mnozenieWektorow, benchmarkLin, 1000*1000, 100*1000*1000, 1000*1000);
            testAlgorithm(mnozenieKwadrat, benchmarkKw, 100, 100 * 100, 100);
        }
    }
}
