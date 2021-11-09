using System;
using System.Collections.Generic;

public class Vendedor:Funcionario{
	public int NumeroDeClientes;
	public List<int> Agencias = new List<int>();
	public static List<int> TodasAgencias = new List<int>();
	public static List<Vendedor> TodosVendedores = new List<Vendedor>();
	
	public override double Bonificacao{
		get{
			return _bonificacao;
		}
		set{
			_bonificacao = this.Salario*value;
		}
	}
	
	public override int DiasDeFerias{get{return (30+NumeroDeClientes);}}
	
	public Vendedor(){}
	
	public Vendedor(string nome, string cpf, double salario, int clientes, int agencia){
		this.Nome = nome;
		this.CPF = cpf;
		this.Salario = salario;
		this.NumeroDeClientes = clientes;
		this.Bonificacao = 0.02;
		
		this.Agencias.Add(agencia);
		TodasAgencias.Add(agencia);
		
		TodosVendedores.Add(this);
		TodosFuncionarios.Add(this);
		Console.WriteLine("Vendedor {0} criado.", this.Nome);
	}
}