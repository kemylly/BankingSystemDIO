using System;

namespace BankingSystemDIO
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta minhaConta = new Conta(TipoConta.PessoaFisica, 10, 10, "Kemylly");

            //minhaConta.Nome = "Kemylly";
            

            Console.WriteLine(minhaConta.ToString());
        }
    }
}
