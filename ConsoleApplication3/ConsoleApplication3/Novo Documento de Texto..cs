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

        // não retorna dados/ não é obrigado -> tem que se usar o OUT para returnar valores ou returnar a struct em si
        static void canivete_suiço(int a, int b, out Queijo)
        {
            Queijo q = new ConsoleApplication4.Program.Queijo();
            q.sum = a + b;
            q.mul = a * b;
            q.div = a / b;
            q.sub = a - b;

        }

        struct Queijo
        {
            public int sum;
            public int mul;
            public int div;
            public int sub;
        }


        // não retorna dados/ não é obrigado
        static void canivete_suiço(string[] args)
        {
            c = a + b;
            d = a + b;
        }
    }
}