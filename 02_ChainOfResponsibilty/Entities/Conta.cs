using System;
using System.Collections.Generic;
using System.Text;

namespace _02_ChainOfResponsibilty.Entities
{
    public class Conta
    {
        public string Titular { get; private set; }
        public decimal Saldo { get; private set; }

        public Conta(string titular, decimal saldo)
        {
            Titular = titular;
            Saldo = saldo;
        }
    }
}
