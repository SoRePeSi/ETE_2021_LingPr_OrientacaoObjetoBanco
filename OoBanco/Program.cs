using System;

namespace OoBanco{
    class Program{
		static void Main(string[] args){
			Vendedor VendedorSonia = new Vendedor("Sonia", "123.456.890-00", 1000, 3, 1234);
			Vendedor VendedorAsquenaz = new Vendedor("Asquenaz", "987.654.321-00", 1000, 6, 1357);
			Vendedor VendedorDumbledore = new Vendedor("Dumbledore", "135.357.579-00", 1000, 5, 2468);
			Console.WriteLine("");
			
			Gerente GerenteBarbara = new Gerente("Bárbara", "246.468.680-00", 2000, 3);
			Console.WriteLine("");

			ContaCorrente ContaSofiaRezende = new ContaCorrente("Sofia Rezende", 1357, 799, 50);
			ContaCorrente ContaCarmem = new ContaCorrente("Carmem", 1234, 789, 100.50);
			ContaCorrente ContaAifos = new ContaCorrente("Aifos", 2468, 790, 120);
			
			Console.WriteLine("Total de contas criadas: {0}", ContaCorrente.TodosClientes.Count);
			Console.WriteLine("");
			
			foreach(Funcionario funcionario in Funcionario.TodosFuncionarios){
				Console.WriteLine("Bonificação anual de {0} = R${1}", funcionario.Nome, funcionario.Bonificacao);
			}
			Console.WriteLine("");
			
			foreach(Funcionario funcionario in Funcionario.TodosFuncionarios){
				Console.WriteLine("Remuneração anual de {0} = R${1}", funcionario.Nome, funcionario.RemuneracaoAnual);
			}
			Console.WriteLine("");
			
			foreach(Funcionario funcionario in Funcionario.TodosFuncionarios){
				Console.WriteLine("Quantidade de dias de férias de {0} = {1}", funcionario.Nome, funcionario.DiasDeFerias);
			}
			Console.WriteLine("");
		}
	}
}

// dotnet new console -o nomeDoArquivo