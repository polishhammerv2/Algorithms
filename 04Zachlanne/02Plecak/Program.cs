using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02Plecak {
    class Program {
        static void Main(string[] args) {
            int pojemnoscPlecaka = 25;
            int[] profity = { 5, 10, 11, 8 };
            int[] wagi = { 20, 15, 10, 5 };
            int[] wynik = { 0, 0, 0, 0 };
            double maxValue;
            int maxIndex;

            double[] gestoscProfitu = new double[profity.Length];

            for(int i = 0; i < profity.Length; i++)
                gestoscProfitu[i] = (1.0 * profity[i]) / wagi[i];

            //Array.Sort(gestoscProfitu);
            //Array.Reverse(gestoscProfitu);
            Console.WriteLine("Gęstości");
            Console.WriteLine(string.Join("  ", gestoscProfitu));
            int indeks = 0;
            while(pojemnoscPlecaka > 0 && indeks < profity.Length - 1) {
                maxValue = gestoscProfitu.Max();
                maxIndex = gestoscProfitu.ToList().IndexOf(maxValue);
                if(pojemnoscPlecaka >= wagi[maxIndex]) {
                    wynik[maxIndex] = wagi[maxIndex];
                    pojemnoscPlecaka -= wagi[maxIndex];
                    gestoscProfitu[maxIndex] = -1;
                } else {
                    wynik[maxIndex] = pojemnoscPlecaka;
                    pojemnoscPlecaka = 0;
                    gestoscProfitu[maxIndex] = -1;
                }
                indeks++;
            }
            Console.WriteLine("Pojemność: {0}", pojemnoscPlecaka);
            Console.WriteLine(string.Join("  ", gestoscProfitu));
            Console.WriteLine(string.Join("  ", wagi));
            Console.WriteLine(string.Join("  ", wynik));
            // .... 
        }
    }
}

