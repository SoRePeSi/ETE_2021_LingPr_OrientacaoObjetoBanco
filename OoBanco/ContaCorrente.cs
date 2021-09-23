using System;
public class ContaCorrente{
	public string Titular{get; set;}
	public int Agencia{get; set;}
	public int Conta{get; set;}

	private double _saldo = 0;
	public double Saldo{
		get {return this._saldo;}

		set{this._saldo = value;}
	}

	public static int TotalDeContas{get; set;}

	public ContaCorrente(){}
	
	public ContaCorrente(string titular, int agencia, int conta, double _saldo){
		this.Titular = titular;
		this.Agencia = agencia;
		this.Conta = conta;
		this._saldo = _saldo;

		TotalDeContas++;
	}

	public bool Sacar(double valor){
		if((this._saldo<valor)||(valor<0)){
			return false;
		}
		else{
			this._saldo -= valor;
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
				return true;
			}
			catch{
				Console.WriteLine("ERRO");
				return false;
			}
		}
	}
}