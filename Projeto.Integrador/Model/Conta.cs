using System;

namespace Projeto.Integrador.Model
{
    public class Conta
    {
        public int NumeroConta { get; private set; }
        public double Saldo { get; private set; }
        public Usuario Titular { get; private set; }

        public Conta()
        {
        }

        public Conta(int numeroConta, double saldo, Usuario titular)
        {
            NumeroConta = numeroConta;
            Saldo = saldo;
            Titular = titular;
        }

        public void Depositar(double valor)
        {
            Saldo += valor;
        }

        public void Sacar(double valor)
        {
            Saldo -= valor;
        }
    }
}