using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Program
    {

        struct Pessoa //facilitar e automizar o processo de procurar ou usar a informação relativa à classe
        {

            public string nome;
            public float dinheiro;
            public string sexo; // masculino ou feminino

        }

        struct Banco //facilitar e automizar o processo de procurar ou usar a informação relativa à classe
        {

            public Pessoa[] clientes;
            public float dinheiro;
            public int numero_clientes;

            public string procura(string n)
            {
                string resultado = n + "não existe no banco!";
                for (int i = 0; i < numero_clientes; i++)
                {
                    if (clientes[i].nome == n)
                    {
                        resultado = ("O " + clientes[i].nome + "senhor tem: " + clientes[i].dinheiro + "euros!");
                    }
                }
                return resultado;
            }
        }

        static float dinheiro_m(Banco b)
        {
            float resultado = 0;

            for (int i = 0; i < b.numero_clientes; i++)
            {
                if (b.clientes[i].sexo == "feminino")
                {
                    Console.WriteLine("As mulheres têm " + b.clientes[i].dinheiro + "euros!");
                }
            }
            return resultado;
        }
              
             int d;   
            static int procurar_acimade100(Banco B, int d)
                {   
                    int resultado = 0;
                    for (int i = 0; i < B.numero_clientes; i++)
                    {
                        if (B.clientes[i].dinheiro >= 100)
                        {
                             resultado += 1;
                        }
                    }
                    return resultado;
                }
        
        
        
        static void Main(string[] args)
        {
            float dinheiro_total = 0;
            //pessoa
            Pessoa p = new Pessoa();
            p.nome = "Tó";
            p.sexo = "masculino";
            p.dinheiro = 50.0f;

            Pessoa p1 = new Pessoa();
            p1.nome = "Zeza";
            p1.sexo = "feminino";
            p1.dinheiro = 100.0f;



            Banco B = new Banco();
            B.clientes = new Pessoa[2];
            B.numero_clientes = 2;
            B.dinheiro = 0;
            B.clientes[0] = p;
            B.clientes[1] = p1;

            string r = B.procura("Zeza");

            for (int i = 0; i < B.numero_clientes; i++)
            {
                dinheiro_total += B.clientes[i].dinheiro;
            }

            

            //percorrer o array para encontrar um nome especifico
            for (int i = 0; i < B.numero_clientes; i++)
            {
                if (B.clientes[i].nome == "Tó")
                {
                    Console.WriteLine("O senhor tem: " + B.clientes[i].dinheiro + "euros!");
                }
            }
            //percorrer o array para encontrar um sexo especifico
            for (int i = 0; i < B.numero_clientes; i++)
            {
                if (B.clientes[i].sexo == "feminino")
                {
                    Console.WriteLine("É uma mulher!");
                }
            }




            // Console.WriteLine("O dinheiro de todos os clientes é: " + dinheiro_total);
            Console.ReadLine();
        }



    }
}
