using System;
public class ContaCorrente{
    public string titular;
    public int agencia, conta;
    public double saldo;
    public void CriarConta(string titular, int agencia, int conta, double saldo){
        this.titular = titular;
        this.agencia = agencia;
        this.conta = conta;
        this.saldo = saldo;
    }
}