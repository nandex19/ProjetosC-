using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        
        struct Data
        {
            public int ano;
            public int mes;
            public int dia;
            public int horas;
            public int minutos;
        }

        struct Pessoa //facilitar e automizar o processo de procurar ou usar a informação relativa à classe
        {
            
            public string nome;
            public Data data_nascimento;
            public int idade;
            public int nif;
            public float dinheiro;

        }

        static void Main(string[] args)
        {

            //pessoa
            Pessoa p = new Pessoa();
            p.nome = "Manuel";
            p.dinheiro = 100.0f;
            p.idade = 56;
            p.nif = 123123123;
            p.data_nascimento.ano = 1961;
            p.data_nascimento.mes = 1;
            p.data_nascimento.dia = 13;
            p.data_nascimento.horas = 3;
            p.data_nascimento.minutos = 43;

            Pessoa p2 = new Pessoa();
            p.nome = "António";
            p2.dinheiro = 10.0f;
            p2.idade = 66;
            p2.nif = 10000001;
            p2.data_nascimento.ano = 1951;
            p2.data_nascimento.mes = 2;
            p2.data_nascimento.dia = 13;
            p2.data_nascimento.horas = 3;
            p2.data_nascimento.minutos = 43;


            if (p.nome == "António")
            {
                Console.WriteLine("Toma lá 10 euros!");
            }
            else
            {
                Console.WriteLine("Voce não é o António");
            }
        }
    }
}
