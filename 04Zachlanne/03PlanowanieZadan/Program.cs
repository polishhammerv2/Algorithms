using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03PlanowanieZadan {
    struct Zadanie {
        public int start;
        public int stop;
        public Zadanie(int start, int stop) {
            this.start = start;
            this.stop = stop;
        }
        public override string ToString() {
            return "(" + start + ", " + stop + ")";
        }
    }
    class Maszyna {
        public int start;
        public int stop;
        public void setJob(int start, int stop) {
            this.start = start;
            this.stop = stop;
        }
        public bool isFreeAt(int time) {
            return (time < start) || (time >= stop);
        }
    }
    class Program {
        static void Main(string[] args) {
            Zadanie[] zadania = {
            new Zadanie(7, 8), new Zadanie(1, 3), new Zadanie(2, 5),
            new Zadanie(3, 7), new Zadanie(4, 7), new Zadanie(6, 9),
            new Zadanie(1, 4)
        };
            List<Maszyna> maszyny = new List<Maszyna>();

            Array.Sort(zadania, (z1, z2) => (z1.start < z2.start ? -1 : 1));
            Console.WriteLine(string.Join(",", zadania));
            Maszyna m0;
            for(int i = 0; i < zadania.Length; i++) {
                m0 = maszyny.Find(m => m.isFreeAt(zadania[i].start));
                if(m0 == null) {
                    m0 = new Maszyna();
                    maszyny.Add(m0);
                }
                m0.setJob(zadania[i].start, zadania[i].stop);
                Console.WriteLine("Maszyna: {0}, pracuje nad: {1}", 
                    maszyny.FindIndex(m => m.Equals(m0)),
                    zadania[i]
                    );
            }
            Console.WriteLine("Potrzeba {0} maszyn", maszyny.Count);
        }
    }
}
