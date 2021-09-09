using System;

namespace OoBanco{
    class Program{
        static void Main(string[] args){
            ContaCorrente ContaBarbara = new ContaCorrente();
            ContaBarbara.CriarConta("Bárbara", 1234, 789, 100.50);
            ContaCorrente ContaJoao = new ContaCorrente();
            ContaJoao.CriarConta("João", 1234, 790, 120);

            Console.WriteLine("O titular da conta é {0}", ContaBarbara.titular);
            Console.WriteLine("O titular da conta é {0}", ContaJoao.titular);
        }
    }
}
