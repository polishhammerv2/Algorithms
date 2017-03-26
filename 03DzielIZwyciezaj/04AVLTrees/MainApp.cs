using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04AVLTrees {
    class MainApp {
        static void Main(string[] args) {
            AVL tree = new AVL();
            tree.Add(1);
            tree.Add(2);
            tree.Add(3);
            tree.Add(4);
            tree.Add(5);
            tree.Add(6);
            tree.Add(7);
            tree.Add(8);
            tree.Add(9);
            tree.Add(10);

            tree.DisplayTree();
            tree.PrettyPrintTree();
        }
    }
}
