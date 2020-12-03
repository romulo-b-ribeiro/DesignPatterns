using _01_Strategy.Interfaces;
using System;

namespace _01_Strategy.Entities
{
    class ICMS : IImposto
    {
        public decimal Calcular(Orcamento orcamento)
        {
            return orcamento.Valor * 0.06M;
        }
    }
}
