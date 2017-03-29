using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01Sortowanie {
    class Program {

        static int BubbleSortCount = 0;
        static int InsertionSortCount = 0;
        static int MergeSortCount = 0;
        static int QuickSortCount = 0;

        static void Swap(int[] tab, int i, int j) {
            int pom = tab[i];
            tab[i] = tab[j];
            tab[j] = pom;
        }
        //
        // Sortowanie b¹belkowe
        //
        static void sortowanieBabelkowe(int[] tab) {
            for (int i = 1; i < tab.Length; i++)
                for (int j = tab.Length - 1; j > 0; j--)
                    if (tab[j - 1] > tab[j]) {
                        Swap(tab, j - 1, j);
                        BubbleSortCount++;
                    }
        }

        //
        // Sortowanie przez wstawianie
        //
        static void sortowanieWstawianie(int[] tab) {
            int x, j;
            for (int i = 1; i < tab.Length - 1; i++) {
                //a[0..i-1] jest ju¿ posortowana
                x = tab[i]; //odk³adamy element z pozycji i
                j = i;
                while (j > 0 && x < tab[j - 1]) {
                    tab[j] = tab[j - 1]; //przesuwamy element wiêkszy od x o jedn¹ pozycjê w prawo    
                    InsertionSortCount++;
                    j = j - 1;
                }
                tab[j] = x;
            }
        }

        //
        // Merge Sort
        //
        public static void MergeSort(int[] input, int low, int high) {
            if (low < high) {
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

            while ((left <= middle) && (right <= high)) {
                if (input[left] < input[right]) {
                    tmp[tmpIndex] = input[left];
                    left = left + 1;
                }
                else {
                    tmp[tmpIndex] = input[right];
                    right = right + 1;
                }
                tmpIndex = tmpIndex + 1;
                MergeSortCount++;
            }

            if (left <= middle) {
                while (left <= middle) {
                    tmp[tmpIndex] = input[left];
                    left = left + 1;
                    tmpIndex = tmpIndex + 1;
                }
            }
            if (right <= high) {
                while (right <= high) {
                    tmp[tmpIndex] = input[right];
                    right = right + 1;
                    tmpIndex = tmpIndex + 1;
                }
            }
            for (int i = 0; i < tmp.Length; i++) {
                input[low + i] = tmp[i];
            }
        }

        //
        // QuictSort
        //
        public static void QuickSort(int[] input, int left, int right) {
            if (left < right) {
                QuickSortCount++;
                int q = Partition(input, left, right);
                QuickSort(input, left, q - 1);
                QuickSort(input, q + 1, right);
            }
        }

        private static int Partition(int[] input, int left, int right) {
            int pivot = input[right];
            int temp;

            int i = left;
            for (int j = left; j < right; j++) {
                if (input[j] <= pivot) {
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

        static void test(int N) {
            int[] tablica = new int[N];
            Random rand = new Random();

            for (int i = 0; i < N; i++)
                tablica[i] = rand.Next(1, 1000);


            int[] tabBabelki = new int[N];
            int[] tabWstaw = new int[N];
            int[] tabMerge = new int[N];
            int[] tabQuick = new int[N];

            for (int i = 0; i < N; i++) tabBabelki[i] = tablica[i];
            for (int i = 0; i < N; i++) tabWstaw[i] = tablica[i];
            for (int i = 0; i < N; i++) tabMerge[i] = tablica[i];
            for (int i = 0; i < N; i++) tabQuick[i] = tablica[i];

            sortowanieBabelkowe(tabBabelki);
            sortowanieWstawianie(tabWstaw);
            MergeSort(tabMerge);
            QuickSort(tabQuick, 0, tabQuick.Length - 1);
        }


        static void Main(string[] args) {

            test(100);
            Console.WriteLine("Testy dla N: {4}\nIloœci swapów w algorytmach:\nb¹belki: {0}\nwstawianie: {1}\nmerge: {2}\nquick: {3}", BubbleSortCount, InsertionSortCount, MergeSortCount, QuickSortCount, 100);
            BubbleSortCount = 0;
            InsertionSortCount = 0;
            MergeSortCount = 0;
            QuickSortCount = 0;


            test(1000);
            Console.WriteLine("Testy dla N: {4}\nIloœci swapów w algorytmach:\nb¹belki: {0}\nwstawianie: {1}\nmerge: {2}\nquick: {3}", BubbleSortCount, InsertionSortCount, MergeSortCount, QuickSortCount, 1000);
            BubbleSortCount = 0;
            InsertionSortCount = 0;
            MergeSortCount = 0;
            QuickSortCount = 0;


            test(10000);
            Console.WriteLine("Testy dla N: {4}\nIloœci swapów w algorytmach:\nb¹belki: {0}\nwstawianie: {1}\nmerge: {2}\nquick: {3}", BubbleSortCount, InsertionSortCount, MergeSortCount, QuickSortCount, 10000);
            BubbleSortCount = 0;
            InsertionSortCount = 0;
            MergeSortCount = 0;
            QuickSortCount = 0;



            
            Console.ReadKey();
        }
    }
}