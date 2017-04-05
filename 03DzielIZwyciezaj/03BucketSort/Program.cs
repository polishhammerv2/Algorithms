using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03BucketSort {    
    class Program {
        // Source: https://www.codeproject.com/Articles/177363/Searching-and-Sorting-Algorithms-via-C
        public static void BucketSort(ref int[] x) {
            //Verify input
            if(x == null || x.Length <= 1)
                return;

            //Find the maximum and minimum values in the array
            int maxValue = x[0];
            int minValue = x[0];

            for(int i = 1; i < x.Length; i++) {
                if(x[i] > maxValue)
                    maxValue = x[i];

                if(x[i] < minValue)
                    minValue = x[i];
            }

            //Create a temporary "bucket" to store the values in order
            //each value will be stored in its corresponding index
            //scooting everything over to the left as much as possible (minValue)
            LinkedList<int>[] bucket = new LinkedList<int>[maxValue - minValue + 1];

            //Move items to bucket
            for(int i = 0; i < x.Length; i++) {
                if(bucket[x[i] - minValue] == null)
                    bucket[x[i] - minValue] = new LinkedList<int>();

                bucket[x[i] - minValue].AddLast(x[i]);
            }

            //Move items in the bucket back to the original array in order
            int k = 0; //index for original array
            for(int i = 0; i < bucket.Length; i++) {
                if(bucket[i] != null) {
                    LinkedListNode<int> node = bucket[i].First; //start add head of linked list

                    while(node != null) {
                        x[k] = node.Value; //get value of current linked node
                        node = node.Next; //move to next linked node
                        k++;
                    }
                }
            }
        }
        static void Main(string[] args) {
            const int N = 10000000;
            int[] tablica = new int[N];
            Random rand = new Random();
            Stopwatch sw = new Stopwatch();

            for(int i = 0; i < N; i++) tablica[i] = rand.Next(1, 1000000);

            //Console.WriteLine("Tablica:{0}", string.Join(",", tablica));
            Console.Write("Heap: ");
            sw.Reset();
            sw.Start();
            BucketSort(ref tablica);
            sw.Stop();
            Console.WriteLine("Czas: {1}", string.Join(",", tablica), sw.Elapsed.TotalMilliseconds);
        }
    }
}
