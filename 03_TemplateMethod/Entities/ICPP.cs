using _03_TemplateMethod.Templates;

namespace _03_TemplateMethod.Entities
{
    public class ICPP : TemplateDeImpostoCondicional
    {
        public override bool DeveUsarMaximaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor >= 500M;
        }

        public override decimal MaximaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor * 0.07M;
        }

        public override decimal MinimaTaxacao(Orcamento orcamento)
    {
            return orcamento.Valor * 0.05M;
        }
    }
}
