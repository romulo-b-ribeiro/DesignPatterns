using System;

namespace _04_Decorator.Entities
{
    public class Conta
    {
        public string Titular { get; private set; }
        public string Numero { get; private set; }
        public string Agencia { get; private set; }
        public decimal Saldo { get; private set; }
        public DateTime DataAbertura { get; set; }

        public Conta(string titular, decimal saldo)
        {
            Titular = titular;
            Saldo = saldo;
        }
    }
}
