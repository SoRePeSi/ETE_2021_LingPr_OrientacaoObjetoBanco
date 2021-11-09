using System;
using System.Collections.Generic;

public class Gerente:Funcionario{
	public int NumeroDeAgencias;
	
	public static List<Gerente> TodosGerentes = new List<Gerente>();
	
	public override double Bonificacao{
		get{
			return _bonificacao;
		}
		set{
			_bonificacao = this.Salario*value;
		}
	}
	
	public override int DiasDeFerias{get{return (30+NumeroDeAgencias*5);}}
	
	public Gerente(){}
	
	public Gerente(string nome, string cpf, double salario, int agencias){
		this.Nome = nome;
		this.CPF = cpf;
		this.Salario = salario;
		this.NumeroDeAgencias = agencias;
		this.Bonificacao = 0.05;
		
		Console.WriteLine("Gerente {0} criado", this.Nome);
		
		TodosFuncionarios.Add(this);
		TodosGerentes.Add(this);
	}
}