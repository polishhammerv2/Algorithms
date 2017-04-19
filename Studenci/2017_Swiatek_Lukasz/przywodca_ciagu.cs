using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadania_1.Podstawy
{
    class Program
    {
        static void Przywodca_ciagu(int [] tab)
        {
            int indeks=0;
            int pomocnicza = 0;
            int [] tablica_licznikow = new int [tab.Length];
            for(int i=0; i<tab.Length;i++){
                indeks = tab[i];
                tablica_licznikow[indeks] += 1;
            }
             for(int j=0;j<tablica_licznikow.Length;j++){
             if(tablica_licznikow[j]>tab.Length/2){
                 pomocnicza = j;
             }}
                 if(pomocnicza != 0){
                     Console.WriteLine("Liczba {0} jest przywódcą ciągu",pomocnicza);
                 }
                 else
                 {
                     Console.WriteLine("Nie ma przywódcy ciagu");
                 }
            
           
           
                }
            
            
               
            
        
        static void Main(string[] args)
        {
            while (true)
            {
                int n;
                Console.WriteLine("Podaj długość tablicy do sprawdzenia");
                int.TryParse(Console.ReadLine(), out n);
                int[] proba = new int[n];
                Random uzupelnianie = new Random();
                for (int i = 0; i < n; i++)
                {
                    proba[i] = uzupelnianie.Next(0, n);
                }
                Przywodca_ciagu(proba);
                Console.ReadKey();
            }
        }
    }
}
