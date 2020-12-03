using _03_TemplateMethod.Entities;
using _03_TemplateMethod.Interfaces;

namespace _03_TemplateMethod.Templates
{
    public abstract class TemplateDeImpostoCondicional : IImposto
    {
        public decimal Calcular(Orcamento orcamento)
        {
            if (DeveUsarMaximaTaxacao(orcamento))
            {
                return MaximaTaxacao(orcamento);
            }
            return MinimaTaxacao(orcamento);
        }

        public abstract bool DeveUsarMaximaTaxacao(Orcamento orcamento);
        public abstract decimal MaximaTaxacao(Orcamento orcamento);
        public abstract decimal MinimaTaxacao(Orcamento orcamento);
    }
}
