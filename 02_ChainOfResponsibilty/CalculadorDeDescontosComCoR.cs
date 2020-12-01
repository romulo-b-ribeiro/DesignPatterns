using _02_ChainOfResponsibilty.Entities;
using _02_ChainOfResponsibilty.Interfaces;
using _02_ChainOfResponsibilty.Services;
using System;

namespace _02_ChainOfResponsibilty
{
    public class CalculadorDeDescontos
    {
        public decimal Calcular(Orcamento orcamento)
        {
            IDesconto d1 = new DescontoProCincoItens();
            IDesconto d2 = new DescontoPorMaisDeQuinhentosReais();
            IDesconto d3 = new DescontoPorVendaCasada();
            IDesconto d4 = new SemDesconto();

            d1.Proximo = d2;
            d2.Proximo = d3;
            d3.Proximo = d4;

            return d1.Descontar(orcamento);
        }
    }

    public class TestaDescontos
    {
        static void Main(string[] args)
        {
            CalculadorDeDescontos calculador = new CalculadorDeDescontos();

            Orcamento orcamento = new Orcamento(500.0M);
            orcamento.AdicionaItem(new Item("CANETA", 250.0M));
            orcamento.AdicionaItem(new Item("LAPIS", 250.0M));

            decimal desconto = calculador.Calcular(orcamento);

            Console.WriteLine(desconto);
        }
    }
}
