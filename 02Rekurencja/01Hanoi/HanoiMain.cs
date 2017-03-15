using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01Hanoi {
    class HanoiMain {
        static void MoveDisc(int numOfDiscs, Stack<String> fstTower,
                            Stack<String> sndTower, Stack<String> pomTower) {
            if(numOfDiscs > 0) {
                MoveDisc(numOfDiscs - 1, fstTower, pomTower, sndTower);
                sndTower.Push(fstTower.Pop());
                MoveDisc(numOfDiscs - 1, pomTower, sndTower, fstTower);
            }
        }
        static void Main(string[] args) {
            Stack<String> towerA = new Stack<String>(),
                towerB = new Stack<String>(),
                towerPom = new Stack<String>();
            String s = "";
            const int N = 20;
            for(int i = 0; i < N; i++) {
                s += "o";
                towerA.Push(s);
            }
            Console.WriteLine("A (przed): {0}", towerA.Count);
            Console.WriteLine("B (przed): {0}", towerB.Count);
            foreach(var x in towerA)
                Console.WriteLine(x);

            MoveDisc(N, towerA, towerB, towerPom);

            Console.WriteLine("A (po): {0}", towerA.Count);
            Console.WriteLine("B (po): {0}", towerB.Count);
            foreach(var x in towerB)
                Console.WriteLine(x);
        }
    }
}
