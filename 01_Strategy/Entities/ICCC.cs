using _01_Strategy.Interfaces;

namespace _01_Strategy.Entities
{
    public class ICCC : IImposto
    {
        public decimal Calcular(Orcamento orcamento)
        {
            if (orcamento.Valor < 1000M)
            {
                return orcamento.Valor * 0.05M;
            }
            if (orcamento.Valor >= 1000M && orcamento.Valor <= 3000M)
            {
                return orcamento.Valor * 0.07M;
            }
            return orcamento.Valor * 0.08M + 30M;
        }
    }
}
