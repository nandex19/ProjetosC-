using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula_projeto_1718
{
    //software para um bar de alternenativo

    //bar - check
    //funcionarios - check
    //produtos - check
    //clientes - check
    //quartos - check
    //finanças - check

    //serviços -> metodos que vão existir dentro das outras classes (maioritariamente)
    // -> balcão(cafés e derivados; bebidas espirituosas)
    // -> palco(striptease; stand ups; circo)
    // -> quartos
    // :: confessionário
    // :: 1 vs 1
    // :: 1 vs M
    // :: Orgia
    // :: BDSM
    // :: Exóticas

    //Funcionarios
    // :: lapdances
    // :: alimentação
    // :: limpeza
    // :: segurança
    // :: DJ azeites

    struct Palco
    {
        public int maximo;
        public bool varão;
        public List<Funcionarios> dançarinos;

    }

    class Bar
    {
        //variáveis
        private List<Clientes> clientes; //OU -> private ArrayList cc; //ArrayList -> utiliza a biblioteca 'System.Collections'
        private List<Produtos> produtos;
        private List<Funcionarios> funcionarios;
        private float dinheiro;
        private Quarto[] quarto;
        private Palco palco;
        //---------------------------------------
        private SortedList stock;  //-> <nomeproduto, produto>
        private Queue<Clientes> fila;
        //------------------------------------------------------------------
        //métodos - serviços
        //get e set

        internal List<Clientes> Clientes
        {
            get
            {
                return clientes;
            }

            set
            {
                clientes = value;
            }
        }

        internal List<Produtos> Produtos
        {
            get
            {
                return produtos;
            }

            set
            {
                produtos = value;
            }
        }

        internal List<Funcionarios> Funcionarios
        {
            get
            {
                return funcionarios;
            }

            set
            {
                funcionarios = value;
            }
        }

        public float Dinheiro
        {
            get
            {
                return dinheiro;
            }

            set
            {
                dinheiro = value;
            }
        }

        internal Quarto[] Quarto
        {
            get
            {
                return quarto;
            }

            set
            {
                quarto = value;
            }
        }

        internal Palco Palco
        {
            get
            {
                return palco;
            }

            set
            {
                palco = value;
            }
        }

        public SortedList Stock
        {
            get
            {
                return stock;
            }

            set
            {
                stock = value;
            }
        }

        internal Queue<Clientes> Fila
        {
            get
            {
                return fila;
            }

            set
            {
                fila = value;
            }
        }

        //------------------------------------------------------------------
        //<sumary>
        //serviços balcão

        //Métodos para a fila (queue)
        public void maisUm(Clientes c)
        {
            fila.Enqueue(c);
        }
        public void menosUm()
        {
            fila.Dequeue();
        }
        //------------------------------------------------------------------
        //Verifica se um produto com nome n existe em stock
        public bool existeProduto(string n)
        {
            bool res = false;

            foreach (Produtos p in Produtos)
            {
                if (n == p.Nome)
                {
                    res = true;
                }
            }
            return res;
        }

        //-------------------------------------------
        // método alternativo para vereficar a existencia de um dado produto
        public bool existeStock(string n)
        {
            return stock.ContainsKey(n);
        }
        //------------------------------------------------------------------
        //Método que verifica se um dado produto existe nas quantidades q
        public bool existeQuantidade(string n, int q)
        {
            bool res = false;
            if (existeProduto(n))
            {
                foreach (Produtos p in produtos)
                {
                    if (p.Quantidades >= q && p.Nome == n)
                    {
                        res = true;
                    }
                }
            }
            return res;
        }
        //------------------------------------------------------------------
        //Método alternativo para vereficar a quantidade de um dado produto utilizando sorted list
        public bool existeStockQuantidade(string n, int q)
        {

            bool res = false;
            if(stock.ContainsKey(n))
            {
                Produtos p = getDoStock(n);
                if(p.Quantidades >= q)
                {
                    res = true;
                }
            }
            return res;
        }
        //------------------------------------------------------------------
        //retira quantidade do produto ao ser usado
        public void daProduto(string n, int q)
        {
            if (existeQuantidade(n, q))
            {
                foreach (Produtos p in produtos)
                {
                    if (n == p.Nome)
                    {
                        p.Quantidades -= q;
                    }
                }
            }
        }
        //------------------------------------------------------------------
        //Método para calcular o valor a pagar de um produto n com quantidades q
        public float valorAPagar(string n, int q)
        {
            float res = 00.0f;
            if (existeQuantidade(n, q))
            {
                foreach (Produtos p in produtos)
                {
                    if (p.Nome == n)
                    {
                        res = p.Preço * q;
                    }
                }
            }
            return res;
        }
        //------------------------------------------------------------------
        //método igual ao valor a pagar1 mas utiliza menos tarefas(RAM) porque chama menos funçoes
        public float valorAPagar2(string n, int q)
        {
            float res = 0.0f;
            Produtos p = getSeExiste(n);
            if (p != null)
            {
                if (p.Quantidades >= q)
                {
                    res = p.Preço * q;
                }
            }
            return res;
        }

        //------------------------------------------------------------------
        //Método para chamar um dançarino para o palco e vereficar se o palco não está cheio
        public void chamada(string n)
        {
            foreach (Funcionarios f in funcionarios)
            {
                if (f.Nome == n && Palco.dançarinos.Count < Palco.maximo) // verifica nome e se palco está cheio
                {
                    foreach (string c in f.Categoria)
                    {
                        if (c == "strip") //destingue do resto de funcionários
                        {
                            Palco.dançarinos.Add(f);
                        }
                    }

                }
            }
        }
        //------------------------------------------------------------------
        public Produtos getSeExiste(string n)
        {
            Produtos res = null;
            foreach (Produtos p in produtos)
            {
                if (p.Nome == n)
                {
                    res = p;
                }
            }
            return res;
        }
        //------------------------------------------------------------------
        //Método alternativo do get se exite usando uma sorted list
        public Produtos getDoStock(string n)
        {
            int i = stock.IndexOfKey(n);
            return (Produtos)stock.GetByIndex(i); //(Produtos) tem de ser usada a especificação do tipo de objeto que sai do método para não dar conflitos a usar uma sortedList

        }
        //------------------------------------------------------------------
        //contrutores  
        public Bar(List<Clientes> clientes, List<Produtos> produtos, List<Funcionarios> funcionarios, float dinheiro, Quarto[] quarto, Palco palco, SortedList stock, Queue<Clientes> fila)
        {
            this.clientes = clientes;
            this.produtos = produtos;
            this.funcionarios = funcionarios;
            this.dinheiro = dinheiro;
            this.quarto = quarto;
            this.palco = palco;
            this.stock = stock;
            this.fila = fila;
        }
    }

    class Funcionarios
    {
        //variáveis
        private string nome;
        private char sexo; //(M, F, T)
        private List<string> categoria; //destingue o tipo de funcionário(dançarino exotico, limpeza, strip, bat, 1vs1, hardore, bdsm)
        private int idade;
        private int nif;
        private int iban;
        private float rendimento;

        //------------------------------------------------------------------

        //métodos
        //get e set
        public string Nome
        {
            get
            {
                return nome;
            }

            set
            {
                nome = value;
            }
        }

        public char Sexo
        {
            get
            {
                return sexo;
            }

            set
            {
                sexo = value;
            }
        }

        public List<string> Categoria
        {
            get
            {
                return categoria;
            }

            set
            {
                categoria = value;
            }
        }

        public int Idade
        {
            get
            {
                return idade;
            }

            set
            {
                idade = value;
            }
        }

        public int Nif
        {
            get
            {
                return nif;
            }

            set
            {
                nif = value;
            }
        }

        public int Iban
        {
            get
            {
                return iban;
            }

            set
            {
                iban = value;
            }
        }

        public float Rendimento
        {
            get
            {
                return rendimento;
            }

            set
            {
                rendimento = value;
            }
        }

        //------------------------------------------------------------------
        //método para indicar que alguem vai furar alguem (^-*)
        public void furala(Clientes c, Bar b) // 1vs1 
        {
            bool jaEscolheu = false; // variavel para determinar que já foi escolhido, para não repetir isto várias vezes
            foreach (Quarto q in b.Quarto) //percorre todos os quartos
            {
                if (q.Disponibilidade && jaEscolheu == false
                    && c.Dinheiro >= q.Preço) //verifica se o quarto esta disponivel
                {
                    Console.WriteLine("\nQueres coiso e tal? aqui?\n"); // -_-' -> pergunta se é para fazer o ato no dito quarto
                    string resposta = Console.ReadLine(); // lê a resposta do utilizador e
                    if (resposta == "sim") //se for sim
                    {
                        //se tudo estiver confirmado insere os dois no quarto
                        q.Funcionarios.Add(this); //adiciona o funcionario ao quarto
                        q.Clientes.Add(c); // adiciona o cliente ao quarto
                        q.Disponibilidade = false; // quarto passa a não estar disponivel
                        jaEscolheu = true;
                        c.pagar(q.Preço, b); //fazer com que o cliente pague
                    }

                }
            }
        }
        //------------------------------------------------------------------
        //contrutores
        public Funcionarios(string nome, char sexo, List<string> categoria, int idade, int nif, int iban, float rendimento)
        {
            this.nome = nome;
            this.sexo = sexo;
            this.categoria = categoria;
            this.idade = idade;
            this.nif = nif;
            this.iban = iban;
            this.rendimento = rendimento;
        }
    }

    class Produtos
    {
        //variáveis
        private string nome;
        private float preço;
        private int quantidades;

        //métodos
        //get e set

        public string Nome
        {
            get { return nome; }
            set
            { nome = value; }
        }

        public float Preço
        {
            get
            {
                return preço;
            }

            set
            {
                preço = value;
            }
        }

        public int Quantidades
        {
            get
            {
                return quantidades;
            }

            set
            {
                quantidades = value;
            }
        }

        //contrutores 
        public Produtos(string nome, float preço, int quantidades)
        {
            this.nome = nome;
            this.preço = preço;
            this.quantidades = quantidades;
        }
    }

    class Quarto
    {
        //variáveis
        private int capacidade;
        private List<string> tipo; //quartos a ter: simples, suites, dungeons,
        private bool disponibilidade;
        private List<Clientes> clientes;
        private List<Funcionarios> funcionarios;
        private float preço;


        //métodos
        //set e get
        public int Capacidade
        {
            get
            {
                return capacidade;
            }

            set
            {
                capacidade = value;
            }
        }

        public List<string> Tipo
        {
            get
            {
                return tipo;
            }

            set
            {
                tipo = value;
            }
        }

        public bool Disponibilidade
        {
            get
            {
                return disponibilidade;
            }

            set
            {
                disponibilidade = value;
            }
        }

        internal List<Clientes> Clientes
        {
            get
            {
                return clientes;
            }

            set
            {
                clientes = value;
            }
        }

        internal List<Funcionarios> Funcionarios
        {
            get
            {
                return funcionarios;
            }

            set
            {
                funcionarios = value;
            }
        }

        public float Preço
        {
            get
            {
                return preço;
            }

            set
            {
                preço = value;
            }
        }

        //contrutores 
        public Quarto(int capacidade, List<string> tipo, bool disponibilidade)
        {
            this.Capacidade = capacidade;
            this.Tipo = tipo;
            this.Disponibilidade = disponibilidade;
        }
    }

    class Clientes
    {
        //variáveis
        private string nome;
        private int idade;
        private float dinheiro;
        private char sexo; // (M, F, T)
        private char orientação; //(D, M, A, T)
        private int nif;
        private int iban;

        //------------------------------------------------------------------

        //métodos
        //método para pedir um produto

        public void pedir(string n, int q, Bar b)
        {
            float valor = b.valorAPagar2(n, q);
            if (b.existeQuantidade(n, q) && valor <= dinheiro)
            {
                pagar(valor, b);
            }

        }
        //------------------------------------------------------------------
        //método para pagar um produto
        public void pagar(float v, Bar b)
        {
            dinheiro -= v;
            b.Dinheiro += v;
        }
        //------------------------------------------------------------------
        // Método para receber o dinheiro do strip e dividilo pelos dançarinos
        public void atirarDinheiro(float d, Bar b)
        {
            if (d > dinheiro)
            {
                float tip = d / (float)b.Palco.dançarinos.Count();   /*(float) serve para converter este valor para o mesmo de tip*/
                dinheiro -= d; // verifica se existe dinheiro a ser mandado

                foreach (Funcionarios f in b.Palco.dançarinos)
                {
                    f.Rendimento += tip; //adiciona o dinheiro da tip ao rendimento dos stripers
                }
            }

        }
        //------------------------------------------------------------------
        //set e get

        public string Nome
        {
            get
            {
                return nome;
            }

            set
            {
                nome = value;
            }
        }

        public int Idade
        {
            get
            {
                return idade;
            }

            set
            {
                idade = value;
            }
        }

        public float Dinheiro
        {
            get
            {
                return dinheiro;
            }

            set
            {
                dinheiro = value;
            }
        }

        public char Sexo
        {
            get
            {
                return sexo;
            }

            set
            {
                sexo = value;
            }
        }

        public char Orientação
        {
            get
            {
                return orientação;
            }

            set
            {
                orientação = value;
            }
        }

        public int Nif
        {
            get
            {
                return nif;
            }

            set
            {
                nif = value;
            }
        }

        public int Iban
        {
            get
            {
                return iban;
            }

            set
            {
                iban = value;
            }
        }

        //contrutores 
        public Clientes(string nome, int idade, float dinheiro, char sexo, char orientação, int nif, int iban)
        {
            this.Nome = nome;
            this.Idade = idade;
            this.Dinheiro = dinheiro;
            this.Sexo = sexo;
            this.Orientação = orientação;
            this.Nif = nif;
            this.Iban = iban;
        }
    }

    class IRS
    {
        //variáveis
        private List<Clientes> dinheiro;

        ////métodos
        //Get e set
        internal List<Clientes> Dinheiro
        {
            get
            {
                return dinheiro;
            }

            set
            {
                dinheiro = value;
            }
        }

        // 23% -> juros estado

        //construtor
        public IRS(List<Clientes> dinheiro)
        {
            this.dinheiro = dinheiro;
        }
    }

    struct Pessoa
    {
        //variáveis
        private string nome;
        private int iban;
        private float dinheiro;

        ////métodos
        //Get e set

        public string Nome
        {
            get
            {
                return nome;
            }

            set
            {
                nome = value;
            }
        }

        public int Iban
        {
            get
            {
                return iban;
            }

            set
            {
                iban = value;
            }
        }

        public float Dinheiro
        {
            get
            {
                return dinheiro;
            }

            set
            {
                dinheiro = value;
            }
        }

        //construtor
        public Pessoa(string nome, int iban, float dinheiro)
        {
            this.nome = nome;
            this.iban = iban;
            this.dinheiro = dinheiro;
        }
    }

    class MB
    {
        //variáveis
        private string nome;
        private int nib;
        private List<Clientes> clientes;
        private float dinheiro;

        ////métodos
        //Get e set
        public string Nome
        {
            get
            {
                return nome;
            }

            set
            {
                nome = value;
            }
        }

        public int Nib
        {
            get
            {
                return nib;
            }

            set
            {
                nib = value;
            }
        }

        internal List<Clientes> Clientes
        {
            get
            {
                return clientes;
            }

            set
            {
                clientes = value;
            }
        }

        public float Dinheiro
        {
            get
            {
                return dinheiro;
            }

            set
            {
                dinheiro = value;
            }
        }

        //construtor
        public MB(string nome, int nib, List<Clientes> clientes, float dinheiro)
        {
            this.Nome = nome;
            this.Nib = nib;
            this.Clientes = clientes;
            this.Dinheiro = dinheiro;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //criar objetos//dados
            //---------------------------------------------------------
            // novo bar
            Bar b = new Bar(, );

            //---------------------------------------------------------
            // novo cliente
            Clientes c1 = new Clientes("Tó", 18, 50, 'm', 'D', 0001, 0011);
            Clientes c2 = new Clientes("Zé", 28, 60, 'm', 'D', 0002, 0012);

            //---------------------------------------------------------
            // novo produto
            Produtos p1 = new Produtos("vodka", 1, 1);


            //---------------------------------------------------------
            //Lista de categorias para ser usada na criação de uma instancia nova de funcionario
            List<string> categoriaParaFuncionario = new List<string>();
            categoriaParaFuncionario.Add("exotica");
            categoriaParaFuncionario.Add("balcao");


            Funcionarios f1 = new Funcionarios("Josefina", 'f', categoriaParaFuncionario, 18, 0040, 0030, 150f);

            b.maisUm(c1); //adiciona à fila um cliente
            b.maisUm(c2);

            //menu
            bool acabou = false;

            Console.WriteLine("Bem vindo ao melhor bar alternativo do universo!");

            while (!acabou) // while(acabou =! acabou) também serve. Significa enquanto não sai
            {
                //opçoes
                //1 - Bar
                //2 - Palco
                //3 - Quarto

                Console.Clear();
                Console.WriteLine("Escolha uma das seguintes oções (números): ");
                Console.WriteLine("1 - Bar");
                Console.WriteLine("2 - Palco");
                Console.WriteLine("3 - Quarto");
                Console.WriteLine("0 - Sair :P");


                //podia usar uma conversao para inteiro e utilizar opções com numeros inteiros
                //mas é preferivel usar strings para a escolha em menus
                string escolha = Console.ReadLine();

                switch (escolha)
                {

                    case ("1"):
                        {
                            bool cheio = false;
                            while (!cheio)
                            {
                                Clientes xxx = b.Fila.Peek(); // Peek -> serve para escolher o primeiro elemento da fila
                                Console.WriteLine("Qual o seu nome? ");
                                Console.WriteLine("1 - Comes e bebes");
                                Console.WriteLine("2 - Take away");
                                Console.WriteLine("3 - Engatar");
                                Console.WriteLine("4 - Voltar atras");
                                Console.WriteLine("0 - Sair :P");
                                escolha = Console.ReadLine();


                                switch (escolha)
                                {
                                    case ("1"):
                                        {
                                            bool comeste = false;
                                            while (!comeste)
                                            {
                                                Console.Clear();
                                                Console.WriteLine("1 - O que há? ");
                                                Console.WriteLine("2 - Sugestões ");
                                                Console.WriteLine("3 - Voltar atrás ");
                                                string s = Console.ReadLine();
                                                escolha = Console.ReadLine();
                                                switch (escolha)
                                                {
                                                    case ("1"):
                                                        {
                                                            foreach (Produtos p in b.Produtos)
                                                            {
                                                                if (p.Quantidades > 0) //verifica se o produto existe
                                                                {
                                                                    Console.WriteLine(p.Nome + ", preço: " + p.Preço);
                                                                }
                                                            }
                                                            Console.WriteLine("O que deseja?");
                                                            s = Console.ReadLine();
                                                            Console.WriteLine("Quantos quer?");
                                                            string n = Console.ReadLine();
                                                            int q = Int32.Parse(n);

                                                            if (b.existeQuantidade(s, q))
                                                            {
                                                                Console.WriteLine("Aqui tem! Bom proveito.");
                                                                float v = b.valorAPagar2(s, q);
                                                                xxx.pagar(v, b);
                                                            }
                                                            else
                                                            {
                                                                Console.WriteLine("A quantidade pretendida não existe nas quantidades que pediu!");
                                                            }
                                                        }
                                                        break;

                                                    case ("2"):
                                                        {
                                                            Console.WriteLine("Whiskey em peitos ucranianos");
                                                        }
                                                        break;
                                                    case ("3"):
                                                        {
                                                            comeste = true;
                                                        }
                                                        break;

                                                    default:
                                                        break;
                                                }
                                            }
                                        }
                                        break;
                                    case ("2"):
                                        {

                                        }
                                        break;
                                    case ("3"):
                                        {

                                        }
                                        break;
                                    case ("4"):
                                        {
                                            cheio = true;
                                        }
                                        break;
                                    case ("0"):
                                        {
                                            acabou = true;
                                            b.menosUm();
                                            cheio = true;
                                        }
                                        break;
                                }

                            }
                        }
                        break;


                    case ("2"):
                        {
                        }
                        break;
                    case ("3"):
                        {
                        }
                        break;
                    case ("0"):
                        {
                            acabou = true;
                        }
                        break;
                    default:
                        {
                            Console.WriteLine("Say what? You high? Don't you know how not to be stupid?");
                        }
                        break;
                }
            }
        }
    }
}
