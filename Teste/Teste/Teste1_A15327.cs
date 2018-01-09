using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste
{
    class SexyEWare
    {
        private List<Armazém> armazens;
        private List<Loja> lojas;
        private List<Cliente> clientes;
        private float dinheiro;

        public SexyEWare(List<Armazém> armazens, List<Loja> lojas, List<Cliente> clientes, float dinheiro)
        {
            this.armazens = armazens;
            this.lojas = lojas;
            this.clientes = clientes;
            this.dinheiro = dinheiro;
        }

        internal List<Armazém> Armazens
        {
            get
            {
                return armazens;
            }

            set
            {
                armazens = value;
            }
        }

        internal List<Loja> Lojas
        {
            get
            {
                return lojas;
            }

            set
            {
                lojas = value;
            }
        }

        internal List<Cliente> Clientes
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
    }
    class Armazém
    {
        List<Produto> produtos;
        List<Veículo> veiculos;

        public Armazém(List<Produto> produtos, List<Veículo> veiculos)
        {
            this.produtos = produtos;
            this.veiculos = veiculos;
        }

        internal List<Produto> Produtos
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

        internal List<Veículo> Veiculos
        {
            get
            {
                return veiculos;
            }

            set
            {
                veiculos = value;
            }
        }
    }

    class Loja
    {
        private string localização;
        private List<Produto> produtos;
        private float dinheiro;
        private List<Loja> lojas;

        public Loja(string localização, List<Produto> produtos, float dinheiro, List<Loja> lojas)
        {
            this.localização = localização;
            this.produtos = produtos;
            this.dinheiro = dinheiro;
            this.lojas = lojas;
        }

        public string Localização
        {
            get
            {
                return localização;
            }

            set
            {
                localização = value;
            }
        }

        internal List<Produto> Produtos
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

        internal List<Loja> Lojas
        {
            get
            {
                return lojas;
            }

            set
            {
                lojas = value;
            }
        }

        //2.a)
        public bool vereficaDinheiroEmpresa(float d, SexyEWare sw)
        {
            bool res = false;
            foreach (Loja l in Lojas)
            {

                l.dinheiro += d;
                sw.Dinheiro = d;
                res = true;
            }
            return res;
        }

        public bool verificaDinheiroCliente(float d, Cliente c)
        {
            bool res = false;

            if (d < c.Dinheiro)
            {
                res = true;
            }
            return res;
        }

        public bool existeProduto(string n)
        {
            bool res = false;

            foreach (Produto p in Produtos)
            {
                if (n == p.Nome)
                {
                    res = true;
                }
            }
            return res;
        }

        public bool existeQuantidades(string n, int q)
        {
            bool res = false;

            if (existeProduto(n) == true)
            {
                foreach (Produto p in Produtos)
                {
                    if (q <= p.Quantidade && p.Nome == n)
                    {
                        res = true;
                    }
                }
            }
            return res;
        }

        public Produto getSeExistir(string n)
        {
            Produto res = null;
            foreach (Produto p in Produtos)
            {
                if (p.Nome == n)
                {
                    res = p;
                }
            }
            return res;
        }

        public float pagar(string n, int q, Cliente c)
        {
            float res = 0.0f;
            Produto p = getSeExistir(n);

            if (p != null)
            {
                if (c.Nivel == "VIP")
                {
                    if (p.Quantidade >= q)
                    {
                        res = (p.Preço * q) * (1.00f - 0.15f);
                    }
                }

                if (c.Nivel == "Abonado")
                {
                    if (p.Quantidade >= q)
                    {
                        res = (p.Preço * q) * (1.00f - 0.10f);
                    }
                }

                if (c.Nivel == "Forreta")
                {
                    if (p.Quantidade >= q)
                    {
                        res = (p.Preço * q);
                    }
                }
            }
            return res;
        }

        public bool vereficarProdLojas(string n, SexyEWare sw)
        {
            bool res = false;
            if (this.existeProduto(n) == false)
            {
                foreach (Loja l in sw.Lojas)
                {
                    if (existeProduto(n))
                    {
                        res = true;
                    }
                }
            }
            return res;
        }

        public bool vereficarProdArmazem(string n, SexyEWare sw)
        {
            bool res = false;
            if (existeProduto(n) == false)
            {
                foreach (Armazém a in sw.Armazens)
                {
                    if (existeProduto(n))
                    {
                        res = true;
                    }
                }
            }
            return res;
        }

        public bool vereficarVeículo( Veículo v)
        {
            bool res = false;
            if (v.Disponibilidade == true)
            {
                res = true;
            }
            return res;
        }

        public bool vereficarLimiteVeículo(float p, Veículo v)
        {
            bool res = false;
            if ( p < v.Limite )
            {
                res = true;
            }
            return res;
        }
    }



    class Produto
    {
        private string nome;
        private int quantidade;
        private float preço;

        public Produto(string nome, int quantidade, float preço)
        {
            this.nome = nome;
            this.quantidade = quantidade;
            this.preço = preço;
        }

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

        public int Quantidade
        {
            get
            {
                return quantidade;
            }

            set
            {
                quantidade = value;
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
    }

    class Cliente
    {
        private string nome;
        private string nivel; // vip, abonado ou forreta
        private float dinheiro;
        private List<string> compras;

        public Cliente(string nome, string nivel, float dinheiro, List<string> compras)
        {
            this.nome = nome;
            this.nivel = nivel;
            this.dinheiro = dinheiro;
            this.compras = compras;
        }

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

        public string Nivel
        {
            get
            {
                return nivel;
            }

            set
            {
                nivel = value;
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

        public List<string> Compras
        {
            get
            {
                return compras;
            }

            set
            {
                compras = value;
            }
        }
    }
    class Veículo
    {
        private bool disponibilidade;
        private string tipo;
        private List<Produto> produtos;
        private float limite;

        public Veículo(bool disponibilidade, string tipo, List<Produto> produtos, float limite)
        {
            this.disponibilidade = disponibilidade;
            this.tipo = tipo;
            this.produtos = produtos;
            this.limite = limite;
        }

        public string Tipo
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

        internal List<Produto> Produtos
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

        public float Limite
        {
            get
            {
                return limite;
            }

            set
            {
                limite = value;
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
    }

    class Program
    {
        static void Main(string[] args)
        {
            SexyEWare sw = new SexyEWare(1, 3, 2, 100.0f);

           

            Produto p1 = new Produto("Calsas", 50, 20.0f);
            Produto p2 = new Produto("T-shirt", 50, 15.0f);
            Produto p3 = new Produto("Tangas", 50, 2.0f);
            Produto p4 = new Produto("Casacos", 50, 30.0f);
            Produto p5 = new Produto("Fio Dental", 50, 7.0f);
            List<Produto> prods = new List<Produto> { p1, p2, p3, p4, p5 };

            Loja l1 = new Loja("Porto", prods, 500f, l1);
        }
    }
}
