using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1 {
    class Program {
        static bool[,] plansza;
        static bool[,] hetman;
        static int N = 8;


        

        static void wypisz() {

            for (int i = 0; i < N; i++) {
                for (int j = 0; j < N; j++) {

                    if (hetman[i, j]) {
                        Console.Write("Q");
                    }

                    else if (plansza[i, j]) {
                        Console.Write(".");
                    }

                    else {

                        Console.Write(" ");
                    }

                }
                Console.WriteLine();
            }

        }

        static void zajmij(int i, int j) {


            for (int n = 0; n < N; n++) {
                plansza[i, n] = true;
                plansza[n, j] = true;
            }

            // w prawy dół
            for (int n = 0; i+n < N && j+n < N; n++) {

                plansza[i + n, j + n] = true;

            }

            // w lewy dół
            for (int n = 0; i + n < N && j -n >= 0; n++) {

                plansza[i + n, j - n] = true;
                    
            }

            // w prawa górę
            for (int n = 0; i - n >= 0 && j + n < N; n++) {

                plansza[i - n, j + n] = true;

            }

            // w lewą górę
            for (int n = 0; i - n >= 0 && j - n >= 0; n++) {

                plansza[i - n, j - n] = true;

            }

        }

        static bool postaw(){

            for (int i = 0; i < N; i++) {
                for (int j = 0; j < N; j++) {

                    if (!plansza[i, j]) {
 
                        hetman[i, j] = true;
                        zajmij(i, j);
                        //return true; ;

                    }

                }

            }

            return false;
        }



        static void Main(string[] args) {

            plansza = new bool[N, N];
            hetman = new bool[N, N];

            hetman[6, 4] = true;
            zajmij(6, 4);

            postaw();

            wypisz();

            Console.ReadKey();

        }
    }
}
