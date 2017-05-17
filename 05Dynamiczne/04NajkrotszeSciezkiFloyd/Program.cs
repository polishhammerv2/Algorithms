using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04NajkrotszeSciezkiFloyd {

    class Program {
        public const int INF = int.MaxValue;

        private static void Print(int[,] distance, int verticesCount) {
            Console.WriteLine("Najkrótsze drogi:");

            for(int i = 0; i < verticesCount; ++i) {
                for(int j = 0; j < verticesCount; ++j) {
                    if(distance[i, j] == INF)
                        Console.Write("INF".PadLeft(7));
                    else
                        Console.Write(distance[i, j].ToString().PadLeft(7));
                }

                Console.WriteLine();
            }
        }

        public static void FloydWarshall(int[,] graph, int verticesCount) {
            int[,] distance = new int[verticesCount, verticesCount];

            for(int i = 0; i < verticesCount; ++i)
                for(int j = 0; j < verticesCount; ++j)
                    distance[i, j] = graph[i, j];

            for(int k = 0; k < verticesCount; ++k) {
                for(int i = 0; i < verticesCount; ++i) {
                    for(int j = 0; j < verticesCount; ++j) {
                        if(distance[i, k] + distance[k, j] < distance[i, j])
                            distance[i, j] = distance[i, k] + distance[k, j];
                    }
                }
                Print(distance, verticesCount);
            }

            Print(distance, verticesCount);
        }

        static void Main(string[] args) {
            //int[,] graph = {
            //            { 0,   5,  INF, 10 },
            //            { INF, 0,   3, INF },
            //            { INF, INF, 0,   1 },
            //            { INF, INF, INF, 0 }
            //        };

            int[,] graph = {
                        { 0,   4,  11 },
                        { 6,   0,   2 },
                        { 3, INF,   0 }
                    };
            FloydWarshall(graph, 3);


        }
    }
}
// Algorytm pochodzi ze strony:
// https://www.programmingalgorithms.com/algorithm/floyd%E2%80%93warshall-algorithm

// Zobacz również: http://eduinf.waw.pl/inf/alg/001_search/0138b.php