using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Przywodca
{
    class Program
    {
        public static int Przywodca(int[] tab)
        {

            int ile = 0;
            int j = 0;
            for (int i = 0; i < tab.Length; i++)
            {
                if (ile == 0)
                {
                    ile++;
                    j = i;
                }
                else if (tab[i] == tab[j])
                {
                    ile = ile++;
                }
                else ile--;
            }
             return tab[j];
        }
        static void Main(string[] args)
        {
            int[] tab = { 1, 1, 2, 2, 1, 3, 1, 4, 1, 7, 1, 6, 2, 1};
            Console.Write(Przywodca(tab));
            Console.Read();
        }
    }
}
