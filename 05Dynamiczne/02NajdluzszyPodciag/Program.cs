using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02NajdluzszyPodciag {

    class Program {
        static string NajdlPodciag(string A, string B) {
            int[,] L = new int[A.Length+1, B.Length+1];

            for(int i = 0; i < A.Length; i++)
                L[i, 0] = 0;
            for(int i = 0; i < B.Length; i++)
                L[0, i] = 0;
            int length = 0, wA = 0, wB = 0;
            for(int i = 0; i < A.Length; i++) {
                for(int j = 0; j < B.Length; j++)
                    if(A[i] != B[j])
                        L[i+1, j+1] = 0;
                    else {
                        L[i+1, j+1] = L[i, j] + 1;
                        if(L[i+1, j+1] > length) {
                            length = L[i+1, j+1];
                            wA = i+1;
                            wB = j+1;
                        }
                    }
            }
            for(int i = 0; i <= A.Length; i++) {
                for(int j = 0; j <= B.Length; j++)
                    Console.Write("{0}, ", L[i, j]);
                Console.WriteLine();
            }
            return A.Substring(wA - length, length);
        }
        static void Main(string[] args) {
            //string A = "HALO", B = "ALOHA";
            //string A = "PROMOTOR", B = "MIESZKANIE";
            string A = "WIELOBRANZOWY", B = "PRZEBRANZOWIENIE";

            Console.WriteLine(NajdlPodciag(A, B));
        }
    }
}
