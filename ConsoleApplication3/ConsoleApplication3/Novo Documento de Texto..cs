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

        // n�o retorna dados/ n�o � obrigado -> tem que se usar o OUT para returnar valores ou returnar a struct em si
        static void canivete_sui�o(int a, int b, out Queijo)
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


        // n�o retorna dados/ n�o � obrigado
        static void canivete_sui�o(string[] args)
        {
            c = a + b;
            d = a + b;
        }
    }
}