using System;

namespace OoBanco{
    class Program{
        static void Main(string[] args){
            ContaCorrente ContaBarbara = new ContaCorrente("Bárbara", 1234, 789, 100.50);
            ContaCorrente ContaJoao = new ContaCorrente("João", 1245, 790, 120);
            ContaCorrente ContaSofia = new ContaCorrente("Sofia", 1357, 799, 50);

            Console.WriteLine("O titular da conta é {0}. Valor: {1}", ContaBarbara.titular, ContaBarbara.ConsultaSaldo());
            ContaBarbara.Sacar(100);
        }
    }
}
