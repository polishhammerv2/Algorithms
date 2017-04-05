using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02Plecak {
    class Program {
        static void Main(string[] args) {
            int pojemnoscPlecaka = 20;
            int[] profity = { 25, 24, 15 };
            int[] wagi = { 18, 15, 10 };

            double[] gestoscProfitu = new double[profity.Length];

            for(int i = 0; i < profity.Length; i++)
                gestoscProfitu[i] = (1.0 * profity[i]) / wagi[i];

            Array.Sort(gestoscProfitu);
            Array.Reverse(gestoscProfitu);

            int indeks = 0;
            while(pojemnoscPlecaka > 0 && indeks < profity.Length - 1) {
                // .... 
            }
        }
    }
}
