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
        //
        // Sortowanie bąbelkowe
        //
        static void sortowanieBabelkowe(int[] tab) {
            for(int i = 1; i < tab.Length; i++)
                for(int j = tab.Length - 1; j > 0; j--)
                    if(tab[j - 1] > tab[j])
                        Swap(tab, j - 1, j);
        }

        //
        // Sortowanie przez wstawianie
        //
        static void sortowanieWstawianie(int[] tab) {
            int x, j;
            for(int i = 1; i < tab.Length - 1; i++) {
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

        //
        // Merge Sort
        //
        public static void MergeSort(int[] input, int low, int high) {
            if(low < high) {
                int middle = (low / 2) + (high / 2);
                MergeSort(input, low, middle);
                MergeSort(input, middle + 1, high);
                Merge(input, low, middle, high);
            }
        }

        public static void MergeSort(int[] input) {
            MergeSort(input, 0, input.Length - 1);
        }

        private static void Merge(int[] input, int low, int middle, int high) {
            int left = low;
            int right = middle + 1;
            int[] tmp = new int[(high - low) + 1];
            int tmpIndex = 0;

            while((left <= middle) && (right <= high)) {
                if(input[left] < input[right]) {
                    tmp[tmpIndex] = input[left];
                    left = left + 1;
                } else {
                    tmp[tmpIndex] = input[right];
                    right = right + 1;
                }
                tmpIndex = tmpIndex + 1;
            }

            if(left <= middle) {
                while(left <= middle) {
                    tmp[tmpIndex] = input[left];
                    left = left + 1;
                    tmpIndex = tmpIndex + 1;
                }
            }
            if(right <= high) {
                while(right <= high) {
                    tmp[tmpIndex] = input[right];
                    right = right + 1;
                    tmpIndex = tmpIndex + 1;
                }
            }
            for(int i = 0; i < tmp.Length; i++) {
                input[low + i] = tmp[i];
            }
        }

        //
        // QuictSort
        //
        public static void QuickSort(int[] input, int left, int right) {
            if(left < right) {
                int q = Partition(input, left, right);
                QuickSort(input, left, q - 1);
                QuickSort(input, q + 1, right);
            }
        }

        private static int Partition(int[] input, int left, int right) {
            int pivot = input[right];
            int temp;

            int i = left;
            for(int j = left; j < right; j++) {
                if(input[j] <= pivot) {
                    temp = input[j];
                    input[j] = input[i];
                    input[i] = temp;
                    i++;
                }
            }

            input[right] = input[i];
            input[i] = pivot;

            return i;
        }

        //
        // 
        //
        static void Main(string[] args) {
            const int N = 1000 * 1000;
            int[] tablica = new int[N];
            Random rand = new Random();
            Stopwatch sw = new Stopwatch();

            for(int i = 0; i < N; i++) tablica[i] = rand.Next(1, 100000);

            //int[] tabBabelki = new int[N];
            //for(int i = 0; i < N; i++) tabBabelki[i] = tablica[i];
            ////Console.WriteLine("Tablica:{0}", string.Join(",", tabBabelki));
            //Console.Write("Bubble: ");
            //sw.Reset();
            //sw.Start();
            //sortowanieBabelkowe(tabBabelki);
            //sw.Stop();
            //Console.WriteLine("Czas: {1}", string.Join(",", tabBabelki), sw.Elapsed.TotalMilliseconds);

            //int[] tabWstaw = new int[N];
            //for(int i = 0; i < N; i++) tabWstaw[i] = tablica[i];
            ////Console.WriteLine("Tablica:{0}", string.Join(",", tabWstaw));
            //Console.Write("Insert: ");
            //sw.Reset();
            //sw.Start();
            //sortowanieWstawianie(tabWstaw);
            //sw.Stop();
            //Console.WriteLine("Czas: {1}", string.Join(",", tabWstaw), sw.Elapsed.TotalMilliseconds);

            int[] tabMerge = new int[N];
            for(int i = 0; i < N; i++) tabMerge[i] = tablica[i];
            //Console.WriteLine("Tablica:{0}", string.Join(",", tabMerge));
            Console.Write("Merge: ");
            sw.Reset();
            sw.Start();
            MergeSort(tabMerge);
            sw.Stop();
            Console.WriteLine("Czas: {1}", string.Join(",", tabMerge), sw.Elapsed.TotalMilliseconds);

            int[] tabQuick = new int[N];
            for(int i = 0; i < N; i++) tabQuick[i] = tablica[i];
            //Console.WriteLine("Tablica:{0}", string.Join(",", tabMerge));
            Console.Write("Quick: ");
            sw.Reset();
            sw.Start();
            QuickSort(tabQuick, 0, tabQuick.Length - 1);
            sw.Stop();
            Console.WriteLine("Czas: {1}", string.Join(",", tabQuick), sw.Elapsed.TotalMilliseconds);
        }
    }
}
