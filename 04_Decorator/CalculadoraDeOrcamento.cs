using _04_Decorator.Entities;
using _04_Decorator.Entities.Abstracts;
using System;

namespace _04_Decorator
{
    public class CalculadorDeImposto
    {
        public void Executar()
        {
            var impostos = new ISS(new ICMS(new ImpostoMuitoAlto()));
            var orcamento = new Orcamento(500);

            CalcularImpostos(orcamento, impostos);
        }

        private void CalcularImpostos(Orcamento orcamento, Imposto imposto)
        {
            Console.WriteLine(imposto.Calcular(orcamento));
        }
    }
}
