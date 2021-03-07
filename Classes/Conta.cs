namespace BankingSystemDIO
{
    public class Conta
    {
        public Conta(TipoConta tipoConta, double saldo, double credito, string nome) 
        {
            this.TipoConta = tipoConta;
            this.Saldo = saldo;
            this.Credito = credito;
            this.Nome = nome;
               
        }
        
        private TipoConta TipoConta { get; set; }  //enum

        private double Saldo { get; set; }

        private double Credito { get; set; }

        private string Nome { get; set; }

        public bool Sacar(double valorSaque)
        {
            //validacao do saldo
            if(this.Saldo - valorSaque < (this.Credito *-1))
            {
                Console.WriteLine("Saldo Insuficente");
                return false;
            }

            this.Saldo -= valorSaque;

            Console.WriteLine("{0}, seu saldo atual da conta é de {1}", this.Nome, this.Saldo);
        }
    }
}