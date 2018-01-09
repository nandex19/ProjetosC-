using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forms
{
    public struct Dims
    {
        public string altura;
        public string comprimento;
        public string largura;
    }
    class prenda
    {
        private Dims dimensões;
        private string nome;
        private string peso;
        private string valor;


        //construtor
        public prenda(Dims dimensões, string nome, string peso, string valor)
        {
            this.dimensões = dimensões;
            this.nome = nome;
            this.peso = peso;
            this.valor = valor;
        }



        //métodos

        //get e set
        public Dims Dimensões
        {
            get
            {
                return dimensões;
            }

            set
            {
                dimensões = value;
            }
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

        public string Peso
        {
            get
            {
                return peso;
            }

            set
            {
                peso = value;
            }
        }

        public string Valor
        {
            get
            {
                return valor;
            }

            set
            {
                valor = value;
            }
        }
    }
}
