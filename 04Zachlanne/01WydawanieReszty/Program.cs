using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01WydawanieReszty {
    class Program {
        static void Main(string[] args) {
            //int [] nominalyMonet = { 20, 10, 5, 1 };
            //int kwotaDoWydania = 42;

            int[] nominalyMonet = { 11, 5, 3 };
            int kwotaDoWydania = 15;

            int[] licznikMonet = new int[nominalyMonet.Length];

            int biezacyNominalIdx = 0;
            int doWydania = kwotaDoWydania;
            bool koniec = false;

            while(doWydania > 0 && ! koniec) {
                if(doWydania >= nominalyMonet[biezacyNominalIdx]) {
                    doWydania -= nominalyMonet[biezacyNominalIdx];
                    licznikMonet[biezacyNominalIdx]++;
                } else if(biezacyNominalIdx < nominalyMonet.Length - 1)
                    biezacyNominalIdx++;
                else koniec = true;
            }
            if(doWydania > 0) {
                Console.WriteLine("Nie udało się. Reszta: {0}", doWydania);
                for(int i = 0; i < licznikMonet.Length; i++)
                    Console.WriteLine("{0} : {1} = {2}", licznikMonet[i], nominalyMonet[i], licznikMonet[i] * nominalyMonet[i]);
            } else {
                Console.WriteLine("Udało się. Reszta: {0}", doWydania);
                for(int i = 0; i < licznikMonet.Length; i++)
                    Console.WriteLine("{0} : {1} = {2}", licznikMonet[i], nominalyMonet[i], licznikMonet[i] * nominalyMonet[i]);
            }
        }
    }
}
