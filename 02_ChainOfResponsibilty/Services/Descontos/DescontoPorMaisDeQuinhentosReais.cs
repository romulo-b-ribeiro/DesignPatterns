using _02_ChainOfResponsibilty.Entities;
using _02_ChainOfResponsibilty.Interfaces;

namespace _02_ChainOfResponsibilty.Services
{
    public class DescontoPorMaisDeQuinhentosReais : IDesconto
    {
        public IDesconto Proximo { get; set; }
        public decimal Descontar(Orcamento orcamento)
        {
            if (orcamento.Valor > 500M)
            {
                return orcamento.Valor * 0.07M;
            }
            else
            {
                return Proximo.Descontar(orcamento);
            }
        }
    }
}
