using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01Newton {
    class Program {
        static long NewtonRek(int n, int k) {
            if(k == 0 || n == k)
                return 1;
            else
                return NewtonRek(n - 1, k - 1) + NewtonRek(n - 1, k);
        }

        static long NewtonDyn(int n, int k) {
            long[,] tab = new long[n+1, n+1];
            for(int i = 0; i <= n; i++) {
                tab[i, 0] = 1;
                tab[i, i] = 1;
                for(int j = 1; j <= Math.Min(k, i - 1); j++)
                    tab[i, j] = tab[i - 1, j - 1] + tab[i - 1, j];
            }
            return tab[n, k];
        }

        static void Main(string[] args) {
            int n = 49, k = 25;
            //int n = 25, k = 13;
            long wynik;

            Stopwatch stopwatch = new Stopwatch();
            //stopwatch.Start();
            //wynik = NewtonRek(n, k);
            //stopwatch.Stop();
            //Console.WriteLine("Wynik = {0}, milis = {1}",
            //    wynik, stopwatch.ElapsedMilliseconds);
            //stopwatch.Reset();

            stopwatch.Start();
            wynik = NewtonDyn(n, k);
            stopwatch.Stop();
            Console.WriteLine("Wynik = {0}, milis = {1}",
                wynik, stopwatch.ElapsedMilliseconds);

        }
        // TODO: Zadanie
        //  Zrób to samo dla rekurencyjnej wersji Fibonacciego.
    }
}
