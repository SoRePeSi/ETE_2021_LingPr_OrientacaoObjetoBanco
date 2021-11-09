using System;
using System.Collections.Generic;

public class Funcionario{
	public string Nome {get; set;}
	public string CPF {get; set;}
	public double Salario {get; set;}
	
	public static List<Funcionario> TodosFuncionarios = new List<Funcionario>();
	
	protected double _bonificacao;
	public virtual double Bonificacao{
		get{
			return _bonificacao;
		}
		set{
			_bonificacao = Salario*0.01;
		}
	}
	
	public List<ContaCorrente> Clientes = new List<ContaCorrente>();
	public int[] agencias = {};
	
	public double RemuneracaoAnual{get{return (this.Salario*13+this.Bonificacao);}}
	
	public virtual int DiasDeFerias{get{return 30;}}
}