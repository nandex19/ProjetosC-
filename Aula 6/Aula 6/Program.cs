using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_5
{
    class Banco
    {
        //variaveis
        private float dinheiroTotal;
        private Pessoa[] clientes;
        public int numClientes;
        
        //métodos
        //contar o dinheiro do banco
        if()
        {
            void contarDinheiro()
            {
            float d = 0;
                for (int i = 0; i <= numClientes; i++)
                {
                    dinheiroTotal += clientes[i].getDinheiro();
                }
            }
        }

    //dizer quando dinheiro tem
    public float getDinheiro()
    {
        return dinheiro;
    }

        public void addClientes(Pessoa[] c)
        {
            for (int i = 0; i <= numClientes; i++)
            {
            clientes[i] = c[i];
        }
        }

        //contrutor
        public Banco()
        {
        dinheiro = 0.0f;
        numClientes = 3;

        }
    }
    class Pessoa
    {
        //esta é uma classe, dividida em instancias de:
        //variáveis -> dados
        private string nome; //->private certificasse que só a própria classe Pessoa é que pode aceder aos dados
        private int idade;
        private float dinheiro;
        private string sexo;

    //métodos
    //->public certificasse que os dados dentro podem ser manipulados por outros metodos
    public float getDinheiro()
    {
        return dinheiro;
    }
    public bool eReformado()
        {
            if (idade >= 65)
            {

                return true;
            }
            else
            {
                return false;
            }
        }

        private void mudadeDeSexo()
        {
            if (sexo == "masculino")
            {
                sexo = "feminino";
            }
            else
            {
                sexo = "masculino";
            }
        }

        public void depositarDinheiro(float d)
            {
            //por dinheiro no banco
            dinheiro -= d;
        }
        
        //Cria objetos
        public Pessoa() //contrutor 1º maneira de fazer
        {
            nome = "John SBritomith";
            idade = 17;
            dinheiro = 0.0f;
            sexo = "Masculino";
        }
        public Pessoa(string n, int i, float d, string s) //contrutor 2ª maneira de fazer
        {
            nome = n;
            idade = i;
            dinheiro = d;
            sexo = s;
        }
    
    }

    class Program
    {
        static void Main(string[] args)
        {
            Pessoa p = new Pessoa(); //-> criar-la mas com dados no contrutor -> 1º maneira do construtor
            Pessoa p2 = new Pessoa("Tó", 45, 2345.01f, "Masculino"); //-> passar informações a criar-la -> 2º maneira do construtor
            Pessoa p3 = new Pessoa("Nhó", 45, 2345.01f, "Masculino");
            ps[1] = p;
            ps[2] = p2;
            ps[1] = p3;

            Banco b = new Banco();
            b.addClientes(ps);
            


            Console.WriteLine("O dinheiro de todos os clientes é: " + dinheiroTotal);
        }
    }
}
