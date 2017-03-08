using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static int[,] labirynt = {
                                   {1, 0, 0, 0, 0, 0},
                                   {1, 1, 1, 0, 1, 0},
                                   {1, 0, 1, 0, 1, 1},
                                   {1, 1, 1, 1, 0, 0},
                                   {0, 0, 0, 1, 1, 1},
                               };

        static bool[,] bylem_tu;

        static void droga(int x1, int y1, int x2, int y2) {

            bylem_tu[x1, y1] = true;

            //Console.WriteLine("Jestem tu: {0} {1} {2} {3}", x1, y1, x2, y2);

            if (x1 == x2 && y1 == y2) {
                Console.WriteLine("OK");
            }

            if (labirynt[x1, y1] == 0)
                return; // jestem na œcianie, false

            if (x1 + 1 < labirynt.GetLength(0))
                if (bylem_tu[x1 + 1, y1] == false)
                    droga(x1 + 1, y1, x2, y2);

            if (x1 - 1 >= 0)
                if (bylem_tu[x1 - 1, y1] == false)
                    droga(x1 - 1, y1, x2, y2);

            if (y1 + 1 < labirynt.GetLength(1))
                if (bylem_tu[x1, y1 + 1] == false)
                    droga(x1, y1 + 1, x2, y2);

            if (y1 - 1 >= 0)
                if (bylem_tu[x1, y1 - 1] == false)
                    droga(x1, y1 - 1, x2, y2);

            return;
        }


        static void Main(string[] args) {

            for (int i = 0; i < labirynt.GetLength(0); i++) {
                for (int j = 0; j < labirynt.GetLength(0); j++) {
                    Console.Write(labirynt[i, j]);
                }
                Console.WriteLine();
            }

            bylem_tu = new bool[labirynt.GetLength(0), labirynt.GetLength(1)];
            droga(0, 0, 4, 5);

            for (int i = 0; i < labirynt.GetLength(0); i++)
            {
                for (int j = 0; j < labirynt.GetLength(0); j++)
                {
                    if (bylem_tu[i, j]) Console.Write(1); else Console.Write(0);
                }
                Console.WriteLine();
            }


            Console.ReadKey();
        }
    }
}
