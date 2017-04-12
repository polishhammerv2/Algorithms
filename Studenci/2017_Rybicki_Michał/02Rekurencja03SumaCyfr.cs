using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie4
{
    class Program
    {
        static void ZliczCyfryWLiczbie(int liczba)
        {
            int  sumaCyfr = 0, zmiennaPomocnicza = 0;


                zmiennaPomocnicza = liczba % 10;
                liczba = liczba / 10;
                sumaCyfr = sumaCyfr + zmiennaPomocnicza;

            if(liczba != 0)
            {
                ZliczCyfryWLiczbie(liczba);
            }
               else
               Console.WriteLine(sumaCyfr);

        }// tak się nie udało, bo sumaCyfr ciągle się zerowała

        static int ZliczCyfryWLiczbie2(int liczba)
        {
            if (liczba > 0)
                return liczba % 10 + ZliczCyfryWLiczbie2(liczba / 10);

            return 0;
        }

        static void Main(string[] args)
        {//Napisz program, który wyznaczy sumę cyfr liczby naturalnej z zakresu [0...1020]. Rozwiąż zadanie metodą rekurencyjną.

            Console.WriteLine(ZliczCyfryWLiczbie2(543));

        }
    }
}
