using _01_Strategy.Interfaces;

namespace _01_Strategy.Entities
{
    public class ISS : IImposto
    {
        public decimal Calcular(Orcamento orcamento)
        {
            return orcamento.Valor * 0.06M;
        }
    }
}
