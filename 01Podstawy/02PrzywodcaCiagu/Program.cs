using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02PrzywodcaCiagu {
    class Program {
        static int PrzywodcaCiagu(int [] A) {
            int ile = 0;
            int j = 0;
            int n = A.Length;

            for (int i = 1; i <= n; i++)
                if (ile == 0) {
                    ile = ile + 1;
                    j = i;
                }
                else if (A[i] == A[j])
                    ile = ile + 1;
                    else ile = ile - 1;

            return A[j];
        }

            static void Main(string[] args) {
        }
    }
}
