using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns_Alura._01_Strategy
{
    interface IInvestimento
    {
        decimal CalcularRetorno(Conta investimento);
    }

    class Conta
    {
        public decimal Saldo { get; private set; }

        public void Depositar(decimal valor)
        {
            Saldo += valor;
        }
    }

    class Conservador : IInvestimento
    {
        private const decimal TAXA_DE_RETORNO = 0.008M;

        public decimal CalcularRetorno(Conta investimento)
        {
            return investimento.Saldo * TAXA_DE_RETORNO;
        }
    }

    class Moderado : IInvestimento
    {
        public decimal CalcularRetorno(Conta investimento)
        {
            decimal taxaDeRetorno;
            var sorte = new Random().Next(2);
            if (sorte == 0)
                taxaDeRetorno = 0.025M;
            else
                taxaDeRetorno = 0.07M;

            return investimento.Saldo * taxaDeRetorno;
        }
    }
    class Arrojado : IInvestimento
    {
        public decimal CalcularRetorno(Conta investimento)
        {
            decimal taxaDeRetorno;
            var sorte = new Random().Next(10);
            if (sorte < 2)
                taxaDeRetorno = 0.05M;
            else if (sorte >= 2 && sorte < 4)
                taxaDeRetorno = 0.03M;
            else
                taxaDeRetorno = 0.006M;
            return investimento.Saldo * taxaDeRetorno;
        }
    }

    class RealizadorDeInvestimentos
    {
        private const decimal DESCONTO_DE_IMPOSTOS = 0.75M;
        public void Realizar(Conta conta, IInvestimento investimento)
        {
            var resultado = investimento.CalcularRetorno(conta);
            conta.Depositar(resultado * DESCONTO_DE_IMPOSTOS);
            Console.WriteLine($"Novo saldo: {conta.Saldo}");
        }
    }
}
