using _05_State.Interfaces;

namespace _05_State.Entities.Conta
{
    public class Positivo : IEstadoDeConta
    {
        public void AtualizarEstado(Conta conta)
        {
            if (conta.Saldo < 0)
            {
                conta.Estado = new Negativo();
            }
        }

        public void Depositar(Conta conta, decimal valor)
        {
            conta.Saldo += valor * 0.98M;
        }

        public void Sacar(Conta conta, decimal valor)
        {
            conta.Saldo -= valor;
            AtualizarEstado(conta);
        }
    }
}
