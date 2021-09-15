using System;
public class ContaCorrente{
    public string titular;
    public int agencia, conta;
    public double saldo;
    public ContaCorrente(){}
    public ContaCorrente(string titular, int agencia, int conta, double saldo){
        this.titular = titular;
        this.agencia = agencia;
        this.conta = conta;
        this.saldo = saldo;
    }

    public bool Sacar(double valor){
        if((this.saldo<valor)||(valor<0)){
            return false;
        }
        else{
            this.saldo -= valor;
            return true;
        }
    }

    public bool Depositar(double valor){
        if(valor<=0){
            Console.WriteLine("ERRO\nValor a depositar deve ser positivo");
            return false;
        }
        else{
            this.saldo += valor;

            Console.WriteLine("Operação finalizada.");
            return true;
        }
    }

    public bool Transferir(ContaCorrente receptor, double valor){
        if((valor<0)||(this.saldo<valor)){
            return false;
        }
        else{
            try{
                this.Sacar(valor);
                receptor.Depositar(valor);

                Console.WriteLine("Operação finalizada");
                return true;
            }
            catch{
                Console.WriteLine("ERRO:\nConta inexistente.");
                return false;
            }
        }
    }

}