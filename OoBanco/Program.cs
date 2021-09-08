using System;

namespace OoBanco{
    class Program{
        static void Main(string[] args){
            ContaCorrente ContaBarbara = new ContaCorrente();
            ContaCorrente ContaJoao = new ContaCorrente();
            
            ContaBarbara.titular = "Bárbara";
            ContaBarbara.agencia = 1234;
            ContaBarbara.conta = 789;
            ContaBarbara.saldo = 100.50;
            
            ContaJoao.titular = "João";
            ContaJoao.agencia = 1234;
            ContaJoao.conta = 790;
            ContaJoao.saldo = 120;

            Console.WriteLine("O titular da conta é {0}", ContaBarbara.titular);
            Console.WriteLine("O titular da conta é {0}", ContaJoao.titular);
        }
    }
}
