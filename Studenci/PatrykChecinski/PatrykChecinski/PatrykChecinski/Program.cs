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
            return n / 28000;
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
            return n * n / 305000;
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


        static long benchmarkCube(int n) {
            return n * n * n / 40000;
        }



        static double matrixMultiply(int n) {

            double[,] m1, m2, m3;
            Random randNum = new Random();

            m1 = new double[n, n];
            m2 = new double[n, n];
            m3 = new double[n, n];

            for (int i = 0; i < m1.GetLength(0); i++)
                for (int j = 0; i < m1.GetLength(0); i++) {
                    m1[i, j] = randNum.NextDouble();
                    m2[i, j] = randNum.NextDouble();
                }

            for (int row1 = 0; row1 < m1.GetLength(0); row1++) {
                for (int col2 = 0; col2 < m2.GetLength(1); col2++) {
                    for (int row2 = 0; row2 < m2.GetLength(0); row2++) {
                        m3[row1, col2] += m1[row1, row2] * m2[row2, col2];
                    }
                }
            }
            return 0.0;
        }


        static void Main(string[] args) {
            //testAlgorithm(mnozenieWektorow, benchmarkLin, 1000*1000, 100*1000*1000, 1000*1000);
            //testAlgorithm(mnozenieKwadrat, benchmarkKw, 100, 100 * 1000, 300);

            testAlgorithm(matrixMultiply, benchmarkCube, 100, 100 * 10, 50);
        }
    }
}