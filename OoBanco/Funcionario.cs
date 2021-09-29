using System;

public class Funcionario{
	public string Nome {get; set;}
	public string CPF {get; set;}
	public string Cargo {get; set;}
	public double Salario {get; set;}
	public double Comissao {get; set;}

	public Funcionario(){}

	public Funcionario(string funcNome, string funcCPF, string funcCargo, double funcSalario){
		this.Nome = funcNome;
		this.CPF = funcCPF;
		this.Cargo = funcCargo;
		this.Salario = funcSalario;

		Console.WriteLine("Funcionário {0}.", this.Nome);
	}	
}