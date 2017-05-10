using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03MnozenieCiaguMacierzy {
    class Program {

        static void printMatrix(int[,] m) {
            int rows = m.GetLength(0);
            int cols = m.GetLength(1);

            for(int y = 0; y < rows; y++) {
                for(int x = 0; x < cols; x++)
                    Console.Write("{0}\t", m[x, y]);
                Console.WriteLine();
            }
        }

        static void Main(string[] args) {
            List<int> rozmiary = new List<int>() { 6, 12, 20, 3, 10, 5, 18 };
            int n = rozmiary.Count() - 1;
            int[,] m = new int[n + 1, n + 1];

            int j, t;
            for(int i = 1; i <= n; i++) { m[i, i] = 0; };

            for(int l = 2; l <= n; l++) {
                for(int i = 1; i <= n - l + 1; i++) {
                    j = i + l - 1;
                    m[i, j] = int.MaxValue;
                    for(int k = i; k <= j - 1; k++) {
                        t = m[i, k] + m[k + 1, j] +
                            rozmiary.ElementAt(i - 1) * rozmiary.ElementAt(k) * rozmiary.ElementAt(j);
                        if(t < m[i, j]) {
                            m[i, j] = t;
                            //Console.WriteLine("m[{0}, {1}] = {2}", i, j, m[i, j]);
                        }
                    }
                }
                Console.WriteLine("l = {0}", l);
                printMatrix(m);
                Console.WriteLine();
            };
            Console.WriteLine(m[1, n]);
        }
    }
}
// Algorytm w C# wykorzystujący powyższy do prawdziwego mnożenia macierzy został zaprezentowany na stronie:
// http://www.rkinteractive.com/blogs/SoftwareDevelopment/post/2013/04/05/Algorithms-In-C-Matrix-Multiplication.aspx
