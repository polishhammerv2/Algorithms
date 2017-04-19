using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    public class Node
    {
        public int value;
        public Node nextNode;

        public Node(int v)
        {
            this.value = v;
            this.nextNode = null;
        }

        public int Dlugosc
        {
            get { return (nextNode == null ? 1 : 1 + nextNode.Dlugosc); }
        }

        public override string ToString()
        {
            if (nextNode == null)
                return value + "";
            return value + ", " + nextNode.ToString();
        }
    }

    public class Lista
    {
        public Node head = null;
        public Node tail = null;

        public void dodajNaPoczatek(Node node)
        {
            node.nextNode = head;
            tail = head;
            head = node;
        }
        public void add(int v)
        {
            Node node = new Node(v);
            node.nextNode = head;
            tail = head;
            head = node;
        }
        public void usunGlowe()
        {
            if (head != null)
            {
                head = tail;
                if (tail != null)
                    tail = tail.nextNode;
            }
        }
        public void deleteSecond() // Usuwanie drugiego noda
        {
            if (head != null)
            {
                if (head.nextNode != null)
                    head.nextNode = head.nextNode.nextNode;
            }
        }
        public int Dlugosc
        {
            get { return (head == null ? 0 : head.Dlugosc); }
        }
        public override string ToString()
        {
            if (head == null) return "NULL";
            return head.ToString();
        }
        public int this[int index] //Index listy
        {
            get
            {
                if (index >= this.Dlugosc) throw new Exception("Index out of bounds");
                tail = head;
                while (index > 0)
                {
                    index--;
                    tail = tail.nextNode;
                }
                if (index == 0) return tail.value;
                return 0;
            }
            set
            {
                if (index >= this.Dlugosc) throw new Exception("Index out of bounds");
                tail = head;
                while (index > 0)
                {
                    index--;
                    tail = tail.nextNode;
                }
                if (index == 0) tail.value = value;
            }
        }
        public void removeAt(int index) //Usuwanie na indexie
        {
            if (index == 0) usunGlowe();
            if (index >= this.Dlugosc) throw new Exception("Index out of bounds");
            index--;
            tail = head;
            while (index > 0)
            {
                index--;
                tail = tail.nextNode;
            }
            tail.nextNode = tail.nextNode.nextNode;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Lista lista = new Lista();

            Console.WriteLine("#: {1}: {0}", lista, lista.Dlugosc);

            lista.dodajNaPoczatek(new Node(1));
            lista.dodajNaPoczatek(new Node(2));
            lista.dodajNaPoczatek(new Node(3));
            lista.dodajNaPoczatek(new Node(4));
            lista.add(8);
            lista.add(14);
            lista.add(55);
            lista.add(32);
            lista.add(15);
            
            Console.WriteLine("li[8]: " + lista[8]);
            lista[8] = 5;
            Console.WriteLine("#: {1}: {0}", lista, lista.Dlugosc);
            lista.removeAt(7);
            Console.WriteLine("li[0]: " + lista[0]);
            Console.WriteLine("#: {1}: {0}", lista, lista.Dlugosc);

            //lista.usunGlowe();
            Console.ReadKey();
        }
    }
}
