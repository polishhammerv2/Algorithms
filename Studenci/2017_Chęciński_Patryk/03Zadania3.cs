using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1 {

    // Zmodyfikuj poznane algorytmy sortowania tak by można było przy ich pomocy posortować listę jednokierunkową.

    class Program {

        //
        // Sortowanie przez wstawianie
        //
        static void sortowanieWstawianie(int[] tab)
        {
            int x, j;
            for (int i = 1; i < tab.Length - 1; i++)
            {
                //a[0..i-1] jest już posortowana
                x = tab[i]; //odkładamy element z pozycji i
                j = i;
                while (j > 0 && x < tab[j - 1])
                {
                    tab[j] = tab[j - 1]; //przesuwamy element większy od x o jedną pozycję w prawo    
                    j = j - 1;
                }
                tab[j] = x;
            }
        }

        //
        // Merge Sort
        //
        public static void MergeSort(int[] input, int low, int high)
        {
            if (low < high)
            {
                int middle = (low / 2) + (high / 2);
                MergeSort(input, low, middle);
                MergeSort(input, middle + 1, high);
                Merge(input, low, middle, high);
            }
        }

        public static void MergeSort(int[] input)
        {
            MergeSort(input, 0, input.Length - 1);
        }

        private static void Merge(int[] input, int low, int middle, int high)
        {
            int left = low;
            int right = middle + 1;
            int[] tmp = new int[(high - low) + 1];
            int tmpIndex = 0;

            while ((left <= middle) && (right <= high))
            {
                if (input[left] < input[right])
                {
                    tmp[tmpIndex] = input[left];
                    left = left + 1;
                }
                else
                {
                    tmp[tmpIndex] = input[right];
                    right = right + 1;
                }
                tmpIndex = tmpIndex + 1;
            }

            if (left <= middle)
            {
                while (left <= middle)
                {
                    tmp[tmpIndex] = input[left];
                    left = left + 1;
                    tmpIndex = tmpIndex + 1;
                }
            }
            if (right <= high)
            {
                while (right <= high)
                {
                    tmp[tmpIndex] = input[right];
                    right = right + 1;
                    tmpIndex = tmpIndex + 1;
                }
            }
            for (int i = 0; i < tmp.Length; i++)
            {
                input[low + i] = tmp[i];
            }
        }

        //
        // QuictSort
        //
        public static void QuickSort(int[] input, int left, int right)
        {
            if (left < right)
            {
                int q = Partition(input, left, right);
                QuickSort(input, left, q - 1);
                QuickSort(input, q + 1, right);
            }
        }

        private static int Partition(int[] input, int left, int right)
        {
            int pivot = input[right];
            int temp;

            int i = left;
            for (int j = left; j < right; j++)
            {
                if (input[j] <= pivot)
                {
                    temp = input[j];
                    input[j] = input[i];
                    input[i] = temp;
                    i++;
                }
            }

            input[right] = input[i];
            input[i] = pivot;

            return i;
        }

        class Lista
        {
            public int wartosc;
            public Lista next;

            public Lista(int wartosc)
            {
                this.wartosc = wartosc;
            }

        }

        // ----
        static void DodajElement(ref Lista l, int val)
        {

            Lista tmp = l;
            l = new Lista(val);
            l.next = tmp;

        }

        static void WyświetlListe(Lista l)
        {

            Console.Write("{0} ", l.wartosc);

            if (l.next != null)
            {
                WyświetlListe(l.next);
            }
        }

        static void UsuńPrzód(ref Lista l)
        {

            l = l.next;

        }

        static int DługośćListy(Lista l)
        {
            if (l.next != null)
            {
                return 1 + DługośćListy(l.next);
            }

            return 1;
        }

        static void DodajNaKońcu(Lista l, int wartosc)
        {

            if (l.next != null)
            {
                DodajNaKońcu(l.next, wartosc);
            }
            else
            {
                l.next = new Lista(wartosc);
            }

        }


        static bool SzukajElementu(Lista l, int szukana)
        {

            if (l.wartosc == szukana)
            {
                return true;
            }
            else
            {
                if (l.next != null)
                {
                    return SzukajElementu(l.next, szukana);
                }
            }

            return false;

        }
        // ----


        static void Swap(int[] tab, int i, int j)
        {
            int pom = tab[i];
            tab[i] = tab[j];
            tab[j] = pom;
        }

        static void sortowanieBabelkowe(Lista l) {
  
            bool czy_swapowal = false;

            do {
                Lista aktualny = l;
                czy_swapowal = false;

                while (aktualny.next != null) {

                    if (aktualny.next.wartosc > aktualny.wartosc) {

                        int tmp = aktualny.wartosc;
                        aktualny.wartosc = aktualny.next.wartosc;
                        aktualny.next.wartosc = tmp;

                        czy_swapowal = true;
                    }

                    aktualny = aktualny.next;
                }

            }
            while (czy_swapowal);

        }



        static void Main(string[] args) {

            Lista lista = new Lista(231);
            DodajElement(ref lista, 332);
            DodajElement(ref lista, 3415);
            DodajElement(ref lista, 4342);
            DodajElement(ref lista, 1252);




            Console.WriteLine("- WyświetlListe -------------\n");
            WyświetlListe(lista);

            sortowanieBabelkowe(lista);

            Console.WriteLine("\n- WyświetlListe -------------\n");
            WyświetlListe(lista);

            Console.ReadKey();


        }
    }
}
