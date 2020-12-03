using _05_State.Interfaces;
using System;

namespace _05_State.Entities.Orcamento
{
    public class Finalizado : IEstadoDeUmOrcamento
    {
        public void AplicarDescontoExtra(Orcamento orcamento)
        {
            throw new Exception("Orçamento finalizado não recebe desconto");
        }

        public void Aprovar(Orcamento orcamento)
        {
            throw new Exception("Orçamento finalizado não pode ser aprovado");
        }

        public void Finalizar(Orcamento orcamento)
        {
            throw new Exception("Orçamento já foi finalizado");
        }

        public void Reprovar(Orcamento orcamento)
        {
            throw new Exception("Orçamento finalizado não pode ser reprovado");
        }
    }
}
