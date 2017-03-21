using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeapSort {
    class HeapSort {
        private int heapSize;

        private void BuildHeap(int[] arr) {
            heapSize = arr.Length - 1;
            for(int i = heapSize / 2; i >= 0; i--) {
                Heapify(arr, i);
            }
        }

        private void Swap(int[] arr, int x, int y)//function to swap elements
        {
            int temp = arr[x];
            arr[x] = arr[y];
            arr[y] = temp;
        }

        private void Heapify(int[] arr, int index) {
            int left = 2 * index;
            int right = 2 * index + 1;
            int largest = index;

            if(left <= heapSize && arr[left] > arr[index]) {
                largest = left;
            }

            if(right <= heapSize && arr[right] > arr[largest]) {
                largest = right;
            }

            if(largest != index) {
                Swap(arr, index, largest);
                Heapify(arr, largest);
            }
        }

        public void PerformHeapSort(int[] arr) {
            BuildHeap(arr);
            for(int i = arr.Length - 1; i >= 0; i--) {
                Swap(arr, 0, i);
                heapSize--;
                Heapify(arr, 0);
            }
        }
    }
    class Program {
        static void Main(string[] args) {
            const int N = 1000000;
            int[] tablica = new int[N];
            Random rand = new Random();
            Stopwatch sw = new Stopwatch();

            for(int i = 0; i < N; i++) tablica[i] = rand.Next(1, 1000000);

            //Console.WriteLine("Tablica:{0}", string.Join(",", tablica));
            Console.Write("Heap: ");
            sw.Reset();
            sw.Start();
            new HeapSort().PerformHeapSort(tablica);
            sw.Stop();
            Console.WriteLine("Czas: {1}", string.Join(",", tablica), sw.Elapsed.TotalMilliseconds);

        }
    }
}
//
// Source: https://simpledevcode.wordpress.com/2014/11/25/heapsort-c-tutorial/
//
