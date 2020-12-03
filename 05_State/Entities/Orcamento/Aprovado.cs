using _05_State.Interfaces;
using System;

namespace _05_State.Entities.Orcamento
{
    public class Aprovado : IEstadoDeUmOrcamento
    {
        private const decimal DESCONTO = 0.02M;
        private bool _semDesconto = true;

        public void AplicarDescontoExtra(Orcamento orcamento)
        {
            if (_semDesconto)
            {
                orcamento.Valor *= (1 - DESCONTO);
                _semDesconto = false;
            }
            else
            {
                throw new Exception("Desconto já aplicado");
            }
        }

        public void Aprovar(Orcamento orcamento)
        {
            throw new Exception("Orçamento já foi aprovado");
        }

        public void Finalizar(Orcamento orcamento)
        {
            orcamento.Estado = new Finalizado();
        }

        public void Reprovar(Orcamento orcamento)
        {
            orcamento.Estado = new Reprovado();
        }
    }
}
