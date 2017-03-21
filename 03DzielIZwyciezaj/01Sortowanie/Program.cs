using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01Sortowanie {
    class Program {
        static void Swap(int[] tab, int i, int j) {
            int pom = tab[i];
            tab[i] = tab[j];
            tab[j] = pom;
        }
        static void sortowanieBabelkowe(int[] tab) {
            for(int i = 1; i < tab.Length; i++)
                for(int j = tab.Length - 1; j > 0; j--)
                    if(tab[j - 1] > tab[j])
                        Swap(tab, j - 1, j);
        }
        static void sortowanieWstawianie(int[] tab) {
            int x, j; 
            for(int i = 1; i < tab.Length-1; i++) {
                //a[0..i-1] jest już posortowana
                x = tab[i]; //odkładamy element z pozycji i
                j = i;
                while(j > 0 && x < tab[j - 1]) {
                    tab[j] = tab[j - 1]; //przesuwamy element większy od x o jedną pozycję w prawo    
                    j = j - 1;
                }
                tab[j] = x;
            }
        }

        static void Main(string[] args) {
            const int N = 10000;
            int[] tablica = new int[N];
            Random rand = new Random();
            Stopwatch sw = new Stopwatch();

            for(int i = 0; i < N; i++) tablica[i] = rand.Next(1, 100);

            int[] tabBabelki = new int[N];
            for(int i = 0; i < N; i++) tabBabelki[i] = tablica[i];
            Console.WriteLine("Tablica:{0}", string.Join(",", tabBabelki));
            sw.Reset();
            sw.Start();
            sortowanieBabelkowe(tabBabelki);
            sw.Stop();
            Console.WriteLine("Tablica:{0}, czas: {1}", string.Join(",", tabBabelki), sw.Elapsed.TotalMilliseconds);

            int[] tabWstaw = new int[N];
            for(int i = 0; i < N; i++) tabWstaw[i] = tablica[i];
            Console.WriteLine("Tablica:{0}", string.Join(",", tabWstaw));
            sw.Reset();
            sw.Start();
            sortowanieWstawianie(tabWstaw);
            sw.Stop();
            Console.WriteLine("Tablica:{0}, czas: {1}", string.Join(",", tabWstaw), sw.Elapsed.TotalMilliseconds);
        }
    }
}
