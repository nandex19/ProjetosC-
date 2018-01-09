using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hastable
{
    struct Stripper
    {
        public string nome;
        public string classe;
        public string categoria;
        public string genero;


        public void preenche(string n, string cl, string ca, string g)
        {
            nome = n;
            classe = cl;
            categoria = ca;
            genero = g;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList a = new ArrayList();
            Stack s = new Stack();
            Queue q = new Queue();
            Hashtable h = new Hashtable();
            SortedList sl = new SortedList();
            Stripper xxx1 = new Stripper();
            Stripper xxx2 = new Stripper();
            Stripper xxx3 = new Stripper();
            Stripper xxx4 = new Stripper();
            Stripper xxx5 = new Stripper();
            xxx1.preenche("Krystal", "Alta", "Porcherie", "Mulher");
            xxx2.preenche("Rox", "Alta", "Porcherie", "Mulher");
            xxx3.preenche("Jorge", "Alta", "Porcherie", "Homem");
            xxx4.preenche("Misterio", "Alta", "Porcherie", "Mulher");
            xxx5.preenche("Goldie", "Alta", "Porcherie", "Mulher");


            //arrayList
            a.Add(xxx1);
            a.Add(xxx2);
            a.Add(xxx3);
            a.Add(xxx4);
            a.Add(xxx5);

            //stack -> inserir os stripers na stack
            s.Push(xxx1);
            s.Push(xxx2);
            s.Push(xxx3);
            s.Push(xxx4);
            s.Push(xxx5);

            //queue
            q.Enqueue(xxx1);
            q.Enqueue(xxx2);
            q.Enqueue(xxx3);
            q.Enqueue(xxx4);
            q.Enqueue(xxx5);

            //hashtable
            h.Add(xxx1.nome, xxx1);
            h.Add(xxx2.nome, xxx2);
            h.Add(xxx3.nome, xxx3);
            h.Add(xxx4.nome, xxx4);
            h.Add(xxx5.nome, xxx5);

            //sortedlist
            sl.Add(xxx1.nome, xxx1);
            sl.Add(xxx2.nome, xxx2);
            sl.Add(xxx3.nome, xxx3);
            sl.Add(xxx4.nome, xxx4);
            sl.Add(xxx5.nome, xxx5);

            //percorre arraylist
            Console.WriteLine("\nArray List\n");
            foreach(Stripper sss in a)
            {
                Console.WriteLine(sss.nome);
            }

            //percorre stack
            Console.WriteLine("\nStack\n");
            foreach (Stripper sss in s)
            {
                Console.WriteLine(sss.nome);
            }

            //percorre queue
            Console.WriteLine("\nQueue\n");
            foreach (Stripper sss in q)
            {
                Console.WriteLine(sss.nome);
            }

            //percorre hastable
            Console.WriteLine("\nHastable\n");
            foreach (Stripper sss in h.Values)
            {
                Console.WriteLine(sss.nome);
            }

            //percorre sortedList
            Console.WriteLine("\nSorted List\n");
            foreach (Stripper sss in sl.Values)
            {
                Console.WriteLine(sss.nome);
            }
        }
    }
}
