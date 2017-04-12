using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        class liczba
        {
            public int wartosc;
            public liczba nastepny;
        };

        static void dodaj(ref liczba s, int val)
        {
            liczba nowa = new liczba();
            nowa.wartosc = val;
            nowa.nastepny = s;
            s = nowa;
        }

        static int zdejmij(ref liczba s)
        {
            if (s == null) return 0;

            int val = s.wartosc;
            s = s.nastepny;
            return val;
        }


        static void Main(string[] args)
        {
            liczba stosik = new liczba();

            dodaj(ref stosik, 1);
            dodaj(ref stosik, 2);
            dodaj(ref stosik, 3);
            dodaj(ref stosik, 4);

            Console.WriteLine(zdejmij(ref stosik));
            Console.WriteLine(zdejmij(ref stosik));
            Console.WriteLine(zdejmij(ref stosik));
            Console.WriteLine(zdejmij(ref stosik));

            Console.ReadKey();
        }
    }
}
