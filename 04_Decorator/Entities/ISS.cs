using _04_Decorator.Entities.Abstracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace _04_Decorator.Entities
{
    public class ISS : Imposto
    {
        public ISS(Imposto outroImposto) : base(outroImposto) { }
        public ISS() : base() { }

        public override decimal Calcular(Orcamento orcamento)
        {
            return orcamento.Valor * 0.06M + CalcularOutroImposto(orcamento);
        }
    }
}
