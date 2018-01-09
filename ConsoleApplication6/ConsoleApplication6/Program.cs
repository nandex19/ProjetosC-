using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    //classes
    //classe pessoa

    class pessoa
    {
        private string nomePessoa;
        private float dinheiro;
        private List<Produto> carrinho; //Lista  -> com a lista é possivel trabalhar com mais coisas

        //métodos
        //---------------------------------------------------
        //Métodos set e get
            /*
        //demonstração da utilização de uma lista
        public void percorre()
        {
            Produto p;
            p = carrinho[0];
            p = carrão[0];
            carrão.Add(p);

            //cerveja, ovos e tremoços
            //carrãp -> cerveja e tremoços
            carrão.Add("Ovos");
        }
        */
        //versão mais facil de set e get
        public string N
        {
            get { return nomePessoa; }
            set { nomePessoa = value; }
        }
        //versão complicada de set e get
        public string getNome()
        {
            return nomePessoa;
        }

        public void setNome( string n)
        {
            nomePessoa = n;
        }

        public float getDinheiro()
        {
            return dinheiro;
        }

        public void setDinheiro(float d)
        {
            dinheiro = d;
        }

        public void setCarrinho(List<Produto> p)
        {
            carrinho = p;
        }

        public List<Produto> getCarrinho()
        {
            return carrinho;
        }
        //----------------------------------------------------
        /*
        public void adicionarCarrinho(Produto[] p)
        {
            Produto[] aux = new Produto[carrinho.Length + p.Length];

            for (int i  = 0; i < carrinho.Length; i++)
            {
                aux[i] = carrinho[i];
            }

            for (int i = 0; i < p.Length; i++)
            {
                aux[carrinho.Length + i] = p[i];
            }

            aux[0] = carrinho[0];
            aux[1] = carrinho[1];
            aux[2] = p[1];
            aux[3] = p[2];
            carrinho = aux;
        }
        */
        public void adicionaCarrinho(Produto[] p) //-> metodo para adicionar ao carrinho mas bem mais simples do que o de cima
        {
            //preservativos, iogurt
            for(int i =0; i < p.Length; i++)
            {
                carrinho.Add(p[i]);

            }
        }

        public float soma()
        {
            float total = 0.0f;
            /* -> fazendo o metodo utilizando só for
            for (int i = 0; i < carrinho.Length; i++)
            {
                total = total + carrinho[i].preço;
            }
            */
            foreach(Produto z in carrinho)
            {
                total = total + z.preço;
            }
            return total;
        }

        private float vereficarDinheiro()
        {
            if (soma() > dinheiro)
            {
                return 0;
            }
            else
            {
                return 1;
            }
        }




        //contrutor pessoa
        public pessoa(string n, float d)
        {
            nomePessoa = n;
            dinheiro = d;
        }

    }

    //classe supermercado:
    //produtos
    //nome
    //preço
    //peso/quantidade

    class supermercado
    {
        private Produto[] produtos;
        private int numProdutos;
        private float dinheiro;


        //metodo para retirar dinheiro da pessoa e por-lo no supermercado
        public void finalizaCompra(pessoa p, float valor)
        {
            dinheiro += valor;
            p.setDinheiro(p.getDinheiro() - valor);
        }

        public void comprar(pessoa p)
        {
            if (vereficaQ(p) && p.vereficarDinheiro())
            {
                finalizaCompra(p, p.soma());
            }

        }


        //metodo para vereficar se as compras que estão no carrinho existem no supermercado
        public bool vereficaQ(pessoa p)
        {
            bool res = true, existe; //vereficar o resultado final
            // supermercado = (ovo, pao, uva)
            // carrinho (ovo, uva) true
            // carrinho (ovo, mel) false
            // carrinho (ovo(6), uva(1)) true
            // carrinho (ovo(6), uva(2)) false

            List<Produto> b = p.getCarrinho();
            foreach (Produto a in b) // a = (ovo(6),uva(1))
            {
                existe = false; //-> vereficar se existe ou não 
                foreach (Produto x in produtos) // x = (ovo(12),uva(2))
                {
                    if ((a.nome == x.nome)&&(a.quantidade <= x.quantidade))
                    {
                        existe = true;
                    }
                }
                if(existe == false)
                {
                    res = false;
                }
            }

            return res;
        }

        //metodo para vereficar se tem itens a mais
        public bool vereficarCarrinho(pessoa p)
        {
            bool res /* resultado final*/ = true, existe /*verificação da existencia do produto*/ = false;
            //percorrer os produtos da pessoa
            List<Produto> ps = p.getCarrinho();
            foreach (Produto i in ps)
            {
                existe = false;
                for (int j = 0; j < produtos.Length; j++)
                {
                    if (ps[j].nome == produtos[j].nome)
                    {
                        existe = true;
                    }
                }
            }
            /*
            {
                //percorre os produtos do supermercado
                existe = false;
                for (int j = 0; j < List<Produto>.; j++)
                {
                    if (ps[i].nome == carrinho[j].nome)
                    {
                        existe = true;
                    }
                }
                if(existe == false)
                {
                    res = false;
                }
            } */
            return res;
        }

 public supermercado(Produto[] p, int n, float d)
        {
            produtos = p;
            numProdutos = n;
            dinheiro = d;
        }
    }

    public struct Produto
    {
        public string nome;
        public float peso;
        public float preço;
        public int quantidade;
    }

    //classe CMB:
    //lista de pessoas
    //dinheiro
    class CMB
    {
        public pessoa[] clientes;  
        public float dinheiro;
    }


    // comprar coisas (dividido em modulos diferentes)
    // 1º -> vereficar se o cliente tem dinheiro para comprar as coisas
    // 2º -> vereficar se o itens da compram existem ou não
    // 3º -> vereficar se leva itens a mais
    // 4º -> retira o dinheiro da pessoa e deixa-o no supermercado

    class Program
    {
        static void Main(string[] args)
        {
            pessoa p0 = new pessoa("Tó", 100.0f);
            pessoa p1 = new pessoa("Zeza", 50.0f);
            List<Produto> p = new List<Produto>();
            Produto[] pp = new Produto[10];
        }
    }
}
