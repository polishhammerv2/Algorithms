using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace List {

    class Lista {
        public int wartosc;
        public Lista next;

        public Lista(int wartosc) {
            this.wartosc = wartosc;
        }

    }

    class Program {

        /*
         Zadanie 1
            -----------
            Dla listy jednokierunkowej przechowuj¹cej elementy okreœlonego typu np. liczby ca³kowite napisz funkcje wykonuj¹ce nastêpuj¹ce operacje:
            – dodawanie elementu na pocz¹tek listy,
            – wyœwietlanie listy,
            – usuwanie elementu z przodu listy,
            - liczenie d³ugoœci listy,
            - dodawanie elementu do listy z zachowaniem porz¹dku
            - wyszukiwanie elementu listy
         */

        static void DodajElement(ref Lista l, int val) {

            Lista tmp = l;
            l = new Lista(val);
            l.next = tmp;

        }

        static void WyœwietlListe(Lista l) {

            Console.Write("{0} ", l.wartosc);

            if (l.next != null) {
                WyœwietlListe(l.next);
            }
        }

        static void UsuñPrzód(ref Lista l) {

            l = l.next;
            
        }

        static int D³ugoœæListy(Lista l) {
			if(l.next != null) {
                return 1 + D³ugoœæListy(l.next);
			}

            return 1;
		}

        static void DodajNaKoñcu(Lista l, int wartosc) {

            if (l.next != null) {
                DodajNaKoñcu(l.next, wartosc);
            } 
            else {
                l.next = new Lista(wartosc);
            }

        }


        static bool SzukajElementu(Lista l, int szukana) {

            if (l.wartosc == szukana) {
                return true;
            }
            else {
                if (l.next != null) {
                    return SzukajElementu(l.next, szukana);
                }
            }

            return false;

        }

        static void Main(string[] args) {

            Lista lista = new Lista(1);

            DodajElement(ref lista, 2);
            DodajElement(ref lista, 3);
            DodajElement(ref lista, 4);
            DodajElement(ref lista, 5);

            Console.WriteLine("- WyœwietlListe -------------\n");
            WyœwietlListe(lista);

            Console.WriteLine("\n- UsuñPrzód -------------\n");
            UsuñPrzód(ref lista);
            WyœwietlListe(lista);

            Console.WriteLine("\n- D³ugoœæListy -------------\n");
            Console.WriteLine("D³ugoœæ listy: {0}", D³ugoœæListy(lista));

            Console.WriteLine("\n- DodajNaKoñcu -------------\n");
            DodajNaKoñcu(lista, 230);
            WyœwietlListe(lista);

            Console.WriteLine("\n- SzukajElementu -------------\n");
            Console.WriteLine("Szukaj 3: {0}", SzukajElementu(lista, 3));
            Console.WriteLine("Szukaj 53: {0}", SzukajElementu(lista, 53));

            Console.ReadKey();



           
        }
    }
}
