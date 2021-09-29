using System;

public class ContaCorrente
	public string Titular{get; set;}
	public int Agencia{get; set;}
	public int Conta{get; set;}
	private double _saldo = 0;
	public double Saldo{
		get {return this._saldo;}

		set{this._saldo = value;}
	}

	public static int TotalDeContas{get; set;}
	public static double TotalDeComissao{get; set;}

	public ContaCorrente(){}
	
	public ContaCorrente(string titular, int agencia, int conta, double conta_saldo, Funcionario funcionario){
		this.Titular = titular;
		this.Agencia = agencia;
		this.Conta = conta;
		this._saldo = conta_saldo;

		Console.WriteLine("Conta de {0} criada.", this.Titular);

		TotalDeContas++;
		funcionario.Comissao += conta_saldo*0.01;
	}

	public bool Sacar(double valor){
		if((this._saldo<valor)||(valor<0)){
			return false;
		}
		else{
			this._saldo -= valor;
			Console.WriteLine("SAQUE EFETUADO COM SUCESSO\nSaldo atual de {0}: R${1}\n", this.Titular, this._saldo);
			return true;
		}
	}

	public bool Depositar(double valor){
		if(valor<=0){
			Console.WriteLine("ERRO\nValor a depositar deve ser positivo");
			return false;
		}
		else{
			this._saldo += valor;
			Console.WriteLine("DEPÓSITO EFETUADO COM SUCESSO\nSaldo atual de {0}: R${1}\n", this.Titular, this._saldo);

			return true;
		}
	}

	public bool Transferir(ContaCorrente receptor, double valor){
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