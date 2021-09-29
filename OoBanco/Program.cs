using System;

namespace OoBanco{
    class Program{
		static void Main(string[] args){
			Funcionario FuncionarioSonia = new Funcionario("Sonia", "123.456.890-00", "Vendedor", 1000);
			Funcionario FuncionarioAsquenaz = new Funcionario("Asquenaz", "987.654.321-00", "Vendedor", 1000);
			Console.WriteLine("\n");

			ContaCorrente ContaSofiaRezende = new ContaCorrente("Sofia Rezende", 1357, 799, 50, FuncionarioAsquenaz);
			ContaCorrente ContaCarmem = new ContaCorrente("Carmem", 1234, 789, 100.50, FuncionarioSonia);
			ContaCorrente ContaAifos = new ContaCorrente("Aifos", 1245, 790, 120, FuncionarioAsquenaz);
			Console.WriteLine("\n");

			ContaSofiaRezende.Sacar(10);
			ContaCarmem.Depositar(200);
			ContaAifos.Transferir(ContaSofiaRezende, 100);
			if((valor<0)||(this._saldo<valor)){
				return false;
			}
			else{
				try{
					this.Sacar(valor);
					receptor.Depositar(valor);
					Console.WriteLine("TRANSFERÊNCIA EFETUADA COM SUCESSO\nSaldo atual de {0}: R${1}\nSaldo atual de {2}: R${3}\n", this.Titular, this._saldo, receptor.Titular, receptor._saldo);
					return true;
				}
				catch{
						Console.WriteLine("ERRO");
						return false;
					}
			}
		}
	}
}
