using System;
using System.Collections.Generic;

namespace BankingSystemDIO
{
    class Program
    {
        static List<Conta> listaContas = new List<Conta>();
        static void Main(string[] args)
        {
            //Conta minhaConta = new Conta(TipoConta.PessoaFisica, 10, 10, "Kemylly");
            //minhaConta.Nome = "Kemylly";
            //Console.WriteLine(minhaConta.ToString());

            string opcaoUsuario = ObterOpcaoUsuario();

            while (opcaoUsuario.ToUpper() != "X")
            {
                switch (opcaoUsuario)
                {
                    case "1": 
                        // ListarContas();
                        break;
                    case "2": 
                        InserirConta();
                        break;
                    case "3": 
                        // Transferir();
                        break;
                    case "4": 
                        // Sacar();
                        break;
                    case "5": 
                        // Depositar();
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
                opcaoUsuario = ObterOpcaoUsuario();
            }
            Console.WriteLine("Obrigado por utilizar nossos serviços");
            Console.ReadLine();
        }

        private static void InserirConta()
        {
            Console.WriteLine("Criando conta");

            Console.Write("Digite 1 para Conta Fisica ou 2 para Juridica: ");
            int entradaTipoConta = int.Parse(Console.ReadLine());

            Console.Write("Digite o Nome do cliente: ");
            string entradaNome = Console.ReadLine();

            Console.Write("Digite o Saldo inicial: ");
            double entradaSaldo = double.Parse(Console.ReadLine());

            Console.Write("Digite o credito: ");
            double entradaCredito = double.Parse(Console.ReadLine());
        }

        private static string ObterOpcaoUsuario()
        {
            Console.WriteLine();
            Console.WriteLine("Bem-vindo ao Banking System");

            Console.WriteLine("Digite o numero da opção desejada:");
            Console.WriteLine("1 - Listar contas");
            Console.WriteLine("2 - Inserir nova conta");
            Console.WriteLine("1 - Transferir");
            Console.WriteLine("1 - Sacar");
            Console.WriteLine("5 - Depositar");
            Console.WriteLine("C - Limpar Tela");
            Console.WriteLine("X - Sair");

            Console.WriteLine();

            string opcaoUsuario = Console.ReadLine().ToUpper();
            Console.WriteLine();

            return opcaoUsuario;
        }
    }
}
