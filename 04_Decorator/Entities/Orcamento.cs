using System.Collections.Generic;

namespace _04_Decorator.Entities
{
    public class Orcamento
    {
        public decimal Valor { get; private set; }
        public IList<Item> Itens { get; private set; }

        public Orcamento(decimal valor)
        {
            Valor = valor;
            Itens = new List<Item>();
        }

        public void AdicionaItem(Item item)
        {
            Itens.Add(item);
        }
    }
}
