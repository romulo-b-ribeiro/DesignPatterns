using _05_State.Interfaces;
using System.Collections.Generic;

namespace _05_State.Entities.Orcamento
{
    public class Orcamento
    {
        public IEstadoDeUmOrcamento Estado { get; set; }
        public decimal Valor { get; set; }
        public IList<Item> Itens { get; private set; }

        public Orcamento(decimal valor)
        {
            Valor = valor;
            Itens = new List<Item>();
            Estado = new EmAprovacao();
        }

        public void AdicionaItem(Item item)
        {
            Itens.Add(item);
        }

        public void AplicarDescontoExtra()
        {
            Estado.AplicarDescontoExtra(this);
        }

        public void Aprovar()
        {
            Estado.Aprovar(this);
        }

        public void Reprovar()
        {
            Estado.Reprovar(this);
        }

        public void Finalizar()
        {
            Estado.Finalizar(this);
        }
    }
}
