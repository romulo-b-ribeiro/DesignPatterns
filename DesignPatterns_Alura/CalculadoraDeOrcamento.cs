using _01_Strategy.Entities;
using _01_Strategy.Interfaces;
using System;

namespace _01_Strategy
{
    public class CalculadorDeImposto
    {
        public CalculadorDeImposto(Orcamento orcamento, IImposto imposto)
        {
            Console.WriteLine(imposto.Calcular(orcamento));
        }
    }
}
