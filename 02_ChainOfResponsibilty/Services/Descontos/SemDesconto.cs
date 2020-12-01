using _02_ChainOfResponsibilty.Entities;
using _02_ChainOfResponsibilty.Interfaces;

namespace _02_ChainOfResponsibilty.Services
{
    class SemDesconto : IDesconto
    {
        public IDesconto Proximo { get; set; }
        public decimal Descontar(Orcamento orcamento)
        {
            return 0;
        }
    }
}
