using _05_State.Interfaces;
using System;

namespace _05_State.Entities.Conta
{
    public class Conta
    {
        public string Titular { get; private set; }
        public string Numero { get; private set; }
        public string Agencia { get; private set; }
        public decimal Saldo { get; set; }
        public DateTime DataAbertura { get; set; }
        public IEstadoDeConta Estado { get; set; }

        public Conta(string titular, decimal saldo)
        {
            Titular = titular;
            Saldo = saldo;
        }

        public void Sacar(decimal valor)
        {
            Estado.Sacar(this, valor);
        }

        public void Depositar(decimal valor)
        {
            Estado.Depositar(this, valor);
        }
    }
}
