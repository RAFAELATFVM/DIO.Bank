using System;
using System.Collections.Generic;

namespace DIO.Bank
{
    class Program 
    {
        static List<conta> listcontas = new List<conta>();
        static void Main(string[] args)
        {
            string opcaousuario = obteropcaousuario();

            while(opcaousuario.ToUpper() !="x")
            {
                switch(opcaousuario)
                {
                    case"1":
                    listarcontas();
                    break;
                    case"2":
                    inserirconta();
                    break;
                    case"3":
                    transferir();
                    break;
                    case"4":
                    Sacar();
                    break;
                    case"5":
                    depositar();
                    break;
                    case"6":
                    Console.Clear();
                    break;

                    default:
                    throw new ArgumentOutOfRangeException();
                }
               
                opcaousuario = obteropcaousuario();
            }

            Console.WriteLine("obrigada por utilizar nossos serviços");
            Console.ReadLine();
                }

               private static void Sacar()
        {
            Console.Write("digite o número da conta: ");
            int indiceconta = int.Parse(Console.ReadLine());

            Console.Write("digite valor do saque: ");
            double valorSaque = double.Parse(Console.ReadLine());

            listcontas[indiceconta].Sacar(valorSaque);
        }
        
        private static void depositar()
        {
            Console.Write("digite o numero da conta: ");
            int indiceconta = int.Parse(Console.ReadLine());

            Console.Write("digite o valor do deposito: ");
            double valordeposito = double.Parse(Console.ReadLine());

            listcontas[indiceconta].depositar(valordeposito);
        }

        private static void transferir()
{
    Console.Write("digite o numero da conta de origem: ");
    int indicecontaorigem = int.Parse(Console.ReadLine());

    Console.Write("digite o número da conta de destino: ");
    int indicecontadestino = int.Parse(Console.ReadLine());

    Console.Write("digite o valor da transferência");
    double valortransferencia = double.Parse(Console.ReadLine());

    listcontas[indicecontaorigem].transferir(valortransferencia, listcontas[indicecontadestino]);
}

        private static void inserirconta()
        {
            Console.WriteLine("inserir nova conta");

            Console.WriteLine("digite 1 para conta fisica ou 2 para juridica: ");
            int entradatipoconta = int.Parse(Console.ReadLine());
            
            Console.WriteLine("digite o nome do cliente: ");
            string entradaNome = Console.ReadLine();

            Console.WriteLine("digite o saldo inicial: ");
            double entradasaldo = Double.Parse(Console.ReadLine());

            Console.WriteLine("digite o credito: ");
            double entradacredito = double.Parse(Console.ReadLine());

            conta novaconta = new conta(tipoconta: (tipoconta)entradatipoconta, saldo:entradasaldo, credito: entradacredito, Nome: entradaNome);




            listcontas.Add(novaconta);
        }

        private static void listarcontas()
        {    
            Console.WriteLine("listar contas");

            if (listcontas.Count == 0)
            {
                Console.WriteLine("nenhuma conta cadastrada.");
                return;
            }

            for (int i = 0; i<listcontas.Count; i++)
            {
                conta conta = listcontas[i];
                Console.Write("#{0} -", i);
                Console.WriteLine(conta);
            }
        }
        private static string obteropcaousuario()
        {

        Console.WriteLine();
        Console.WriteLine ("DIO Bank a seu dispor");
        Console.WriteLine ("Informe a opção desejada");

        Console.WriteLine ("1 - Listar contas");
        Console.WriteLine ("2 - Inserir nova conta");
        Console.WriteLine ("3 - transferir");
        Console.WriteLine ("4 - sacar");
        Console.WriteLine ("5 - depositar");
        Console.WriteLine ("6 - limpar tela");
        Console.WriteLine ("x - sair");
        Console.WriteLine();
        string opcaousuario = Console.ReadLine().ToUpper();
        Console.WriteLine();
        return opcaousuario;
        }

    }
}
 