using _04_Decorator.Entities.Abstracts;

namespace _04_Decorator.Entities
{
    public class ImpostoMuitoAlto : Imposto
    {
        public ImpostoMuitoAlto(Imposto outroImposto) : base (outroImposto) { }
        public ImpostoMuitoAlto() : base() { }

        public override decimal Calcular(Orcamento orcamento)
        {
            return orcamento.Valor * 0.20M;
        }
    }
}
