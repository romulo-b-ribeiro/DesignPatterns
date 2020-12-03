using _05_State.Interfaces;
using System;

namespace _05_State.Entities.Conta
{
    public class Negativo : IEstadoDeConta
    {

        public void AtualizarEstado(Conta conta)
        {
            if (conta.Saldo > 0)
            {
                conta.Estado = new Positivo();
            }
        }

        public void Depositar(Conta conta, decimal valor)
        {
            conta.Saldo += valor * 0.95M;
            AtualizarEstado(conta);
        }

        public void Sacar(Conta conta, decimal valor)
        {
            throw new Exception("Não é possível sacar com a conta negativada");
        }
    }
}
