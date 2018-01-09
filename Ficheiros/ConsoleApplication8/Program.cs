using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO; //-> biblioteca ESSENCIAL para trabalhar com ficheiros (IO -> imput/output)

namespace ConsoleApplication8
{

    struct Bidhaa
    {
        public string nome;
        public float preco;
        public float quantidade;

        public void writeToFile(string path)
        {

            StreamWriter f = null;
            //se o ficheiro path existir
            if (File.Exists(path))
            {
                f = new StreamWriter(path, true); //true-> acrescenta, false-> faz overwrite
                f.WriteLine("Bidhaa");
                f.WriteLine(nome);
                f.WriteLine(preco);
                f.WriteLine(quantidade);
                f.Close();
            }
            //se não existir cria
            else
            {
                try
                {
                    f = File.CreateText(path);
                    f.WriteLine("Bidhaa");
                    f.WriteLine(nome);
                    f.WriteLine(preco);
                    f.WriteLine(quantidade);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                finally
                {
                    f.Close();
                }
            }

        }

        public void daBidhaa(string n, float p, float q)
        {
            nome = n;
            preco = p;
            quantidade = q;
        }
    }


    struct dadosMB
    {
        public int nib;
        public float euros;
    }

    class MB
    {
        //MB
        //variaveis
        //struct com dados
        private List<dadosMB> dados;

        //métodos 
        //-- metodo para guardar ficheiro "MB.txt"
        public void write2file(string filename)
        {
            StreamWriter sw;
            try
            {
                sw = File.CreateText(filename);
                sw.WriteLine("Dados do multibanco: ");
                foreach (dadosMB d in dados)
                {
                    sw.WriteLine(d.nib);
                    sw.WriteLine(d.euros);
                }
                sw.Close();
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
        }

        //dados do multibanco
        //1
        //10.0f
        //2
        //3.0f
        //3
        //150.0f

        public void readFromFile(string filename)
        {
            StreamReader sr;
            string aux;

            try
            {
                sr = new StreamReader(filename);
                aux = sr.ReadLine();

                //enquanto tivermos dados para ler

                while ((aux = sr.ReadLine()) != null) //-> enquanto houver uma linha com dados continua a procurar
                {
                    int n = Int32.Parse(aux);
                    aux = sr.ReadLine();
                    float d = Int32.Parse(aux);

                    dadosMB newD = new dadosMB();
                    newD.nib = n;
                    newD.euros = d;
                    dados.Add(newD);

                }


                aux = sr.ReadLine();
                

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        //get e set

        internal List<dadosMB> Dados
        {
            get
            {
                return dados;
            }

            set
            {
                dados = value;
            }
        }

        //construtor

        public MB(List<dadosMB> dados)
        {
            this.dados = dados;
        }
    }


    class Pessoa
    {
        //pessoas
        //variaveis
        //nome
        //nib
        //dinheiro
        string nome;
        int nib;
        float dinheiro;

        //métodos 
        //-- metodo para guardar ficheiro "pessoa.txt"


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
        public Pessoa(string nome, int nib, float dinheiro)
        {
            this.nome = nome;
            this.nib = nib;
            this.dinheiro = dinheiro;
        }
    }
    //-- metodo para guardar ficheiro "pessoas.txt"


    class Program
    {

        public static void readFromFile(string path, List<Bidhaa> b)
        {
            string l;
            try
            {
                StreamReader r = new StreamReader(path);
                Bidhaa aux;

                for (int i = 0; i < b.Count; i++)
                {
                    aux = b.ElementAt(1);
                    l = r.ReadLine(); //Bidaah
                    l = r.ReadLine(); //nome
                    aux.nome = l;
                    l = r.ReadLine(); //preco
                    aux.preco = float.Parse(l);
                    l = r.ReadLine(); //quantidade
                    aux.quantidade = float.Parse(l);
                }
                r.Close();
            }

            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }

        static void Main(string[] args)
        {
            
            string ondeEstou = Directory.GetCurrentDirectory();
            string filename = ondeEstou + "/../../dadosMB.txt";

            List<dadosMB> listaDados = new List<dadosMB>();

            dadosMB d1 = new dadosMB();
            dadosMB d2 = new dadosMB();
            dadosMB d3 = new dadosMB();

            d1.nib = 1; d1.euros = 10.0f;
            d2.nib = 2; d2.euros = 50.0f;
            d3.nib = 3; d3.euros = 10330.0f;

            listaDados.Add(d1);
            listaDados.Add(d2);
            listaDados.Add(d3);


            MB mb = new MB(listaDados);

            mb.write2file(filename);

            List<dadosMB> lista2 = new List<dadosMB>();

            MB mb2 = new MB(lista2);
            mb2.readFromFile(filename);

            Console.WriteLine();

            /*
            Bidhaa b1 = new Bidhaa();
            Bidhaa b2 = new Bidhaa();
            Bidhaa b3 = new Bidhaa();
            Bidhaa b4 = new Bidhaa();

            b1.daBidhaa("almofada", 100000000.0f, 1.0f);
            b2.daBidhaa("cobertor", 100000.0f, 2.0f);
            b3.daBidhaa("chocolate quente", 1.0f, 1.5f);
            b4.daBidhaa("almofada", 100000000.0f, 1.0f);

            //criar ficheiros
            //guardar informação
            //ler informação


            b1.writeToFile("kucheka.txt");
            b2.writeToFile("kucheka.txt");
            b3.writeToFile("kucheka.txt");
            b4.writeToFile("kucheka.txt");

            Bidhaa b1t = new Bidhaa();
            Bidhaa b2t = new Bidhaa();
            Bidhaa b3t = new Bidhaa();
            Bidhaa b4t = new Bidhaa();

            List<Bidhaa> b = new List<Bidhaa>();

            b.Add(b1t);
            b.Add(b2t);
            b.Add(b3t);
            b.Add(b4t);

            readFromFile("kucheka.txt", b);*/
        }
    }
}
