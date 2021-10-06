using System;

public class Funcionario{
	public string Nome {get; set;}
	public string CPF {get; set;}
	public string Cargo {get; set;}
	public double Salario {get; set;}
	public double Comissao {get; set;}
	
	private double _bonificacao {get; set;}
	public double Bonificacao{
		get{
			return this._bonificacao;
		}
		set{
			if(this.Cargo=="Vendedor"){
				this._bonificacao += value * 0.02;
			}
			else if(this.Cargo=="Diretor"){
				this._bonificacao += value * 0.08;
			}
		}
	}

	public Funcionario(){}

	public Funcionario(string funcNome, string funcCPF, string funcCargo, double funcSalario){
		this.Nome = funcNome;
		this.CPF = funcCPF;
		this.Cargo = funcCargo;
		this.Salario = funcSalario;

		Console.WriteLine("Funcionário {0}.", this.Nome);
	}	
}