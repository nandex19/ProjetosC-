using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula_sobre_exepções
{
    //class para defenir uma expeção no nome
    class NotaNameException : ApplicationException
    {
        public NotaNameException(string value) : base(value)
        {
            Console.WriteLine("Indruduza um nome valido!");
        }
    }

    //*************************************+******************************************

    //class para defenir uma expeção na idade
    class NotanAgeException : ApplicationException
    {
        public NotanAgeException(int value) : base()
        {
            Console.WriteLine("Introduza um email valido!");
        }
}

//*************************************+******************************************

//class para defenir uma expeção no nif
class NotanNIFException : ApplicationException
{
    public NotanNIFException(int value) : base()
            {
                Console.WriteLine("Introduza um email valido!");
            }
}
    //*************************************+******************************************

    //class para defenir uma expeção no email
    class NotanEmailException : ApplicationException
{
    public NotanEmailException(string value) : base(value)
    {
        Console.WriteLine("Introduza um email valido!");
    }
}
//*************************************+******************************************



class Program
{
    //**************************************************************************************
    //função para validar o nome e lançar uma mensagem que avise o utilizador que errou a introduzir os dados
    static bool validaNome(string n)
    {
        bool res = false;

        if (n.Contains("1"))
        {
            res = false;
            //se for invalido
            throw new NotaNameException("Não pode conter numeros!");
        }
        else if (n.Contains("$"))
        {
            res = false;
            //se for invalido
            throw new NotaNameException("Não pode conter caracteres especias!");
        }
        else
        {
            //se for valido
            res = true;
            Console.WriteLine("O nome é: " + n);
        }
        return res;
    }
    //**************************************************************************************
    //função para validar a idade e lançar uma mensagem que avise o utilizador que errou a introduzir os dados
    static bool validaIdade(int idade)
    {
        bool res = false;

        int i = 0;
        try
        {
            int i = Int32.Parse(idade);
        }
        catch (Exception)
        {
            res = false;

        }

        int i = -1;

        if (i == -1)
        {
            res = true;
        }
        return res;
    }
    //**************************************************************************************

    //************************************MAIN*************************************//
    static void Main(string[] args)
    {


        //nome
        //idade
        //nif
        //email - verificar tambem existencia do caracter: @
        //password
        //repetir password

        //*************************************+******************************************
        //inserir e listar nome 

        //while para continuar a perguntar enquanto não receber caracteres valisdos
        bool feito = false;

        Console.WriteLine("Qual é o teu nome?");
        string nome = Console.ReadLine();

        while (feito == false)
        {
            try
            {
                validaNome(nome);
            }
            catch (NotaNameException)
            {
                throw new NotaNameException("Erro nos caracteres introduzidos!");
            }
            feito = true;
        }


        //*************************************+******************************************
        //inserir e listar idade
        Console.WriteLine("E a tua idade?");
        string idade = Console.ReadLine();

        try
        { validaIdade(idade); }
        catch (NotanAgeException)
        { }



        //*************************************+******************************************
        //inserir e listar nif
        Console.WriteLine("E o teu nif?");
        string nif = Console.ReadLine();
        int x = 0;

        try
        { x = Int32.Parse(nif); }
        catch (Exception e2)
        { Console.WriteLine(e2.Message); }
        Console.WriteLine("O teu nif é: " + x);


        //*************************************+******************************************
        //inserir e listar email
        Console.WriteLine("E o teu email?");
        string email = Console.ReadLine();
        bool z;

        if (email.Contains("@"))
        {
            Console.WriteLine("Email Inválido");
        }

        try
        { }
        catch (NotanEmailException)
        { throw new NotanEmailException("Erro nos caracteres introduzidos!"); }

        //Console.WriteLine("O teu email é  " + z);


        //*************************************+******************************************
        //inserir password1
        Console.WriteLine("E a tua password?");
        string password1 = Console.ReadLine();

        //inserir password2
        Console.WriteLine("E o teu email?");
        string password2 = Console.ReadLine();

        if (password1.Equals(password2) == false)
        {
            Console.WriteLine("As passwords intrudozidas não coicidem!");
        }



        //*************************************+******************************************
        Console.ReadKey();

    }
}
}
