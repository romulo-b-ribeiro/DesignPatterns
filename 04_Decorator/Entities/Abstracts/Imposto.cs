namespace _04_Decorator.Entities.Abstracts
{
    public abstract class Imposto
    {
        public Imposto OutroImposto { get; private set; }

        public Imposto(Imposto outroImposto)
        {
            OutroImposto = outroImposto;
        }

        public Imposto()
        {
            OutroImposto = null;
        }

        public decimal CalcularOutroImposto(Orcamento orcamento)
        {
            if (OutroImposto is null) return 0;
            return OutroImposto.Calcular(orcamento);
        }

        public abstract decimal Calcular(Orcamento orcamento);
    }
}
