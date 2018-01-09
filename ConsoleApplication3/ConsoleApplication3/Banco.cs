using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {

        struct Pessoa //facilitar e automizar o processo de procurar ou usar a informação relativa à classe
        {

            public string nome;
            public float dinheiro;

        }

        struct Banco //facilitar e automizar o processo de procurar ou usar a informação relativa à classe
        {

            public Pessoa[] clientes;
            public float dinheiro;
            public int numero_clientes;

        }

        static void Main(string[] args)
        {
            float dinheiro_total = 0;
            //pessoa
            Pessoa p = new Pessoa();
            p.nome = "Zé";
            p.dinheiro = 150.0f;

            Pessoa p1 = new Pessoa();
            p.nome = "Tó";
            p1.dinheiro = 50.0f;

            Pessoa p2 = new Pessoa();
            p.nome = "Bó";
            p2.dinheiro = 100.0f;

            Banco B = new Banco();
            B.clientes = new Pessoa[3];
            B.numero_clientes = 3;
            B.dinheiro = 0;
            B.clientes[0] = p;
            B.clientes[1] = p1;
            B.clientes[2] = p2;

            for (int i = 0; i < B.numero_clientes; i++)
            {
                dinheiro_total += B.clientes[i].dinheiro;
            }

            //qual o dinheiro que tem o tó
            string nn = "Tó";

            for (int i = 0; i < B.numero_clientes; i++)
            {
                if (B.clientes[i].nome)
                {
                    Console.WriteLine("O senhor tem: " + B.clientes[i].dinheiro + "euros!");
                }
            }

            Console.WriteLine("O dinheiro de todos os clientes é: " + dinheiro_total);
            Console.ReadLine(); 
        }

        
    }
}
