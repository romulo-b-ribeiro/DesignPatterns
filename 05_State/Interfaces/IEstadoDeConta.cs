using _05_State.Entities.Conta;

namespace _05_State.Interfaces
{
    public interface IEstadoDeConta
    {
        void AtualizarEstado(Conta conta);
        void Depositar(Conta conta, decimal valor);
        void Sacar(Conta conta, decimal valor);
    }
}
