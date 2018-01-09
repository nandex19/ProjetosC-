using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            //pedir um numero de sorte 0- 50
            //se for 13 -> ganhou 1 centimo
            //se for 22 --> vai para a prisao
            //se for 45 --> ganhas 10 euros
            //se for 3 - > ganha, 100000000 euros
            // se for 11 -> ganham um par de estalos

            Console.WriteLine("Escolhe um numero de 1 a 50");
            string s = Console.ReadLine();

            int x = Int32.Parse(s);
            if (x < 1 || x > 50)
            {
                Console.WriteLine("burro o numero Ã© atÃ© 50");
            }

            switch (x)
            {
                case (13):
                    {
                        Console.WriteLine("Gaanhou um centimo");
                    }
                    break;
                case (22):
                    {
                        Console.WriteLine("vais para a prisÃ£o");
                    }
                    break;
                case (3):
                    {
                        Console.WriteLine("ganha, 100000000 euros");
                    }
                    break;
                case (45):
                    {
                        Console.WriteLine("ganhou 10 euros");
                    }
                    break;
                case (11):
                    {
                        Console.WriteLine("par de estalos");
                    }
                    break;
                default:
                    { }

                    break;

            }
            Console.ReadLine();
        }
    }
}
