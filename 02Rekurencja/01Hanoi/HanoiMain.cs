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
            const int N = 10;
            for(int i = 0; i < N; i++) {
                s += "o";
                towerA.Push(s);
            }
            foreach(var x in towerA)
                Console.WriteLine(x);

            MoveDisc(N, towerA, towerB, towerPom);

            foreach(var x in towerB)
                Console.WriteLine(x);
        }
    }
}
