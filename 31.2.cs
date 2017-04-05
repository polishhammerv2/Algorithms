using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1 {

    class Element {

        public int wartosc;
        public int ilosc = 1;
        Element lewy;
        Element prawy;

        public Element (int _wartosc) {
            wartosc = _wartosc;
        }

        public void dodajWartosc(int n) {

            if (wartosc == n) {
                ilosc++;
            }

            if (n > wartosc) {

                if (prawy == null) {
                    prawy = new Element(n);
                }
                else {
                    prawy.dodajWartosc(n);
                }

            }

            else {

                if (lewy == null) {
                    lewy = new Element(n);
                }
                else {
                    lewy.dodajWartosc(n);
                }

            }

        }

        public void wypiszWartosci() {


            if (lewy != null) {
                lewy.wypiszWartosci();
            }

            for (int i = 0; i < ilosc; i++) {
                Console.WriteLine(wartosc);
            }


            if(prawy != null) {
                prawy.wypiszWartosci();
            }

        }
    }




    class Program {


        static void Main(string[] args) {

            Element struktura = new Element(30);
            Random r = new Random();

            for (int i = 0; i < 10; i++) {
                struktura.dodajWartosc(r.Next(100));
            }

            struktura.wypiszWartosci();
          


            Console.ReadKey();
        }
    }
}
