using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeapSort {
    class HeapSort {
        private int heapSize;

        public void BuildHeap(int[] arr) {
            heapSize = arr.Length - 1;
            for(int i = heapSize / 2; i >= 0; i--) {
                Heapify(arr, i);
            }
        }
        int parentNode(int i) { return (i - 1) / 2; }
        int leftChild(int i) { return 2*i + 1; }
        int rightChild(int i) { return 2*i+2; }

        bool existsLeftChild(int sizeOfHeap, int node) {
            return ((leftChild(node) < sizeOfHeap) ? true : false);
        }
        bool existsRightChild(int sizeOfHeap, int node) {
            return ((rightChild(node) < sizeOfHeap) ? true : false);
        }
        bool isLeaf(int sizeOfHeap, int node) {
            return ((leftChild(node) < sizeOfHeap || rightChild(node) < sizeOfHeap) ? false : true);
        }

        public void printHaep(int[] arr, int root, String space) {
            if(isLeaf(arr.Length, root)) Console.WriteLine("{0}{1}", space, arr[root]);
            else {
                if(existsLeftChild(arr.Length, root))
                    printHaep(arr, leftChild(root), space + "  ");
                Console.WriteLine("{0}{1}", space, arr[root]);
                if(existsRightChild(arr.Length, root))
                    printHaep(arr, rightChild(root), space + "  ");
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
            Random rand = new Random();
            // przykład kopca
            const int M = 10;
            int[] kopiec = new int[M] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            HeapSort h = new HeapSort();
            //for(int i = 0; i < M; i++) kopiec[i] = rand.Next(1, 10);
            Console.WriteLine("Tablica: {0}", string.Join(",", kopiec));
            h.BuildHeap(kopiec);
            Console.WriteLine("Tablica: {0}", string.Join(",", kopiec));
            // wypisz kopiec "graficznie"
            // przechyl głowę w lewo i użyj wyobraźni
            h.printHaep(kopiec, 0, "");

            //const int N = 1000000;
            //int[] tablica = new int[N];
            
            //Stopwatch sw = new Stopwatch();

            //for(int i = 0; i < N; i++) tablica[i] = rand.Next(1, 1000000);

            ////Console.WriteLine("Tablica:{0}", string.Join(",", tablica));
            //Console.Write("Heap: ");
            //sw.Reset();
            //sw.Start();
            //new HeapSort().PerformHeapSort(tablica);
            //sw.Stop();
            //Console.WriteLine("Czas: {1}", string.Join(",", tablica), sw.Elapsed.TotalMilliseconds);
        }
    }
}
//
// Source: https://simpledevcode.wordpress.com/2014/11/25/heapsort-c-tutorial/
// see also: https://en.wikipedia.org/wiki/Heapsort
//
