using _05_State.Interfaces;
using System;

namespace _05_State.Entities.Orcamento
{
    public class Reprovado : IEstadoDeUmOrcamento
    {
        public void AplicarDescontoExtra(Orcamento orcamento)
        {
            throw new Exception("Orçamento reprovado não recebe desconto");
        }

        public void Aprovar(Orcamento orcamento)
        {
            throw new Exception("Orçamento reprovado não pode ser aprovado");
        }

        public void Finalizar(Orcamento orcamento)
        {
            throw new Exception("Orçamento reprovado não pode ser finalizado");
        }

        public void Reprovar(Orcamento orcamento)
        {
            throw new Exception("Orçamento já foi reprovado");
        }
    }
}
