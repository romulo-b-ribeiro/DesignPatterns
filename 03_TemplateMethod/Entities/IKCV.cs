using _03_TemplateMethod.Templates;
using System.Linq;

namespace _03_TemplateMethod.Entities
{
    public class IKCV : TemplateDeImpostoCondicional
    {
        public override bool DeveUsarMaximaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor > 500 && TemItemMaiorQue100ReaisNo(orcamento);
        }

        public override decimal MaximaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor * 0.10M;
        }

        public override decimal MinimaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor * 0.06M;
        }
        private bool TemItemMaiorQue100ReaisNo(Orcamento orcamento)
    {
            return orcamento.Itens.Any(item => item.Valor > 100);
        }
    }
}
