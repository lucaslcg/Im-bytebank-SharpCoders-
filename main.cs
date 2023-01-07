using System;

class lucascarrilhogomes_bytebank_SharpCoders
{
    static double saldo;
    static string usuario1 = "lucas", senha1 = "1111";
    static double saldo1 = 1000;

    static string usuario2 = "italo", senha2 = "2222";
    static double saldo2 = 2000;


    private static void login()
    {
        Console.Clear();
        Console.WriteLine("BytBank login \n");

        Console.WriteLine("usuario:");
        string loginusuario = Console.ReadLine();

        Console.WriteLine("senha:");
        string loginsenha = Console.ReadLine();

        if (loginusuario == usuario1)
        {
            if (loginsenha == senha1)
            {
                saldo = saldo1;
                menu();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("BytBank \n senha invalida");
                Console.ReadKey();
                login();
            }

        }
        else if (loginusuario == usuario2)
        {
            if (loginsenha == senha2)
            {
                saldo = saldo2;
                menu();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("BytBank \n senha invalida");
                Console.ReadKey();
                login();
            }

        }
        else
        {
            Console.Clear();
            Console.WriteLine("BytBank \n usuario nao encontrado");
            Console.ReadKey();
            login();
        }

    }

    private static void menu()
    {
        Console.Clear();
        Console.WriteLine("BytBank menu \n");

        Console.WriteLine("1 - Saque");
        Console.WriteLine("2 - Deposito");
        Console.WriteLine("3 - Transferencia");
        Console.WriteLine(" 			0 - logout");

        string seleçao;
        do
        {
            seleçao = Console.ReadLine();

            switch (seleçao)
            {
                case "0":
                    Console.Clear();
                    Console.WriteLine("BytBank \n logout");
                    login();
                    break;
                case "1":
                    saque();
                    break;
                case "2":
                    deposito();
                    break;
                case "3":
                    transferencia();
                    break;
            }
        } while (seleçao != "0");
        Console.ReadKey();
    }

    private static void submenu()
    {
        Console.WriteLine("novo saldo: {0}", saldo);
        Console.WriteLine("1 - menu			0 - logout");

        string seleçao;
        do
        {
            seleçao = Console.ReadLine();

            switch (seleçao)
            {
                case "0":
                    Console.Clear();
                    Console.WriteLine("BytBank \n logout");
                    login();
                    break;
                case "1":
                    menu();
                    break;
            }
        } while (seleçao != "0");
    }

    private static void saque()
    {
        Console.Clear();
        Console.WriteLine("BytBank saque \n");
        Console.WriteLine("saldo: {0}", saldo);
        Console.Write("valor do saque: ");
        double valsaque = double.Parse(Console.ReadLine());
        saldo = saldo - valsaque;
        submenu();
    }

    private static void deposito()
    {
        Console.Clear();
        Console.WriteLine("BytBank deposito \n");
        Console.WriteLine("saldo: {0}", saldo);
        Console.Write("valor do deposito: ");
        double valdeposito = double.Parse(Console.ReadLine());
        saldo = saldo + valdeposito;

        submenu();
    }

    private static void transferencia()
    {
        Console.Clear();
        Console.WriteLine("BytBank transferencia \n");
        Console.WriteLine("saldo: {0}", saldo);
        Console.Write("transferir: ");
        double valtrans = double.Parse(Console.ReadLine());
        Console.Write("para: ");
        string para = (Console.ReadLine());
        saldo = saldo - valtrans;
        saldo1 = saldo;
        saldo2 = saldo2 + valtrans;


        submenu();

    }

    static void Main(string[] args)
    {
        login();
        

    }


}