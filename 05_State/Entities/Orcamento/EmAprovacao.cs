using _05_State.Interfaces;
using System;

namespace _05_State.Entities.Orcamento
{
    public class EmAprovacao : IEstadoDeUmOrcamento
    {
        private const decimal DESCONTO = 0.05M;
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
            orcamento.Estado = new Aprovado();
        }

        public void Finalizar(Orcamento orcamento)
        {
            throw new Exception("Orçamento em aprovação não pode ser finalizado diretamente");
        }

        public void Reprovar(Orcamento orcamento)
        {
            orcamento.Estado = new Reprovado();
        }
    }
}
