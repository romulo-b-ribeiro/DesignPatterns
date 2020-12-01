using _02_ChainOfResponsibilty.Entities;

namespace _02_ChainOfResponsibilty.Interfaces
{
    public interface IDesconto
    {
        IDesconto Proximo { get; set; }
        decimal Descontar(Orcamento orcamento);
    }
}
