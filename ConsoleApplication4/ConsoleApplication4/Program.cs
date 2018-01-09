using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        struct Calculadora
        {
            public int soma_c(int a, int b)
            {
                return a + b;
            }
        }
         //funções podem ter o mesmo nome, tendo apenas que ter um numero de argumentos diferentes para não dar conflito
        static int soma_s(int a, int b)
        {
            return a + b;
        }

        static int soma_s(int a, int b, int c, int d, int e, int f)
        {
            return a + b + c + d + e + f;
        }

        static int soma_s(int a, int b, out int c)
        {
            g = a + b; 
        }

        //static significa que a função/método pode ser chamado em qualquer sitio e não está associado a nada
        static void Main(string[] args)
        {
            int x = soma_s(2, 3);
            Calculadora casio = new Calculadora();
            int y = soma_s(3, 2);
            int d = soma_s(3, 2, 2, 3, 4, 2);
        }
    }
}
