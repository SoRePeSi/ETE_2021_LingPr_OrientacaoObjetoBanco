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
		}
	}
}
