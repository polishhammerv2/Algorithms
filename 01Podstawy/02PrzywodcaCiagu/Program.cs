using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02PrzywodcaCiagu {
    class Program {
        static int PrzywodcaCiagu(int[] A) {
            int ile = 0;
            int j = 0;
            int n = A.Length;

            for (int i = 0; i < n; i++)
                if (ile == 0) {
                    ile = ile + 1;
                    j = i;
                }
                else if (A[i] == A[j])
                    ile = ile + 1;
                else ile = ile - 1;

            return A[j];
        }

        static void Main(string[] args) {
            int[] A = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 2, 4, 6, 8, 4, 6, 4 };
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            int wynik = PrzywodcaCiagu(A);
            stopwatch.Stop();

            Console.WriteLine("Wynik = {0}, milis ={1}", 
                wynik,stopwatch.ElapsedMilliseconds);
        }
    }
}
