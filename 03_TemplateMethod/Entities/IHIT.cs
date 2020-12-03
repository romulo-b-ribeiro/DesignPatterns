using _03_TemplateMethod.Templates;
using System.Collections.Generic;
using System.Linq;

namespace _03_TemplateMethod.Entities
{
    public class IHIT : TemplateDeImpostoCondicional
    {
        public override bool DeveUsarMaximaTaxacao(Orcamento orcamento)
        {
            return ChecarItensIguais(orcamento, 2);
        }

        public override decimal MaximaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor * 0.13M + 100M;
        }

        public override decimal MinimaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor * 0.01M * orcamento.Itens.Count;
        }

        private bool ChecarItensIguais(Orcamento orcamento, int numero)
        {
            foreach (var item in orcamento.Itens)
            {
                if (ContarNumeroDeItens(orcamento, item) >= numero)
                    return true;
            };
            return false;
        }

        private static int ContarNumeroDeItens(Orcamento orcamento, Item item)
        {
            return orcamento.Itens.Union(new List<Item> { item }).Count();
        }
    }
}
