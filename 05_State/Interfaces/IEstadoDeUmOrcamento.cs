using _05_State.Entities.Orcamento;

namespace _05_State.Interfaces
{
    public interface IEstadoDeUmOrcamento
    {
        void AplicarDescontoExtra(Orcamento orcamento);
        void Aprovar(Orcamento orcamento);
        void Reprovar(Orcamento orcamento);
        void Finalizar(Orcamento orcamento);
    }
}
