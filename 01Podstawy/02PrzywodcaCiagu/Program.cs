﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02PrzywodcaCiagu {
    class Program {
        static long SumaTabliczkiMnozenia(int n) {
            long suma = 0;
            for (int i = 1; i <= n; i++)
                for (int j = 1; j <= n; j++)
                    suma += i * j;
            return suma;
        }

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
            int N = 4000;
            //int[] A = new int[N];
            //Random randNum = new Random();

            //for (int i = 0; i < N; i++)
            //    A[i] = randNum.Next(10);

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            long wynik = SumaTabliczkiMnozenia(N);
            //int wynik = PrzywodcaCiagu(A);
            stopwatch.Stop();

            Console.WriteLine("Wynik = {0}, milis ={1}", 
                wynik,stopwatch.ElapsedMilliseconds);
        }
    }
}
