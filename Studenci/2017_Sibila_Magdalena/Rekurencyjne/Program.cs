using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rekurencyjne
{
    class Program
    {
        //silnia
        //silnia(n) = ( n < 2 ? 1 : n * silnia(n) )
        public static long Silnia(long n)
        {
            if (n <= 1) return 1;
            else return n * Silnia(n - 1);
        }

        /* Poniżej zdefiniowany jest pewien ciąg, którego kolejne wyrazy generowane są w sposób rekurencyjny:
            a(n) = 
	        a(n / 2) dla n < 0
	        1  dla n = 0
	        0.5 dla n = 1
	        - a(n-1) * a(n-2) dla n > 1
            Napisz program, który znajdzie wartość n-tego wyrazu ciągu.
         */
        public static double Ciag(int n)
        {
            if (n < 0)
                return n / 2.0;
            else if (n == 0)
                return 1.0;
            else if (n == 1)
                return 0.5;
            else
                return -(Ciag(n - 1)) * Ciag(n - 2);
        }

        //Napisz program, który zapisze podaną liczbę dziesiętną naturalną w systemie binarnym. Rozwiąż zadany problem rekurencyjnie.

        public static void Binarne(int n)
        {
            if (n > 0)
            {
                Binarne(n / 2);
                Console.Write(n % 2);
            }
        }

        //Napisz program, który wyznaczy sumę cyfr liczby naturalnej z zakresu [0...1020]. Rozwiąż zadanie metodą rekurencyjną.

        public static int Suma(int n)
        {
            if (n < 10)
                return n;
            else
            {
                return (n % 10) + Suma(n / 10);
            }
        }

        /*Czy istnieje ścieżka miedzy wskazanymi punktami (i1,j1) i (i2,j2) w labiryncie reprezentowanym przez prostokątną tablicę liczb
         *  całkowitych o rozmiarze M×N, zawierającą zera (ściana) i jedynki (droga)? Zakładamy, że nie można przechodzić z pola na pole
         *   po skosie (np. z (2,5) na (3,6)), a tylko w czterech podstawowych kierunkach (np. z (2,5) na (3,5), (2,4) itd.) */
        public static void Labirynt(int n, int m)
        {
            int[,] labirynt = new int[n, m];
            Random gen = new Random();
            for (int a = 0; a < n; a++)
            {
                for (int b = 0; b < m; b++)
                {
                    labirynt[a, b] = gen.Next(2);
                }
            }

        }
        


        static void Main(string[] args)
        {
            Console.WriteLine(Silnia(10));
            Console.WriteLine("{0}, {1}, {2}, {3}", Ciag(-2), Ciag(0), Ciag(1), Ciag(2));
            Binarne(10);
            Console.WriteLine();
            Console.WriteLine(Suma(1019));
            Console.ReadKey();
        }

    }
}
