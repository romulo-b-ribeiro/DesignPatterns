using _02_ChainOfResponsibilty.Entities;
using _02_ChainOfResponsibilty.Interfaces;
using System;
using System.Linq;

namespace _02_ChainOfResponsibilty.Services
{
    public class DescontoPorVendaCasada : IDesconto
    {
        public IDesconto Proximo { get; set; }

        public decimal Descontar(Orcamento orcamento)
        {
            if (AconteceuVendaCasada(orcamento))
            {
                return orcamento.Valor * 0.05M;
            }
            return Proximo.Descontar(orcamento);
        }

        private bool AconteceuVendaCasada(Orcamento orcamento)
        {
            return ChecarNome(orcamento, "LAPIS") && ChecarNome(orcamento, "CANETA");
        }

        private bool ChecarNome(Orcamento orcamento, string nomeDoItem)
        {
            return orcamento.Itens.Select(q => q.Nome).Contains(nomeDoItem);
        }
    }
}
