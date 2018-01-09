using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herança
{
    //imaginar que estamos a fazer um jogar
    //desenhar
    //update


    //numa interface ~só são criados métodos (nada de variaveis)
    //é uma maneira de cria polimorfismo em varias classes diferentes sem o constrangimento de herdar duas ou mais classes (pq não funciona)
    interface iAndo 
    {
        void mover(); // todos os metodos que herdem esta interface terão um uso para o metodo (mover)
    }

    interface iComo
    {
        void daComer(); // todos os metodos que herdem esta interface terão um uso para o metodo (daComer)
    }
    // classes abstratas são classes que podem ou não ter metodos defenidos e outras coisas,
    // mas terá metodos abstratos para que este sejam preenchidos e não esquecidos
    abstract class Nitro
    {
        protected float quantidade;
        
        public float Quantidade
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

        //métodos

        public abstract void boost(); //-> vai ser diferente para cada classe de veículo e tem de ser obrigatóriamente defenido para a classe Tunning Funcionar

        public virtual void rebenta()
        {
            quantidade -= 100.0f;
        }
    }

    class Tunning : Nitro //-> não permite mais do que uma classe a ser herdade
    {

        public override void boost() //-> usa-se mestodos abstratos para nos lembrar/forçar a defenir parametros
        {

        }

        public override void rebenta()
        {
            base.rebenta();
            quantidade -= 50.0f;
        }
    }

    class Carrinha : iAndo, iComo //herdaando interfaces em vez de outras classes é possivel ter multiplas interfaces a serem chamadas, mas com classes apenas 1 classe pode ser filho
        //mas é possivel que uma classe herde uma outra classe e multiplas interfaces
    {
        public void mover()
        {

        }
        public void daComer()
        {

        }
    }


    //estrutura para defenir a localizaçao do veículo em questao
    public struct tempo_espaço
    {
        public long tempo;
        public float x, y, z; //x e z plano -- z é a altura
    }

    class veículo
    {
        protected tempo_espaço posição;
        protected string marca;
        protected int passageiros;
        protected float volocidade_max;
        protected float acelaração_max;
        protected float consumo;
        protected float capacidade;

        //métodos
        public virtual void mover(long tempo) //virtual -> mecanismo para forçar o override a funcionar no método mover da classe mota
        {
            posição.x += volocidade_max * 0.1f + acelaração_max * 1.0f;
            posição.y += volocidade_max * 1.0f + acelaração_max * 0.1f; 

            posição.tempo += tempo;
        }

        public void mover(float x, float y, float z, long tempo)
        {
            posição.x += x;
            posição.y += y;
            posição.z += z;

            posição.tempo += tempo;
        }

        //get e set
        internal tempo_espaço Posição
        {
            get
            {
                return posição;
            }

            set
            {
                posição = value;
            }
        }

        public string Marca
        {
            get
            {return marca;}
            set
            {
                marca = value;
            }
        }

        public int Passageiros
        {
            get
            {
                return passageiros;
            }

            set
            {
                passageiros = value;
            }
        }

        public float Volocidade_max
        {
            get
            {
                return volocidade_max;
            }

            set
            {
                volocidade_max = value;
            }
        }

        public float Acelaração_max
        {
            get
            {
                return acelaração_max;
            }

            set
            {
                acelaração_max = value;
            }
        }

        public float Consumo
        {
            get
            {
                return consumo;
            }

            set
            {
                consumo = value;
            }
        }

        public float Capacidade
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

        //construtor
        public veículo(tempo_espaço posição, string marca, int passageiros, float volocidade_max, float acelaração_max, float consumo, float capacidade)
        {
            this.posição = posição;
            this.marca = marca;
            this.passageiros = passageiros;
            this.volocidade_max = volocidade_max;
            this.acelaração_max = acelaração_max;
            this.consumo = consumo;
            this.capacidade = capacidade;
        }

    }

    class Carro : veículo // permite que os dados da classe véiculo sejam usados nestqa classe
    {
        /*
        //dados em comum - > passam para a classe veículo por serem comuns
        private tempo_espaço posição;
        private string marca;
        private int passageiros;
        private float volocidade_max;
        private float acelaração_max;
        private float consumo;
        private float capacidade;
        */

        //dados em exclusivo
        private bool airbag;

        //métodos

        //get e set
        public bool Airbag
        {
            get
            {
                return airbag;
            }

            set
            {
                airbag = value;
            }
        }

        //construtor
        public Carro(bool airbag, tempo_espaço pos, string marca, int pass, float v, float a, float c, float cap) :
            base(pos, marca, pass, v, a, c, cap)
        {
            this.airbag = airbag;
        }

    }

    class Avião : veículo // permite que os dados da classe véiculo sejam usados nestqa classe
    {
        /*
        //dados em comum - > passam para a classe veículo por serem comuns       
        private tempo_espaço posição;
        private string marca;
        private int passageiros;
        private float volocidade_max;
        private float acelaração_max;
        private float consumo;
        private float capacidade;
        */

        //dados em exclusivo
        private int turbinas;

        //métodos

        public override void mover(long tempo) //override serve para sobreescrever o método dado pela classe pai
        {
            posição.x += volocidade_max * 0.1f + acelaração_max * 1.0f + turbinas * 20.0f;
            posição.y += volocidade_max * 1.0f + acelaração_max * 0.1f + turbinas * 150.0f;

            posição.tempo += tempo;
        }
        //get e set
        public int Turbinas
        {
            get
            {
                return turbinas;
            }

            set
            {
                turbinas = value;
            }
        }

        //construtor
        public Avião(int turbinas, tempo_espaço pos, string marca, int pass, float v, float a, float c, float cap) :
            base(pos, marca, pass, v, a, c, cap) //função para ir buscar os valores do construtor da class pai
        {
            this.Turbinas = turbinas;
        }

    }

    class Mota : veículo
    {
                /*
        //dados em comum - > passam para a classe veículo por serem comuns       
        private tempo_espaço posição;
        private string marca;
        private int passageiros;
        private float volocidade_max;
        private float acelaração_max;
        private float consumo;
        private float capacidade;
        */

        //dados em exclusivo
        private float turbo;

        //métodos
        public override void mover(long tempo) //override serve para sobreescrever o método dado pela classe pai
        {
            posição.x += volocidade_max * 0.1f + acelaração_max * 1.0f;
            posição.y += volocidade_max * 1.0f + acelaração_max * 0.1f + turbo * 0.5f;

            posição.tempo += tempo;
        }

        //get e set
        public float Turbo
        {
            get
            {
                return turbo;
            }

            set
            {
                turbo = value;
            }
        }

        //construtor
        public Mota(float turbo, tempo_espaço pos, string marca, int pass, float v, float a, float c, float cap) :
            base(pos, marca, pass, v, a, c, cap) //função para ir buscar os valores do construtor da class pai
        {
            this.Turbo = turbo;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Tunning chunning = new Tunning();
            //Nitro neos = new Nitro(); //-> classes abstratas não podem ser usadas em instancias das mesmas

            //criar um avião e um carro
            tempo_espaço pos1 = new tempo_espaço();
            pos1.x = 0.0f;
            pos1.y = 10.0f;
            pos1.z = 0.0f;
            pos1.tempo = 0;

            tempo_espaço pos2 = new tempo_espaço();
            pos2.x = 0.0f;
            pos2.y = 10.0f;
            pos2.z = 0.0f;
            pos2.tempo = 0;

            tempo_espaço pos3 = new tempo_espaço();
            pos3.x = 0.0f;
            pos3.y = 10.0f;
            pos3.z = 0.0f;
            pos3.tempo = 0;

            tempo_espaço pos4 = new tempo_espaço();
            pos4.x = 0.0f;
            pos4.y = 10.0f;
            pos4.z = 0.0f;
            pos4.tempo = 0;


            tempo_espaço pos5 = new tempo_espaço();
            pos5.x = 0.0f;
            pos5.y = 10.0f;
            pos5.z = 0.0f;
            pos5.tempo = 0;

            Carro c = new Carro(true, pos2, "renault5", 5, 100.0f, 30.01f, 50, 200.0f);
            Avião a = new Avião(4, pos1, "boing", 100, 450.0f, 30.0f, 500.0f, 2000.0f);
            Mota m1 = new Mota(5.0f, pos5, "kawasaki", 2, 350.0f, 20.0f, 8.0f, 1.0f);

            //console writeline posição e tempo
            //Console.WriteLine("Avião parte da posiçao " + a.Posição.x + ";" + a.Posição.y + ";" + a.Posição.z + ";");
            //Console.WriteLine("Carro parte da posiçao " + c.Posição.x + ";" + c.Posição.y + ";" + c.Posição.z + ";");
            //Console.WriteLine("Mota parte da posiçao " + m1.Posição.x + ";" + m1.Posição.y + ";" + m1.Posição.z + ";");
            
            //mover os dois
            a.mover(10, 100, 10, 100);
            c.mover(10, 20, 0, 0);


            //console writeline posição e tempo

            //Console.WriteLine("Avião chegou à posiçao " + a.Posição.x + ";" + a.Posição.y + ";" + a.Posição.z + ";");
            //Console.WriteLine("Carro chegou à posiçao " + c.Posição.x + ";" + c.Posição.y + ";" + c.Posição.z + ";");
            //Console.WriteLine("Mota chegou à posiçao " + m1.Posição.x + ";" + m1.Posição.y + ";" + m1.Posição.z + ";");


            /*********************************************************************************/



            List<veículo> vs = new List<veículo>();
            vs.Add(a);
            vs.Add(c);
            vs.Add(m1);

            foreach(veículo v in vs)
            {
                Console.WriteLine("\nVeículo parte da posiçao " + v.Posição.x + ";" + v.Posição.y + ";" + v.Posição.z + ";");
            }


            foreach (veículo v in vs)
            {
                v.mover(1000);
            }


            foreach (veículo v in vs)
            {
                Console.WriteLine("\nVeículo está na posiçao " + v.Posição.x + ";" + v.Posição.y + ";" + v.Posição.z + ";");
            }

            Console.ReadKey();
        }



    }
 }

