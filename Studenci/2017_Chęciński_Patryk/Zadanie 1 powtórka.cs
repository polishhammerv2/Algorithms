using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02PrzywodcaCiagu
{
    class Program
    {
        static int PrzywodcaCiagu(int[] A)
        {
            int[] C = new int[A.Length];

            foreach (var a in A)
            {
                C[a]++;
            }

            Array.Sort(C);
            Array.Reverse(C);

            foreach (var a in C)
            {
                if (a != 0)
                {
                    Console.WriteLine(a);
                }
                
            }
            if (C[0] > A.Length / 2)
            {
                return C[0];
            }
            else
            {
                return -1;
            }
        }


        static void Main(string[] args)
        {
            int N = 40;
           // int[] A = new int[N];

            int[] A = { 1, 1, 1, 1, 2 };

            Random randNum = new Random();

           // for (int i = 0; i < N; i++)
           //     A[i] = randNum.Next(10);

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            //long wynik = SumaTabliczkiMnozenia(N);
            int wynik = PrzywodcaCiagu(A);
            stopwatch.Stop();

            foreach (var i in A)
            {
              //  Console.Write(i);
            }

            Console.WriteLine("Wynik = {0}, milis ={1}",
                wynik, stopwatch.ElapsedMilliseconds);

            Array.Sort(A);

            stopwatch.Restart();
            //long wynik = SumaTabliczkiMnozenia(N);
            wynik = PrzywodcaCiagu(A);
            stopwatch.Stop();

            foreach (var i in A)
            {
              //  Console.Write(i);
            }

            Console.WriteLine("Wynik = {0}, milis ={1}",
    wynik, stopwatch.ElapsedMilliseconds);

            Array.Reverse(A);

            stopwatch.Restart();
            //long wynik = SumaTabliczkiMnozenia(N);
            wynik = PrzywodcaCiagu(A);
            stopwatch.Stop();

            foreach (var i in A)
            {
              //  Console.Write(i);
            }

            Console.WriteLine("Wynik = {0}, milis ={1}",
    wynik, stopwatch.ElapsedMilliseconds);

            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
