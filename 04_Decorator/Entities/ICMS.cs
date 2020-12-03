using _04_Decorator.Entities.Abstracts;

namespace _04_Decorator.Entities
{
    public class ICMS : Imposto
    {
        public ICMS(Imposto outroImposto) : base(outroImposto) { }
        public ICMS() : base() { }

        public override decimal Calcular(Orcamento orcamento)
        {
            return orcamento.Valor * 0.05M + 50M + CalcularOutroImposto(orcamento);
        }
    }
}
