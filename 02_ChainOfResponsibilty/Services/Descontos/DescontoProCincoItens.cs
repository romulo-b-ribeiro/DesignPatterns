using _02_ChainOfResponsibilty.Entities;
using _02_ChainOfResponsibilty.Interfaces;

namespace _02_ChainOfResponsibilty.Services
{
    public class DescontoProCincoItens : IDesconto
    {
        public IDesconto Proximo { get; set; }
        public decimal Descontar(Orcamento orcamento)
        {
            if (orcamento.Itens.Count > 5)
            {
                return orcamento.Valor * 0.1M;
            }
            else
            {
                return Proximo.Descontar(orcamento);
            }
        }
    }
}
